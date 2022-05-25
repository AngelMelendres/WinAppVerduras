namespace WinAppVerduras
{
    partial class btnBuscar
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

            this.button1 = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
<<<<<<< HEAD
=======
=======


            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 144);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Empleados ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Eliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Location = new System.Drawing.Point(70, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 93);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.Eliminar.Location = new System.Drawing.Point(408, 28);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(114, 41);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(201, 28);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 41);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlContenedor.Controls.Add(this.dataGridView1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 144);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(684, 417);
            this.pnlContenedor.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 151);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnBuscar

            this.pnlLateral = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOtros = new System.Windows.Forms.Button();
            this.btnERepetición = new System.Windows.Forms.Button();
            this.btnEAlternativas = new System.Windows.Forms.Button();
            this.btnESecuenciales = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlPie = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.lblAdmin = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new WinAppVerduras.RJCircularPictureBox();
=======
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.button2 = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
<<<<<<< HEAD
            this.pnlLateral.SuspendLayout();
            this.pnlPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
            this.rjCircularPictureBox1 = new WinAppVerduras.RJCircularPictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pnlLateral.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.AutoScroll = true;
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.pnlLateral.Controls.Add(this.button1);
            this.pnlLateral.Controls.Add(this.btnSalir);
            this.pnlLateral.Controls.Add(this.btnOtros);
            this.pnlLateral.Controls.Add(this.btnERepetición);
            this.pnlLateral.Controls.Add(this.btnEAlternativas);
            this.pnlLateral.Controls.Add(this.btnESecuenciales);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(100, 569);
=======
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(133, 700);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.pnlLateral.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.button1.BackgroundImage = global::WinAppVerduras.Properties.Resources.report;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(28, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(42, 46);
=======
            this.button1.Location = new System.Drawing.Point(37, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(56, 57);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSalir.BackgroundImage = global::WinAppVerduras.Properties.Resources.SAlir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
<<<<<<< HEAD
            this.btnSalir.Location = new System.Drawing.Point(28, 504);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(42, 46);
=======
            this.btnSalir.Location = new System.Drawing.Point(37, 620);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(56, 57);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.btnSalir.TabIndex = 8;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnOtros
            // 
            this.btnOtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnOtros.BackgroundImage = global::WinAppVerduras.Properties.Resources.Usuario;
            this.btnOtros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOtros.FlatAppearance.BorderSize = 0;
            this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
<<<<<<< HEAD
            this.btnOtros.Location = new System.Drawing.Point(28, 240);
            this.btnOtros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnOtros.Size = new System.Drawing.Size(42, 46);
            this.btnOtros.TabIndex = 6;
            this.btnOtros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtros.UseVisualStyleBackColor = false;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
=======
            this.btnOtros.Location = new System.Drawing.Point(37, 295);
            this.btnOtros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnOtros.Size = new System.Drawing.Size(56, 57);
            this.btnOtros.TabIndex = 6;
            this.btnOtros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtros.UseVisualStyleBackColor = false;
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            // 
            // btnERepetición
            // 
            this.btnERepetición.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnERepetición.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnERepetición.BackgroundImage = global::WinAppVerduras.Properties.Resources.Ventas;
            this.btnERepetición.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnERepetición.FlatAppearance.BorderSize = 0;
            this.btnERepetición.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnERepetición.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
<<<<<<< HEAD
            this.btnERepetición.Location = new System.Drawing.Point(28, 301);
            this.btnERepetición.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnERepetición.Name = "btnERepetición";
            this.btnERepetición.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnERepetición.Size = new System.Drawing.Size(42, 46);
=======
            this.btnERepetición.Location = new System.Drawing.Point(37, 370);
            this.btnERepetición.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnERepetición.Name = "btnERepetición";
            this.btnERepetición.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnERepetición.Size = new System.Drawing.Size(56, 57);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.btnERepetición.TabIndex = 4;
            this.btnERepetición.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnERepetición.UseVisualStyleBackColor = false;
            // 
            // btnEAlternativas
            // 
            this.btnEAlternativas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEAlternativas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnEAlternativas.BackgroundImage = global::WinAppVerduras.Properties.Resources.Inicio;
            this.btnEAlternativas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEAlternativas.FlatAppearance.BorderSize = 0;
            this.btnEAlternativas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEAlternativas.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnEAlternativas.Location = new System.Drawing.Point(28, 116);
            this.btnEAlternativas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEAlternativas.Name = "btnEAlternativas";
            this.btnEAlternativas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEAlternativas.Size = new System.Drawing.Size(42, 46);
            this.btnEAlternativas.TabIndex = 2;
            this.btnEAlternativas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEAlternativas.UseVisualStyleBackColor = false;
            this.btnEAlternativas.Click += new System.EventHandler(this.btnEAlternativas_Click);
=======
            this.btnEAlternativas.Location = new System.Drawing.Point(37, 143);
            this.btnEAlternativas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEAlternativas.Name = "btnEAlternativas";
            this.btnEAlternativas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnEAlternativas.Size = new System.Drawing.Size(56, 57);
            this.btnEAlternativas.TabIndex = 2;
            this.btnEAlternativas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEAlternativas.UseVisualStyleBackColor = false;
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            // 
            // btnESecuenciales
            // 
            this.btnESecuenciales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnESecuenciales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnESecuenciales.BackgroundImage = global::WinAppVerduras.Properties.Resources.Cliente;
            this.btnESecuenciales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnESecuenciales.FlatAppearance.BorderSize = 0;
            this.btnESecuenciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESecuenciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
<<<<<<< HEAD
            this.btnESecuenciales.Location = new System.Drawing.Point(28, 176);
            this.btnESecuenciales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnESecuenciales.Name = "btnESecuenciales";
            this.btnESecuenciales.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnESecuenciales.Size = new System.Drawing.Size(42, 46);
=======
            this.btnESecuenciales.Location = new System.Drawing.Point(37, 217);
            this.btnESecuenciales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnESecuenciales.Name = "btnESecuenciales";
            this.btnESecuenciales.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnESecuenciales.Size = new System.Drawing.Size(56, 57);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.btnESecuenciales.TabIndex = 1;
            this.btnESecuenciales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnESecuenciales.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.pnlLogo.BackgroundImage = global::WinAppVerduras.Properties.Resources.Esta_es;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(100, 98);
=======
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(133, 121);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnlPie.Controls.Add(this.lblAdmin);
            this.pnlPie.Controls.Add(this.rjCircularPictureBox1);
            this.pnlPie.Controls.Add(this.button2);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Top;
<<<<<<< HEAD
            this.pnlPie.Location = new System.Drawing.Point(100, 0);
            this.pnlPie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(612, 71);
            this.pnlPie.TabIndex = 7;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(517, 24);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(52, 17);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Admin";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(460, 10);
            this.rjCircularPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(44, 44);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 7;
            this.rjCircularPictureBox1.TabStop = false;
            // 
=======
            this.pnlPie.Location = new System.Drawing.Point(133, 0);
            this.pnlPie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(816, 87);
            this.pnlPie.TabIndex = 7;
            // 
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.button2.Location = new System.Drawing.Point(688, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 19);
=======
            this.button2.Location = new System.Drawing.Point(917, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.DarkGray;
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Controls.Add(this.label3);
            this.pnlContenedor.Controls.Add(this.pictureBox1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
<<<<<<< HEAD
            this.pnlContenedor.Location = new System.Drawing.Point(100, 71);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(612, 498);
=======
            this.pnlContenedor.Location = new System.Drawing.Point(133, 87);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(816, 613);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.pnlContenedor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(127, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 90);
=======
            this.label2.Location = new System.Drawing.Point(169, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 115);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.label2.TabIndex = 1;
            this.label2.Text = "Escuela Superior Politécnica de Chimborazo\r\nFacultad de Informática y Electrónica" +
    "\r\nCarrera de Ingeniería en Software\r\n \r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(250, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 72);
=======
            this.label3.Location = new System.Drawing.Point(333, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 92);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.label3.TabIndex = 2;
            this.label3.Text = "\r\n10/05/2022\r\n \r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
<<<<<<< HEAD
            this.pictureBox1.Location = new System.Drawing.Point(212, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
=======
            this.pictureBox1.Location = new System.Drawing.Point(283, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(614, 12);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(58, 58);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 7;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(689, 30);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(61, 20);
            this.lblAdmin.TabIndex = 8;
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf

            // 
            // Form1

            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(542, 339);
=======
            //this.ClientSize = new System.Drawing.Size(542, 339);
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf
            this.Controls.Add(this.button1);


            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btnBuscar";
            this.Text = "Buscar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            this.ClientSize = new System.Drawing.Size(949, 700);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);

            this.Name = "Form1";
            this.Text = "Form1";
<<<<<<< HEAD
=======
            this.ClientSize = new System.Drawing.Size(712, 569);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlLateral.ResumeLayout(false);
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
=======
            this.pnlLateral.ResumeLayout(false);
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
>>>>>>> 2d5ebd002584ceac6b5360a6f58b8fe0058dd3cf

            this.ResumeLayout(false);

        }

        #endregion


        //private System.Windows.Forms.Button button1;


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnOtros;
        private System.Windows.Forms.Button btnERepetición;
        private System.Windows.Forms.Button btnEAlternativas;
        private System.Windows.Forms.Button btnESecuenciales;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdmin;
        private RJCircularPictureBox rjCircularPictureBox1;


    }
}

