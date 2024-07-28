using Spire.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode_gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeSettings bs = new BarcodeSettings();

            bs.Type = BarCodeType.Code128;
            bs.Data = richTextBox1.Text;

            BarCodeGenerator bg = new BarCodeGenerator(bs);
            saveFileDialog1.Filter = ("png image |*.png");
            saveFileDialog1.ShowDialog();

            bg.GenerateImage().Save(saveFileDialog1.FileName);

            System.Diagnostics.Process.Start(saveFileDialog1.FileName);
            linkLabel1.Text = saveFileDialog1.FileName;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
