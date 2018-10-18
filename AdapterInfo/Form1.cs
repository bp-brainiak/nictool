using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var tarjetas =  Utils.GetInterfaces();
            foreach (string tarjeta in tarjetas)
            {
                cmbNic.Items.Add(tarjeta);
            }
        }

        private void cmbNic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nic = cmbNic.SelectedItem.ToString();
            var items = Utils.GetNicIPAddress(nic);
            if(items != null)
            {
                txtIpAddress.Text = items["IpAddress"].ToString();
                txtDefaultGW.Text = items["Gateway"].ToString();
                txtSunetMask.Text = items["SubnetMask"].ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Creado por Ulises Ruz Puga (CopyLeft) 2018, todos los derechos no reservados\n Este programa es un beerware, osea si te es util, puedes invitarme una cerveza (o brindar en mi honor) :) \npero si quieres hacerme una pequeña donación, olvidalo, es gratis  ","Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}