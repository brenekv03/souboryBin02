using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace souboryBin02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            FileStream fs = new FileStream(@"..\..\realnaCisla.dat", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs);
            BinaryWriter bw = new BinaryWriter(fs);
            Random random = new Random();
            for(int i =0;i<n;i++)
            {
                double cislo = random.NextDouble()*(200-(-200))-200;
                bw.Write(cislo);
            }
            while(fs.Position < fs.Length)
            {
                double soubor = br.ReadDouble();
                listBox1.Items.Add(soubor);
            }
            fs.Close();
        }
    }
}
