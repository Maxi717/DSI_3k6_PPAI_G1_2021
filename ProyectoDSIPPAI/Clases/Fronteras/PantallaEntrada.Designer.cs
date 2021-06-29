
namespace ProyectoDSIPPAI.Clases.Fronteras
{
    partial class PantallaEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblCantVisitantes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCapacidad.Location = new System.Drawing.Point(300, 147);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(29, 31);
            this.lblCapacidad.TabIndex = 4;
            this.lblCapacidad.Text = "0";
            // 
            // lblCantVisitantes
            // 
            this.lblCantVisitantes.AutoSize = true;
            this.lblCantVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantVisitantes.ForeColor = System.Drawing.Color.Black;
            this.lblCantVisitantes.Location = new System.Drawing.Point(145, 55);
            this.lblCantVisitantes.Name = "lblCantVisitantes";
            this.lblCantVisitantes.Size = new System.Drawing.Size(70, 76);
            this.lblCantVisitantes.TabIndex = 5;
            this.lblCantVisitantes.Text = "0";
            this.lblCantVisitantes.Click += new System.EventHandler(this.lblCantVisitantes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capacidad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visitantes:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PantallaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 186);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblCantVisitantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(900, 350);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PantallaEntrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblCantVisitantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}