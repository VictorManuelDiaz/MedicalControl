﻿namespace CapaPresentacion
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tlsInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMedicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsExpedientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsRespaldo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.picturebxCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebxCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsInicio,
            this.tlsCitas,
            this.tlsMedicos,
            this.tlsPacientes,
            this.tlsExpedientes,
            this.tlsCuentas,
            this.mantenimientoToolStripMenuItem,
            this.tlsSalir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1185, 24);
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
            // tlsExpedientes
            // 
            this.tlsExpedientes.Name = "tlsExpedientes";
            this.tlsExpedientes.Size = new System.Drawing.Size(81, 20);
            this.tlsExpedientes.Text = "Expedientes";
            this.tlsExpedientes.Click += new System.EventHandler(this.tlsExpedientes_Click);
            // 
            // tlsCuentas
            // 
            this.tlsCuentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsEspecialidades,
            this.tlsServicios,
            this.tlsUsuarios});
            this.tlsCuentas.Name = "tlsCuentas";
            this.tlsCuentas.Size = new System.Drawing.Size(106, 20);
            this.tlsCuentas.Text = "Configuraciones";
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
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsRespaldo});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // tlsRespaldo
            // 
            this.tlsRespaldo.Name = "tlsRespaldo";
            this.tlsRespaldo.Size = new System.Drawing.Size(152, 22);
            this.tlsRespaldo.Text = "Respaldo BD";
            this.tlsRespaldo.Click += new System.EventHandler(this.tlsRespaldo_Click);
            // 
            // tlsSalir
            // 
            this.tlsSalir.Name = "tlsSalir";
            this.tlsSalir.Size = new System.Drawing.Size(41, 20);
            this.tlsSalir.Text = "Salir";
            this.tlsSalir.Click += new System.EventHandler(this.tlsSalir_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.picturebxCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 36);
            this.panel1.TabIndex = 5;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.menuStrip);
            this.panel2.Location = new System.Drawing.Point(-1, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 24);
            this.panel2.TabIndex = 6;
            // 
            // MDIAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Control";
            this.Load += new System.EventHandler(this.MDIAdminPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebxCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripMenuItem tlsEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tlsServicios;
        private System.Windows.Forms.ToolStripMenuItem tlsUsuarios;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picturebxCerrar;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlsRespaldo;
    }
}



