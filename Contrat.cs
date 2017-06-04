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
    public partial class Contrat : Form
    {
        public Contrat()
        {
            InitializeComponent();
        }

        private void Contrat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contrats.contrats' table. You can move, or remove it, as needed.
         //   this.contratsTableAdapter.Fill(this.contrats.contrats);
            // TODO: This line of code loads data into the 'myProjectDBDataSet.contrats' table. You can move, or remove it, as needed.
            // this.contratsTableAdapter.Fill(this.myProjectDBDataSet.contrats);
            DataTable set = new DataTable();
            using (SqlConnection con = Get_Connection())
            {
                con.Open();
                String req = "Select * from contrats";
                using (SqlCommand cmd = new SqlCommand(req, con))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(set);

                }
            }
            dataGridView1.DataSource = set;

        }
        public SqlConnection Get_Connection()
        {
            String conn_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyProjectBD;Integrated Security=True";
            return new SqlConnection(conn_string);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (raison_SocialeTextEdit.Text == string.Empty)
            {
                raison_SocialeTextEdit.Focus();
                errorProvider1.SetError(raison_SocialeTextEdit, "Ne peut pas etre vide");
            }
            if (nomTextEdit.Text == string.Empty)
            {
                nomTextEdit.Focus();
                errorProvider2.SetError(nomTextEdit, "Ne peut pas etre vide");
            }
            if (raison_SocialeTextEdit.Text != string.Empty)
            {
                errorProvider1.Clear();
            }
            if (nomTextEdit.Text != string.Empty)
            {
                errorProvider2.Clear();
            }

            if ((raison_SocialeTextEdit.Text != string.Empty) && (nomTextEdit.Text != string.Empty))
            {
                using (SqlConnection conn = Get_Connection())
                {
                    int i = dataGridView1.RowCount +2 ;
                    conn.Open();
                    
                    String req = "INSERT INTO contrats (contrat_Id,raison_Sociale, nom) VALUES ('" + contrat_IdTextEdit.Text +"','" + raison_SocialeTextEdit.Text + "','" + nomTextEdit.Text + "')";
                    String req2 = "select * from contrats where contrat_Id ='" + contrat_IdTextEdit.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(req2, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Le contrat existe deja", "Erreur", MessageBoxButtons.OKCancel);
                            }
                            else
                            {
                                reader.Close();

                                using (SqlCommand cmd2 = new SqlCommand(req, conn))
                                {
                                    cmd2.ExecuteNonQuery();

                                }


                                MessageBox.Show("Contrat ajouté avec succés", "Ajouter", MessageBoxButtons.OKCancel);
                                Contrat_Load(sender, e);
                            }
                        }
                    }
                }
            }


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contratsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}