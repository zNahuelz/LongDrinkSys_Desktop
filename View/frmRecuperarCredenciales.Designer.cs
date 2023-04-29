namespace LongDrinkSys_Local.View
{
    partial class frmRecuperarCredenciales
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
            this.pbPrincipal = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNC1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNC2 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCambiarC = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.Image = global::LongDrinkSys_Local.Properties.Resources.logo_longdrink_removebg_preview;
            this.pbPrincipal.Location = new System.Drawing.Point(12, 114);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(322, 133);
            this.pbPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrincipal.TabIndex = 0;
            this.pbPrincipal.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(385, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(367, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "RECUPERACIÓN DE CREDENCIALES";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(516, 116);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(203, 20);
            this.txtDNI.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(516, 83);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(203, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(468, 118);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(30, 16);
            this.lblContrasena.TabIndex = 7;
            this.lblContrasena.Text = "DNI";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(430, 85);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 16);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "USUARIO";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "NUEVA\r\nCONTRASEÑA\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNC1
            // 
            this.txtNC1.Location = new System.Drawing.Point(516, 157);
            this.txtNC1.Name = "txtNC1";
            this.txtNC1.PasswordChar = '*';
            this.txtNC1.Size = new System.Drawing.Size(203, 20);
            this.txtNC1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "REPETIR\r\nCONTRASEÑA\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNC2
            // 
            this.txtNC2.Location = new System.Drawing.Point(516, 198);
            this.txtNC2.Name = "txtNC2";
            this.txtNC2.PasswordChar = '*';
            this.txtNC2.Size = new System.Drawing.Size(203, 20);
            this.txtNC2.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(559, 241);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCambiarC
            // 
            this.btnCambiarC.Location = new System.Drawing.Point(559, 270);
            this.btnCambiarC.Name = "btnCambiarC";
            this.btnCambiarC.Size = new System.Drawing.Size(160, 23);
            this.btnCambiarC.TabIndex = 16;
            this.btnCambiarC.Text = "CAMBIAR CONTRASEÑA";
            this.btnCambiarC.UseVisualStyleBackColor = true;
            this.btnCambiarC.Click += new System.EventHandler(this.btnCambiarC_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(559, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRecuperarCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCambiarC);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNC2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperarCredenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LONG DRINK BAR - RECUPERACIÓN DE CRENDENCIALES";
            this.Load += new System.EventHandler(this.frmRecuperarCredenciales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNC1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNC2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCambiarC;
        private System.Windows.Forms.Button btnSalir;
    }
}