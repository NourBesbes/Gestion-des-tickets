using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectV2
{
    public partial class Statistique : Form
    {
        public Statistique()
        {
            InitializeComponent();
        }

        private void Statistique_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketsFerme.employeTicketsFerme' table. You can move, or remove it, as needed.
            this.employeTicketsFermeTableAdapter.Fill(this.ticketsFerme.employeTicketsFerme);
            // TODO: This line of code loads data into the 'ticketsOuverts.employeTicketOuverts' table. You can move, or remove it, as needed.
            this.employeTicketOuvertsTableAdapter.Fill(this.ticketsOuverts.employeTicketOuverts);
            // TODO: This line of code loads data into the 'myProjectBDDataSet3.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter1.Fill(this.myProjectBDDataSet3.emp);
            // TODO: This line of code loads data into the 'nbreticketpar.NombreTicketParEmploye' table. You can move, or remove it, as needed.
            this.nombreTicketParEmployeTableAdapter.Fill(this.nbreticketpar.NombreTicketParEmploye);
            // TODO: This line of code loads data into the 'myProjectBDDataSet2.EntrepriseTicket' table. You can move, or remove it, as needed.
            this.entrepriseTicketTableAdapter1.Fill(this.myProjectBDDataSet2.EntrepriseTicket);
            // TODO: This line of code loads data into the 'myProjectBDDataSet.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.myProjectBDDataSet.emp);
            // TODO: This line of code loads data into the 'myProjectDBDataSet4.employeView1' table. You can move, or remove it, as needed.
           // this.employeView1TableAdapter.Fill(this.myProjectDBDataSet4.employeView1);
           //  TODO: This line of code loads data into the 'myProjectDBDataSet3.EntrepriseTicket' table. You can move, or remove it, as needed.
           // this.entrepriseTicketTableAdapter.Fill(this.myProjectDBDataSet3.EntrepriseTicket);

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
