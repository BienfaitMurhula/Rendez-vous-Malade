using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO.Ports;
namespace Rendezvous

{
    class Traitements
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-08J4U82\\SA1;Initial Catalog=BDRENDEZVOUS;User ID=sa;Password=bb");
        SqlCommand cmd;



        public void insertmixtemalade(Label id, TextBox nom,TextBox postnom,TextBox prenom,ComboBox sexe,DateTimePicker datenaiss,TextBox lieu,
            ComboBox etacivil, MaskedTextBox tele, TextBox mail, TextBox nationali, TextBox adresse)
        {
            try
            {
                con.Open();
                if (String.IsNullOrEmpty(nom.Text) || String.IsNullOrEmpty(postnom.Text) || String.IsNullOrEmpty(prenom.Text) || String.IsNullOrEmpty(sexe.Text) || String.IsNullOrEmpty(datenaiss.Text) || String.IsNullOrEmpty(lieu.Text) || String.IsNullOrEmpty(etacivil.Text) || String.IsNullOrEmpty(tele.Text) || String.IsNullOrEmpty(mail.Text) || String.IsNullOrEmpty(nationali.Text) || String.IsNullOrEmpty(adresse.Text))
                {
                    MessageBox.Show("Veuillez completer tout les champs svp !!");
               }
              else
              {
                  cmd = new SqlCommand("EXEC SP_INSERTMALADE  '" + id.Text + "','" + nom.Text + "','" + postnom.Text + "','" + prenom.Text + "','" + sexe.Text + "','" + datenaiss.Text + "','" + lieu.Text + "','" + etacivil.Text + "','" + tele.Text + "','" + mail.Text + "','" + nationali.Text + "','" + adresse.Text + "'", con);
                  cmd.ExecuteNonQuery();
                  con.Close();
                  MessageBox.Show("Action effectué", "Confirmation");
                 
              }
                id.Text = "";
                nom.Text = "";
                id.Text = "";
                postnom.Text = "";
                prenom.Text = "";
                sexe.Text = "";
                datenaiss.Text = "";
                lieu.Text = "";
                etacivil.Text = "";
                tele.Text = "";
                mail.Text = "";
                nationali.Text = "";
                adresse.Text = "";
  
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message,"Erreur");
            }
            finally
            {
                con.Close();
            }
        }

        public void comboboxidmalade(ComboBox idmalade)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select IDMALADE from MALADAE",con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idmalade.Items.Add(dr["IDMALADE"].ToString());
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }


        public void comboboxidmedcin2(ComboBox idmedci)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select CODEMEDCIN from MEDCIN",con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idmedci.Items.Add(dr["CODEMEDCIN"].ToString());
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }


        public void comboboxNOM(ComboBox idmedci)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select NOM from MALADAE", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idmedci.Items.Add(dr["NOM"].ToString());
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }


        public void affichetexte(Label heure)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select SUBSTRING(format(getdate(),'HH:mm:ss'),1,5) as heure",con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    heure.Text = dr["heure"].ToString();
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }
        public void insertmixtemedcin(Label id, TextBox nom, TextBox postnom, TextBox prenom, TextBox spec, ComboBox sexe,
           TextBox tele, TextBox mail)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("EXEC  SP_MEDCIN  '" + id.Text + "','" + nom.Text + "','" + postnom.Text + "','" + prenom.Text + "','" + spec.Text + "','" + sexe.Text + "','" + tele.Text + "','" + mail.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Action effectué", "Confirmation");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }


        public void insertconsultation(Label id, TextBox typecons, DateTimePicker date, ComboBox idmalade)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("EXEC  sp_consultation  '" + id.Text + "','" + typecons.Text + "','" + date.Text + "','" + idmalade.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Action effectué", "Confirmation");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }



        public void insertrendezvous(Label id, TextBox motif, DateTimePicker date, Label heure,ComboBox codemedcin,ComboBox idmalade)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("EXEC  sp_rendezvous  '" + id.Text + "','" + motif.Text + "','" + date.Text + "','" + heure.Text + "','" + codemedcin.Text + "','" + idmalade.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Action effectué", "Confirmation");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }


        public void updatemalade(Label id, TextBox nom, TextBox postnom, TextBox prenom, ComboBox sexe, DateTimePicker datenaiss, TextBox lieu,
            TextBox etacivil, TextBox tele, TextBox mail, TextBox nationali, TextBox adresse)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("EXEC SP_INSERTMALADE '" + id.Text + "','" + nom.Text + "','" + postnom.Text + "','" + sexe.Text + "','" + datenaiss.Text + "','" + lieu.Text + "','" + etacivil.Text + "','" + tele.Text + "','" + mail.Text + "','" + nationali.Text + "','" + adresse.Text + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Action effectué", "Confirmation");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }


        public void deletemalade(Label id)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from MEDCIN where CODEMEDCIN='" + id.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Action effectué", "Confirmation");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }

        public void deletemedcin(Label id)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from MALADAE where IDMALADE='" + id.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Action effectué", "Confirmation");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }


        public void afficher(DataGridView table,String sql)
        {
            try
            {
                con.Open();
                DataTable n = new DataTable();
                cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(n);
                table.DataSource = n;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de faire l'action" + e.Message);
            }
        }



        public void selection(DataGridView table, Label id, TextBox nom, TextBox postnom, TextBox prenom, ComboBox sexe, DateTimePicker datenaiss, TextBox lieu,
            ComboBox etacivil, MaskedTextBox tele, TextBox mail, TextBox nationali, TextBox adresse)
        {
            try
            {
                id.Text = table.SelectedRows[0].Cells[0].Value.ToString();
                nom.Text = table.SelectedRows[0].Cells[1].Value.ToString();
                postnom.Text = table.SelectedRows[0].Cells[2].Value.ToString();
                prenom.Text = table.SelectedRows[0].Cells[3].Value.ToString();
                sexe.Text = table.SelectedRows[0].Cells[4].Value.ToString();
                datenaiss.Text = table.SelectedRows[0].Cells[5].Value.ToString();
                lieu.Text = table.SelectedRows[0].Cells[6].Value.ToString();
                etacivil.Text = table.SelectedRows[0].Cells[7].Value.ToString();
                tele.Text = table.SelectedRows[0].Cells[8].Value.ToString();
                mail.Text = table.SelectedRows[0].Cells[9].Value.ToString();
                nationali.Text = table.SelectedRows[0].Cells[10].Value.ToString();
                adresse.Text = table.SelectedRows[0].Cells[11].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de selection" + e.Message);
            }
        }

        static SerialPort port;
        public void sendMessage(RichTextBox mess, TextBox num)
        {

            {
                port = new SerialPort();

                Console.WriteLine("NUMERO TELEPHONE CENTRE");

                OpenPort();
                bool result;
                result = sendSMS(mess.Text, num.Text);

                if (result == true)
                {
                    MessageBox.Show("Message envoiyé","ALERTE MESSAGE");
                }
                else
                {
                    MessageBox.Show("Message non envoyé","ERREUR D'ALERTE MESSAGE");
                }
                Console.ReadLine();

                port.Close();

            }
        }

        private static bool sendSMS(string textsms, string telnumber)
        {
            if (!port.IsOpen) return false;

            try
            {
                System.Threading.Thread.Sleep(500);
                port.WriteLine("AT\r\n"); // означает "Внимание!" для модема 
                System.Threading.Thread.Sleep(500);

                port.Write("AT+CMGF=1\r\n"); // устанавливается текстовый режим для отправки сообщений
                System.Threading.Thread.Sleep(500);
            }
            catch
            {
                return false;
            }

            try
            {
                port.Write("AT+CMGS=\"" + telnumber + "\"" + "\r\n"); // задаем номер мобильного телефона получаталя смс
                System.Threading.Thread.Sleep(500);

                port.Write(textsms + char.ConvertFromUtf32(26) + "\r\n"); // отправляем текст смс
                System.Threading.Thread.Sleep(500);
            }
            catch
            {
                return false;
            }

            try
            {
                string recievedData;
                recievedData = port.ReadExisting();

                if (recievedData.Contains("ERROR"))
                {
                    return false;
                }

            }
            catch { }

            return true;
        }


      

        private static void OpenPort()
        {

            port.BaudRate = 2400; // еще варианты 4800, 9600, 28800 или 56000
            port.DataBits = 7; // еще варианты 8, 9

            port.StopBits = StopBits.One; // еще варианты StopBits.Two StopBits.None или StopBits.OnePointFive         
            port.Parity = Parity.Odd; // еще варианты Parity.Even Parity.Mark Parity.None или Parity.Space

            port.ReadTimeout = 500; // еще варианты 1000, 2500 или 5000 (больше уже не стоит)
            port.WriteTimeout = 500; // еще варианты 1000, 2500 или 5000 (больше уже не стоит)

            //port.Handshake = Handshake.RequestToSend;
            //port.DtrEnable = true;
            //port.RtsEnable = true;
            //port.NewLine = Environment.NewLine;

            port.Encoding = Encoding.GetEncoding("windows-1251");

            port.PortName = "COM4";

            // незамысловатая конструкция для открытия порта
            if (port.IsOpen)
                port.Close();
            try
            {
                port.Open();
            }
            catch { }

        }



        public void selectionmedcin(DataGridView table, Label id, TextBox nom, TextBox postnom, TextBox prenom, TextBox spec, ComboBox sexe,
           TextBox tele, TextBox mail)
        {
            try
            {
                id.Text = table.SelectedRows[0].Cells[0].Value.ToString();
                nom.Text = table.SelectedRows[0].Cells[1].Value.ToString();
                postnom.Text = table.SelectedRows[0].Cells[2].Value.ToString();
                prenom.Text = table.SelectedRows[0].Cells[3].Value.ToString();
                spec.Text = table.SelectedRows[0].Cells[4].Value.ToString();
                sexe.Text = table.SelectedRows[0].Cells[5].Value.ToString();
                tele.Text = table.SelectedRows[0].Cells[6].Value.ToString();
                mail.Text = table.SelectedRows[0].Cells[7].Value.ToString();
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de selection" + e.Message);
            }
        }
    }
}
