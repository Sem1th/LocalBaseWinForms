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

        // подключаем БД
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = staff; Integrated Security = True";


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

                    // подключаемся к БД
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        {

                            // задаем текстбоксам принимаемые ими значения
                            string Name = textBoxName.Text;
                            string Surname = textBoxSurname.Text;
                            string Patronomic = textBoxPatronymic.Text;
                            string Date = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyyMMdd"); //конвертируем чтоб работало с SQL
                            string Adress = textBoxAdress.Text;
                            string Dept = comboBox1.Text;
                            string About = textBoxAbout.Text;

                            //выполняем sql запрос на добавление новой записи

                            string query = $"insert into [tb_list](name, surname, patronomic, date, adress, dept, about) Values(N'{Name}',N'{Surname}',N'{Patronomic}',N'{Date}',N'{Adress}',N'{Dept}',N'{About}');";

                            SqlCommand rg = new SqlCommand(query, sqlCon);
                            rg.Parameters.Add(new SqlParameter("@name", Name));
                            rg.Parameters.Add(new SqlParameter("@surname", Surname));
                            rg.Parameters.Add(new SqlParameter("@patronomic", Patronomic));
                            rg.Parameters.Add(new SqlParameter("@date", Date));
                            rg.Parameters.Add(new SqlParameter("@adress", Adress));
                            rg.Parameters.Add(new SqlParameter("@dept", Dept));
                            rg.Parameters.Add(new SqlParameter("@about", About));


                            rg.ExecuteNonQuery();

                        }
                    }


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
