namespace CapaPresentacion
{
    partial class frmCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentas));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tablepanelCuenta = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdCuen = new System.Windows.Forms.Label();
            this.lblFalloConf = new System.Windows.Forms.Label();
            this.cmbbxTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxConf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbxContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtbxIdCuen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxNomCuen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxContraActual = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCuentas = new System.Windows.Forms.DataGridView();
            this.btnEditarCuenta = new System.Windows.Forms.Button();
            this.txtbxBuscCuenta = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnEliminarCuenta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tablepanelCuenta.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(57, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tablepanelCuenta);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Location = new System.Drawing.Point(697, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 500);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(122, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "CUENTAS DE USUARIO";
            // 
            // tablepanelCuenta
            // 
            this.tablepanelCuenta.ColumnCount = 2;
            this.tablepanelCuenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.76731F));
            this.tablepanelCuenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.23269F));
            this.tablepanelCuenta.Controls.Add(this.lblIdCuen, 0, 0);
            this.tablepanelCuenta.Controls.Add(this.lblFalloConf, 1, 6);
            this.tablepanelCuenta.Controls.Add(this.cmbbxTipo, 1, 5);
            this.tablepanelCuenta.Controls.Add(this.label9, 0, 5);
            this.tablepanelCuenta.Controls.Add(this.txtbxConf, 1, 4);
            this.tablepanelCuenta.Controls.Add(this.label10, 0, 4);
            this.tablepanelCuenta.Controls.Add(this.txtbxContra, 1, 3);
            this.tablepanelCuenta.Controls.Add(this.lblContra, 0, 3);
            this.tablepanelCuenta.Controls.Add(this.txtbxIdCuen, 1, 0);
            this.tablepanelCuenta.Controls.Add(this.label7, 0, 1);
            this.tablepanelCuenta.Controls.Add(this.txtbxNomCuen, 1, 1);
            this.tablepanelCuenta.Controls.Add(this.label1, 0, 2);
            this.tablepanelCuenta.Controls.Add(this.txtbxContraActual, 1, 2);
            this.tablepanelCuenta.Location = new System.Drawing.Point(23, 58);
            this.tablepanelCuenta.Name = "tablepanelCuenta";
            this.tablepanelCuenta.RowCount = 7;
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28449F));
            this.tablepanelCuenta.Size = new System.Drawing.Size(361, 263);
            this.tablepanelCuenta.TabIndex = 0;
            // 
            // lblIdCuen
            // 
            this.lblIdCuen.AutoSize = true;
            this.lblIdCuen.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCuen.ForeColor = System.Drawing.Color.White;
            this.lblIdCuen.Location = new System.Drawing.Point(3, 0);
            this.lblIdCuen.Name = "lblIdCuen";
            this.lblIdCuen.Size = new System.Drawing.Size(22, 17);
            this.lblIdCuen.TabIndex = 5;
            this.lblIdCuen.Text = "Id:";
            // 
            // lblFalloConf
            // 
            this.lblFalloConf.AutoSize = true;
            this.lblFalloConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalloConf.ForeColor = System.Drawing.Color.Red;
            this.lblFalloConf.Location = new System.Drawing.Point(160, 222);
            this.lblFalloConf.Name = "lblFalloConf";
            this.lblFalloConf.Size = new System.Drawing.Size(163, 30);
            this.lblFalloConf.TabIndex = 9;
            this.lblFalloConf.Text = "La contraseña indicada no coincide con la confirmación";
            this.lblFalloConf.Visible = false;
            // 
            // cmbbxTipo
            // 
            this.cmbbxTipo.FormattingEnabled = true;
            this.cmbbxTipo.Items.AddRange(new object[] {
            "Administrador",
            "Estándar"});
            this.cmbbxTipo.Location = new System.Drawing.Point(160, 188);
            this.cmbbxTipo.Name = "cmbbxTipo";
            this.cmbbxTipo.Size = new System.Drawing.Size(198, 21);
            this.cmbbxTipo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo de cuenta:";
            // 
            // txtbxConf
            // 
            this.txtbxConf.Location = new System.Drawing.Point(160, 151);
            this.txtbxConf.Name = "txtbxConf";
            this.txtbxConf.Size = new System.Drawing.Size(197, 20);
            this.txtbxConf.TabIndex = 3;
            this.txtbxConf.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Confirmar contraseña:";
            // 
            // txtbxContra
            // 
            this.txtbxContra.Location = new System.Drawing.Point(160, 114);
            this.txtbxContra.Name = "txtbxContra";
            this.txtbxContra.Size = new System.Drawing.Size(197, 20);
            this.txtbxContra.TabIndex = 2;
            this.txtbxContra.UseSystemPasswordChar = true;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.White;
            this.lblContra.Location = new System.Drawing.Point(3, 111);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(77, 17);
            this.lblContra.TabIndex = 7;
            this.lblContra.Text = "Contraseña:";
            // 
            // txtbxIdCuen
            // 
            this.txtbxIdCuen.Location = new System.Drawing.Point(160, 3);
            this.txtbxIdCuen.Name = "txtbxIdCuen";
            this.txtbxIdCuen.Size = new System.Drawing.Size(198, 20);
            this.txtbxIdCuen.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre cuenta:";
            // 
            // txtbxNomCuen
            // 
            this.txtbxNomCuen.Location = new System.Drawing.Point(160, 40);
            this.txtbxNomCuen.Name = "txtbxNomCuen";
            this.txtbxNomCuen.Size = new System.Drawing.Size(197, 20);
            this.txtbxNomCuen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña Actual:";
            // 
            // txtbxContraActual
            // 
            this.txtbxContraActual.Location = new System.Drawing.Point(160, 77);
            this.txtbxContraActual.Name = "txtbxContraActual";
            this.txtbxContraActual.Size = new System.Drawing.Size(197, 20);
            this.txtbxContraActual.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoEllipsis = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(19, 353);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(361, 35);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.dataGridViewCuentas);
            this.panel2.Controls.Add(this.btnEditarCuenta);
            this.panel2.Controls.Add(this.txtbxBuscCuenta);
            this.panel2.Controls.Add(this.btnEliminarCuenta);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 500);
            this.panel2.TabIndex = 16;
            // 
            // dataGridViewCuentas
            // 
            this.dataGridViewCuentas.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuentas.Location = new System.Drawing.Point(3, 112);
            this.dataGridViewCuentas.Name = "dataGridViewCuentas";
            this.dataGridViewCuentas.Size = new System.Drawing.Size(692, 276);
            this.dataGridViewCuentas.TabIndex = 12;
            // 
            // btnEditarCuenta
            // 
            this.btnEditarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCuenta.Location = new System.Drawing.Point(95, 416);
            this.btnEditarCuenta.Name = "btnEditarCuenta";
            this.btnEditarCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCuenta.TabIndex = 9;
            this.btnEditarCuenta.Text = "Editar";
            this.btnEditarCuenta.UseVisualStyleBackColor = true;
            this.btnEditarCuenta.Click += new System.EventHandler(this.btnEditarCuenta_Click);
            // 
            // txtbxBuscCuenta
            // 
            this.txtbxBuscCuenta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtbxBuscCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbxBuscCuenta.BackgroundImage")));
            this.txtbxBuscCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbxBuscCuenta.ForeColor = System.Drawing.Color.White;
            this.txtbxBuscCuenta.Icon = ((System.Drawing.Image)(resources.GetObject("txtbxBuscCuenta.Icon")));
            this.txtbxBuscCuenta.Location = new System.Drawing.Point(86, 27);
            this.txtbxBuscCuenta.Name = "txtbxBuscCuenta";
            this.txtbxBuscCuenta.Size = new System.Drawing.Size(420, 42);
            this.txtbxBuscCuenta.TabIndex = 11;
            this.txtbxBuscCuenta.text = "";
            this.txtbxBuscCuenta.OnTextChange += new System.EventHandler(this.txtbxBuscCuenta_OnTextChange);
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCuenta.Location = new System.Drawing.Point(3, 417);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCuenta.TabIndex = 8;
            this.btnEliminarCuenta.Text = "Eliminar";
            this.btnEliminarCuenta.UseVisualStyleBackColor = true;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tablepanelCuenta.ResumeLayout(false);
            this.tablepanelCuenta.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tablepanelCuenta;
        private System.Windows.Forms.Label lblIdCuen;
        private System.Windows.Forms.Label lblFalloConf;
        private System.Windows.Forms.ComboBox cmbbxTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxConf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbxContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtbxIdCuen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxNomCuen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxContraActual;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewCuentas;
        private System.Windows.Forms.Button btnEditarCuenta;
        private Bunifu.Framework.UI.BunifuTextbox txtbxBuscCuenta;
        private System.Windows.Forms.Button btnEliminarCuenta;
    }
}