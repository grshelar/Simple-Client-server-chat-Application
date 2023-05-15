using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer Server;

       

        private void Startbutton_Click(object sender, EventArgs e)
        {
            Server.Start();
            txtinfo.Text += $"starting...{Environment.NewLine}";
            Startbutton.Enabled = false;
            Sendbutton.Enabled = true;
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if(Server.IsListening)
            {
                if (!string.IsNullOrEmpty(Msgbox.Text)&& listClientIP.SelectedItems != null)
                {
                    Server.Send(listClientIP.SelectedItem.ToString(), Msgbox.Text);
                    txtinfo.Text += $"server : {Msgbox.Text}{Environment.NewLine}";
                    Msgbox.Text = string.Empty;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            Sendbutton.Enabled = false;
            Server = new SimpleTcpServer(txtIP.Text);
            Server.Events.ClientConnected += Events_ClientConnected;
            Server.Events.ClientDisconnected += Events_ClientDisconnected;
            Server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {

                txtinfo.Text += $"Client : {Encoding.UTF8.GetString(e.Data.ToArray())}{Environment.NewLine}";

            });
        } 

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtinfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                listClientIP.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtinfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                listClientIP.Items.Add(e.IpPort);
            });
        }

       
    }
}
