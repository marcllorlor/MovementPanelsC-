namespace ExamenFinalJaume
{
    partial class fmExamenFinal
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
            this.btnBarra = new System.Windows.Forms.Button();
            this.btnQuadrat = new System.Windows.Forms.Button();
            this.btnCanviarColor = new System.Windows.Forms.Button();
            this.lbBarres = new System.Windows.Forms.Label();
            this.lbGuionet = new System.Windows.Forms.Label();
            this.lbQuadrats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBarra
            // 
            this.btnBarra.BackColor = System.Drawing.Color.Red;
            this.btnBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarra.Location = new System.Drawing.Point(29, 24);
            this.btnBarra.Name = "btnBarra";
            this.btnBarra.Size = new System.Drawing.Size(123, 45);
            this.btnBarra.TabIndex = 0;
            this.btnBarra.Text = "barra";
            this.btnBarra.UseVisualStyleBackColor = false;
            this.btnBarra.Click += new System.EventHandler(this.btnBarra_Click);
            // 
            // btnQuadrat
            // 
            this.btnQuadrat.BackColor = System.Drawing.Color.Yellow;
            this.btnQuadrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuadrat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuadrat.Location = new System.Drawing.Point(179, 24);
            this.btnQuadrat.Name = "btnQuadrat";
            this.btnQuadrat.Size = new System.Drawing.Size(123, 45);
            this.btnQuadrat.TabIndex = 1;
            this.btnQuadrat.Text = "quadrat";
            this.btnQuadrat.UseVisualStyleBackColor = false;
            this.btnQuadrat.Click += new System.EventHandler(this.btnQuadrat_Click);
            // 
            // btnCanviarColor
            // 
            this.btnCanviarColor.BackColor = System.Drawing.Color.Blue;
            this.btnCanviarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanviarColor.ForeColor = System.Drawing.Color.White;
            this.btnCanviarColor.Location = new System.Drawing.Point(332, 24);
            this.btnCanviarColor.Name = "btnCanviarColor";
            this.btnCanviarColor.Size = new System.Drawing.Size(151, 45);
            this.btnCanviarColor.TabIndex = 2;
            this.btnCanviarColor.Text = "canviar color";
            this.btnCanviarColor.UseVisualStyleBackColor = false;
            this.btnCanviarColor.Click += new System.EventHandler(this.btnCanviarColor_Click);
            // 
            // lbBarres
            // 
            this.lbBarres.AutoSize = true;
            this.lbBarres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarres.Location = new System.Drawing.Point(512, 37);
            this.lbBarres.Name = "lbBarres";
            this.lbBarres.Size = new System.Drawing.Size(81, 22);
            this.lbBarres.TabIndex = 3;
            this.lbBarres.Text = "barres: 0";
            // 
            // lbGuionet
            // 
            this.lbGuionet.AutoSize = true;
            this.lbGuionet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuionet.Location = new System.Drawing.Point(599, 33);
            this.lbGuionet.Name = "lbGuionet";
            this.lbGuionet.Size = new System.Drawing.Size(16, 22);
            this.lbGuionet.TabIndex = 4;
            this.lbGuionet.Text = "-";
            // 
            // lbQuadrats
            // 
            this.lbQuadrats.AutoSize = true;
            this.lbQuadrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuadrats.Location = new System.Drawing.Point(631, 37);
            this.lbQuadrats.Name = "lbQuadrats";
            this.lbQuadrats.Size = new System.Drawing.Size(100, 22);
            this.lbQuadrats.TabIndex = 5;
            this.lbQuadrats.Text = "quadrats: 0";
            // 
            // fmExamenFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1026, 600);
            this.Controls.Add(this.lbQuadrats);
            this.Controls.Add(this.lbGuionet);
            this.Controls.Add(this.lbBarres);
            this.Controls.Add(this.btnCanviarColor);
            this.Controls.Add(this.btnQuadrat);
            this.Controls.Add(this.btnBarra);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmExamenFinal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fmExamenFinal_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBarra;
        private System.Windows.Forms.Button btnQuadrat;
        private System.Windows.Forms.Button btnCanviarColor;
        private System.Windows.Forms.Label lbBarres;
        private System.Windows.Forms.Label lbGuionet;
        private System.Windows.Forms.Label lbQuadrats;
    }
}

