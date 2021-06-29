
namespace ProyectoDSIPPAI.Clases.Fronteras
{
    partial class PantallaVentaEntrada
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
            this.grdTarifas = new System.Windows.Forms.DataGridView();
            this.lblTarifas = new System.Windows.Forms.Label();
            this.btnTomarTarifa = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCantidadEntradas = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtCantidadAMostrar = new System.Windows.Forms.TextBox();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTarifas
            // 
            this.grdTarifas.AllowUserToAddRows = false;
            this.grdTarifas.AllowUserToDeleteRows = false;
            this.grdTarifas.AllowUserToResizeColumns = false;
            this.grdTarifas.AllowUserToResizeRows = false;
            this.grdTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monto,
            this.TipoVisita,
            this.TipoEntrada,
            this.ListIndex});
            this.grdTarifas.Location = new System.Drawing.Point(44, 25);
            this.grdTarifas.Name = "grdTarifas";
            this.grdTarifas.ReadOnly = true;
            this.grdTarifas.RowHeadersWidth = 51;
            this.grdTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTarifas.Size = new System.Drawing.Size(552, 150);
            this.grdTarifas.TabIndex = 0;
            this.grdTarifas.Visible = false;
            this.grdTarifas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTarifas_CellClick);
            // 
            // lblTarifas
            // 
            this.lblTarifas.AutoSize = true;
            this.lblTarifas.Location = new System.Drawing.Point(41, 9);
            this.lblTarifas.Name = "lblTarifas";
            this.lblTarifas.Size = new System.Drawing.Size(39, 13);
            this.lblTarifas.TabIndex = 1;
            this.lblTarifas.Text = "Tarifas";
            // 
            // btnTomarTarifa
            // 
            this.btnTomarTarifa.Enabled = false;
            this.btnTomarTarifa.Location = new System.Drawing.Point(602, 25);
            this.btnTomarTarifa.Name = "btnTomarTarifa";
            this.btnTomarTarifa.Size = new System.Drawing.Size(138, 150);
            this.btnTomarTarifa.TabIndex = 2;
            this.btnTomarTarifa.Text = "Tomar seleccion";
            this.btnTomarTarifa.UseVisualStyleBackColor = true;
            this.btnTomarTarifa.Visible = false;
            this.btnTomarTarifa.Click += new System.EventHandler(this.TomarSeleccionTarifas);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(61, 191);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(108, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad de entradas";
            // 
            // btnCantidadEntradas
            // 
            this.btnCantidadEntradas.Enabled = false;
            this.btnCantidadEntradas.Location = new System.Drawing.Point(199, 239);
            this.btnCantidadEntradas.Name = "btnCantidadEntradas";
            this.btnCantidadEntradas.Size = new System.Drawing.Size(116, 55);
            this.btnCantidadEntradas.TabIndex = 5;
            this.btnCantidadEntradas.Text = "Tomar cantidad";
            this.btnCantidadEntradas.UseVisualStyleBackColor = true;
            this.btnCantidadEntradas.Click += new System.EventHandler(this.TomarCantidadEntradas);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(400, 192);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(84, 13);
            this.lblDetalle.TabIndex = 7;
            this.lblDetalle.Text = "Detalle entradas";
            this.lblDetalle.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(578, 217);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(122, 80);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.TomarConfirmacionVenta);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(424, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(397, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio Total";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(474, 246);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(88, 20);
            this.txtPrecioUnitario.TabIndex = 3;
            // 
            // txtCantidadAMostrar
            // 
            this.txtCantidadAMostrar.Enabled = false;
            this.txtCantidadAMostrar.Location = new System.Drawing.Point(474, 217);
            this.txtCantidadAMostrar.Name = "txtCantidadAMostrar";
            this.txtCantidadAMostrar.ReadOnly = true;
            this.txtCantidadAMostrar.Size = new System.Drawing.Size(88, 20);
            this.txtCantidadAMostrar.TabIndex = 3;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Enabled = false;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(474, 274);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(88, 23);
            this.txtPrecioTotal.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(64, 213);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(251, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 75;
            // 
            // TipoVisita
            // 
            this.TipoVisita.HeaderText = "Tipo de Visita";
            this.TipoVisita.MinimumWidth = 6;
            this.TipoVisita.Name = "TipoVisita";
            this.TipoVisita.ReadOnly = true;
            this.TipoVisita.Width = 200;
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.HeaderText = "Tipo de Entrada";
            this.TipoEntrada.MinimumWidth = 6;
            this.TipoEntrada.Name = "TipoEntrada";
            this.TipoEntrada.ReadOnly = true;
            this.TipoEntrada.Width = 200;
            // 
            // ListIndex
            // 
            this.ListIndex.HeaderText = "N";
            this.ListIndex.Name = "ListIndex";
            this.ListIndex.ReadOnly = true;
            this.ListIndex.Visible = false;
            // 
            // PantallaVentaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 328);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.btnCantidadEntradas);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.txtCantidadAMostrar);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.btnTomarTarifa);
            this.Controls.Add(this.lblTarifas);
            this.Controls.Add(this.grdTarifas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(50, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaVentaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PantallaVentaEntrada";
            this.Load += new System.EventHandler(this.PantallaVentaEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTarifas;
        private System.Windows.Forms.Label lblTarifas;
        private System.Windows.Forms.Button btnTomarTarifa;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCantidadEntradas;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtCantidadAMostrar;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListIndex;
    }
}