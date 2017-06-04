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
    public partial class TicketOuvert : Form
    {
        public TicketOuvert()
        {
            InitializeComponent();
        }
        public SqlConnection Get_Connection()
        {
            String conn_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyProjectBD;Integrated Security=True";
            return new SqlConnection(conn_string);
        }
        private void TicketOuvet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myProjectDBOuvert.tickets' table. You can move, or remove it, as needed.
          //  this.ticketsTableAdapter1.Fill(this.myProjectDBOuvert.tickets);
            // TODO: This line of code loads data into the 'myProjectDBDataSet2.tickets' table. You can move, or remove it, as needed.
            //this.ticketsTableAdapter.Fill(this.myProjectDBDataSet2.tickets);
            DataTable set = new DataTable();
            using (SqlConnection con = Get_Connection())
            {
                con.Open();
                String req = "Select tick_Id,contrat_Id as Reference_Contrat,delai,date_deb,nom,prenom,reclamation,tel,fax,type_Intervention,responsable from tickets where date_fin is NULL";
                using (SqlCommand cmd = new SqlCommand(req, con))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(set);

                }
            }
            dataGridView1.DataSource = set;

        }

        

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Get_Connection())
            {
                conn.Open();
                String req = "UPDATE tickets SET date_fin='" + DateTime.Now + "',reponse='" + textBox2.Text + "' Where CAST (tick_Id AS CHAR(50)) ='" + textEdit1.Text + "'";


                using (SqlCommand cmd = new SqlCommand(req, conn))
                {
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("La ticket a été approuvé avec succés", "Approuver", MessageBoxButtons.OKCancel);
            TicketOuvet_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable set = new DataTable();
            using (SqlConnection con = Get_Connection())
            {
                if (Recherche.Text == "Responsable")
                {
                    con.Open();
                    String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable FROM tickets T , employes E where T.responsable like '" + textBox1.Text + "%' AND date_fin is NULL";

                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(set);

                    }
                }
                if (Recherche.Text == "Entreprise")
                {
                    con.Open();
                    String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable from tickets T , contrats C where C.nom like '" + textBox1.Text + "%' AND C.raison_Sociale = T.raison_Sociale AND date_fin is NULL";

                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(set);

                    }
                }
                if (Recherche.Text == "Type d'intervention")
                {
                    con.Open();
                    String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable from tickets T  where T.type_Intervention like '" + textBox1.Text + "%' AND date_fin is NULL";

                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(set);

                    }
                }

                dataGridView1.DataSource = set;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}