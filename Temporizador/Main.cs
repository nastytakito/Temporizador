using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "00h:00m:00s";
        }
        
        int flag = 0;
        int time = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            time = (tiempo(Convert.ToInt32(tiempoup.Value), formatocb.Text));
            if (apagarrb.Checked == true)
            {
                string taco = "/c shutdown -s -t " + time;
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = taco;
                process.StartInfo = startInfo;
                process.Start();
                contador.Start();
                contador_Tick(sender, e);
            }
            else
            {
                contador.Start();
                contador_Tick(sender, e);
            }
            button1.Enabled = false;
            apagarrb.Enabled = false;
            hibernarrb.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string taco = "/c shutdown -a";
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = taco;
                process.StartInfo = startInfo;
                process.Start();
                contador.Stop();
                textBox1.Text = "00h:00m:00s";
            }
            button1.Enabled = true;
            apagarrb.Enabled = true;
            hibernarrb.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SSIDtb.Text == "")
            {
                MessageBox.Show("SSID está en blanco", "Aguas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (KEYtb.Text.Count() < 7)
                {
                    MessageBox.Show("La key debe ser de 8 o más caracteres", "Aguas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    asignar(SSIDtb.Text, KEYtb.Text);
                }
            }
        }

        public void asignar(string SSID, string key)
        {
            string taco = "/c netsh wlan set hostednetwork mode=allow SSID=" + SSID + " key=" + key;
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = taco;
            process.StartInfo = startInfo;
            process.Start();
            System.Threading.Thread.Sleep(2000);
            aplicar();
        }

        public void aplicar()
        {
            string taco2 = "/c netsh wlan start hostednetwork";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = taco2;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string taco2 = "/c netsh wlan stop hostednetwork";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = taco2;
            process.StartInfo = startInfo;
            process.Start();
        }

        public void numeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        public int tiempo(int tiempo, string formato)
        {
            int resultado=3600;

            switch (formato) { 
                case "Horas":
                    resultado = tiempo * 3600;
                    break;
                case "Minutos":
                    resultado = tiempo * 60;
                    break;
                case "Segundos":
                    resultado = tiempo;
                    break;
            }
            return resultado;
        }

        private void tiempotb_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }
        
        private void formatocb_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (formatocb.SelectedIndex)
            {
                case 0://horas
                    if (flag==1)
                    {
                        //si viene de minutos
                        //if (tiempoup.Value)
                        tiempoup.Value = Convert.ToInt32(tiempoup.Value / 60);
                        tiempoup.Maximum = 24;
                    }
                    else
                    {
                        //si viene de segundos
                        tiempoup.Value = Convert.ToInt32(tiempoup.Value / 60 / 60);
                        tiempoup.Maximum = 24;
                    }
                    break;
                case 1://minutos
                    if (flag == 0)
                    {
                        //si viene de horas
                        tiempoup.Maximum = 1440;
                        tiempoup.Value = Convert.ToInt32(tiempoup.Value * 60);
                    }
                    else
                    {
                        //si viene de segundos
                        tiempoup.Value = Convert.ToInt32(tiempoup.Value/60);
                        tiempoup.Maximum = 1440;
                    }
                    break;
                case 2://segundos
                    if (flag == 0)
                    {
                        //si viene de horas
                        tiempoup.Maximum = 86400;
                        tiempoup.Value = Convert.ToInt32(tiempoup.Value * 60 * 60);
                    }
                    else
                    {
                        //si viene de minutos
                        tiempoup.Maximum = 86400;
                        tiempoup.Value = Convert.ToInt32(tiempoup.Value * 60);
                    }
                    break;
            }

            flag = formatocb.SelectedIndex;
        }

        private void formatocb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void contador_Tick(object sender, EventArgs e)
        {
            TimeSpan t = TimeSpan.FromSeconds(time);
            if (time != -1)
            {
                string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                t.Hours,
                t.Minutes,
                t.Seconds);
                time -= 1;
                textBox1.Text = answer;
            }
            else
            {
                if (apagarrb.Checked == false)
                {
                    string taco = "/c shutdown -h ";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = taco;
                    process.StartInfo = startInfo;
                    process.Start();
                    //Console.Write("hibernar"); //just for debug
                }
                else
                {
                    //Console.Write("Apagar"); //just for debug
                }
                
                contador.Stop();
                button1.Enabled = true;
                apagarrb.Enabled = true;
                hibernarrb.Enabled = true;
            }
        }
    }
}
