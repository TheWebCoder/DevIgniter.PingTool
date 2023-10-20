using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace DevIgniter.NetworkScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            string ipAddress = ipTextBox.Text;

            // Check if the entered IP address is valid
            if (IPAddress.TryParse(ipAddress, out IPAddress address))
            {
                // Display the IP address in the Label
                //ipLabel.Text = "IP Address: " + ipAddress;
                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();

                options.DontFragment = true;

                string data = "Just a test ping";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 120;

                PingReply reply = pingSender.Send(ipAddress, timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    ipLabel.Text = "Ping Was Successfull!";
                }
                else
                {
                    ipLabel.Text = "Ping Was Not Successfull!";
                }

            }
            else
            {
                // Display error message if IP is not valid
                ipLabel.Text = "Invalid IP Address";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string localIP = GetLocalIPAddress();

            // Set the local IP address in the TextBox
            ipTextBox.Text = localIP;

        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Local IP Address Not Found!";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}