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

namespace prepare
{
    public partial class uchastnik : Form
    {
        public uchastnik()
        {
            InitializeComponent();
        }

        private void avtorizacia_Click(object sender, EventArgs e)
        {
            if (log.Text != " " && pas.Text != " ")
            {
                string connect = "Data Source=stud-mssql.sttec.yar.ru,38325;Initial Catalog=user127_db;Persist Security Info=True;User ID=user127_db;Password=user127";
                SqlConnection sqlcon = new SqlConnection(connect);
                string command = "SELECT * FROM Auser1 where login='" + log.Text + "' and pass='" + pas.Text + "'";
                SqlCommand sqlcom = new SqlCommand(command, sqlcon);
                sqlcon.Open();
                SqlDataReader sqldr = sqlcom.ExecuteReader();
                string login = " ";
                string pass = " ";
                string role = " ";
                while (sqldr.Read())
                {
                    login= sqldr.GetString(1);
                    pass = sqldr.GetString(2);
                    role = sqldr.GetString(3);
                }
                sqlcon.Close();
                if (role == "0")
                {
                    MessageBox.Show("uchastnik");
                    avtorizacia avt = new avtorizacia();
                    avt.Show();
                    this.Hide();
                }
               else if (role == "1")
                {
                    MessageBox.Show("organizator");
                    organizator org = new organizator();
                    org.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("невыерный пароль");
                }
            }
            else
            {
                MessageBox.Show("zapolnite vse polya");
            }         
        }

        private void registrcia_Click(object sender, EventArgs e)
        {
          try
          {
               if (regrepass.Text != regpass.Text)
               {
                    MessageBox.Show("пароли должны совпадать");
               }
               else if ( (regpass.Text==string.Empty)|| (reglogin.Text==string.Empty)|| (regrepass.Text==string.Empty)) 
               {
                    MessageBox.Show("заполните все поля");
               }
               else if (!(reglogin.Text.Any(Char.IsLetter)))
               {
                    MessageBox.Show(" пароль должен содержать хотя бы одну букву");
               }
               else
               {
                    string connect = "Data Source=stud-mssql.sttec.yar.ru,38325;Initial Catalog=user127_db;Persist Security Info=True;User ID=user127_db;Password=user127";
                    SqlConnection sqlcon = new SqlConnection(connect);
                    string command = "INSERT INTO Auser1 values('" + reglogin.Text + "', '" + regpass.Text + "', '0')";
                    SqlCommand sqlcom = new SqlCommand(command, sqlcon);
                    sqlcon.Open();
                    sqlcom.ExecuteNonQuery();
                    MessageBox.Show("вы зарегестрировались");
               }            
          }
           catch
          {
                MessageBox.Show("no work");
          }

        }
    }
}
