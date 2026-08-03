using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umi.device.business.GPS;
using System.Globalization;

namespace umi.device
{
    public partial class frmGPS : Form
    {
        Gps gps = null;
        bool boolNovasInformacoesGps = false;

        public frmGPS()
        {
            InitializeComponent();
        }

        private void frmGPS_Load(object sender, EventArgs e)
        {                       
            //faz nada
        }        

        private void frmGPS_Closing(object sender, CancelEventArgs e)
        {
            timer1.Enabled = false;
            if (gps != null && gps.Aberto) gps.Fechar();            
        }

        private void menuItemSair_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (gps != null && gps.Aberto) gps.Fechar();
            this.Close();
            Application.Exit();
        }

        private void menuItemAbrir_Click(object sender, EventArgs e)
        {
            gps = new Gps("COM4", 38400);
            gps.Abrir();
            gps.OnUpdated += new Gps.GpsEventHandler(gps_OnUpdated);
            timer1.Enabled = true;
        }

        void gps_OnUpdated()
        {
            boolNovasInformacoesGps = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (boolNovasInformacoesGps)
            {
                listView1.Items.Clear();
                lock (gps)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { "Fix", (gps.Fix ? "Obtido" : "Perdido") }));
                    listView1.Items.Add(new ListViewItem(new string[] { "Latitude", gps.Latitude.ToString() }));
                    listView1.Items.Add(new ListViewItem(new string[] { "Longitude", gps.Longitude.ToString() }));
                    listView1.Items.Add(new ListViewItem(new string[] { "Data/Hora", gps.DataHora.ToString("dd/MM/yyyy HH:mm:ss") }));
                    listView1.Items.Add(new ListViewItem(new string[] { "Velocidade", gps.Velocidade.ToString() + " Km/h" }));
                    listView1.Items.Add(new ListViewItem(new string[] { "Satelites", gps.NumeroSatelitesVista.ToString() }));
                    listView1.Items.Add(new ListViewItem(new string[] { "Altitude (nív. mar)", gps.AltitudeNivelMar.ToString() }));
                    listView1.Items.Add(new ListViewItem(new string[] { "Altura (ref. WGS84)", gps.AlturaWGS84.ToString() }));
                    dgSatelite.DataSource = gps.Satelites;
                }
                dgSatelite.Refresh();                
                boolNovasInformacoesGps = false;
            }            
        }
    }
}