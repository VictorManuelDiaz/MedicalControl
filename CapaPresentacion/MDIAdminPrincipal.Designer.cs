namespace CapaPresentacion
{
    partial class MDIAdminPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tlsInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMedicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsExpedientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsInicio,
            this.tlsMedicos,
            this.tlsPacientes,
            this.tlsCitas,
            this.tlsExpedientes,
            this.tlsCuentas,
            this.tlsSalir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tlsInicio
            // 
            this.tlsInicio.Name = "tlsInicio";
            this.tlsInicio.Size = new System.Drawing.Size(48, 20);
            this.tlsInicio.Text = "Inicio";
            this.tlsInicio.Click += new System.EventHandler(this.tlsInicio_Click);
            // 
            // tlsMedicos
            // 
            this.tlsMedicos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.tlsMedicos.Name = "tlsMedicos";
            this.tlsMedicos.Size = new System.Drawing.Size(64, 20);
            this.tlsMedicos.Text = "Médicos";
            this.tlsMedicos.Click += new System.EventHandler(this.tlsMedicos_Click);
            // 
            // tlsPacientes
            // 
            this.tlsPacientes.Name = "tlsPacientes";
            this.tlsPacientes.Size = new System.Drawing.Size(69, 20);
            this.tlsPacientes.Text = "Pacientes";
            this.tlsPacientes.Click += new System.EventHandler(this.tlsPacientes_Click);
            // 
            // tlsCitas
            // 
            this.tlsCitas.Name = "tlsCitas";
            this.tlsCitas.Size = new System.Drawing.Size(45, 20);
            this.tlsCitas.Text = "Citas";
            this.tlsCitas.Click += new System.EventHandler(this.tlsCitas_Click);
            // 
            // tlsExpedientes
            // 
            this.tlsExpedientes.Name = "tlsExpedientes";
            this.tlsExpedientes.Size = new System.Drawing.Size(81, 20);
            this.tlsExpedientes.Text = "Expedientes";
            this.tlsExpedientes.Click += new System.EventHandler(this.tlsExpedientes_Click);
            // 
            // tlsCuentas
            // 
            this.tlsCuentas.Name = "tlsCuentas";
            this.tlsCuentas.Size = new System.Drawing.Size(62, 20);
            this.tlsCuentas.Text = "Cuentas";
            this.tlsCuentas.Click += new System.EventHandler(this.tlsCuentas_Click_1);
            // 
            // tlsSalir
            // 
            this.tlsSalir.Name = "tlsSalir";
            this.tlsSalir.Size = new System.Drawing.Size(41, 20);
            this.tlsSalir.Text = "Salir";
            this.tlsSalir.Click += new System.EventHandler(this.tlsSalir_Click);
            // 
            // MDIAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Control";
            this.Load += new System.EventHandler(this.MDIAdminPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tlsMedicos;
        private System.Windows.Forms.ToolStripMenuItem tlsCitas;
        private System.Windows.Forms.ToolStripMenuItem tlsExpedientes;
        private System.Windows.Forms.ToolStripMenuItem tlsCuentas;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tlsSalir;
        private System.Windows.Forms.ToolStripMenuItem tlsPacientes;
        private System.Windows.Forms.ToolStripMenuItem tlsInicio;
    }
}



