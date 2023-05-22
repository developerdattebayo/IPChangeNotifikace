using System.Drawing.Design;
using System.Net;
using System.Net.Mail;

namespace IPChangeNotifikace
{
    public partial class Form1 : Form
    {
        private HttpClient httpClient;
        private SmtpClient smtpClient;
        private CredentialsSaver credentialsSaver;
        private async void GetIp()
        {
            string url = "http://checkip.dyndns.org/";
            HttpRequestMessage messenge = new HttpRequestMessage(HttpMethod.Get, url);
            string response = await httpClient.GetStringAsync(url);
            string[] dirtyResponse = response.Split(':');
            string[] almostCleanResponse = dirtyResponse[1].Split('<');
            txtBoxIP.Text = almostCleanResponse[0];
            if (txtBoxIP.Text != credentialsSaver.CurrentIP)
            {
                if (credentialsSaver.AllCredentials)
                {
                    SendNotification();
                    
                }

                credentialsSaver.CurrentIP = txtBoxIP.Text;
            }
            labelCasKontroly.Text = "Èas do kontroly: " + DateTime.Now.AddMilliseconds((double)timerCheck.Interval).ToShortTimeString();
        }
        private void SendNotification()
        {
            try
            {
                smtpClient.Credentials = new NetworkCredential(credentialsSaver.Email, credentialsSaver.Password);
                smtpClient.EnableSsl = true;
                string cislo = $"00420{credentialsSaver.PhoneNumber}@sms.cz.o2.com";

                MailMessage mailMessage = new MailMessage(credentialsSaver.Email, cislo);
                mailMessage.Subject = "Zmena IP";
                mailMessage.Body = "Vase IP adresa se zmenila";

                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {
                MessageBox.Show("Nìco se pokazilo pøi odesílání!");
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            httpClient= new HttpClient();
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            credentialsSaver = new CredentialsSaver();
            timerCheck.Interval = 3600000; //1 hour
            timerCheck.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                credentialsSaver.Load();
            }
            catch (Exception)
            {
            }

            if (credentialsSaver.AllCredentials)
            {
                txtboxEmail.Text = credentialsSaver.Email;
                txtboxEmail.ReadOnly = true;
                txtBoxPassword.Text = credentialsSaver.Password;
                txtBoxPassword.ReadOnly = true;
                txtboxTelefon.Text = credentialsSaver.PhoneNumber;
                txtboxTelefon.ReadOnly = true;
                btnAktivace.Enabled = false;
                btnDeaktivace.Enabled = true;
                btnAktivace.Text = "Aktivaváno";
            }
            else
            {
                txtboxEmail.ForeColor = Color.Gray;
                txtboxEmail.Text = "tvuj-email@gmail.com";
                txtboxTelefon.ForeColor= Color.Gray;
                txtboxTelefon.Text = "605 305 305";
                txtBoxPassword.ForeColor = Color.Gray;
                txtBoxPassword.Text = "*********";
            }
            try
            {
                GetIp();
            }
            catch (Exception)
            {
                MessageBox.Show($"Chyba pøi získávání IP!\nDalší pokus za {(timerCheck.Interval/1000)/60} minut");
            }
           
            timerCheck.Start();
            

        }

        private void txtboxEmail_Click(object sender, EventArgs e)
        {
            if (btnAktivace.Enabled == true)
            {
                txtboxEmail.ForeColor = Color.Black;
                txtboxEmail.Text = String.Empty;
            }
        }

        private void txtboxTelefon_Click(object sender, EventArgs e)
        {
            if (btnAktivace.Enabled == true)
            {
                txtboxTelefon.ForeColor= Color.Black;
                txtboxTelefon.Text= String.Empty;
            }
            
        }

        private void nápovìdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NapovedaForm napoveda = new NapovedaForm();
            napoveda.ShowDialog();
        }

        private void btnAktivace_Click(object sender, EventArgs e)
        {
            try
            {
                smtpClient.Credentials = new NetworkCredential(txtboxEmail.Text, txtBoxPassword.Text);
                smtpClient.EnableSsl = true;
                string cislo = $"00420{txtboxTelefon.Text.Replace(" ", "")}@sms.cz.o2.com";

                MailMessage mailMessage = new MailMessage(txtboxEmail.Text, cislo);
                mailMessage.Subject = "Aktivace";
                mailMessage.Body = "Aplikace je aktivni";

                smtpClient.Send(mailMessage);

                credentialsSaver.Email = txtboxEmail.Text;
                credentialsSaver.Password = txtBoxPassword.Text;
                credentialsSaver.PhoneNumber = txtboxTelefon.Text;
                btnAktivace.Enabled = false;
                btnDeaktivace.Enabled = true;

                txtboxEmail.ReadOnly = true;
                txtBoxPassword.ReadOnly = true;
                txtboxTelefon.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Nìco se pokazilo pøi aktivaci!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (credentialsSaver.AllCredentials)
            {
                try
                {
                    credentialsSaver.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }         
        }

        private void txtBoxPassword_Click(object sender, EventArgs e)
        {
            if (btnAktivace.Enabled == true)
            {
                txtBoxPassword.ForeColor = Color.Black;
                txtBoxPassword.Text = string.Empty;
            }
            
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            GetIp();
        }

        private void btnDeaktivace_Click(object sender, EventArgs e)
        {   
                try
                {
                    credentialsSaver.DeleteSavedFiles();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nìco se pokazilo pøi mazání souboru!");
                }          
                credentialsSaver.CurrentIP = "";
                credentialsSaver.Email = "";
                credentialsSaver.Password = "";
                credentialsSaver.PhoneNumber = "";

                txtboxEmail.ReadOnly = false;
                txtBoxPassword.ReadOnly = false;
                txtboxTelefon.ReadOnly = false;

                btnAktivace.Enabled = true;
                btnDeaktivace.Enabled = false;
        }
    }
}