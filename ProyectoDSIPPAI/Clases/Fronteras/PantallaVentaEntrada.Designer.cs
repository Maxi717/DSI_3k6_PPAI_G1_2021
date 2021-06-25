
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
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTarifas = new System.Windows.Forms.Label();
            this.btnTomarTarifa = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCantidadEntradas = new System.Windows.Forms.Button();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.NumeroEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieneGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTarifas
            // 
            this.grdTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.TipoVisita,
            this.Tipo,
            this.Guia});
            this.grdTarifas.Location = new System.Drawing.Point(44, 73);
            this.grdTarifas.Name = "grdTarifas";
            this.grdTarifas.ReadOnly = true;
            this.grdTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTarifas.Size = new System.Drawing.Size(442, 150);
            this.grdTarifas.TabIndex = 0;
            this.grdTarifas.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // TipoVisita
            // 
            this.TipoVisita.HeaderText = "Tipo visita";
            this.TipoVisita.Name = "TipoVisita";
            this.TipoVisita.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo ";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Guia
            // 
            this.Guia.HeaderText = "ConGuia";
            this.Guia.Name = "Guia";
            this.Guia.ReadOnly = true;
            // 
            // lblTarifas
            // 
            this.lblTarifas.AutoSize = true;
            this.lblTarifas.Location = new System.Drawing.Point(41, 48);
            this.lblTarifas.Name = "lblTarifas";
            this.lblTarifas.Size = new System.Drawing.Size(39, 13);
            this.lblTarifas.TabIndex = 1;
            this.lblTarifas.Text = "Tarifas";
            // 
            // btnTomarTarifa
            // 
            this.btnTomarTarifa.Location = new System.Drawing.Point(371, 244);
            this.btnTomarTarifa.Name = "btnTomarTarifa";
            this.btnTomarTarifa.Size = new System.Drawing.Size(115, 23);
            this.btnTomarTarifa.TabIndex = 2;
            this.btnTomarTarifa.Text = "Tomar seleccion";
            this.btnTomarTarifa.UseVisualStyleBackColor = true;
            this.btnTomarTarifa.Visible = false;
            this.btnTomarTarifa.Click += new System.EventHandler(this.btnTomarTarifa_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(41, 333);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(108, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad de entradas";
            this.lblCantidad.Visible = false;
            // 
            // btnCantidadEntradas
            // 
            this.btnCantidadEntradas.Location = new System.Drawing.Point(275, 326);
            this.btnCantidadEntradas.Name = "btnCantidadEntradas";
            this.btnCantidadEntradas.Size = new System.Drawing.Size(103, 23);
            this.btnCantidadEntradas.TabIndex = 5;
            this.btnCantidadEntradas.Text = "Tomar cantidad";
            this.btnCantidadEntradas.UseVisualStyleBackColor = true;
            this.btnCantidadEntradas.Visible = false;
            this.btnCantidadEntradas.Click += new System.EventHandler(this.btnCantidadEntradas_Click);
            // 
            // grdDetalle
            // 
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroEntrada,
            this.Tarifa,
            this.TipoDeVisita,
            this.TipoEntrada,
            this.TieneGuia});
            this.grdDetalle.Location = new System.Drawing.Point(44, 405);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.Size = new System.Drawing.Size(535, 103);
            this.grdDetalle.TabIndex = 6;
            this.grdDetalle.Visible = false;
            // 
            // NumeroEntrada
            // 
            this.NumeroEntrada.HeaderText = "Numero";
            this.NumeroEntrada.Name = "NumeroEntrada";
            // 
            // Tarifa
            // 
            this.Tarifa.HeaderText = "Column1";
            this.Tarifa.Name = "Tarifa";
            // 
            // TipoDeVisita
            // 
            this.TipoDeVisita.HeaderText = "Column1";
            this.TipoDeVisita.Name = "TipoDeVisita";
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.HeaderText = "Column1";
            this.TipoEntrada.Name = "TipoEntrada";
            // 
            // TieneGuia
            // 
            this.TieneGuia.HeaderText = "Column1";
            this.TieneGuia.Name = "TieneGuia";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(41, 378);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(84, 13);
            this.lblDetalle.TabIndex = 7;
            this.lblDetalle.Text = "Detalle entradas";
            this.lblDetalle.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(624, 446);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(155, 328);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.ValidatingType = typeof(int);
            // 
            // PantallaVentaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 520);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.btnCantidadEntradas);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnTomarTarifa);
            this.Controls.Add(this.lblTarifas);
            this.Controls.Add(this.grdTarifas);
            this.Name = "PantallaVentaEntrada";
            this.Text = "PantallaVentaEntrada";
            this.Load += new System.EventHandler(this.PantallaVentaEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTarifas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guia;
        private System.Windows.Forms.Label lblTarifas;
        private System.Windows.Forms.Button btnTomarTarifa;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCantidadEntradas;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieneGuia;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
    }
}