using CanimOkulum.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanimOkulum
{
    public partial class Form1 : Form
    {
        OkulContext db = new OkulContext();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci { Ad = txtAd.Text, Soyad = txtSoyad.Text };
            db.Ogrenciler.Add(o);
            db.SaveChanges();
            dgvOgrenciler.DataSource = db.Ogrenciler.ToList();
        }
    }
}
