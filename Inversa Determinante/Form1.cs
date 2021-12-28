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

        private double[,] ConseguirMatrizAlterna(double[,] inMatriz2, int posicioni, int posicionj)
        {
            int num = Convert.ToInt32(Math.Pow(double.Parse(inMatriz2.Length.ToString()), 0.5)) - 1;
            double[,] array = new double[num, num];
            int num2 = 0;
            for (int i = 0; i < num; i++)
            {
                if (i == posicionj)
                {
                    num2 = 1;
                }
                if (num2 == 0)
                {
                    int num3 = 0;
                    for (int j = 0; j < num; j++)
                    {
                        if (j == posicioni)
                        {
                            num3 = 1;
                        }
                        if (num3 == 0)
                        {
                            double[,] array2 = array;
                            int num4 = j;
                            int num5 = i;
                            double num6 = inMatriz2[j, i];
                            array2[num4, num5] = num6;
                        }
                        else
                        {
                            double[,] array3 = array;
                            int num7 = j;
                            int num8 = i;
                            double num9 = inMatriz2[j + 1, i];
                            array3[num7, num8] = num9;
                        }
                    }
                }
                else
                {
                    int num3 = 0;
                    for (int j = 0; j < num; j++)
                    {
                        if (j == posicioni)
                        {
                            num3 = 1;
                        }
                        if (num3 == 0)
                        {
                            double[,] array4 = array;
                            int num10 = j;
                            int num11 = i;
                            double num12 = inMatriz2[j, i + 1];
                            array4[num10, num11] = num12;
                        }
                        else
                        {
                            double[,] array5 = array;
                            int num13 = j;
                            int num14 = i;
                            double num15 = inMatriz2[j + 1, i + 1];
                            array5[num13, num14] = num15;
                        }
                    }
                }
            }
            return array;
        }

        private double[,] Adjunta(double[,] inMatriz3)
        {
            int num = Convert.ToInt32(Math.Pow(double.Parse(inMatriz3.Length.ToString()), 0.5));
            double[,] array = new double[num, num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    double[,] array2 = array;
                    int num2 = i;
                    int num3 = j;
                    double num4 = Math.Pow(-1.0, (double)(i + j)) * this.Determinante(this.ConseguirMatrizAlterna(inMatriz3, i, j));
                    array2[num2, num3] = num4;
                }
            }
            return array;
        }

        private double[,] TransponerMatriz(double[,] inmattrans)
        {
            int num = Convert.ToInt32(Math.Pow(double.Parse(inmattrans.Length.ToString()), 0.5));
            double[,] array = new double[num, num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    double[,] array2 = array;
                    int num2 = i;
                    int num3 = j;
                    double num4 = inmattrans[j, i];
                    array2[num2, num3] = num4;
                }
            }
            return array;
        }

        private double[,] matrizmenosuno(double[,] mta, double deter)
        {
            int num = Convert.ToInt32(Math.Pow(double.Parse(mta.Length.ToString()), 0.5));
            double[,] array = new double[num, num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    double[,] array2 = array;
                    int num2 = i;
                    int num3 = j;
                    double num4 = mta[i, j] / deter;
                    array2[num2, num3] = num4;
                }
            }
            return array;
        }

        private void btn_datos_Click(object sender, EventArgs e)
        {
            if (txt_x.Text.Length > 0)
            {
                int tamano = int.Parse(txt_x.Text);
                if (tamano >= 3)
                {
                    this.mcg = int.Parse(this.txt_x.Text);
                    this.CrearMatriz(this.mcg);
                }
                else
                {
                    MessageBox.Show("El tamaño de la matriz debe ser por lo menos de 3x3.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_x.Text = "3";
                }
            }
            else
            {
                MessageBox.Show("Debes definir el tamaño de la matriz.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_x.Text = "3";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.determinantedeMatriz = 0.0;
            for (int i = 0; i < this.mcg; i++)
            {
                for (int j = 0; j < this.mcg; j++)
                {
                    double[,] matriz = this.Matriz;
                    int num = i;
                    int num2 = j;
                    double num3 = double.Parse(this.grid_Matriz.Rows[i].Cells[j].Value.ToString());
                    matriz[num, num2] = num3;
                }
            }
            this.determinantedeMatriz = this.Determinante(this.Matriz);
            this.txt_respuesta.Text = this.determinantedeMatriz.ToString();
            this.MatrizAdjunta = this.Adjunta(this.Matriz);
            this.MatrizTranspuestaAdjunta = this.TransponerMatriz(this.MatrizAdjunta);

            this.MatrizInvertida = this.matrizmenosuno(this.MatrizTranspuestaAdjunta, this.determinantedeMatriz);
            for (int i = 0; i < this.mcg; i++)
            {
                for (int j = 0; j < this.mcg; j++)
                {
                    this.gridinversa.Rows[i].Cells[j].Value = this.MatrizInvertida[i, j];
                }
            }
        }
    }
}
