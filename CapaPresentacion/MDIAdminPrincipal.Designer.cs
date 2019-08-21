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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIAdminPrincipal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picturebxCerrar = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tlsInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMedicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsExpedientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsConfiguraciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsRespaldo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebxCerrar)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.picturebxCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 36);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.logo_white_v2;
            this.pictureBox2.Location = new System.Drawing.Point(10, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(53, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 16);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Medical control";
            // 
            // picturebxCerrar
            // 
            this.picturebxCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.picturebxCerrar.Image = global::CapaPresentacion.Properties.Resources.cancel1;
            this.picturebxCerrar.Location = new System.Drawing.Point(1152, 9);
            this.picturebxCerrar.Name = "picturebxCerrar";
            this.picturebxCerrar.Size = new System.Drawing.Size(23, 17);
            this.picturebxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebxCerrar.TabIndex = 0;
            this.picturebxCerrar.TabStop = false;
            this.picturebxCerrar.Click += new System.EventHandler(this.picturebxCerrar_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsInicio,
            this.tlsCitas,
            this.tlsMedicos,
            this.tlsPacientes,
            this.tlsConsultas,
            this.tlsExpedientes,
            this.tlsConfiguraciones,
            this.tlsMantenimiento,
            this.tlsSalir});
            this.menuStrip.Location = new System.Drawing.Point(0, 36);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tlsInicio
            // 
            this.tlsInicio.Name = "tlsInicio";
            this.tlsInicio.Size = new System.Drawing.Size(48, 20);
            this.tlsInicio.Text = "Inicio";
            this.tlsInicio.Click += new System.EventHandler(this.tlsInicio_Click);
            // 
            // tlsCitas
            // 
            this.tlsCitas.Name = "tlsCitas";
            this.tlsCitas.Size = new System.Drawing.Size(45, 20);
            this.tlsCitas.Text = "Citas";
            this.tlsCitas.Click += new System.EventHandler(this.tlsCitas_Click);
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
            // tlsConsultas
            // 
            this.tlsConsultas.Name = "tlsConsultas";
            this.tlsConsultas.Size = new System.Drawing.Size(71, 20);
            this.tlsConsultas.Text = "Consultas";
            this.tlsConsultas.Click += new System.EventHandler(this.tlsConsultas_Click);
            // 
            // tlsExpedientes
            // 
            this.tlsExpedientes.Name = "tlsExpedientes";
            this.tlsExpedientes.Size = new System.Drawing.Size(81, 20);
            this.tlsExpedientes.Text = "Expedientes";
            this.tlsExpedientes.Click += new System.EventHandler(this.tlsExpedientes_Click);
            // 
            // tlsConfiguraciones
            // 
            this.tlsConfiguraciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsEspecialidades,
            this.tlsServicios,
            this.tlsUsuarios});
            this.tlsConfiguraciones.Name = "tlsConfiguraciones";
            this.tlsConfiguraciones.Size = new System.Drawing.Size(106, 20);
            this.tlsConfiguraciones.Text = "Configuraciones";
            // 
            // tlsEspecialidades
            // 
            this.tlsEspecialidades.Name = "tlsEspecialidades";
            this.tlsEspecialidades.Size = new System.Drawing.Size(175, 22);
            this.tlsEspecialidades.Text = "Especialidades";
            this.tlsEspecialidades.Click += new System.EventHandler(this.tlsEspecialidades_Click);
            // 
            // tlsServicios
            // 
            this.tlsServicios.Name = "tlsServicios";
            this.tlsServicios.Size = new System.Drawing.Size(175, 22);
            this.tlsServicios.Text = "Servicios";
            // 
            // tlsUsuarios
            // 
            this.tlsUsuarios.Name = "tlsUsuarios";
            this.tlsUsuarios.Size = new System.Drawing.Size(175, 22);
            this.tlsUsuarios.Text = "Cuentas de usuario";
            this.tlsUsuarios.Click += new System.EventHandler(this.tlsUsuarios_Click);
            // 
            // tlsMantenimiento
            // 
            this.tlsMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsRespaldo});
            this.tlsMantenimiento.Name = "tlsMantenimiento";
            this.tlsMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.tlsMantenimiento.Text = "Mantenimiento";
            // 
            // tlsRespaldo
            // 
            this.tlsRespaldo.Name = "tlsRespaldo";
            this.tlsRespaldo.Size = new System.Drawing.Size(140, 22);
            this.tlsRespaldo.Text = "Respaldo BD";
            this.tlsRespaldo.Click += new System.EventHandler(this.tlsRespaldo_Click);
            // 
            // tlsSalir
            // 
            this.tlsSalir.Name = "tlsSalir";
            this.tlsSalir.Size = new System.Drawing.Size(41, 20);
            this.tlsSalir.Text = "Salir";
            // 
            // MDIAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Control";
            this.Load += new System.EventHandler(this.MDIAdminPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebxCerrar)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picturebxCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tlsInicio;
        private System.Windows.Forms.ToolStripMenuItem tlsCitas;
        private System.Windows.Forms.ToolStripMenuItem tlsMedicos;
        private System.Windows.Forms.ToolStripMenuItem tlsPacientes;
        private System.Windows.Forms.ToolStripMenuItem tlsConsultas;
        private System.Windows.Forms.ToolStripMenuItem tlsExpedientes;
        private System.Windows.Forms.ToolStripMenuItem tlsConfiguraciones;
        private System.Windows.Forms.ToolStripMenuItem tlsEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tlsServicios;
        private System.Windows.Forms.ToolStripMenuItem tlsUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tlsMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tlsRespaldo;
        private System.Windows.Forms.ToolStripMenuItem tlsSalir;
    }
}



