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

namespace MyProjectV2
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
            textBox7.MaxLength = 8;
        }
        public SqlConnection Get_Connection()
        {
            String conn_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyProjectBD;Integrated Security=True";
            return new SqlConnection(conn_string);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == string.Empty)
            {
                textBox6.Focus();
                errorProvider1.SetError(textBox6, "Ne peut pas etre vide");
            }
            if (textBox6.Text != string.Empty)
            {
                errorProvider1.Clear();
            }
            if (textBox2.Text == string.Empty)
            {
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Ne peut pas etre vide");
            }
            if (textBox2.Text != string.Empty)
            {
                errorProvider2.Clear();
            }
            if (textBox3.Text == string.Empty)
            {
                textBox3.Focus();
                errorProvider3.SetError(textBox3, "Ne peut pas etre vide");
            }
            if (textBox3.Text != string.Empty)
            {
                errorProvider3.Clear();
            }
            if (textBox4.Text == string.Empty)
            {  
                textBox4.Focus();
                errorProvider4.SetError(textBox4, "Ne peut pas etre vide");
            }
            if ((!(textBox4.Text.Contains("@")))||(!(textBox4.Text.Contains("."))))
            {
                textBox4.Focus();
                errorProvider4.SetError(textBox4, "Email n'est pas valide");
            }
            if ((textBox4.Text != string.Empty) && (textBox4.Text.Contains("@")) && (textBox4.Text.Contains(".")))
            {
                errorProvider4.Clear();
            }
            if (textBox5.Text == string.Empty)
            {
                
                textBox5.Focus();
                errorProvider5.SetError(textBox5, "Ne peut pas etre vide");
            }
            if (textBox5.Text != string.Empty)
            {
                errorProvider5.Clear();
            }
            if (textBox7.Text == string.Empty)
            {
                textBox7.Focus();
                errorProvider6.SetError(textBox7, "Ne peut pas etre vide");
            }
            if (textBox7.Text != string.Empty)
            {
                errorProvider6.Clear();
            }

            if ((textBox7.Text != string.Empty) && (textBox2.Text != string.Empty) && (textBox3.Text != string.Empty) && (textBox4.Text != string.Empty) && (textBox5.Text != string.Empty) && (textBox6.Text != string.Empty) && (textBox4.Text.Contains("@")) && (textBox4.Text.Contains(".")))
            {

                using (SqlConnection conn = Get_Connection())
                {
                    conn.Open();
                    String req = "INSERT INTO employes (login, password,nom,prenom,mail,tel) VALUES ('" + textBox6.Text + "','" + textBox7.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    String req2 = "select * from employes where login ='" + textBox6.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(req2, conn))
                    {
                       using (SqlDataReader reader = cmd.ExecuteReader())
                       {
                           if (reader.HasRows)
                           {
                               MessageBox.Show("Le login existe deja", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                           }
                           else
                           {
                               reader.Close();
                               using (SqlCommand cmd2 = new SqlCommand(req, conn))
                               {
                                   cmd2.ExecuteNonQuery();

                               }
                               MessageBox.Show("L'inscription a été effectuée avec succés", "Inscription", MessageBoxButtons.OKCancel);
                               Accueil ss = new Accueil(textBox2.Text, textBox3.Text);
                               ss.Show();
                               this.Hide();
                           }


                           
                        }



                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
