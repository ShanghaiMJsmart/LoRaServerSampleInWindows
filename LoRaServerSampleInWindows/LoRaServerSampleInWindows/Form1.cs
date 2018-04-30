using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;
using MQTTnet;
using System.Threading;

namespace LoRaServerSampleInWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipStr = textBoxip.Text;
            IPAddress ip;
            textBoxmacaddr.Text = textBoxmacaddr.Text.ToUpper();
            if (IPAddress.TryParse(ipStr, out ip))
            {
                MessageBox.Show("您输入的IP地址为：" + ip.ToString());

            }
            else
            {
                MessageBox.Show("请输入合法的IP地址");
                return;
            }
            //var mqttClient = new MqttClientFactory().CreateMqttClient();
        }
    }
}
