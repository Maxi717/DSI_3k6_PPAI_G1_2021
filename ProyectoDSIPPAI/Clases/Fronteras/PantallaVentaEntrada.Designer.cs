
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCantidadEntradas = new System.Windows.Forms.Button();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.NumeroEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieneGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTarifas
            // 
            this.grdTarifas.AllowUserToAddRows = false;
            this.grdTarifas.AllowUserToDeleteRows = false;
            this.grdTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.TipoVisita,
            this.TipoEntrada,
            this.Guia});
            this.grdTarifas.Location = new System.Drawing.Point(59, 90);
            this.grdTarifas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTarifas.Name = "grdTarifas";
            this.grdTarifas.ReadOnly = true;
            this.grdTarifas.RowHeadersWidth = 51;
            this.grdTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTarifas.Size = new System.Drawing.Size(589, 185);
            this.grdTarifas.TabIndex = 0;
            this.grdTarifas.Visible = false;
            // 
            // lblTarifas
            // 
            this.lblTarifas.AutoSize = true;
            this.lblTarifas.Location = new System.Drawing.Point(55, 59);
            this.lblTarifas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarifas.Name = "lblTarifas";
            this.lblTarifas.Size = new System.Drawing.Size(52, 17);
            this.lblTarifas.TabIndex = 1;
            this.lblTarifas.Text = "Tarifas";
            // 
            // btnTomarTarifa
            // 
            this.btnTomarTarifa.Location = new System.Drawing.Point(495, 300);
            this.btnTomarTarifa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTomarTarifa.Name = "btnTomarTarifa";
            this.btnTomarTarifa.Size = new System.Drawing.Size(153, 28);
            this.btnTomarTarifa.TabIndex = 2;
            this.btnTomarTarifa.Text = "Tomar seleccion";
            this.btnTomarTarifa.UseVisualStyleBackColor = true;
            this.btnTomarTarifa.Visible = false;
            this.btnTomarTarifa.Click += new System.EventHandler(this.btnTomarTarifa_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(207, 406);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 22);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(55, 410);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(144, 17);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad de entradas";
            this.lblCantidad.Visible = false;
            // 
            // btnCantidadEntradas
            // 
            this.btnCantidadEntradas.Location = new System.Drawing.Point(367, 401);
            this.btnCantidadEntradas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCantidadEntradas.Name = "btnCantidadEntradas";
            this.btnCantidadEntradas.Size = new System.Drawing.Size(137, 28);
            this.btnCantidadEntradas.TabIndex = 5;
            this.btnCantidadEntradas.Text = "Tomar cantidad";
            this.btnCantidadEntradas.UseVisualStyleBackColor = true;
            this.btnCantidadEntradas.Visible = false;
            this.btnCantidadEntradas.Click += new System.EventHandler(this.btnCantidadEntradas_Click);
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroEntrada,
            this.Tarifa,
            this.TipoDeVisita,
            this.TipoDeEntrada,
            this.TieneGuia});
            this.grdDetalle.Location = new System.Drawing.Point(59, 498);
            this.grdDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersWidth = 51;
            this.grdDetalle.Size = new System.Drawing.Size(713, 127);
            this.grdDetalle.TabIndex = 6;
            this.grdDetalle.Visible = false;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(55, 465);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(112, 17);
            this.lblDetalle.TabIndex = 7;
            this.lblDetalle.Text = "Detalle entradas";
            this.lblDetalle.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(828, 535);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // NumeroEntrada
            // 
            this.NumeroEntrada.HeaderText = "Numero";
            this.NumeroEntrada.MinimumWidth = 6;
            this.NumeroEntrada.Name = "NumeroEntrada";
            this.NumeroEntrada.ReadOnly = true;
            this.NumeroEntrada.Width = 125;
            // 
            // Tarifa
            // 
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.MinimumWidth = 6;
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.ReadOnly = true;
            this.Tarifa.Width = 125;
            // 
            // TipoDeVisita
            // 
            this.TipoDeVisita.HeaderText = "Tipo de Visita";
            this.TipoDeVisita.MinimumWidth = 6;
            this.TipoDeVisita.Name = "TipoDeVisita";
            this.TipoDeVisita.ReadOnly = true;
            this.TipoDeVisita.Width = 125;
            // 
            // TipoDeEntrada
            // 
            this.TipoDeEntrada.HeaderText = "Tipo de Entrada";
            this.TipoDeEntrada.MinimumWidth = 6;
            this.TipoDeEntrada.Name = "TipoDeEntrada";
            this.TipoDeEntrada.ReadOnly = true;
            this.TipoDeEntrada.Width = 125;
            // 
            // TieneGuia
            // 
            this.TieneGuia.HeaderText = "Guia";
            this.TieneGuia.MinimumWidth = 6;
            this.TieneGuia.Name = "TieneGuia";
            this.TieneGuia.ReadOnly = true;
            this.TieneGuia.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // TipoVisita
            // 
            this.TipoVisita.HeaderText = "Tipo de Visita";
            this.TipoVisita.MinimumWidth = 6;
            this.TipoVisita.Name = "TipoVisita";
            this.TipoVisita.ReadOnly = true;
            this.TipoVisita.Width = 125;
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.HeaderText = "Tipo de Entrada";
            this.TipoEntrada.MinimumWidth = 6;
            this.TipoEntrada.Name = "TipoEntrada";
            this.TipoEntrada.ReadOnly = true;
            this.TipoEntrada.Width = 125;
            // 
            // Guia
            // 
            this.Guia.HeaderText = "ConGuia";
            this.Guia.MinimumWidth = 6;
            this.Guia.Name = "Guia";
            this.Guia.ReadOnly = true;
            this.Guia.Width = 125;
            // 
            // PantallaVentaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 640);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.btnCantidadEntradas);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnTomarTarifa);
            this.Controls.Add(this.lblTarifas);
            this.Controls.Add(this.grdTarifas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblTarifas;
        private System.Windows.Forms.Button btnTomarTarifa;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCantidadEntradas;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieneGuia;
    }
}