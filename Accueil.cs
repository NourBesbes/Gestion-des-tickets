using EAGetMail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectV2
{
    public partial class Accueil : Form
    {
        public Accueil(string nom, string prenom)
        {
            InitializeComponent();
            tileItem3.Text = "Bonjour \n" + prenom + " " + nom;
        }

        public SqlConnection Get_Connection()
        {
            String conn_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MyProjectBD;Integrated Security=True";
            return new SqlConnection(conn_string);
        }
        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Modifier a = new Modifier();


            a.Show();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ViewTickets viewTickets = new ViewTickets();
            viewTickets.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Contrat contrat = new Contrat();
            contrat.Show();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            TicketOuvert tik = new TicketOuvert();
            tik.Show();
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            TicketFerme tiket = new TicketFerme();
            tiket.Show();
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Statistique s = new Statistique();
            s.Show();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MailServer oServer = new MailServer("pop.gmail.com", "nourbesbes11@gmail.com", "nourbess", true, ServerAuthType.AuthLogin, ServerProtocol.Pop3);
            MailClient oClient = new MailClient("TryIt");

            oClient.Connect(oServer);
            MailInfo[] infos = oClient.GetMailInfos();
            for (int i = 0; i < infos.Length; i++)
            {
                MailInfo info = infos[i];                    // Receive email from POP3 server
                Mail oMail = oClient.GetMail(info);

                String[] substrings = oMail.TextBody.Split('\n');

                String[] substrings2 = substrings[0].Split(':');
                String[] substrings3 = substrings[1].Split(':');
                String[] substrings4 = substrings[2].Split(':');
                String[] substrings5 = substrings[3].Split(':');
                String[] substrings6 = substrings[4].Split(':');

                //FAX
                String[] substrings7 = substrings[5].Split(':');

                //Responsable
                String[] substrings8 = substrings[6].Split(':');
                //  Console.WriteLine(substrings8[substrings8.Length - 1]);
                String[] X = substrings8[substrings8.Length - 1].Split(' ');
                Debug.WriteLine(X[0]);
                //Type d'intervention
                String[] substrings9 = substrings[7].Split(':');

                //delai
                String[] substrings10 = substrings[8].Split(':');

                //mail
                String[] substrings11 = substrings[9].Split(':');

                //Reclamation
                String[] substrings12 = substrings[10].Split(':');


                using (SqlConnection conn = Get_Connection())
                {
                    conn.Open();
                    String req = "INSERT INTO tickets(nom, prenom,raison_Sociale,contrat_Id,tel,type_Intervention,delai,mail,reclamation,date_deb) VALUES ('" + substrings2[substrings2.Length - 1] + "','" + substrings3[substrings3.Length - 1] + "','" + substrings4[substrings4.Length - 1] + "','" + substrings5[substrings5.Length - 1] + "','" + substrings6[substrings6.Length - 1] + "','" + substrings9[substrings9.Length - 1] + "','" + substrings10[substrings10.Length - 1] + "','" + substrings11[substrings11.Length - 1] + "','" + substrings12[substrings12.Length - 1] + "','" + oMail.SentDate + "')";
                    using (SqlCommand cmd = new SqlCommand(req, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailServer oServer = new MailServer("pop.gnet.tn", "hotline@infratech.com.tn", "H1o5T9l7I5n3E", ServerProtocol.Pop3);
            MailClient oClient = new MailClient("TryIt");

            oClient.Connect(oServer);
            MailInfo[] infos = oClient.GetMailInfos();

            for (int i = 0; i < infos.Length; i++)

            {
                MailInfo info = infos[i];                    // Receive email from POP3 server
                Mail oMail = oClient.GetMail(info);
                String[] substring1 = oMail.Subject.Split(' ');
                string Object1 = substring1[0] + " " + substring1[1] + " " + substring1[2];
                if (Object1.Equals("Ticket de support"))
                {

                    String[] substrings = oMail.HtmlBody.Split('<');
                    String[] substrings2 = substrings[0].Split(':');
                    String[] substrings3 = substrings[1].Split(':');
                    String[] substrings4 = substrings[2].Split(':');
                    String[] substrings5 = substrings[3].Split(':');
                    String[] substrings6 = substrings[4].Split(':');

                    //FAX
                    String[] substrings7 = substrings[5].Split(':');

                    //Responsable
                    String[] substrings8 = substrings[6].Split(':');

                    //Type d'intervention
                    String[] substrings9 = substrings[7].Split(':');

                    //delai
                    String[] substrings10 = substrings[8].Split(':');

                    //mail
                    String[] substrings11 = substrings[9].Split(':');

                    //Reclamation
                    String substrings12 = substrings[15];


                    using (SqlConnection conn = Get_Connection())
                    {
                        conn.Open();
                        String req1 = "Select * from tickets where nom='" + substrings2[substrings2.Length - 1] + "' AND prenom='" + substrings3[substrings3.Length - 1] + "'AND raison_Sociale='" + substrings4[substrings4.Length - 1] + "' AND contrat_Id='" + substrings5[substrings5.Length - 1] + "' AND tel='" + substrings6[substrings6.Length - 1] + "'AND type_Intervention='" + substrings9[substrings9.Length - 1] + "'AND delai='" + substrings10[substrings10.Length - 1] + "' AND mail='" + substrings11[substrings11.Length - 1] + "'AND reclamation='" + substrings[15] + "' AND fax='" + substrings7[substrings7.Length - 1] + "'AND responsable='" + substrings8[substrings8.Length - 1] + "'";
                        String req = "INSERT INTO tickets(nom, prenom,raison_Sociale,contrat_Id,tel,type_Intervention,delai,mail,reclamation,date_deb,fax,responsable) VALUES ('" + substrings2[substrings2.Length - 1] + "','" + substrings3[substrings3.Length - 1] + "','" + substrings4[substrings4.Length - 1] + "','" + substrings5[substrings5.Length - 1] + "','" + substrings6[substrings6.Length - 1] + "','" + substrings9[substrings9.Length - 1] + "','" + substrings10[substrings10.Length - 1] + "','" + substrings11[substrings11.Length - 1] + "','" + substrings[15] + "','" + oMail.SentDate + "','" + substrings7[substrings7.Length - 1] + "','" + substrings8[substrings8.Length - 1] + "')";

                        using (SqlCommand cmd2 = new SqlCommand(req1, conn))
                        {
                            using (SqlDataReader reader = cmd2.ExecuteReader())
                            {

                                if (reader.HasRows)
                                {
                                    reader.Close();
                                  
                                }
                                else
                                {
                                    reader.Close();
                                    using (SqlCommand cmd = new SqlCommand(req, conn))
                                    {
                                        cmd.ExecuteNonQuery();

                                    }
                                }

                            }
                        }

                    }
                }

            }
            //      oClient.Delete(info);

        }
        // Quit and pure emails marked as deleted from POP3 server.
        //oClient.Quit();
    }

}
   
//}


         
        

    

    