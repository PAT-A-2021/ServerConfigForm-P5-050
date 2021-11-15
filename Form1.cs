using ServiceMtk_P1_20190140050;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ServerConfigForm_P5_050
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOn_click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server On";
            labelKet.Text = "Klick OFF untuk mematikan server";
            Host.Open();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;

        }

        private void buttonOff_click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            labelOnOrOff.Text = "Server Off";
            labelKet.Text = "Klick ON untuk menjalankan server";
            Host.Close();
       
        }
    }
}
