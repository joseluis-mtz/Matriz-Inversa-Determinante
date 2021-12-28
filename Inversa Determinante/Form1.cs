using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inversa_Determinante
{
    public partial class Form1 : Form
    {
        // Variables y matrices
        private double[,] Matriz;

        private double[,] MatrizAdjunta;

        private double[,] MatrizTranspuestaAdjunta;

        private double[,] MatrizInvertida;

        private double[,] MatrizIdentidad;

        private int mcg;

        private Random r = new Random();

        private double determinantedeMatriz;

        public Form1()
        {
            InitializeComponent();
            txt_x.Text = "3";
            this.mcg = int.Parse(this.txt_x.Text);
            this.txt_x.Text = this.mcg.ToString();
            this.CrearMatriz(this.mcg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
