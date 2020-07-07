using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DataBase
{
    public partial class Form1 : Form
    {
        // подключаем БД
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = staff; Integrated Security = True";




        
        public Form1()
        {
            InitializeComponent();
            
        }



        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "staffDataSet.tb_list". При необходимости она может быть перемещена или удалена.
            this.tb_listTableAdapter.Fill(this.staffDataSet.tb_list);
            DisplayData(); 



        }

        //Display Data in DataGridView  
        public void DisplayData() //обновление таблицы данных list
        {
            // подключаемся к БД
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                {

                    
                  //создаем таблицу и после делаем запрос на заполнение ее значениями из БД

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("select * from tb_list", sqlCon);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }





        public void buttonAddMain_Click(object sender, EventArgs e) //добавление новой учетной записи, открытие формы2
        {
           Form2 af = new Form2();
           af.Owner = this;
           af.ShowDialog();
        }




        public void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            ReloadData(); // фильтрация поиска по datadrid
        }

        private void ReloadData() // фильтрация поиска по datadrid, ищет значения по Фамилии
        {

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;

            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((dataGridView1[2, i].Value.ToString().ToLower().IndexOf(textBoxFind.Text.ToLower()) != -1))
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }



        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8) //редактирование, загрузка информации о пользователе в текстбоксты на основной форме
            {
                DialogResult dialogResult = MessageBox.Show(
                                                       "Вы уверены что хотите изменить иформацию об этом пользователе?",
                                                       "Изменение",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question,
                                                       MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {

                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //берем значение id (значение из dataGridView1 = значению из SQL)

                    /* string name1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                     string surname1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                     string patronomic1 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                     string date1 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                     string adress1 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                     string dept1 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                     string about1 = dataGridView1.CurrentRow.Cells[7].Value.ToString(); */


                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        {


                            string SQLq = $"Select name, surname, patronomic, date, adress, dept, about from tb_list WHERE  id = @id  ";
                            
                            SqlCommand Comm1 = new SqlCommand(SQLq, sqlCon);
                            Comm1.Parameters.AddWithValue("@id", id);
                            SqlDataReader reader = Comm1.ExecuteReader();
                            if (reader.Read())
                            {
                                  textBox1Name.Text = reader.GetValue(0).ToString();

                                  textBox1Name.Text = (reader["name"].ToString());
                                  textBox2Surname.Text = (reader["surname"].ToString());
                                  textBox3Patronomic.Text = (reader["patronomic"].ToString());

                                  dateTimePicker1.Value = Convert.ToDateTime(reader["date"]);

                               // dateTimePicker1.Value = DateTime.Parse(reader["date"].ToString()); // так тоже можно и работает


                                  textBox6Adress.Text = (reader["adress"].ToString());
                                  comboBox1.Text = (reader["dept"].ToString());
                                  textBox7About.Text = (reader["about"].ToString());



                            }
                            reader.Close();
                        }
                    }

                }
            }
            if (e.ColumnIndex == 9) //delete
            {
                DialogResult dialogResult = MessageBox.Show(
                                                        "Вы уверены что хотите удалить данные об этом пользователе?",
                                                        "Удаление",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    string surname = dataGridView1.CurrentRow.Cells[2].Value.ToString(); // получаем значение из dataDrida и работаем с ним 
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();


                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open(); //открывает соединение с бд
                        {


                            string sql = "DELETE FROM tb_list WHERE surname = @surname and id = @id"; //параметризованный запрос, удаляем пользователя с заданной фамилией



                            SqlCommand cmd = new SqlCommand(sql, sqlCon); //создаем команду 
                            cmd.Parameters.AddWithValue("@surname", surname); //создаем параметр и добавляем его в коллекцию
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery(); //выполняем sql запрос

                            MessageBox.Show("Запись успешно удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            DisplayData();
                        }
                    }
                }

            }
        }
        public void button1button1SaveChanges_Click(object sender, EventArgs e) // сохранение изменений после редактировния полей о сотруднике
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();


            /* string Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
             string Surname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
             string patronomic1 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
             string date1 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
             string adress1 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
             string dept1 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
             string about1 = dataGridView1.CurrentRow.Cells[7].Value.ToString(); */

            string name = textBox1Name.Text;
            string surname = textBox2Surname.Text;
            string patronomic = textBox3Patronomic.Text;
            string date = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyyMMdd"); //конвертируем чтоб работало с SQL 
            string adress = textBox6Adress.Text;
            string dept = comboBox1.Text;
            string about = textBox7About.Text;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                {

                    string sqlExpression = $"UPDATE tb_list SET name = N'{name}' , surname = N'{surname}' , patronomic = N'{patronomic}', date = N'{date}', adress = N'{adress}' , dept = N'{dept}' , about = N'{about}'  WHERE  id = @id  ";
                    {

                        SqlCommand command = new SqlCommand(sqlExpression, sqlCon);


                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@patronomic", patronomic);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@adress", adress);
                        command.Parameters.AddWithValue("@dept", dept);
                        command.Parameters.AddWithValue("@about", about);
                        command.ExecuteNonQuery();

                    }

                }

            }

            DisplayData(); //обновление данных

            //очистка полей после внесения данных

            textBox1Name.Clear();
            textBox2Surname.Clear();
            textBox3Patronomic.Clear();
            dateTimePicker1.ResetText();
            textBox6Adress.Clear();
            comboBox1.SelectedIndex = -1; // сбрасываем индекс выборки 'отдела'
            textBox7About.Clear();
        }

        private void button1Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


