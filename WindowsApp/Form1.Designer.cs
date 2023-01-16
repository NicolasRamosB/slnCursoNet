namespace WindowsApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnDC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(168, 63);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(150, 55);
            this.btnEmpresa.TabIndex = 1;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(324, 63);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(167, 55);
            this.btnPersona.TabIndex = 2;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnDC
            // 
            this.btnDC.Location = new System.Drawing.Point(497, 63);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(150, 55);
            this.btnDC.TabIndex = 3;
            this.btnDC.Text = "Documento Comercial";
            this.btnDC.UseVisualStyleBackColor = true;
            this.btnDC.Click += new System.EventHandler(this.btnDC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 172);
            this.Controls.Add(this.btnDC);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnDC;
    }
}

