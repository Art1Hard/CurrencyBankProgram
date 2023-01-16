using System.Collections.Generic;
using System.Configuration;

namespace CurrencyBank.Logic
{
    internal class DataBase
    {
        // строка sql-запрос
        public string Query { get; set; }

        // строка подключения
        public static string ConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
    }
}