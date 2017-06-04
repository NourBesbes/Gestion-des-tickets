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
    public partial class Supprimer : Form
    {
        public Supprimer()
        {
            InitializeComponent();
        }
        public SqlConnection Get_Connection()
        {
            String conn_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyProject;Integrated Security=True";
            return new SqlConnection(conn_string);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Get_Connection())
            {
                conn.Open();
                String req ="DELETE FROM employes WHERE login='" + textBox6.Text + "'";


                using (SqlCommand cmd = new SqlCommand(req, conn))
                {
                    cmd.ExecuteNonQuery();

                }


            }

        }
    }
}
