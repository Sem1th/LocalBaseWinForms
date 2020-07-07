using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class FormLogin : Form
    {
        // подключаем БД
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = staff; Integrated Security = True";

        public FormLogin()
        {
            InitializeComponent();


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1ClsLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1ChkLogin_Click(object sender, EventArgs e)
        {
            // подключаемся к БД
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                // задаем текстбоксам принимаемые ими значения
                string User = textBox1User.Text;
                string Pass = textBox2Pass.Text;


                //выполняем sql запрос на сверку пользователя из таблицы SQL

                string queryLogin = $"SELECT userlog, pass FROM tb_login WHERE userlog = N'{User}' and pass = N'{Pass}' ";

                SqlDataAdapter sda  = new SqlDataAdapter(queryLogin, sqlCon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    Form1 nform = new Form1();
                    this.Hide();
                    nform.Show();
                    
                }
                else
                {
                    label3Error.Visible = true;
                    textBox1User.Clear();
                    textBox2Pass.Clear();
                   
                }
            }            
        }
    }
}
