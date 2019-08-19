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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridViewCuentas = new System.Windows.Forms.DataGridView();
            this.txtbxBuscCuenta = new Bunifu.Framework.UI.BunifuTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAsignar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbbxCuenta = new System.Windows.Forms.ComboBox();
            this.cmbbxMed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tablepanelCuenta.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuentas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tablepanelCuenta);
            this.panel1.Location = new System.Drawing.Point(635, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 480);
            this.panel1.TabIndex = 17;
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
            this.btnRegistrar.Location = new System.Drawing.Point(99, 387);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(166, 49);
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
            this.tablepanelCuenta.Controls.Add(this.lblFalloConf, 1, 5);
            this.tablepanelCuenta.Controls.Add(this.cmbbxTipo, 1, 4);
            this.tablepanelCuenta.Controls.Add(this.label9, 0, 4);
            this.tablepanelCuenta.Controls.Add(this.txtbxConf, 1, 3);
            this.tablepanelCuenta.Controls.Add(this.label10, 0, 3);
            this.tablepanelCuenta.Controls.Add(this.txtbxContra, 1, 2);
            this.tablepanelCuenta.Controls.Add(this.lblContra, 0, 2);
            this.tablepanelCuenta.Controls.Add(this.txtbxIdCuen, 1, 0);
            this.tablepanelCuenta.Controls.Add(this.label7, 0, 1);
            this.tablepanelCuenta.Controls.Add(this.txtbxNomCuen, 1, 1);
            this.tablepanelCuenta.Location = new System.Drawing.Point(67, 91);
            this.tablepanelCuenta.Name = "tablepanelCuenta";
            this.tablepanelCuenta.RowCount = 6;
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66528F));
            this.tablepanelCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.lblFalloConf.Location = new System.Drawing.Point(160, 215);
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
            this.cmbbxTipo.Location = new System.Drawing.Point(160, 175);
            this.cmbbxTipo.Name = "cmbbxTipo";
            this.cmbbxTipo.Size = new System.Drawing.Size(198, 21);
            this.cmbbxTipo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo de cuenta:";
            // 
            // txtbxConf
            // 
            this.txtbxConf.Location = new System.Drawing.Point(160, 132);
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
            this.label10.Location = new System.Drawing.Point(3, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Confirmar contraseña:";
            // 
            // txtbxContra
            // 
            this.txtbxContra.Location = new System.Drawing.Point(160, 89);
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
            this.lblContra.Location = new System.Drawing.Point(3, 86);
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
            this.label7.Location = new System.Drawing.Point(3, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre cuenta:";
            // 
            // txtbxNomCuen
            // 
            this.txtbxNomCuen.Location = new System.Drawing.Point(160, 46);
            this.txtbxNomCuen.Name = "txtbxNomCuen";
            this.txtbxNomCuen.Size = new System.Drawing.Size(197, 20);
            this.txtbxNomCuen.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.dataGridViewCuentas);
            this.panel2.Controls.Add(this.txtbxBuscCuenta);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 484);
            this.panel2.TabIndex = 18;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageActive = null;
            this.btnEliminar.Location = new System.Drawing.Point(79, 405);
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
            this.btnEditar.Location = new System.Drawing.Point(24, 405);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 30);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 28;
            this.btnEditar.TabStop = false;
            this.btnEditar.Zoom = 10;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGridViewCuentas
            // 
            this.dataGridViewCuentas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuentas.Location = new System.Drawing.Point(23, 112);
            this.dataGridViewCuentas.Name = "dataGridViewCuentas";
            this.dataGridViewCuentas.Size = new System.Drawing.Size(597, 276);
            this.dataGridViewCuentas.TabIndex = 12;
            // 
            // txtbxBuscCuenta
            // 
            this.txtbxBuscCuenta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtbxBuscCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbxBuscCuenta.BackgroundImage")));
            this.txtbxBuscCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbxBuscCuenta.ForeColor = System.Drawing.Color.White;
            this.txtbxBuscCuenta.Icon = ((System.Drawing.Image)(resources.GetObject("txtbxBuscCuenta.Icon")));
            this.txtbxBuscCuenta.Location = new System.Drawing.Point(28, 51);
            this.txtbxBuscCuenta.Name = "txtbxBuscCuenta";
            this.txtbxBuscCuenta.Size = new System.Drawing.Size(366, 42);
            this.txtbxBuscCuenta.TabIndex = 11;
            this.txtbxBuscCuenta.text = "";
            this.txtbxBuscCuenta.OnTextChange += new System.EventHandler(this.txtbxBuscCuenta_OnTextChange);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1106, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignar cuentas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.btnAsignar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1106, 486);
            this.panel3.TabIndex = 19;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Activecolor = System.Drawing.Color.DarkBlue;
            this.btnAsignar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAsignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignar.BorderRadius = 3;
            this.btnAsignar.ButtonText = "Asignar";
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.DisabledColor = System.Drawing.Color.MidnightBlue;
            this.btnAsignar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAsignar.Iconimage = global::CapaPresentacion.Properties.Resources.save;
            this.btnAsignar.Iconimage_right = null;
            this.btnAsignar.Iconimage_right_Selected = null;
            this.btnAsignar.Iconimage_Selected = null;
            this.btnAsignar.IconMarginLeft = 0;
            this.btnAsignar.IconMarginRight = 0;
            this.btnAsignar.IconRightVisible = true;
            this.btnAsignar.IconRightZoom = 0D;
            this.btnAsignar.IconVisible = true;
            this.btnAsignar.IconZoom = 50D;
            this.btnAsignar.IsTab = false;
            this.btnAsignar.Location = new System.Drawing.Point(385, 352);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnAsignar.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnAsignar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAsignar.selected = false;
            this.btnAsignar.Size = new System.Drawing.Size(291, 48);
            this.btnAsignar.TabIndex = 24;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAsignar.Textcolor = System.Drawing.Color.White;
            this.btnAsignar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(461, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "CUENTAS DE USUARIO";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.76731F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.23269F));
            this.tableLayoutPanel2.Controls.Add(this.cmbbxCuenta, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbbxMed, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(362, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 98);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cmbbxCuenta
            // 
            this.cmbbxCuenta.FormattingEnabled = true;
            this.cmbbxCuenta.Location = new System.Drawing.Point(160, 3);
            this.cmbbxCuenta.Name = "cmbbxCuenta";
            this.cmbbxCuenta.Size = new System.Drawing.Size(198, 21);
            this.cmbbxCuenta.TabIndex = 32;
            // 
            // cmbbxMed
            // 
            this.cmbbxMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbbxMed.FormattingEnabled = true;
            this.cmbbxMed.Location = new System.Drawing.Point(160, 52);
            this.cmbbxMed.Name = "cmbbxMed";
            this.cmbbxMed.Size = new System.Drawing.Size(198, 21);
            this.cmbbxMed.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuenta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Médico:";
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tablepanelCuenta.ResumeLayout(false);
            this.tablepanelCuenta.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnEliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnEditar;
        private System.Windows.Forms.DataGridView dataGridViewCuentas;
        private Bunifu.Framework.UI.BunifuTextbox txtbxBuscCuenta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbbxMed;
        private System.Windows.Forms.ComboBox cmbbxCuenta;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAsignar;
    }
}