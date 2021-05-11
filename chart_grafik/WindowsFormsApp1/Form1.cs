using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series["kitap"].Points.AddXY("EGE BÖLGESİ", 2);
            chart1.Series["kitap"].Points.AddXY("MARMARA BÖLGESİ", 3);
            chart1.Series["kitap"].Points.AddXY("İÇ ANADOLU BÖLGESİ", 1);
            chart1.Series["kitap"].Points.AddXY("KARADENİZ BÖLGESİ",3);
        }
    }
}
