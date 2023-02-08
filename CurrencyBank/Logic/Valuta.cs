using CurrencyBank.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyBank.Logic
{
    internal class Valuta
    {
        private static string url { get; } = $"https://www.cbr-xml-daily.ru/daily_json.js";
        private static ValResponce valResponce;

        static String[] Name = new String[2];
        static String[] Course = new String[2];

        public static void Parse()
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader stream = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = stream.ReadToEnd(); // присваиваем информацию
            }
            valResponce = JsonConvert.DeserializeObject<ValResponce>(response);

            Name[0] = valResponce.Valute.EUR.Name;
            Course[0] = valResponce.Valute.EUR.Value.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            Name[1] = valResponce.Valute.USD.Name;
            Course[1] = valResponce.Valute.USD.Value.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            AddToDataBase();
        }

        public static void AddToDataBase()
        {
            DataBase dataBase = new DataBase();
            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                for (Int32 i = 0; i < Name.Length; i++)
                {
                    Int32 ID = i + 1;
                    dataBase.Query = $"UPDATE Valuta SET Name='{Name[i]}', Course={Course[i]} WHERE ID={ID}";
                    SqlCommand command = new SqlCommand(dataBase.Query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Show(DataGridView valutaDgw)
        {
            DataBase data = new DataBase();
            data.Query = "SELECT Name, Course FROM VALUTA";

            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(data.Query, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                valutaDgw.DataSource = ds.Tables[0];
            }
        }
    }
}
