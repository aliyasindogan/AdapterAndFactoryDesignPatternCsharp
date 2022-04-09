using System;
using System.Windows.Forms;

namespace AdapterAndFactoryDesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            txtPort.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IDeviceFactory deviceFactory = new DeviceFactory();
                var selectedItem = comboBox1.SelectedItem.ToString();
                string[] selectedDeviceId = selectedItem.Split('-');
                var data = deviceFactory.DeviceConnection(new Device
                {
                    DeviceSDKType = (DeviceSDKTypes)Convert.ToInt32(selectedDeviceId[0]),
                    IP = txtIP.Text,
                    Port = Convert.ToInt32(String.IsNullOrEmpty(txtPort.Text) ? "0" : txtPort.Text)
                });
                label2.Text = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu! İlgili alanları doldurup tekrar deneyiniz!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBox1.SelectedItem.ToString();
            string[] selectedDeviceId = selectedItem.Split('-');
            if (selectedDeviceId[0] == "2")
                txtPort.Enabled = false;
            else
                txtPort.Enabled = true;
        }
    }
}