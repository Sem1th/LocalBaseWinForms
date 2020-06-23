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
        

        SqlCommand cmd;
        SqlDataAdapter adapt;

        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\SOBASH\SOURCE\REPOS\DATABASESQL\DATABASE\NAUKADEPT.MDF;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
            
        }



        public void Form1_Load(object sender, EventArgs e)
        {
            DisplayData(); 



        }

        //Display Data in DataGridView  
        public void DisplayData() //обновление таблицы данных list
        {
              DataTable dt = new DataTable();
              adapt = new SqlDataAdapter("select * from list", sc);
              adapt.Fill(dt);
              dataGridView1.DataSource = dt;
              sc.Close(); 
        }





        public void buttonAddMain_Click(object sender, EventArgs e) //добавление новой учетной записи, открытие формы2
        {
           Form2 af = new Form2();
           af.Owner = this;
           af.ShowDialog();

           

        }




        private void функционалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 tt = new Form4();
            tt.ShowDialog();

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 ff = new Form5();
            ff.ShowDialog();
        }

        public void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            ReloadData(); // фильтрация поиска по datadrid
        }

        private void ReloadData() // фильтрация поиска по datadrid, ищет значения по фамилии
        {

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;

            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((dataGridView1[1, i].Value.ToString().ToLower().IndexOf(textBoxFind.Text.ToLower()) != -1))
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }



        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7) //редактирование, загрузка информации о пользователе в текстбоксты на основной форме
            {
                DialogResult dialogResult = MessageBox.Show(
                                                       "Вы уверены что хотите изменить иформацию об этом пользователе?",
                                                       "Изменение",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question,
                                                       MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {


                    string name1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string surname1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string patronomic1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string date1 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string adress1 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    string dept1 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    string about1 = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                    sc.Open();

                    string SQLq = $"Select Name, Surname, Patronomic, Date, Adress, Dept, About from list where Name = N'{name1}' and Surname = N'{surname1}' and Patronomic = N'{patronomic1}' and Date = N'{date1}' and Adress = N'{adress1}' and Dept = N'{dept1}' and About = N'{about1}' ";

                     SqlCommand Comm1 = new SqlCommand(SQLq, sc);
                     SqlDataReader reader = Comm1.ExecuteReader();
                      if(reader.Read())
                     {
                       textBox1Name.Text = (string)reader.GetValue(0);
                       textBox2Surname.Text = (string)reader.GetValue(1);
                       textBox3Patronomic.Text = (string)reader.GetValue(2);
                       dateTimePicker1.Text = (string)reader.GetValue(3);
                       textBox6Adress.Text = (string)reader.GetValue(4);
                       comboBox1.Text = (string)reader.GetValue(5);
                       textBox7About.Text = (string)reader.GetValue(6);
                    }
                     reader.Close();
                     sc.Close();  
                }




            }
            if (e.ColumnIndex == 8) //delete
            {
                DialogResult dialogResult = MessageBox.Show(
                                                        "Вы уверены что хотите удалить данные об этом пользователе?",
                                                        "Удаление",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button1);
              if (dialogResult == DialogResult.Yes)
                {
                    string Surname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); // получаем значение из dataDrida и работаем с ним 

                    sc.Open(); //открывает соединение с бд

                    string sql = "DELETE FROM list WHERE Surname = @Surname"; //параметризованный запрос, удаляем пользователя с заданной фамилией

                    cmd = new SqlCommand(sql, sc); //создаем команду 
                    cmd.Parameters.AddWithValue("@Surname", Surname); //создаем параметр и добавляем его в коллекцию
                    cmd.ExecuteNonQuery(); //выполняем sql запрос
                    sc.Close(); //закрываем содединение с бд
                    MessageBox.Show("Запись успешно удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    DisplayData();
                    
                }
            }
        }

        public void button1button1SaveChanges_Click(object sender, EventArgs e) // сохранение изменений после редактировния полей о сотруднике
        {
            string Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Surname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string patronomic1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string date1 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string adress1 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string dept1 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string about1 = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            string name = textBox1Name.Text;
            string surname = textBox2Surname.Text;
            string patronomic = textBox3Patronomic.Text;
            string date = dateTimePicker1.Text;
            string adress = textBox6Adress.Text;
            string dept = comboBox1.Text;
            string about = textBox7About.Text;


            
            string sqlExpression = $"UPDATE list SET Name = N'{name}' , Surname = N'{surname}' , Patronomic = N'{patronomic}', Date = N'{date}' , Adress = N'{adress}' , Dept = N'{dept}' , About = N'{about}'  WHERE  Name = N'{Name}' and Surname = N'{Surname}' and Patronomic = N'{patronomic1}' and Date = N'{date1}' and Adress = N'{adress1}' and Dept = N'{dept1}' and About = N'{about1}'  ";
            {
                sc.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sc);

            

               command.Parameters.AddWithValue("@Name", name);
               command.Parameters.AddWithValue("@Surname", surname);
               command.Parameters.AddWithValue("@Patronomic", patronomic);
               command.Parameters.AddWithValue("@Date", date);
               command.Parameters.AddWithValue("@Adress", adress);
               command.Parameters.AddWithValue("@Dept", dept);
               command.Parameters.AddWithValue("@About", about);
               command.ExecuteNonQuery();
               
            }

            sc.Close();

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

    }
}


