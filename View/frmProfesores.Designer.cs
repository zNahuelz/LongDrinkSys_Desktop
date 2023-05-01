namespace LongDrinkSys_Local.View
{
    partial class frmProfesores
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.tcPrincipal.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tabPage2);
            this.tcPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(999, 572);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(991, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NUEVO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvProfesores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(991, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LISTAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(7, 7);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.Size = new System.Drawing.Size(978, 414);
            this.dgvProfesores.TabIndex = 0;
            // 
            // frmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1023, 596);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINITRACIÓN DE PROFESORES";
            this.Load += new System.EventHandler(this.frmProfesores_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvProfesores;
    }
}