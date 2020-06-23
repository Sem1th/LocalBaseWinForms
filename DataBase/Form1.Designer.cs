namespace DataBase
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronomicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRed = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.naukaDeptDataSet2 = new DataBase.NaukaDeptDataSet2();
            this.buttonAddMain = new System.Windows.Forms.Button();
            this.listTableAdapter2 = new DataBase.NaukaDeptDataSet2TableAdapters.listTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.помошьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функционалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1SaveChanges = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7About = new System.Windows.Forms.TextBox();
            this.textBox6Adress = new System.Windows.Forms.TextBox();
            this.textBox3Patronomic = new System.Windows.Forms.TextBox();
            this.textBox2Surname = new System.Windows.Forms.TextBox();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naukaDeptDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronomicDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.deptDataGridViewTextBoxColumn,
            this.aboutDataGridViewTextBoxColumn,
            this.buttonRed,
            this.buttonDel});
            this.dataGridView1.DataSource = this.listBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(10, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(904, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // patronomicDataGridViewTextBoxColumn
            // 
            this.patronomicDataGridViewTextBoxColumn.DataPropertyName = "Patronomic";
            this.patronomicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronomicDataGridViewTextBoxColumn.Name = "patronomicDataGridViewTextBoxColumn";
            this.patronomicDataGridViewTextBoxColumn.ReadOnly = true;
            this.patronomicDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес проживания";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "Dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            this.deptDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // aboutDataGridViewTextBoxColumn
            // 
            this.aboutDataGridViewTextBoxColumn.DataPropertyName = "About";
            this.aboutDataGridViewTextBoxColumn.HeaderText = "О себе";
            this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
            this.aboutDataGridViewTextBoxColumn.ReadOnly = true;
            this.aboutDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonRed
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.buttonRed.DefaultCellStyle = dataGridViewCellStyle17;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.HeaderText = "";
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.ReadOnly = true;
            this.buttonRed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.buttonRed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.buttonRed.Text = "Редактировать";
            this.buttonRed.UseColumnTextForButtonValue = true;
            this.buttonRed.Width = 92;
            // 
            // buttonDel
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.buttonDel.DefaultCellStyle = dataGridViewCellStyle18;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.HeaderText = "";
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.ReadOnly = true;
            this.buttonDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.buttonDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseColumnTextForButtonValue = true;
            this.buttonDel.Width = 92;
            // 
            // listBindingSource2
            // 
            this.listBindingSource2.DataMember = "list";
            this.listBindingSource2.DataSource = this.naukaDeptDataSet2;
            // 
            // naukaDeptDataSet2
            // 
            this.naukaDeptDataSet2.DataSetName = "NaukaDeptDataSet2";
            this.naukaDeptDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddMain
            // 
            this.buttonAddMain.BackColor = System.Drawing.Color.Green;
            this.buttonAddMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMain.ForeColor = System.Drawing.Color.Snow;
            this.buttonAddMain.Location = new System.Drawing.Point(589, 9);
            this.buttonAddMain.Name = "buttonAddMain";
            this.buttonAddMain.Size = new System.Drawing.Size(153, 23);
            this.buttonAddMain.TabIndex = 2;
            this.buttonAddMain.Text = "Добавить новую запись";
            this.buttonAddMain.UseVisualStyleBackColor = false;
            this.buttonAddMain.Click += new System.EventHandler(this.buttonAddMain_Click);
            // 
            // listTableAdapter2
            // 
            this.listTableAdapter2.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помошьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(929, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // помошьToolStripMenuItem
            // 
            this.помошьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функционалToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1});
            this.помошьToolStripMenuItem.Name = "помошьToolStripMenuItem";
            this.помошьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помошьToolStripMenuItem.Text = "Помощь";
            // 
            // функционалToolStripMenuItem
            // 
            this.функционалToolStripMenuItem.Name = "функционалToolStripMenuItem";
            this.функционалToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.функционалToolStripMenuItem.Text = "Функционал";
            this.функционалToolStripMenuItem.Click += new System.EventHandler(this.функционалToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(766, 12);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(142, 20);
            this.textBoxFind.TabIndex = 9;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1SaveChanges);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox7About);
            this.groupBox1.Controls.Add(this.textBox6Adress);
            this.groupBox1.Controls.Add(this.textBox3Patronomic);
            this.groupBox1.Controls.Add(this.textBox2Surname);
            this.groupBox1.Controls.Add(this.textBox1Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 228);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование данных ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(589, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Охрана",
            "Отдел кадров",
            "Отдел разработки",
            "Руководство",
            "Отдел эксплуатации"});
            this.comboBox1.Location = new System.Drawing.Point(780, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // button1SaveChanges
            // 
            this.button1SaveChanges.BackColor = System.Drawing.Color.Green;
            this.button1SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1SaveChanges.ForeColor = System.Drawing.Color.White;
            this.button1SaveChanges.Location = new System.Drawing.Point(706, 172);
            this.button1SaveChanges.Name = "button1SaveChanges";
            this.button1SaveChanges.Size = new System.Drawing.Size(141, 23);
            this.button1SaveChanges.TabIndex = 14;
            this.button1SaveChanges.Text = "Сохранить изменения";
            this.button1SaveChanges.UseVisualStyleBackColor = false;
            this.button1SaveChanges.Click += new System.EventHandler(this.button1button1SaveChanges_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "О себе";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Адрес проживания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Отдел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата рождения";
            // 
            // textBox7About
            // 
            this.textBox7About.Location = new System.Drawing.Point(155, 106);
            this.textBox7About.Multiline = true;
            this.textBox7About.Name = "textBox7About";
            this.textBox7About.Size = new System.Drawing.Size(417, 55);
            this.textBox7About.TabIndex = 7;
            // 
            // textBox6Adress
            // 
            this.textBox6Adress.Location = new System.Drawing.Point(155, 61);
            this.textBox6Adress.Name = "textBox6Adress";
            this.textBox6Adress.Size = new System.Drawing.Size(417, 20);
            this.textBox6Adress.TabIndex = 6;
            // 
            // textBox3Patronomic
            // 
            this.textBox3Patronomic.Location = new System.Drawing.Point(391, 22);
            this.textBox3Patronomic.Name = "textBox3Patronomic";
            this.textBox3Patronomic.Size = new System.Drawing.Size(100, 20);
            this.textBox3Patronomic.TabIndex = 3;
            // 
            // textBox2Surname
            // 
            this.textBox2Surname.Location = new System.Drawing.Point(225, 23);
            this.textBox2Surname.Name = "textBox2Surname";
            this.textBox2Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox2Surname.TabIndex = 2;
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(57, 22);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(100, 20);
            this.textBox1Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(712, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 35);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(802, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 35);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonAddMain);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naukaDeptDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public NaukaDeptDataSet2 naukaDeptDataSet2;
        public System.Windows.Forms.BindingSource listBindingSource2;
        public NaukaDeptDataSet2TableAdapters.listTableAdapter listTableAdapter2;
        private System.Windows.Forms.Button buttonAddMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem помошьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функционалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1SaveChanges;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7About;
        private System.Windows.Forms.TextBox textBox6Adress;
        private System.Windows.Forms.TextBox textBox3Patronomic;
        private System.Windows.Forms.TextBox textBox2Surname;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronomicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn buttonRed;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

