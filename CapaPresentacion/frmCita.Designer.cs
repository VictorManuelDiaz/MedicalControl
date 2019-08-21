namespace CapaPresentacion
{
    partial class frmCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCita));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelVista = new System.Windows.Forms.Panel();
            this.dataGridViewCita = new System.Windows.Forms.DataGridView();
            this.panelRegistrar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTextBoxHoraC = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxIdMed = new System.Windows.Forms.ComboBox();
            this.comboBoxNumExp = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRealCita = new System.Windows.Forms.DateTimePicker();
            this.lblIdCita = new System.Windows.Forms.Label();
            this.txtbxIdCita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewCitasHoy = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtbxBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCita)).BeginInit();
            this.panelRegistrar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitasHoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 504);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelVista);
            this.tabPage1.Controls.Add(this.panelRegistrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cita";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelVista
            // 
            this.panelVista.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelVista.Controls.Add(this.btnEliminar);
            this.panelVista.Controls.Add(this.btnEditar);
            this.panelVista.Controls.Add(this.txtbxBuscar);
            this.panelVista.Controls.Add(this.dataGridViewCita);
            this.panelVista.Location = new System.Drawing.Point(-3, -19);
            this.panelVista.Name = "panelVista";
            this.panelVista.Size = new System.Drawing.Size(638, 497);
            this.panelVista.TabIndex = 8;
            // 
            // dataGridViewCita
            // 
            this.dataGridViewCita.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCita.Location = new System.Drawing.Point(21, 108);
            this.dataGridViewCita.Name = "dataGridViewCita";
            this.dataGridViewCita.Size = new System.Drawing.Size(592, 291);
            this.dataGridViewCita.TabIndex = 17;
            // 
            // panelRegistrar
            // 
            this.panelRegistrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelRegistrar.Controls.Add(this.btnRegistrar);
            this.panelRegistrar.Controls.Add(this.tableLayoutPanel1);
            this.panelRegistrar.Location = new System.Drawing.Point(632, -19);
            this.panelRegistrar.Name = "panelRegistrar";
            this.panelRegistrar.Size = new System.Drawing.Size(474, 503);
            this.panelRegistrar.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.84475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.15525F));
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxHoraC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxIdMed, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxNumExp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerRealCita, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIdCita, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbxIdCita, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 314);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // maskedTextBoxHoraC
            // 
            this.maskedTextBoxHoraC.Location = new System.Drawing.Point(148, 127);
            this.maskedTextBoxHoraC.Mask = "00:00";
            this.maskedTextBoxHoraC.Name = "maskedTextBoxHoraC";
            this.maskedTextBoxHoraC.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxHoraC.TabIndex = 3;
            this.maskedTextBoxHoraC.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxIdMed
            // 
            this.comboBoxIdMed.FormattingEnabled = true;
            this.comboBoxIdMed.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.comboBoxIdMed.Location = new System.Drawing.Point(148, 251);
            this.comboBoxIdMed.Name = "comboBoxIdMed";
            this.comboBoxIdMed.Size = new System.Drawing.Size(254, 21);
            this.comboBoxIdMed.TabIndex = 25;
            // 
            // comboBoxNumExp
            // 
            this.comboBoxNumExp.FormattingEnabled = true;
            this.comboBoxNumExp.Location = new System.Drawing.Point(148, 189);
            this.comboBoxNumExp.Name = "comboBoxNumExp";
            this.comboBoxNumExp.Size = new System.Drawing.Size(254, 21);
            this.comboBoxNumExp.TabIndex = 24;
            // 
            // dateTimePickerRealCita
            // 
            this.dateTimePickerRealCita.Location = new System.Drawing.Point(148, 65);
            this.dateTimePickerRealCita.Name = "dateTimePickerRealCita";
            this.dateTimePickerRealCita.Size = new System.Drawing.Size(254, 20);
            this.dateTimePickerRealCita.TabIndex = 22;
            // 
            // lblIdCita
            // 
            this.lblIdCita.AutoSize = true;
            this.lblIdCita.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCita.ForeColor = System.Drawing.Color.White;
            this.lblIdCita.Location = new System.Drawing.Point(3, 0);
            this.lblIdCita.Name = "lblIdCita";
            this.lblIdCita.Size = new System.Drawing.Size(22, 17);
            this.lblIdCita.TabIndex = 0;
            this.lblIdCita.Text = "Id:";
            // 
            // txtbxIdCita
            // 
            this.txtbxIdCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbxIdCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxIdCita.Location = new System.Drawing.Point(148, 3);
            this.txtbxIdCita.Name = "txtbxIdCita";
            this.txtbxIdCita.Size = new System.Drawing.Size(254, 22);
            this.txtbxIdCita.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id Médico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hora cita:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Número expediente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha cita:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage2.Controls.Add(this.dataGridViewCitasHoy);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1106, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Citas de hoy";
            // 
            // dataGridViewCitasHoy
            // 
            this.dataGridViewCitasHoy.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCitasHoy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCitasHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCitasHoy.Location = new System.Drawing.Point(43, 66);
            this.dataGridViewCitasHoy.Name = "dataGridViewCitasHoy";
            this.dataGridViewCitasHoy.Size = new System.Drawing.Size(997, 358);
            this.dataGridViewCitasHoy.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageActive = null;
            this.btnEliminar.Location = new System.Drawing.Point(78, 432);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 30);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Zoom = 10;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageActive = null;
            this.btnEditar.Location = new System.Drawing.Point(23, 432);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 30);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 26;
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
            this.txtbxBuscar.Location = new System.Drawing.Point(28, 50);
            this.txtbxBuscar.Name = "txtbxBuscar";
            this.txtbxBuscar.Size = new System.Drawing.Size(305, 32);
            this.txtbxBuscar.TabIndex = 20;
            this.txtbxBuscar.text = "";
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
            this.btnRegistrar.IconRightVisible = false;
            this.btnRegistrar.IconRightZoom = 0D;
            this.btnRegistrar.IconVisible = false;
            this.btnRegistrar.IconZoom = 50D;
            this.btnRegistrar.IsTab = false;
            this.btnRegistrar.Location = new System.Drawing.Point(103, 429);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistrar.selected = false;
            this.btnRegistrar.Size = new System.Drawing.Size(291, 48);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Textcolor = System.Drawing.Color.White;
            this.btnRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCita";
            this.Load += new System.EventHandler(this.frmCita_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCita)).EndInit();
            this.panelRegistrar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitasHoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelVista;
        private Bunifu.Framework.UI.BunifuImageButton btnEliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnEditar;
        private Bunifu.Framework.UI.BunifuTextbox txtbxBuscar;
        private System.Windows.Forms.DataGridView dataGridViewCita;
        private System.Windows.Forms.Panel panelRegistrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraC;
        private System.Windows.Forms.ComboBox comboBoxIdMed;
        private System.Windows.Forms.ComboBox comboBoxNumExp;
        private System.Windows.Forms.DateTimePicker dateTimePickerRealCita;
        private System.Windows.Forms.Label lblIdCita;
        private System.Windows.Forms.TextBox txtbxIdCita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewCitasHoy;
    }
}