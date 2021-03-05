namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.txthoraslaboradas = new System.Windows.Forms.TextBox();
            this.txthoradiurna = new System.Windows.Forms.TextBox();
            this.txtnocturna = new System.Windows.Forms.TextBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txthorafestivo = new System.Windows.Forms.TextBox();
            this.txthoradomilical = new System.Windows.Forms.TextBox();
            this.btnpunto2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 153);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(38, 48);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(141, 20);
            this.txtIdentificacion.TabIndex = 3;
            this.txtIdentificacion.Enter += new System.EventHandler(this.TxtIdentificacion_Enter);
            // 
            // txtperiodo
            // 
            this.txtperiodo.Location = new System.Drawing.Point(38, 305);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(100, 20);
            this.txtperiodo.TabIndex = 4;
            // 
            // txthoraslaboradas
            // 
            this.txthoraslaboradas.Location = new System.Drawing.Point(233, 305);
            this.txthoraslaboradas.Name = "txthoraslaboradas";
            this.txthoraslaboradas.Size = new System.Drawing.Size(100, 20);
            this.txthoraslaboradas.TabIndex = 5;
            // 
            // txthoradiurna
            // 
            this.txthoradiurna.Location = new System.Drawing.Point(429, 305);
            this.txthoradiurna.Name = "txthoradiurna";
            this.txthoradiurna.Size = new System.Drawing.Size(100, 20);
            this.txthoradiurna.TabIndex = 6;
            // 
            // txtnocturna
            // 
            this.txtnocturna.Location = new System.Drawing.Point(607, 305);
            this.txtnocturna.Name = "txtnocturna";
            this.txtnocturna.Size = new System.Drawing.Size(100, 20);
            this.txtnocturna.TabIndex = 7;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(429, 383);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(100, 20);
            this.txtdescuento.TabIndex = 8;
            // 
            // txthorafestivo
            // 
            this.txthorafestivo.Location = new System.Drawing.Point(233, 383);
            this.txthorafestivo.Name = "txthorafestivo";
            this.txthorafestivo.Size = new System.Drawing.Size(100, 20);
            this.txthorafestivo.TabIndex = 9;
            // 
            // txthoradomilical
            // 
            this.txthoradomilical.Location = new System.Drawing.Point(38, 380);
            this.txthoradomilical.Name = "txthoradomilical";
            this.txthoradomilical.Size = new System.Drawing.Size(100, 20);
            this.txthoradomilical.TabIndex = 10;
            // 
            // btnpunto2
            // 
            this.btnpunto2.Location = new System.Drawing.Point(607, 377);
            this.btnpunto2.Name = "btnpunto2";
            this.btnpunto2.Size = new System.Drawing.Size(135, 23);
            this.btnpunto2.TabIndex = 11;
            this.btnpunto2.Text = "Guardar";
            this.btnpunto2.UseVisualStyleBackColor = true;
            this.btnpunto2.Click += new System.EventHandler(this.Btnpunto2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Digite la identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Horas totales laboradas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Horas Diurnas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Horas Nocturnas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Horas Dominical";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Horas Festivas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Descuento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpunto2);
            this.Controls.Add(this.txthoradomilical);
            this.Controls.Add(this.txthorafestivo);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.txtnocturna);
            this.Controls.Add(this.txthoradiurna);
            this.Controls.Add(this.txthoraslaboradas);
            this.Controls.Add(this.txtperiodo);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.TextBox txthoraslaboradas;
        private System.Windows.Forms.TextBox txthoradiurna;
        private System.Windows.Forms.TextBox txtnocturna;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txthorafestivo;
        private System.Windows.Forms.TextBox txthoradomilical;
        private System.Windows.Forms.Button btnpunto2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

