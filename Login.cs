using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MyProjectV2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Set to no text.
            textBox1.Text = "";
            // The password character is an asterisk.
            textBox1.PasswordChar = '*';
            // The control will allow no more than 8 characters.
            textBox1.MaxLength = 8;
           

        }
        
        public SqlConnection Get_Connection()
        {
            String conn_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyProjectBD;Integrated Security=True";
            return new SqlConnection(conn_string);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == string.Empty)
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Ne peut pas etre vide");                              
            }
            if (textBox1.Text == string.Empty)
            {
                textBox1.Focus();
                errorProvider2.SetError(textBox1, "Ne peut pas etre vide");
            }
            if (textBox1.Text != string.Empty)
            {
                errorProvider2.Clear();
            }
            if (textBox2.Text != string.Empty)
            {
                errorProvider1.Clear();
            }
            if ((textBox1.Text != string.Empty) && (textBox2.Text != string.Empty))
            {
                using (SqlConnection con = Get_Connection())
                {
                    con.Open();
                    String req = "Select nom, prenom from employes where login='" + textBox2.Text + "'and password='" + textBox1.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nom = reader.GetString(0);
                                string prenom = reader.GetString(1);
                                // int id = reader.Get;
                                Accueil ss = new Accueil(nom, prenom);

                                ss.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Login ou mot de passe incorrecte", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inscription ss = new Inscription();
            this.Hide();
            ss.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void imageEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void session1_SchemaInit(object sender, DevExpress.Xpo.SchemaInitEventArgs e)
        {

        }
    }
}
