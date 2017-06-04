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
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
           // label1.Text = id.ToString();
        }

        private void Mod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMPLOYE.employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.eMPLOYE.employes);
            // TODO: This line of code loads data into the 'myProjectDBDataSet5.employes' table. You can move, or remove it, as needed.
            // this.employesTableAdapter1.Fill(this.myProjectDBDataSet5.employes);
            // TODO: This line of code loads data into the 'myProjectDBDataSet1.employes' table. You can move, or remove it, as needed.
            // this.employesTableAdapter.Fill(this.myProjectDBDataSet1.employes);

        }

        private void dataLayoutControl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public SqlConnection Get_Connection()
        {
            String conn_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyProjectBD;Integrated Security=True";
            return new SqlConnection(conn_string);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Get_Connection())
            {
                conn.Open();
                String req = "UPDATE employes SET password='" + passwordTextEdit.Text + "',nom='" + nomTextEdit.Text + "',prenom='" + prenomTextEdit.Text + "',mail='" + mailTextEdit.Text + "',tel='" + telTextEdit.Text + "',login ='" + loginTextEdit.Text +"' Where empl_Id='" + empl_IdTextEdit.Text +"'" ; 


                using (SqlCommand cmd = new SqlCommand(req, conn))
                {
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("La mise à jour a été effectuée avec succés", "Modifier", MessageBoxButtons.OKCancel);
        }

        private void editFormUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
