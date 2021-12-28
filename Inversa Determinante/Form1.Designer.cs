namespace Inversa_Determinante
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grid_Matriz = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_datos = new System.Windows.Forms.Button();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridinversa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Matriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridinversa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Escribe los valores de la Matriz:";
            // 
            // grid_Matriz
            // 
            this.grid_Matriz.AllowUserToAddRows = false;
            this.grid_Matriz.AllowUserToDeleteRows = false;
            this.grid_Matriz.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grid_Matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Matriz.ColumnHeadersVisible = false;
            this.grid_Matriz.Location = new System.Drawing.Point(12, 32);
            this.grid_Matriz.Name = "grid_Matriz";
            this.grid_Matriz.RowHeadersVisible = false;
            this.grid_Matriz.Size = new System.Drawing.Size(1239, 236);
            this.grid_Matriz.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Determinante Obtenido:";
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Enabled = false;
            this.txt_respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_respuesta.Location = new System.Drawing.Point(589, 285);
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(152, 22);
            this.txt_respuesta.TabIndex = 18;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(747, 282);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(154, 26);
            this.btn_ok.TabIndex = 17;
            this.btn_ok.Text = "Calcular Inversa";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_datos
            // 
            this.btn_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos.Location = new System.Drawing.Point(173, 283);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(233, 24);
            this.btn_datos.TabIndex = 16;
            this.btn_datos.Text = "Establecer Tamaño";
            this.btn_datos.UseVisualStyleBackColor = true;
            // 
            // txt_x
            // 
            this.txt_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x.Location = new System.Drawing.Point(12, 284);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(155, 22);
            this.txt_x.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Matriz Inversa";
            // 
            // gridinversa
            // 
            this.gridinversa.AllowUserToAddRows = false;
            this.gridinversa.AllowUserToDeleteRows = false;
            this.gridinversa.AllowUserToResizeColumns = false;
            this.gridinversa.AllowUserToResizeRows = false;
            this.gridinversa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridinversa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridinversa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridinversa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridinversa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridinversa.ColumnHeadersVisible = false;
            this.gridinversa.Location = new System.Drawing.Point(12, 332);
            this.gridinversa.Name = "gridinversa";
            this.gridinversa.ReadOnly = true;
            this.gridinversa.RowHeadersVisible = false;
            this.gridinversa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridinversa.Size = new System.Drawing.Size(1236, 365);
            this.gridinversa.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 733);
            this.Controls.Add(this.gridinversa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_datos);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.grid_Matriz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::::: CALCULO DEL DETERMINATE Y MATRIZ INVERSA ::::: DE UNA MATRIZ DE N X N :::::" +
    "";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Matriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridinversa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_Matriz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_datos;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridinversa;
    }
}

