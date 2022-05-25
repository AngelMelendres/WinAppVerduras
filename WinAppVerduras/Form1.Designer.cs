namespace WinAppVerduras
{
    partial class Form1
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
=======
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOtros = new System.Windows.Forms.Button();
            this.btnERepetición = new System.Windows.Forms.Button();
            this.btnEAlternativas = new System.Windows.Forms.Button();
            this.btnESecuenciales = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new WinAppVerduras.RJCircularPictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLateral.SuspendLayout();
            this.pnlPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(100, 569);
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
            this.button1.Location = new System.Drawing.Point(28, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(42, 46);
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
            this.btnSalir.Location = new System.Drawing.Point(28, 504);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(42, 46);
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
            this.btnOtros.Location = new System.Drawing.Point(28, 240);
            this.btnOtros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnOtros.Size = new System.Drawing.Size(42, 46);
            this.btnOtros.TabIndex = 6;
            this.btnOtros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtros.UseVisualStyleBackColor = false;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
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
            this.btnERepetición.Location = new System.Drawing.Point(28, 301);
            this.btnERepetición.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnERepetición.Name = "btnERepetición";
            this.btnERepetición.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnERepetición.Size = new System.Drawing.Size(42, 46);
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
            this.btnEAlternativas.Location = new System.Drawing.Point(28, 116);
            this.btnEAlternativas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEAlternativas.Name = "btnEAlternativas";
            this.btnEAlternativas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEAlternativas.Size = new System.Drawing.Size(42, 46);
            this.btnEAlternativas.TabIndex = 2;
            this.btnEAlternativas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEAlternativas.UseVisualStyleBackColor = false;
            this.btnEAlternativas.Click += new System.EventHandler(this.btnEAlternativas_Click);
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
            this.btnESecuenciales.Location = new System.Drawing.Point(28, 176);
            this.btnESecuenciales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnESecuenciales.Name = "btnESecuenciales";
            this.btnESecuenciales.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnESecuenciales.Size = new System.Drawing.Size(42, 46);
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
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(100, 98);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnlPie.Controls.Add(this.lblAdmin);
            this.pnlPie.Controls.Add(this.rjCircularPictureBox1);
            this.pnlPie.Controls.Add(this.button2);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Top;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(688, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 19);
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
            this.pnlContenedor.Location = new System.Drawing.Point(100, 71);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(612, 498);
            this.pnlContenedor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escuela Superior Politécnica de Chimborazo\r\nFacultad de Informática y Electrónica" +
    "\r\nCarrera de Ingeniería en Software\r\n \r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 72);
            this.label3.TabIndex = 2;
            this.label3.Text = "\r\n10/05/2022\r\n \r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(212, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(542, 339);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
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

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}

