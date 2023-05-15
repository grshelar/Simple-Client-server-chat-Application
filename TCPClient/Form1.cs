using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using SuperSimpleTcp;
using System.Globalization;

namespace TCPClient
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient Client;
        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if (Client.IsConnected)
            {
                if (!string.IsNullOrEmpty(Messagebox.Text))
                {
                    Client.Send(Messagebox.Text);
                    textinfo.Text += $"Client : {Messagebox.Text}{Environment.NewLine}";
                    Messagebox.Text = string.Empty;
                }
            }
        }

        private void Connectbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Connect();
                Sendbutton.Enabled = true;
                Connectbutton.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sendbutton.Enabled = false;
            Client = new SimpleTcpClient(txtIP.Text);
            Client.Events.Connected += Events_Connected;
            Client.Events.Disconnected += Events_Disconnected;
            Client.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textinfo.Text += $"Server : {Encoding.UTF8.GetString(e.Data.ToArray())}{Environment.NewLine}";

            });
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e  )
        {
            this.Invoke((MethodInvoker)delegate
            {
                textinfo.Text += $"sever disconnected.{Environment.NewLine}";
            });
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textinfo.Text += $"sever connected.{Environment.NewLine}";
            });
        }
    }
}
