namespace LongDrinkSys_Local.View
{
    partial class frmCursos
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
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.gbSecundario = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescL = new System.Windows.Forms.TextBox();
            this.nudCostoL = new System.Windows.Forms.NumericUpDown();
            this.nudDuracionL = new System.Windows.Forms.NumericUpDown();
            this.cbEstadoL = new System.Windows.Forms.ComboBox();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.cbEditar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDL = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.gbPrincipal.SuspendLayout();
            this.gbSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracionL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tabPage2);
            this.tcPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(840, 561);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.cbEstado);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnCrear);
            this.tabPage1.Controls.Add(this.cbTurno);
            this.tabPage1.Controls.Add(this.nudDuracion);
            this.tabPage1.Controls.Add(this.nudCosto);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NUEVO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(257, 416);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(248, 21);
            this.cbEstado.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "ESTADO";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(463, 451);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 40);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(257, 451);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(165, 40);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "CREAR CURSO";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cbTurno
            // 
            this.cbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Location = new System.Drawing.Point(257, 378);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(248, 21);
            this.cbTurno.TabIndex = 10;
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(258, 337);
            this.nudDuracion.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDuracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(120, 20);
            this.nudDuracion.TabIndex = 9;
            this.nudDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCosto
            // 
            this.nudCosto.DecimalPlaces = 2;
            this.nudCosto.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCosto.Location = new System.Drawing.Point(258, 299);
            this.nudCosto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCosto.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(120, 20);
            this.nudCosto.TabIndex = 8;
            this.nudCosto.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(258, 168);
            this.txtDescripcion.MaxLength = 255;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(370, 111);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "TURNO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "DURACIÓN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "COSTO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "DESCRIPCIÓN";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(258, 129);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(370, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVO CURSO";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbSecundario);
            this.tabPage2.Controls.Add(this.gbPrincipal);
            this.tabPage2.Controls.Add(this.dgvCursos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LISTADO";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(6, 6);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(820, 364);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.txtIDL);
            this.gbPrincipal.Controls.Add(this.label12);
            this.gbPrincipal.Controls.Add(this.cbEstadoL);
            this.gbPrincipal.Controls.Add(this.nudDuracionL);
            this.gbPrincipal.Controls.Add(this.nudCostoL);
            this.gbPrincipal.Controls.Add(this.txtDescL);
            this.gbPrincipal.Controls.Add(this.label11);
            this.gbPrincipal.Controls.Add(this.label10);
            this.gbPrincipal.Controls.Add(this.label9);
            this.gbPrincipal.Controls.Add(this.label8);
            this.gbPrincipal.Location = new System.Drawing.Point(7, 377);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(643, 152);
            this.gbPrincipal.TabIndex = 1;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "DETALLES";
            // 
            // gbSecundario
            // 
            this.gbSecundario.Controls.Add(this.btnCancelar);
            this.gbSecundario.Controls.Add(this.btnEliminar);
            this.gbSecundario.Controls.Add(this.cbEditar);
            this.gbSecundario.Controls.Add(this.btnGuardarC);
            this.gbSecundario.Location = new System.Drawing.Point(657, 377);
            this.gbSecundario.Name = "gbSecundario";
            this.gbSecundario.Size = new System.Drawing.Size(169, 152);
            this.gbSecundario.TabIndex = 2;
            this.gbSecundario.TabStop = false;
            this.gbSecundario.Text = "HERRAMIENTAS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "DESCRIPCIÓN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(411, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "COSTO";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(387, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "DURACIÓN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(403, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "ESTADO";
            // 
            // txtDescL
            // 
            this.txtDescL.Location = new System.Drawing.Point(124, 27);
            this.txtDescL.MaxLength = 255;
            this.txtDescL.Multiline = true;
            this.txtDescL.Name = "txtDescL";
            this.txtDescL.Size = new System.Drawing.Size(235, 109);
            this.txtDescL.TabIndex = 4;
            // 
            // nudCostoL
            // 
            this.nudCostoL.DecimalPlaces = 2;
            this.nudCostoL.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCostoL.Location = new System.Drawing.Point(471, 27);
            this.nudCostoL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCostoL.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCostoL.Name = "nudCostoL";
            this.nudCostoL.Size = new System.Drawing.Size(146, 20);
            this.nudCostoL.TabIndex = 5;
            this.nudCostoL.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudDuracionL
            // 
            this.nudDuracionL.Location = new System.Drawing.Point(471, 57);
            this.nudDuracionL.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDuracionL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuracionL.Name = "nudDuracionL";
            this.nudDuracionL.Size = new System.Drawing.Size(147, 20);
            this.nudDuracionL.TabIndex = 6;
            this.nudDuracionL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbEstadoL
            // 
            this.cbEstadoL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoL.FormattingEnabled = true;
            this.cbEstadoL.Location = new System.Drawing.Point(472, 86);
            this.cbEstadoL.Name = "cbEstadoL";
            this.cbEstadoL.Size = new System.Drawing.Size(146, 21);
            this.cbEstadoL.TabIndex = 7;
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Location = new System.Drawing.Point(22, 57);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(125, 23);
            this.btnGuardarC.TabIndex = 0;
            this.btnGuardarC.Text = "GUARDAR CAMBIOS";
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // cbEditar
            // 
            this.cbEditar.AutoSize = true;
            this.cbEditar.Location = new System.Drawing.Point(51, 29);
            this.cbEditar.Name = "cbEditar";
            this.cbEditar.Size = new System.Drawing.Size(66, 17);
            this.cbEditar.TabIndex = 1;
            this.cbEditar.Text = "EDITAR";
            this.cbEditar.UseVisualStyleBackColor = true;
            this.cbEditar.CheckedChanged += new System.EventHandler(this.cbEditar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(22, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(22, 84);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(445, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "ID";
            // 
            // txtIDL
            // 
            this.txtIDL.Location = new System.Drawing.Point(472, 120);
            this.txtIDL.Name = "txtIDL";
            this.txtIDL.Size = new System.Drawing.Size(146, 20);
            this.txtIDL.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LongDrinkSys_Local.Properties.Resources.icons8_aula_100;
            this.pictureBox1.Location = new System.Drawing.Point(398, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(864, 585);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRACIÓN DE CURSOS";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.gbSecundario.ResumeLayout(false);
            this.gbSecundario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracionL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.NumericUpDown nudCosto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbSecundario;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstadoL;
        private System.Windows.Forms.NumericUpDown nudDuracionL;
        private System.Windows.Forms.NumericUpDown nudCostoL;
        private System.Windows.Forms.CheckBox cbEditar;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDL;
    }
}