namespace CurrencyBank.UI
{
    partial class Registration
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
            this.regBtn = new System.Windows.Forms.Button();
            this.passwordRegTb = new System.Windows.Forms.TextBox();
            this.loginRegTb = new System.Windows.Forms.TextBox();
            this.titleRegL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.loginL = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(160, 132);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(143, 31);
            this.regBtn.TabIndex = 8;
            this.regBtn.Text = "Зарегистрироваться";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // passwordRegTb
            // 
            this.passwordRegTb.Location = new System.Drawing.Point(160, 94);
            this.passwordRegTb.Name = "passwordRegTb";
            this.passwordRegTb.Size = new System.Drawing.Size(143, 20);
            this.passwordRegTb.TabIndex = 7;
            // 
            // loginRegTb
            // 
            this.loginRegTb.Location = new System.Drawing.Point(160, 59);
            this.loginRegTb.Name = "loginRegTb";
            this.loginRegTb.Size = new System.Drawing.Size(143, 20);
            this.loginRegTb.TabIndex = 6;
            // 
            // titleRegL
            // 
            this.titleRegL.AutoSize = true;
            this.titleRegL.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleRegL.Location = new System.Drawing.Point(50, 9);
            this.titleRegL.Name = "titleRegL";
            this.titleRegL.Size = new System.Drawing.Size(214, 36);
            this.titleRegL.TabIndex = 9;
            this.titleRegL.Text = "Регистрация";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordL.Location = new System.Drawing.Point(85, 94);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(67, 20);
            this.passwordL.TabIndex = 11;
            this.passwordL.Text = "Пароль";
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginL.Location = new System.Drawing.Point(97, 59);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(55, 20);
            this.loginL.TabIndex = 10;
            this.loginL.Text = "Логин";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(56, 132);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(99, 31);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Назад";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 189);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.loginL);
            this.Controls.Add(this.titleRegL);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.passwordRegTb);
            this.Controls.Add(this.loginRegTb);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox passwordRegTb;
        private System.Windows.Forms.TextBox loginRegTb;
        private System.Windows.Forms.Label titleRegL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Button exitBtn;
    }
}