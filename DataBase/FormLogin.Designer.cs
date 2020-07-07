namespace DataBase
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1User = new System.Windows.Forms.TextBox();
            this.textBox2Pass = new System.Windows.Forms.TextBox();
            this.button1ClsLogin = new System.Windows.Forms.Button();
            this.button1ChkLogin = new System.Windows.Forms.Button();
            this.label3Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // textBox1User
            // 
            this.textBox1User.Location = new System.Drawing.Point(116, 32);
            this.textBox1User.Name = "textBox1User";
            this.textBox1User.Size = new System.Drawing.Size(166, 20);
            this.textBox1User.TabIndex = 2;
            // 
            // textBox2Pass
            // 
            this.textBox2Pass.Location = new System.Drawing.Point(116, 69);
            this.textBox2Pass.Name = "textBox2Pass";
            this.textBox2Pass.PasswordChar = '*';
            this.textBox2Pass.Size = new System.Drawing.Size(166, 20);
            this.textBox2Pass.TabIndex = 3;
            // 
            // button1ClsLogin
            // 
            this.button1ClsLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1ClsLogin.FlatAppearance.BorderSize = 0;
            this.button1ClsLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1ClsLogin.ForeColor = System.Drawing.Color.White;
            this.button1ClsLogin.Location = new System.Drawing.Point(264, 105);
            this.button1ClsLogin.Name = "button1ClsLogin";
            this.button1ClsLogin.Size = new System.Drawing.Size(75, 23);
            this.button1ClsLogin.TabIndex = 5;
            this.button1ClsLogin.Text = "Закрыть";
            this.button1ClsLogin.UseVisualStyleBackColor = false;
            this.button1ClsLogin.Click += new System.EventHandler(this.button1ClsLogin_Click);
            // 
            // button1ChkLogin
            // 
            this.button1ChkLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1ChkLogin.FlatAppearance.BorderSize = 0;
            this.button1ChkLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1ChkLogin.ForeColor = System.Drawing.Color.White;
            this.button1ChkLogin.Location = new System.Drawing.Point(33, 105);
            this.button1ChkLogin.Name = "button1ChkLogin";
            this.button1ChkLogin.Size = new System.Drawing.Size(75, 23);
            this.button1ChkLogin.TabIndex = 8;
            this.button1ChkLogin.Text = "Войти";
            this.button1ChkLogin.UseVisualStyleBackColor = false;
            this.button1ChkLogin.Click += new System.EventHandler(this.button1ChkLogin_Click);
            // 
            // label3Error
            // 
            this.label3Error.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3Error.ForeColor = System.Drawing.Color.White;
            this.label3Error.Location = new System.Drawing.Point(-7, 9);
            this.label3Error.Name = "label3Error";
            this.label3Error.Size = new System.Drawing.Size(387, 20);
            this.label3Error.TabIndex = 9;
            this.label3Error.Text = "Неверный логин или пароль!";
            this.label3Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3Error.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 140);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3Error);
            this.Controls.Add(this.textBox2Pass);
            this.Controls.Add(this.button1ChkLogin);
            this.Controls.Add(this.button1ClsLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1User;
        private System.Windows.Forms.TextBox textBox2Pass;
        private System.Windows.Forms.Button button1ClsLogin;
        private System.Windows.Forms.Button button1ChkLogin;
        private System.Windows.Forms.Label label3Error;
    }
}