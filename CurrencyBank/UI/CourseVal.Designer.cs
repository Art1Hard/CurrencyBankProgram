namespace CurrencyBank.UI
{
    partial class CourseVal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.valutaDgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.valutaDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // valutaDgw
            // 
            this.valutaDgw.AllowUserToAddRows = false;
            this.valutaDgw.AllowUserToDeleteRows = false;
            this.valutaDgw.AllowUserToResizeColumns = false;
            this.valutaDgw.AllowUserToResizeRows = false;
            this.valutaDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valutaDgw.Location = new System.Drawing.Point(12, 12);
            this.valutaDgw.Name = "valutaDgw";
            this.valutaDgw.Size = new System.Drawing.Size(223, 150);
            this.valutaDgw.TabIndex = 2;
            // 
            // CourseVal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valutaDgw);
            this.Name = "CourseVal";
            this.Text = "Валюта";
            this.Load += new System.EventHandler(this.CourseVal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valutaDgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView valutaDgw;
    }
}