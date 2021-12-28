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
            txt_x.Focus();
        }

        private void CrearMatriz(int mc)
        {
            this.grid_Matriz.Rows.Clear();
            this.grid_Matriz.Columns.Clear();
            this.gridinversa.Rows.Clear();
            this.gridinversa.Columns.Clear();
            this.Matriz = new double[mc, mc];
            int i;
            for (i = 0; i < mc; i++)
            {
                this.grid_Matriz.Columns.Add("Columna" + i.ToString(), i.ToString());
                this.grid_Matriz.Columns[i].Width = 60;
                this.gridinversa.Columns.Add("Columna" + i.ToString(), i.ToString());
                this.gridinversa.Columns[i].Width = 60;
            }
            this.grid_Matriz.Rows.Add(mc);
            this.gridinversa.Rows.Add(mc);
            for (i = 0; i < mc; i++)
            {
                for (int j = 0; j < mc; j++)
                {
                    int num = 0;
                    this.grid_Matriz.Rows[i].Cells[j].Value = num;
                }
            }
        }

        private double Determinante(double[,] inMatriz)
        {
            double num = 0.0;
            double num2 = Math.Pow(double.Parse(inMatriz.Length.ToString()), 0.5);
            if (num2 == 2.0)
            {
                num = inMatriz[0, 0] * inMatriz[1, 1] - inMatriz[0, 1] * inMatriz[1, 0];
            }
            else
            {
                int num3 = Convert.ToInt32(num2 - 1.0);
                double[,] array = new double[num3, num3];
                for (int i = 0; (double)i < num2; i++)
                {
                    array = this.ConseguirMatrizAlterna(inMatriz, 0, i);
                    num += Math.Pow(-1.0, (double)i) * inMatriz[0, i] * this.Determinante(array);
                }
            }
            return num;
        }
    }
}
