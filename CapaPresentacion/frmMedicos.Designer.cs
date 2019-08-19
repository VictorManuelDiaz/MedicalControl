namespace CapaPresentacion
{
    partial class frmMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtbxBuscMed = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridViewMedico = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maskedtxtbxTelefonoMed = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxtbxCedMed = new System.Windows.Forms.MaskedTextBox();
            this.combobxEspe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxIdMedico = new System.Windows.Forms.TextBox();
            this.txtbxNombM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxApellM = new System.Windows.Forms.TextBox();
            this.txtbxCorreo = new System.Windows.Forms.TextBox();
            this.txtbxDirec = new System.Windows.Forms.TextBox();
            this.combobxSexo = new System.Windows.Forms.ComboBox();
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedico)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.txtbxBuscMed);
            this.panel2.Controls.Add(this.dataGridViewMedico);
            this.panel2.Location = new System.Drawing.Point(-19, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 500);
            this.panel2.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageActive = null;
            this.btnEliminar.Location = new System.Drawing.Point(88, 450);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 30);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Zoom = 10;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageActive = null;
            this.btnEditar.Location = new System.Drawing.Point(33, 450);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 30);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 28;
            this.btnEditar.TabStop = false;
            this.btnEditar.Zoom = 10;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtbxBuscMed
            // 
            this.txtbxBuscMed.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtbxBuscMed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbxBuscMed.BackgroundImage")));
            this.txtbxBuscMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbxBuscMed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBuscMed.ForeColor = System.Drawing.Color.White;
            this.txtbxBuscMed.Icon = ((System.Drawing.Image)(resources.GetObject("txtbxBuscMed.Icon")));
            this.txtbxBuscMed.Location = new System.Drawing.Point(32, 24);
            this.txtbxBuscMed.Name = "txtbxBuscMed";
            this.txtbxBuscMed.Size = new System.Drawing.Size(284, 34);
            this.txtbxBuscMed.TabIndex = 16;
            this.txtbxBuscMed.text = "";
            this.txtbxBuscMed.OnTextChange += new System.EventHandler(this.txtbxBuscMed_OnTextChange);
            // 
            // dataGridViewMedico
            // 
            this.dataGridViewMedico.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedico.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMedico.Location = new System.Drawing.Point(31, 69);
            this.dataGridViewMedico.Name = "dataGridViewMedico";
            this.dataGridViewMedico.Size = new System.Drawing.Size(613, 366);
            this.dataGridViewMedico.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(633, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 500);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "MÉDICOS";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRegistrar);
            this.panel3.Location = new System.Drawing.Point(33, 455);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 89);
            this.panel3.TabIndex = 25;
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
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btnRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistrar.selected = false;
            this.btnRegistrar.Size = new System.Drawing.Size(388, 41);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Textcolor = System.Drawing.Color.White;
            this.btnRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.84475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.15525F));
            this.tableLayoutPanel1.Controls.Add(this.maskedtxtbxTelefonoMed, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.maskedtxtbxCedMed, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.combobxEspe, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtbxIdMedico, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbxNombM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtbxApellM, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtbxCorreo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtbxDirec, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.combobxSexo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblIdMedico, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 384);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // maskedtxtbxTelefonoMed
            // 
            this.maskedtxtbxTelefonoMed.Location = new System.Drawing.Point(142, 213);
            this.maskedtxtbxTelefonoMed.Mask = "0000 0000";
            this.maskedtxtbxTelefonoMed.Name = "maskedtxtbxTelefonoMed";
            this.maskedtxtbxTelefonoMed.Size = new System.Drawing.Size(243, 20);
            this.maskedtxtbxTelefonoMed.TabIndex = 52;
            // 
            // maskedtxtbxCedMed
            // 
            this.maskedtxtbxCedMed.Location = new System.Drawing.Point(142, 255);
            this.maskedtxtbxCedMed.Mask = "000-000000-0000?";
            this.maskedtxtbxCedMed.Name = "maskedtxtbxCedMed";
            this.maskedtxtbxCedMed.Size = new System.Drawing.Size(243, 20);
            this.maskedtxtbxCedMed.TabIndex = 51;
            // 
            // combobxEspe
            // 
            this.combobxEspe.FormattingEnabled = true;
            this.combobxEspe.Location = new System.Drawing.Point(142, 129);
            this.combobxEspe.Name = "combobxEspe";
            this.combobxEspe.Size = new System.Drawing.Size(121, 21);
            this.combobxEspe.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(3, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtbxIdMedico
            // 
            this.txtbxIdMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbxIdMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxIdMedico.Location = new System.Drawing.Point(142, 3);
            this.txtbxIdMedico.Name = "txtbxIdMedico";
            this.txtbxIdMedico.Size = new System.Drawing.Size(243, 22);
            this.txtbxIdMedico.TabIndex = 3;
            // 
            // txtbxNombM
            // 
            this.txtbxNombM.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbxNombM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNombM.Location = new System.Drawing.Point(142, 45);
            this.txtbxNombM.Name = "txtbxNombM";
            this.txtbxNombM.Size = new System.Drawing.Size(243, 22);
            this.txtbxNombM.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono/Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Especialidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(3, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Correo electrónico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cédula:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(3, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Apellidos:";
            // 
            // txtbxApellM
            // 
            this.txtbxApellM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxApellM.Location = new System.Drawing.Point(142, 87);
            this.txtbxApellM.Name = "txtbxApellM";
            this.txtbxApellM.Size = new System.Drawing.Size(243, 21);
            this.txtbxApellM.TabIndex = 12;
            // 
            // txtbxCorreo
            // 
            this.txtbxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCorreo.Location = new System.Drawing.Point(142, 171);
            this.txtbxCorreo.Name = "txtbxCorreo";
            this.txtbxCorreo.Size = new System.Drawing.Size(243, 21);
            this.txtbxCorreo.TabIndex = 14;
            // 
            // txtbxDirec
            // 
            this.txtbxDirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDirec.Location = new System.Drawing.Point(142, 339);
            this.txtbxDirec.Multiline = true;
            this.txtbxDirec.Name = "txtbxDirec";
            this.txtbxDirec.Size = new System.Drawing.Size(243, 41);
            this.txtbxDirec.TabIndex = 18;
            // 
            // combobxSexo
            // 
            this.combobxSexo.FormattingEnabled = true;
            this.combobxSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.combobxSexo.Location = new System.Drawing.Point(142, 297);
            this.combobxSexo.Name = "combobxSexo";
            this.combobxSexo.Size = new System.Drawing.Size(121, 21);
            this.combobxSexo.TabIndex = 19;
            // 
            // lblIdMedico
            // 
            this.lblIdMedico.AutoSize = true;
            this.lblIdMedico.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMedico.ForeColor = System.Drawing.Color.Transparent;
            this.lblIdMedico.Location = new System.Drawing.Point(3, 0);
            this.lblIdMedico.Name = "lblIdMedico";
            this.lblIdMedico.Size = new System.Drawing.Size(22, 17);
            this.lblIdMedico.TabIndex = 0;
            this.lblIdMedico.Text = "Id:";
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médico";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTextbox txtbxBuscMed;
        private System.Windows.Forms.DataGridView dataGridViewMedico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox maskedtxtbxTelefonoMed;
        private System.Windows.Forms.MaskedTextBox maskedtxtbxCedMed;
        private System.Windows.Forms.ComboBox combobxEspe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxIdMedico;
        private System.Windows.Forms.TextBox txtbxNombM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxApellM;
        private System.Windows.Forms.TextBox txtbxCorreo;
        private System.Windows.Forms.TextBox txtbxDirec;
        private System.Windows.Forms.ComboBox combobxSexo;
        private System.Windows.Forms.Label lblIdMedico;
        private Bunifu.Framework.UI.BunifuImageButton btnEliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrar;
    }
}