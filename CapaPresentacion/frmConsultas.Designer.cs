namespace CapaPresentacion
{
    partial class frmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxMedi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxDiag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxSinto = new System.Windows.Forms.TextBox();
            this.txtbxCosto = new System.Windows.Forms.TextBox();
            this.txtbxIdConsul = new System.Windows.Forms.TextBox();
            this.lblIdConsul = new System.Windows.Forms.Label();
            this.datetimepickerFecha = new System.Windows.Forms.DateTimePicker();
            this.maskedtxtbxHora = new System.Windows.Forms.MaskedTextBox();
            this.txtbxPresent = new System.Windows.Forms.TextBox();
            this.cmbbxIdExpe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtbxBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridViewConsult = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(695, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 500);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRegistrar);
            this.panel3.Location = new System.Drawing.Point(76, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 97);
            this.panel3.TabIndex = 31;
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
            this.btnRegistrar.Size = new System.Drawing.Size(274, 52);
            this.btnRegistrar.TabIndex = 29;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Textcolor = System.Drawing.Color.White;
            this.btnRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.13044F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.86956F));
            this.tableLayoutPanel2.Controls.Add(this.txtbxMedi, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtbxDiag, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtbxSinto, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtbxCosto, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtbxIdConsul, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIdConsul, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.datetimepickerFecha, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.maskedtxtbxHora, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtbxPresent, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.cmbbxIdExpe, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(26, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.882479F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.882485F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.882485F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.882485F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.56744F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.56744F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.56886F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.882485F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.883826F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 342);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // txtbxMedi
            // 
            this.txtbxMedi.Location = new System.Drawing.Point(134, 229);
            this.txtbxMedi.Multiline = true;
            this.txtbxMedi.Name = "txtbxMedi";
            this.txtbxMedi.Size = new System.Drawing.Size(190, 32);
            this.txtbxMedi.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Medicamentos:";
            // 
            // txtbxDiag
            // 
            this.txtbxDiag.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbxDiag.Location = new System.Drawing.Point(134, 176);
            this.txtbxDiag.Multiline = true;
            this.txtbxDiag.Name = "txtbxDiag";
            this.txtbxDiag.Size = new System.Drawing.Size(199, 32);
            this.txtbxDiag.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Presentación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Diagnóstico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Síntomas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // txtbxSinto
            // 
            this.txtbxSinto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbxSinto.Location = new System.Drawing.Point(134, 123);
            this.txtbxSinto.Multiline = true;
            this.txtbxSinto.Name = "txtbxSinto";
            this.txtbxSinto.Size = new System.Drawing.Size(199, 32);
            this.txtbxSinto.TabIndex = 1;
            // 
            // txtbxCosto
            // 
            this.txtbxCosto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbxCosto.Location = new System.Drawing.Point(134, 93);
            this.txtbxCosto.Name = "txtbxCosto";
            this.txtbxCosto.Size = new System.Drawing.Size(199, 20);
            this.txtbxCosto.TabIndex = 1;
            // 
            // txtbxIdConsul
            // 
            this.txtbxIdConsul.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbxIdConsul.Location = new System.Drawing.Point(134, 3);
            this.txtbxIdConsul.Name = "txtbxIdConsul";
            this.txtbxIdConsul.Size = new System.Drawing.Size(199, 20);
            this.txtbxIdConsul.TabIndex = 1;
            // 
            // lblIdConsul
            // 
            this.lblIdConsul.AutoSize = true;
            this.lblIdConsul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdConsul.ForeColor = System.Drawing.Color.White;
            this.lblIdConsul.Location = new System.Drawing.Point(3, 0);
            this.lblIdConsul.Name = "lblIdConsul";
            this.lblIdConsul.Size = new System.Drawing.Size(76, 17);
            this.lblIdConsul.TabIndex = 0;
            this.lblIdConsul.Text = "Id Consulta:";
            // 
            // datetimepickerFecha
            // 
            this.datetimepickerFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.datetimepickerFecha.Location = new System.Drawing.Point(134, 33);
            this.datetimepickerFecha.Name = "datetimepickerFecha";
            this.datetimepickerFecha.Size = new System.Drawing.Size(199, 20);
            this.datetimepickerFecha.TabIndex = 2;
            // 
            // maskedtxtbxHora
            // 
            this.maskedtxtbxHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.maskedtxtbxHora.Location = new System.Drawing.Point(134, 63);
            this.maskedtxtbxHora.Mask = "00:00";
            this.maskedtxtbxHora.Name = "maskedtxtbxHora";
            this.maskedtxtbxHora.Size = new System.Drawing.Size(199, 20);
            this.maskedtxtbxHora.TabIndex = 3;
            this.maskedtxtbxHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtbxPresent
            // 
            this.txtbxPresent.Location = new System.Drawing.Point(134, 282);
            this.txtbxPresent.Name = "txtbxPresent";
            this.txtbxPresent.Size = new System.Drawing.Size(199, 20);
            this.txtbxPresent.TabIndex = 34;
            // 
            // cmbbxIdExpe
            // 
            this.cmbbxIdExpe.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbbxIdExpe.FormattingEnabled = true;
            this.cmbbxIdExpe.Location = new System.Drawing.Point(134, 312);
            this.cmbbxIdExpe.Name = "cmbbxIdExpe";
            this.cmbbxIdExpe.Size = new System.Drawing.Size(199, 21);
            this.cmbbxIdExpe.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Id Expediente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.txtbxBuscar);
            this.panel1.Controls.Add(this.dataGridViewConsult);
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 501);
            this.panel1.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageActive = null;
            this.btnEliminar.Location = new System.Drawing.Point(100, 453);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 30);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Zoom = 10;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageActive = null;
            this.btnEditar.Location = new System.Drawing.Point(45, 453);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 30);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 29;
            this.btnEditar.TabStop = false;
            this.btnEditar.Zoom = 10;
            // 
            // txtbxBuscar
            // 
            this.txtbxBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtbxBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbxBuscar.BackgroundImage")));
            this.txtbxBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbxBuscar.ForeColor = System.Drawing.Color.White;
            this.txtbxBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtbxBuscar.Icon")));
            this.txtbxBuscar.Location = new System.Drawing.Point(45, 43);
            this.txtbxBuscar.Name = "txtbxBuscar";
            this.txtbxBuscar.Size = new System.Drawing.Size(305, 32);
            this.txtbxBuscar.TabIndex = 28;
            this.txtbxBuscar.text = "";
            // 
            // dataGridViewConsult
            // 
            this.dataGridViewConsult.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsult.Location = new System.Drawing.Point(45, 104);
            this.dataGridViewConsult.Name = "dataGridViewConsult";
            this.dataGridViewConsult.Size = new System.Drawing.Size(628, 319);
            this.dataGridViewConsult.TabIndex = 22;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIdConsul;
        private System.Windows.Forms.TextBox txtbxCosto;
        private System.Windows.Forms.TextBox txtbxSinto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimepickerFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedtxtbxHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewConsult;
        private Bunifu.Framework.UI.BunifuTextbox txtbxBuscar;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtbxDiag;
        private System.Windows.Forms.TextBox txtbxIdConsul;
        private Bunifu.Framework.UI.BunifuImageButton btnEliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnEditar;
        private System.Windows.Forms.TextBox txtbxMedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxPresent;
        private System.Windows.Forms.ComboBox cmbbxIdExpe;
        private System.Windows.Forms.Label label8;
    }
}