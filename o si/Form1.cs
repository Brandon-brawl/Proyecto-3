using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace o_si
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispositivos d;
            d = new Dispositivos();
            d.Generacion = 6;
            MessageBox.Show(d.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Celular c;
            c = new Celular();
            c.Generacion = 6;
            c.SistemaOperativo = "sistema: Android, Generacion: ";
            MessageBox.Show(c.ToString());
        }

        private void btnmarca_Click(object sender, EventArgs e)
        {
            Samsung s;
            s = new Samsung();
            s.Generacion = 6;
            s.SistemaOperativo = " sistema: Android, Generacion: ";
            s.Marca = " marca: Samsung, ";
            MessageBox.Show(s.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Modelo m;
            m = new Modelo();
            m.Generacion = 6;
            m.SistemaOperativo = " sistema: Android, Generacion: ";
            m.Marca = " marca: Samsung, ";
            m.Nmodelo = " Numero de modelo: SM-J530GM ";
            MessageBox.Show(m.ToString());
        }
    }
}
