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
            this.tabControlRegistro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.combobxEspe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxNomCuen = new System.Windows.Forms.TextBox();
            this.txtbxNomb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxApell = new System.Windows.Forms.TextBox();
            this.txtbxCorreo = new System.Windows.Forms.TextBox();
            this.txtbxCel = new System.Windows.Forms.TextBox();
            this.txtbxCed = new System.Windows.Forms.TextBox();
            this.txtbxDirec = new System.Windows.Forms.TextBox();
            this.combobxSexo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewMedico = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControlRegistro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRegistro
            // 
            this.tabControlRegistro.Controls.Add(this.tabPage1);
            this.tabControlRegistro.Controls.Add(this.tabPage2);
            this.tabControlRegistro.Controls.Add(this.tabPage3);
            this.tabControlRegistro.Controls.Add(this.tabPage4);
            this.tabControlRegistro.Location = new System.Drawing.Point(-3, 0);
            this.tabControlRegistro.Name = "tabControlRegistro";
            this.tabControlRegistro.SelectedIndex = 0;
            this.tabControlRegistro.Size = new System.Drawing.Size(787, 563);
            this.tabControlRegistro.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo médico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(357, 495);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 33);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.84475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.15525F));
            this.tableLayoutPanel1.Controls.Add(this.combobxEspe, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtbxNomCuen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbxNomb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtbxApell, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtbxCorreo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtbxCel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtbxCed, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtbxDirec, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.combobxSexo, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(91, 30);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 448);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // combobxEspe
            // 
            this.combobxEspe.FormattingEnabled = true;
            this.combobxEspe.Location = new System.Drawing.Point(170, 150);
            this.combobxEspe.Name = "combobxEspe";
            this.combobxEspe.Size = new System.Drawing.Size(121, 21);
            this.combobxEspe.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtbxNomCuen
            // 
            this.txtbxNomCuen.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbxNomCuen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNomCuen.Location = new System.Drawing.Point(170, 3);
            this.txtbxNomCuen.Name = "txtbxNomCuen";
            this.txtbxNomCuen.Size = new System.Drawing.Size(293, 22);
            this.txtbxNomCuen.TabIndex = 3;
            // 
            // txtbxNomb
            // 
            this.txtbxNomb.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbxNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNomb.Location = new System.Drawing.Point(170, 52);
            this.txtbxNomb.Name = "txtbxNomb";
            this.txtbxNomb.Size = new System.Drawing.Size(293, 22);
            this.txtbxNomb.TabIndex = 4;
            this.txtbxNomb.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono/Celular";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Especialidad";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Correo electrónico";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cédula";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Apellidos";
            // 
            // txtbxApell
            // 
            this.txtbxApell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxApell.Location = new System.Drawing.Point(170, 101);
            this.txtbxApell.Name = "txtbxApell";
            this.txtbxApell.Size = new System.Drawing.Size(293, 21);
            this.txtbxApell.TabIndex = 12;
            // 
            // txtbxCorreo
            // 
            this.txtbxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCorreo.Location = new System.Drawing.Point(170, 199);
            this.txtbxCorreo.Name = "txtbxCorreo";
            this.txtbxCorreo.Size = new System.Drawing.Size(293, 21);
            this.txtbxCorreo.TabIndex = 14;
            // 
            // txtbxCel
            // 
            this.txtbxCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCel.Location = new System.Drawing.Point(170, 248);
            this.txtbxCel.Name = "txtbxCel";
            this.txtbxCel.Size = new System.Drawing.Size(293, 21);
            this.txtbxCel.TabIndex = 15;
            // 
            // txtbxCed
            // 
            this.txtbxCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCed.Location = new System.Drawing.Point(170, 297);
            this.txtbxCed.Name = "txtbxCed";
            this.txtbxCed.Size = new System.Drawing.Size(293, 21);
            this.txtbxCed.TabIndex = 16;
            // 
            // txtbxDirec
            // 
            this.txtbxDirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDirec.Location = new System.Drawing.Point(170, 395);
            this.txtbxDirec.Multiline = true;
            this.txtbxDirec.Name = "txtbxDirec";
            this.txtbxDirec.Size = new System.Drawing.Size(293, 41);
            this.txtbxDirec.TabIndex = 18;
            // 
            // combobxSexo
            // 
            this.combobxSexo.FormattingEnabled = true;
            this.combobxSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.combobxSexo.Location = new System.Drawing.Point(170, 346);
            this.combobxSexo.Name = "combobxSexo";
            this.combobxSexo.Size = new System.Drawing.Size(121, 21);
            this.combobxSexo.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewMedico);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Todos los médicos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMedico
            // 
            this.dataGridViewMedico.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedico.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMedico.Location = new System.Drawing.Point(37, 23);
            this.dataGridViewMedico.Name = "dataGridViewMedico";
            this.dataGridViewMedico.Size = new System.Drawing.Size(702, 283);
            this.dataGridViewMedico.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Médicos en turno";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(779, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nueva cita";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControlRegistro);
            this.Name = "frmMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            this.tabControlRegistro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControlRegistro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxNomCuen;
        private System.Windows.Forms.TextBox txtbxNomb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxApell;
        private System.Windows.Forms.TextBox txtbxCorreo;
        private System.Windows.Forms.TextBox txtbxCel;
        private System.Windows.Forms.TextBox txtbxCed;
        private System.Windows.Forms.TextBox txtbxDirec;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox combobxSexo;
        private System.Windows.Forms.ComboBox combobxEspe;
        private System.Windows.Forms.DataGridView dataGridViewMedico;
    }
}