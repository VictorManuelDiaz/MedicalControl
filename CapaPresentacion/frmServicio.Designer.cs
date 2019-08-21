namespace CapaPresentacion
{
    partial class frmServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxCosto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIdSer = new System.Windows.Forms.Label();
            this.txtbxIdSer = new System.Windows.Forms.TextBox();
            this.txtbxNombreSer = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtbxBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridViewServicio = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(695, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 500);
            this.panel1.TabIndex = 28;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Activecolor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.BorderRadius = 3;
            this.btnRegistrar.ButtonText = "Registrar";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.DisabledColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Iconimage = global::CapaPresentacion.Properties.Resources.save;
            this.btnRegistrar.Iconimage_right = null;
            this.btnRegistrar.Iconimage_right_Selected = null;
            this.btnRegistrar.Iconimage_Selected = null;
            this.btnRegistrar.IconMarginLeft = 0;
            this.btnRegistrar.IconMarginRight = 0;
            this.btnRegistrar.IconRightVisible = true;
            this.btnRegistrar.IconRightZoom = 0D;
            this.btnRegistrar.IconVisible = true;
            this.btnRegistrar.IconZoom = 50D;
            this.btnRegistrar.IsTab = false;
            this.btnRegistrar.Location = new System.Drawing.Point(58, 415);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistrar.selected = false;
            this.btnRegistrar.Size = new System.Drawing.Size(291, 48);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Textcolor = System.Drawing.Color.White;
            this.btnRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.76731F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.23269F));
            this.tableLayoutPanel2.Controls.Add(this.txtbxCosto, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblIdSer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbxIdSer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbxNombreSer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCosto, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 167);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 120);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtbxCosto
            // 
            this.txtbxCosto.Location = new System.Drawing.Point(160, 81);
            this.txtbxCosto.Name = "txtbxCosto";
            this.txtbxCosto.Size = new System.Drawing.Size(197, 20);
            this.txtbxCosto.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre servicio";
            // 
            // lblIdSer
            // 
            this.lblIdSer.AutoSize = true;
            this.lblIdSer.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSer.ForeColor = System.Drawing.Color.White;
            this.lblIdSer.Location = new System.Drawing.Point(3, 0);
            this.lblIdSer.Name = "lblIdSer";
            this.lblIdSer.Size = new System.Drawing.Size(22, 17);
            this.lblIdSer.TabIndex = 5;
            this.lblIdSer.Text = "Id:";
            // 
            // txtbxIdSer
            // 
            this.txtbxIdSer.Location = new System.Drawing.Point(160, 3);
            this.txtbxIdSer.Name = "txtbxIdSer";
            this.txtbxIdSer.Size = new System.Drawing.Size(198, 20);
            this.txtbxIdSer.TabIndex = 0;
            // 
            // txtbxNombreSer
            // 
            this.txtbxNombreSer.Location = new System.Drawing.Point(160, 42);
            this.txtbxNombreSer.Name = "txtbxNombreSer";
            this.txtbxNombreSer.Size = new System.Drawing.Size(197, 20);
            this.txtbxNombreSer.TabIndex = 1;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.Color.White;
            this.lblCosto.Location = new System.Drawing.Point(3, 78);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(112, 17);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "Costo del servicio";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.txtbxBuscar);
            this.panel2.Controls.Add(this.dataGridViewServicio);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 500);
            this.panel2.TabIndex = 29;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageActive = null;
            this.btnEditar.Location = new System.Drawing.Point(29, 431);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 30);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 24;
            this.btnEditar.TabStop = false;
            this.btnEditar.Zoom = 10;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtbxBuscar
            // 
            this.txtbxBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtbxBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbxBuscar.BackgroundImage")));
            this.txtbxBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbxBuscar.ForeColor = System.Drawing.Color.White;
            this.txtbxBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtbxBuscar.Icon")));
            this.txtbxBuscar.Location = new System.Drawing.Point(29, 41);
            this.txtbxBuscar.Name = "txtbxBuscar";
            this.txtbxBuscar.Size = new System.Drawing.Size(305, 32);
            this.txtbxBuscar.TabIndex = 20;
            this.txtbxBuscar.text = "";
            this.txtbxBuscar.OnTextChange += new System.EventHandler(this.txtbxBuscar_OnTextChange);
            // 
            // dataGridViewServicio
            // 
            this.dataGridViewServicio.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewServicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicio.Location = new System.Drawing.Point(29, 92);
            this.dataGridViewServicio.Name = "dataGridViewServicio";
            this.dataGridViewServicio.Size = new System.Drawing.Size(628, 319);
            this.dataGridViewServicio.TabIndex = 19;
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServicio";
            this.Load += new System.EventHandler(this.frmServicio_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtbxCosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIdSer;
        private System.Windows.Forms.TextBox txtbxIdSer;
        private System.Windows.Forms.TextBox txtbxNombreSer;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnEditar;
        private Bunifu.Framework.UI.BunifuTextbox txtbxBuscar;
        private System.Windows.Forms.DataGridView dataGridViewServicio;
    }
}