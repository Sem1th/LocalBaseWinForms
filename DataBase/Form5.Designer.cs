namespace DataBase
{
    partial class Form5
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
            this.buttonCloseAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разработал: Собашников Семён\r\nemail: sobashnikoff.s@yandex.ru\r\n\r\nВерсия: DataBase" +
    " v1.";
            // 
            // buttonCloseAbout
            // 
            this.buttonCloseAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCloseAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseAbout.ForeColor = System.Drawing.Color.Snow;
            this.buttonCloseAbout.Location = new System.Drawing.Point(184, 104);
            this.buttonCloseAbout.Name = "buttonCloseAbout";
            this.buttonCloseAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseAbout.TabIndex = 1;
            this.buttonCloseAbout.Text = "Закрыть";
            this.buttonCloseAbout.UseVisualStyleBackColor = false;
            this.buttonCloseAbout.Click += new System.EventHandler(this.buttonCloseAboutPr_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(289, 148);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCloseAbout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCloseAbout;
    }
}