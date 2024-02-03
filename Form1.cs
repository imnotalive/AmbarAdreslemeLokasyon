using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbarAdreslemeLokasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AMBARADRESEntities _AmbarAdres;
        public KutuAna KutuAna { get; set; }
        private void btnBUL_Click(object sender, EventArgs e)
        {
            if (txtKutuNo.Text == null)
            {
                MessageBox.Show("Lütfen Kutu Numarası Giriniz");
            }
            else
            {
                LokasyonBul();
            }
        }
        public void LokasyonBul()
        {
            string KutuNo = txtKutuNo.Text.Replace(" ", "");

            try
            {
                KutuAna = _AmbarAdres.KutuAna.First(a => a.KutuNo.Replace(" ", "") == KutuNo);
            }
            catch (Exception e)
            {
                MessageBox.Show("Bilinmeyen Bir Hata oluştu.." + "Hata Nedeni:" + e.ToString());
            }
            txtLokasyon.Text = KutuAna.Location;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _AmbarAdres = new AMBARADRESEntities();
            KutuAna = new KutuAna();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
