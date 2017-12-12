using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFiNetworks
{
    public partial class WiFi : Form
    {
        private readonly NetworkSearcher _searcher = new NetworkSearcher();
        private List<WiFiNetwork> networks;

        public WiFi()
        {
            InitializeComponent();
        }

        private void WiFi_Load(object sender, EventArgs e)
        {
            UpdateNetworkList();
            ConnectionB.Enabled = false;
            PasswordF.Enabled = false;
            timer1.Enabled = true;
        }

        private void UpdateNetworkList()
        {
            NetworkList.Items.Clear();
            networks = _searcher.GetNetworks();
            foreach (var network in networks)
            {
                var item = new ListViewItem(network.Name);
                item.SubItems.AddRange(new[] 
                {
                    network.SignalStrength,
                    network.Description,
                    String.Join(" ",network.BssId.ToArray()),
                    network.IsSecured.ToString(),
                    network.IsConnected.ToString()
                });
                NetworkList.Items.Add(item);
            }
        }

        private void NetworkList_MouseClick(object sender, MouseEventArgs e)
        {
            EnablePassword(networks[NetworkList.SelectedItems[0].Index]);
            EnableDisconnect(networks[NetworkList.SelectedItems[0].Index]);
        }

        private void EnablePassword(WiFiNetwork network)
        {           
            if (network.IsConnected)
            {
                PasswordF.Enabled = false;
                ConnectionB.Enabled = false;
            }
            else
            {
                PasswordF.Enabled = network.IsSecured;
                ConnectionB.Enabled = true;
            }
        }

        private void EnableDisconnect(WiFiNetwork network)
        {
            if (network.IsConnected)
            {
                Disconnect.Enabled = true;
            }
            else
            {
                Disconnect.Enabled = false;
            }
        }

        private void ConnectionB_Click(object sender, EventArgs e)
        {
            if (PasswordF.Text.Length > 0)
            {
                if (networks[NetworkList.SelectedItems[0].Index].Connect(PasswordF.Text))
                {
                    MessageBox.Show("Connected");
                    PasswordF.Enabled = false;
                    ConnectionB.Enabled = false;
                    NetworkList.SelectedItems[0].Selected = false;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void PingB_Click(object sender, EventArgs e)
        {
            if (UrlF.Text.Length > 0)
            {
                var ping = new NetworkPing();
                PingAnswer.Text = ping.PingToAddress(UrlF.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             UpdateNetworkList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            networks[NetworkList.SelectedItems[0].Index].Disconect();
            if (networks[NetworkList.SelectedItems[0].Index].Disconect())
            {
                MessageBox.Show("Disconnected");
                PasswordF.Enabled = true;
                ConnectionB.Enabled = true;
                NetworkList.SelectedItems[0].Selected = false;
            }
            else
            {
                MessageBox.Show("Error");
            }
            UpdateNetworkList();
        }
    }
}
