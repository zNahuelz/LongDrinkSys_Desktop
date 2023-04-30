namespace LongDrinkSys_Local.View
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBSalir = new System.Windows.Forms.ToolStripButton();
            this.lblDatos = new System.Windows.Forms.ToolStripLabel();
            this.tReloj = new System.Windows.Forms.Timer(this.components);
            this.tsBCursos = new System.Windows.Forms.ToolStripButton();
            this.tsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDatos,
            this.tsBCursos,
            this.tsBSalir});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(1123, 38);
            this.tsPrincipal.TabIndex = 1;
            this.tsPrincipal.Text = "Herramientas";
            // 
            // tsBSalir
            // 
            this.tsBSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsBSalir.Image")));
            this.tsBSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBSalir.Name = "tsBSalir";
            this.tsBSalir.Size = new System.Drawing.Size(41, 35);
            this.tsBSalir.Text = "SALIR";
            this.tsBSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBSalir.Click += new System.EventHandler(this.tsBSalir_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(148, 35);
            this.lblDatos.Text = "<-----CAMBIAR---->";
            // 
            // tReloj
            // 
            this.tReloj.Tick += new System.EventHandler(this.tReloj_Tick);
            // 
            // tsBCursos
            // 
            this.tsBCursos.Image = ((System.Drawing.Image)(resources.GetObject("tsBCursos.Image")));
            this.tsBCursos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBCursos.Name = "tsBCursos";
            this.tsBCursos.Size = new System.Drawing.Size(55, 35);
            this.tsBCursos.Text = "CURSOS";
            this.tsBCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBCursos.Click += new System.EventHandler(this.tsBCursos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 617);
            this.ControlBox = false;
            this.Controls.Add(this.tsPrincipal);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LONG DRINK BAR - ADMINISTRACIÓN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsBSalir;
        private System.Windows.Forms.ToolStripLabel lblDatos;
        private System.Windows.Forms.Timer tReloj;
        private System.Windows.Forms.ToolStripButton tsBCursos;
    }
}