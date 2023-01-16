namespace CurrencyBank.UI
{
    partial class Avtorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginSignTb = new System.Windows.Forms.TextBox();
            this.PasswordSignTb = new System.Windows.Forms.TextBox();
            this.SignBtn = new System.Windows.Forms.Button();
            this.titleAvtL = new System.Windows.Forms.Label();
            this.loginL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.RegL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginSignTb
            // 
            this.LoginSignTb.Location = new System.Drawing.Point(154, 66);
            this.LoginSignTb.Multiline = true;
            this.LoginSignTb.Name = "LoginSignTb";
            this.LoginSignTb.Size = new System.Drawing.Size(184, 20);
            this.LoginSignTb.TabIndex = 0;
            // 
            // PasswordSignTb
            // 
            this.PasswordSignTb.Location = new System.Drawing.Point(154, 102);
            this.PasswordSignTb.Name = "PasswordSignTb";
            this.PasswordSignTb.Size = new System.Drawing.Size(184, 20);
            this.PasswordSignTb.TabIndex = 1;
            // 
            // SignBtn
            // 
            this.SignBtn.Location = new System.Drawing.Point(12, 144);
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Size = new System.Drawing.Size(326, 28);
            this.SignBtn.TabIndex = 2;
            this.SignBtn.Text = "Войти";
            this.SignBtn.UseVisualStyleBackColor = true;
            this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // titleAvtL
            // 
            this.titleAvtL.AutoSize = true;
            this.titleAvtL.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleAvtL.Location = new System.Drawing.Point(62, 9);
            this.titleAvtL.Name = "titleAvtL";
            this.titleAvtL.Size = new System.Drawing.Size(215, 36);
            this.titleAvtL.TabIndex = 6;
            this.titleAvtL.Text = "Авторизация";
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginL.Location = new System.Drawing.Point(90, 66);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(55, 20);
            this.loginL.TabIndex = 7;
            this.loginL.Text = "Логин";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordL.Location = new System.Drawing.Point(81, 102);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(67, 20);
            this.passwordL.TabIndex = 8;
            this.passwordL.Text = "Пароль";
            // 
            // RegL
            // 
            this.RegL.AutoSize = true;
            this.RegL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegL.Location = new System.Drawing.Point(225, 175);
            this.RegL.Name = "RegL";
            this.RegL.Size = new System.Drawing.Size(113, 13);
            this.RegL.TabIndex = 9;
            this.RegL.Text = "Зарегистрироваться";
            this.RegL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegL_MouseClick);
            this.RegL.MouseLeave += new System.EventHandler(this.RegL_MouseLeave);
            this.RegL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegL_MouseMove);
            // 
            // Avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 218);
            this.Controls.Add(this.RegL);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.loginL);
            this.Controls.Add(this.titleAvtL);
            this.Controls.Add(this.SignBtn);
            this.Controls.Add(this.PasswordSignTb);
            this.Controls.Add(this.LoginSignTb);
            this.Name = "Avtorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Avtorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginSignTb;
        private System.Windows.Forms.TextBox PasswordSignTb;
        private System.Windows.Forms.Button SignBtn;
        private System.Windows.Forms.Label titleAvtL;
        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Label RegL;
    }
}

