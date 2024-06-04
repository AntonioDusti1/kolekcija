using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolekcije
{
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" ||
                    textBox2.Text == "" ||
                    comboBox1.Text == "")
                {
                    MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                                        "Pogrešan unos", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else
                {
                    Vozilo vozilo = new Vozilo(textBox1.Text,
                        textBox2.Text,
                        comboBox1.Text);
                    voziloList.Add(vozilo);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                    "Pogrešan unos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Vozilo v in voziloList)
            {
                textBox3.AppendText(v.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (Vozilo v in voziloList)
            {
                if (v.Vrsta == "Avion")
                {
                    v.VoziPo = "Zrak";
                }
                else if (v.Vrsta == "Vozilo")
                {
                    v.VoziPo = "Cesta";
                }
                else
                {
                    v.VoziPo = "Voda";
                }
            }
        }
    }

    }

