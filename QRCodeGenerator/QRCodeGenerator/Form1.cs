using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBoxUnesi.Text == "Unesite string za barcode!")
            {
                textBoxUnesi.Text = "";
                textBoxUnesi.ForeColor = Color.FromArgb(221, 79, 66);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBoxUnesi.Text == "")
            {
                textBoxUnesi.Text = "Unesite string za barcode!";
                textBoxUnesi.ForeColor = Color.FromArgb(193, 193, 193);
            }
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData data = qr.CreateQrCode(textBoxUnesi.Text, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode code = new QRCoder.QRCode(data);
            picBox.Image = code.GetGraphic(5);

            textBoxPrikazi.Text = textBoxUnesi.Text;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ddlStringovi.AddItem(textBoxUnesi.Text);

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ddlStringovi.RemoveAt(ddlStringovi.selectedIndex);
            ddlStringovi.selectedIndex++;
        }

        private void ddlStringovi_onItemSelected(object sender, EventArgs e)
        {
            textBoxUnesi.Text = ddlStringovi.selectedValue;
        }
    }
}
