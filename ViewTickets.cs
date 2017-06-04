using MyProjectV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectV2
{
    public partial class ViewTickets : Form
    {
        
        
        public SqlConnection Get_Connection()
        {
            String conn_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyProjectBD;Integrated Security=True";
            return new SqlConnection(conn_string);
        }
       
          
           
            
      
        public ViewTickets()
        {
            InitializeComponent();
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             DataTable set = new DataTable();
            using (SqlConnection con = Get_Connection())
            {  
                if (Recherche.Text == "Responsable")
            { 
                con.Open();
                String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.date_fin,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable,T.reponse from tickets T , employes E where T.responsable like '" + textBox1.Text + "%' ";

                using (SqlCommand cmd = new SqlCommand(req, con))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(set);

                }
            }
                if (Recherche.Text == "Entreprise")
                {
                    con.Open();
                    String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.date_fin,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable,T.reponse from tickets T , contrats C where C.nom like '" + textBox1.Text + "%' AND C.raison_Sociale = T.raison_Sociale";

                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(set);

                    }
                }
                if (Recherche.Text == "Type d'intervention")
                {
                    con.Open();
                    String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.date_fin,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable,T.reponse from tickets T  where T.type_Intervention like '" + textBox1.Text + "%' ";

                    using (SqlCommand cmd = new SqlCommand(req, con))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(set);

                    }
                }

            cboFilter.DataSource = set; 
            
            }


        }

        private void Intervention_Click(object sender, EventArgs e)
        {

        }

        private void ViewTickets_Load(object sender, EventArgs e)
        {
            DataTable set = new DataTable();
            using (SqlConnection con = Get_Connection())
            {
                con.Open();
                String req = "Select T.tick_Id,T.contrat_Id as Reference_Contrat,T.delai,T.date_deb,T.date_fin,T.nom,T.prenom,T.reclamation,T.tel,T.fax,T.type_Intervention,T.responsable,T.reponse from tickets T";
                using (SqlCommand cmd = new SqlCommand(req, con))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(set);

                }
            }
            cboFilter.DataSource = set; 
        }

        private void Recherche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

       

        
        }
        }

     
    
