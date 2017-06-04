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
    public partial class TicketFerme : Form
    {
        public TicketFerme()
        {
            InitializeComponent();
        }
        public SqlConnection Get_Connection()
        {
            String conn_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyProjectBD;Integrated Security=True";
            return new SqlConnection(conn_string);
        }
        private void TicketFerme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myProjectDBDataSet2.tickets' table. You can move, or remove it, as needed.
            //this.ticketsTableAdapter.Fill(this.myProjectDBDataSet2.tickets);
            DataTable set = new DataTable();
            using (SqlConnection con = Get_Connection())
            {
                con.Open();
                String req = "Select tick_Id,contrat_Id as Reference_Contrat,delai,date_deb,date_fin,nom,prenom,reclamation,tel,fax,type_Intervention,responsable,reponse from tickets where date_fin is not NULL";
                using (SqlCommand cmd = new SqlCommand(req, con))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(set);

                }
            }
            dataGridView1.DataSource = set;


        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable set = new DataTable();
            using (SqlConnection con = Get_Connection())
            {
                if (Recherche.Text == "Responsable")
                {
                    con.Open();
                    String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.date_fin,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable,T.reponse FROM tickets T where T.responsable like '" + textBox1.Text + "%' AND date_fin is not NULL";

                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(set);

                    }
                }
                if (Recherche.Text == "Entreprise")
                {
                    con.Open();
                    String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.date_fin,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable,T.reponse from tickets T , contrats C where C.nom like '" + textBox1.Text + "%' AND C.raison_Sociale = T.raison_Sociale AND date_fin is not NULL";

                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(set);

                    }
                }
                if (Recherche.Text == "Type d'intervention")
                {
                    con.Open();
                    String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.date_fin,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable,T.reponse from tickets T  where T.type_Intervention like '" + textBox1.Text + "%' AND date_fin is not NULL";

                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(set);

                    }
                }

                dataGridView1.DataSource = set;
            }
        }
    }
        }
    

