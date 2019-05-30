namespace Trapecio_Múltiple
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
            this.funcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inferior = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.superior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.intervalos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ecua = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcion
            // 
            this.funcion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcion.Location = new System.Drawing.Point(27, 43);
            this.funcion.Name = "funcion";
            this.funcion.Size = new System.Drawing.Size(184, 26);
            this.funcion.TabIndex = 0;
            this.funcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Limite inferior (a)";
            // 
            // inferior
            // 
            this.inferior.Location = new System.Drawing.Point(130, 62);
            this.inferior.Name = "inferior";
            this.inferior.Size = new System.Drawing.Size(100, 26);
            this.inferior.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Limite superior (b)";
            // 
            // superior
            // 
            this.superior.Location = new System.Drawing.Point(11, 62);
            this.superior.Name = "superior";
            this.superior.Size = new System.Drawing.Size(100, 26);
            this.superior.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Intevalos (n)";
            // 
            // intervalos
            // 
            this.intervalos.AllowDrop = true;
            this.intervalos.Location = new System.Drawing.Point(245, 62);
            this.intervalos.Name = "intervalos";
            this.intervalos.Size = new System.Drawing.Size(100, 26);
            this.intervalos.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ecua);
            this.groupBox1.Controls.Add(this.R);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.resultado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Calcular);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inferior);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.superior);
            this.groupBox1.Controls.Add(this.intervalos);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 257);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular h";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Ecua
            // 
            this.Ecua.AutoSize = true;
            this.Ecua.Location = new System.Drawing.Point(252, 204);
            this.Ecua.Name = "Ecua";
            this.Ecua.Size = new System.Drawing.Size(0, 20);
            this.Ecua.TabIndex = 16;
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(14, 204);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(34, 20);
            this.R.TabIndex = 14;
            this.R.Text = "A=  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "F(x)=";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(45, 99);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 20);
            this.resultado.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "h=";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(245, 123);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 30);
            this.Calcular.TabIndex = 10;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.funcion);
            this.Name = "Form1";
            this.Text = "Trapecio Multiple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox funcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inferior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox superior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox intervalos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Ecua;
    }
}

