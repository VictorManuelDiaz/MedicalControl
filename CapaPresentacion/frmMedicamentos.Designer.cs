namespace CapaPresentacion
{
    partial class frmMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicamentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbxBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridViewMedica = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedica)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.txtbxBuscar);
            this.panel1.Controls.Add(this.dataGridViewMedica);
            this.panel1.Location = new System.Drawing.Point(-11, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 503);
            this.panel1.TabIndex = 3;
            // 
            // txtbxBuscar
            // 
            this.txtbxBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtbxBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbxBuscar.BackgroundImage")));
            this.txtbxBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbxBuscar.ForeColor = System.Drawing.Color.White;
            this.txtbxBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtbxBuscar.Icon")));
            this.txtbxBuscar.Location = new System.Drawing.Point(277, 63);
            this.txtbxBuscar.Name = "txtbxBuscar";
            this.txtbxBuscar.Size = new System.Drawing.Size(305, 32);
            this.txtbxBuscar.TabIndex = 28;
            this.txtbxBuscar.text = "";
            this.txtbxBuscar.OnTextChange += new System.EventHandler(this.txtbxBuscar_OnTextChange);
            // 
            // dataGridViewMedica
            // 
            this.dataGridViewMedica.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMedica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMedica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedica.Location = new System.Drawing.Point(277, 115);
            this.dataGridViewMedica.Name = "dataGridViewMedica";
            this.dataGridViewMedica.Size = new System.Drawing.Size(628, 319);
            this.dataGridViewMedica.TabIndex = 22;
            // 
            // frmMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMedicamentos";
            this.Load += new System.EventHandler(this.frmMedicamentos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox txtbxBuscar;
        private System.Windows.Forms.DataGridView dataGridViewMedica;
    }
}