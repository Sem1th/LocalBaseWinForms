using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase
{
    public partial class Form2 : Form //форма создания нового сотрудника
    {

        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\SOBASH\SOURCE\REPOS\DATABASESQL\DATABASE\NAUKADEPT.MDF;Integrated Security=True;Connect Timeout=30");


        public Form2()
        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "naukaDeptDataSet.list". При необходимости она может быть перемещена или удалена.
           // this.listTableAdapter.Fill(this.naukaDeptDataSet.list);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBoxSurname.Text == "") // поверка на пустоту поля 'фамилия'
            {
                MessageBox.Show(
                "Поле 'Фамилия' не может быть пустым!",
                "Ввод значения",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
            }
            else
            {
                Form1 main = Owner as Form1;
                if (main != null)
                {

                    sc.Open();

                    // задаем текстбоксам принимаемые ими значения
                    string Name = textBoxName.Text;
                    string Surname = textBoxSurname.Text;
                    string Patronomic = textBoxPatronymic.Text;
                    string Date = dateTimePicker1.Text;
                    string Adress = textBoxAdress.Text;
                    string Dept = comboBox1.Text;
                    string About = textBoxAbout.Text;

                    //выполняем sql запрос на добавление новой записи

                    string query = $"insert into [list](Name, Surname, Patronomic, Date, Adress, Dept, About) Values(N'{Name}',N'{Surname}',N'{Patronomic}',N'{Date}',N'{Adress}',N'{Dept}',N'{About}');";

                     SqlCommand rg = new SqlCommand(query, sc);
                     rg.Parameters.Add(new SqlParameter("@Name", Name));
                     rg.Parameters.Add(new SqlParameter("@Surname", Surname));
                     rg.Parameters.Add(new SqlParameter("@Patronomic", Patronomic));
                     rg.Parameters.Add(new SqlParameter("@Date", Date));
                     rg.Parameters.Add(new SqlParameter("@Adress", Adress));
                     rg.Parameters.Add(new SqlParameter("@Dept", Dept));
                     rg.Parameters.Add(new SqlParameter("@About", About)); 


                    rg.ExecuteNonQuery();
                   
                    sc.Close();


                    MessageBox.Show("Данные внесены успешно!");


                    //очистка полей после внесения данных

                    textBoxName.Clear(); 
                    textBoxSurname.Clear();
                    textBoxPatronymic.Clear();
                    dateTimePicker1.ResetText(); // сброс даты
                    textBoxAdress.Clear();
                    textBoxAbout.Clear();
                    comboBox1.SelectedIndex = -1; // сбрасы индекса выборки 'отдела'

                }
                main.DisplayData(); // делаем обновление данных
            }
    }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         // comboBox1.Items.AddRange(new string[] { "Охрана", "Отдел кадров", "Отдел разработки", "Руководство", "Отдел эксплуатации" });
        }

        
    }
}
