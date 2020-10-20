namespace o_si
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
            this.btnDispositovo = new System.Windows.Forms.Button();
            this.btnCelular = new System.Windows.Forms.Button();
            this.btnmarca = new System.Windows.Forms.Button();
            this.btnModelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDispositovo
            // 
            this.btnDispositovo.Location = new System.Drawing.Point(160, 33);
            this.btnDispositovo.Name = "btnDispositovo";
            this.btnDispositovo.Size = new System.Drawing.Size(125, 64);
            this.btnDispositovo.TabIndex = 0;
            this.btnDispositovo.Text = "Dispositivo";
            this.btnDispositovo.UseVisualStyleBackColor = true;
            this.btnDispositovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCelular
            // 
            this.btnCelular.Location = new System.Drawing.Point(160, 112);
            this.btnCelular.Name = "btnCelular";
            this.btnCelular.Size = new System.Drawing.Size(125, 64);
            this.btnCelular.TabIndex = 1;
            this.btnCelular.Text = "Celular";
            this.btnCelular.UseVisualStyleBackColor = true;
            this.btnCelular.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmarca
            // 
            this.btnmarca.Location = new System.Drawing.Point(160, 182);
            this.btnmarca.Name = "btnmarca";
            this.btnmarca.Size = new System.Drawing.Size(125, 64);
            this.btnmarca.TabIndex = 2;
            this.btnmarca.Text = "Marca";
            this.btnmarca.UseVisualStyleBackColor = true;
            this.btnmarca.Click += new System.EventHandler(this.btnmarca_Click);
            // 
            // btnModelo
            // 
            this.btnModelo.Location = new System.Drawing.Point(160, 252);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(125, 64);
            this.btnModelo.TabIndex = 3;
            this.btnModelo.Text = "Modelo";
            this.btnModelo.UseVisualStyleBackColor = true;
            this.btnModelo.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 355);
            this.Controls.Add(this.btnModelo);
            this.Controls.Add(this.btnmarca);
            this.Controls.Add(this.btnCelular);
            this.Controls.Add(this.btnDispositovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDispositovo;
        private System.Windows.Forms.Button btnCelular;
        private System.Windows.Forms.Button btnmarca;
        private System.Windows.Forms.Button btnModelo;
    }
}

