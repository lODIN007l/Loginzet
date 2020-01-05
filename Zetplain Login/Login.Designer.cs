namespace Zetplain_Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Logo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btENTRAR = new System.Windows.Forms.Button();
            this.Recuperar = new System.Windows.Forms.LinkLabel();
            this.cerrarlogin = new System.Windows.Forms.PictureBox();
            this.minimizarlogin = new System.Windows.Forms.PictureBox();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.RoyalBlue;
            this.Logo.Controls.Add(this.pictureBox2);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 380);
            this.Logo.TabIndex = 0;
            this.Logo.Paint += new System.Windows.Forms.PaintEventHandler(this.Logo_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 380);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("LCDMono2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(271, 101);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(431, 29);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "USER";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("LCDMono2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(271, 167);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(431, 29);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "PASSWORD";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(446, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "LOGIN";
            // 
            // btENTRAR
            // 
            this.btENTRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btENTRAR.FlatAppearance.BorderSize = 0;
            this.btENTRAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btENTRAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btENTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btENTRAR.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btENTRAR.ForeColor = System.Drawing.Color.LightGray;
            this.btENTRAR.Location = new System.Drawing.Point(308, 244);
            this.btENTRAR.Name = "btENTRAR";
            this.btENTRAR.Size = new System.Drawing.Size(394, 40);
            this.btENTRAR.TabIndex = 3;
            this.btENTRAR.Text = "INGRESAR";
            this.btENTRAR.UseVisualStyleBackColor = false;
            // 
            // Recuperar
            // 
            this.Recuperar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Recuperar.AutoSize = true;
            this.Recuperar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recuperar.ForeColor = System.Drawing.Color.DimGray;
            this.Recuperar.LinkColor = System.Drawing.Color.DimGray;
            this.Recuperar.Location = new System.Drawing.Point(424, 298);
            this.Recuperar.Name = "Recuperar";
            this.Recuperar.Size = new System.Drawing.Size(185, 17);
            this.Recuperar.TabIndex = 7;
            this.Recuperar.TabStop = true;
            this.Recuperar.Text = "¿Ha olvida su contraseña ?";
            // 
            // cerrarlogin
            // 
            this.cerrarlogin.Image = ((System.Drawing.Image)(resources.GetObject("cerrarlogin.Image")));
            this.cerrarlogin.Location = new System.Drawing.Point(729, 0);
            this.cerrarlogin.Name = "cerrarlogin";
            this.cerrarlogin.Size = new System.Drawing.Size(19, 18);
            this.cerrarlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarlogin.TabIndex = 8;
            this.cerrarlogin.TabStop = false;
            this.cerrarlogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimizarlogin
            // 
            this.minimizarlogin.Image = ((System.Drawing.Image)(resources.GetObject("minimizarlogin.Image")));
            this.minimizarlogin.Location = new System.Drawing.Point(704, 0);
            this.minimizarlogin.Name = "minimizarlogin";
            this.minimizarlogin.Size = new System.Drawing.Size(19, 18);
            this.minimizarlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarlogin.TabIndex = 9;
            this.minimizarlogin.TabStop = false;
            this.minimizarlogin.Click += new System.EventHandler(this.minimizarlogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(750, 380);
            this.Controls.Add(this.minimizarlogin);
            this.Controls.Add(this.cerrarlogin);
            this.Controls.Add(this.Recuperar);
            this.Controls.Add(this.btENTRAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarlogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btENTRAR;
        private System.Windows.Forms.LinkLabel Recuperar;
        private System.Windows.Forms.PictureBox cerrarlogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox minimizarlogin;
    }
}

