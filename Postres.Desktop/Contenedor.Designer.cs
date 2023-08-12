namespace Postres.Desktop
{
    partial class Contenedor
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
            this.AsidePanel = new System.Windows.Forms.Panel();
            this.PostresButtom = new System.Windows.Forms.Button();
            this.PrincipalPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AsidePanel.SuspendLayout();
            this.PrincipalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsidePanel
            // 
            this.AsidePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.AsidePanel.Controls.Add(this.PostresButtom);
            this.AsidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AsidePanel.Location = new System.Drawing.Point(0, 0);
            this.AsidePanel.Name = "AsidePanel";
            this.AsidePanel.Size = new System.Drawing.Size(198, 634);
            this.AsidePanel.TabIndex = 0;
            // 
            // PostresButtom
            // 
            this.PostresButtom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PostresButtom.Location = new System.Drawing.Point(25, 117);
            this.PostresButtom.Name = "PostresButtom";
            this.PostresButtom.Size = new System.Drawing.Size(148, 40);
            this.PostresButtom.TabIndex = 0;
            this.PostresButtom.Text = "Postres";
            this.PostresButtom.UseVisualStyleBackColor = true;
            this.PostresButtom.Click += new System.EventHandler(this.PostresButtom_Click);
            // 
            // PrincipalPanel
            // 
            this.PrincipalPanel.Controls.Add(this.label1);
            this.PrincipalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrincipalPanel.Location = new System.Drawing.Point(198, 0);
            this.PrincipalPanel.Name = "PrincipalPanel";
            this.PrincipalPanel.Size = new System.Drawing.Size(838, 634);
            this.PrincipalPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 634);
            this.Controls.Add(this.PrincipalPanel);
            this.Controls.Add(this.AsidePanel);
            this.Name = "Contenedor";
            this.Text = "Form1";
            this.AsidePanel.ResumeLayout(false);
            this.PrincipalPanel.ResumeLayout(false);
            this.PrincipalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AsidePanel;
        private System.Windows.Forms.Button PostresButtom;
        private System.Windows.Forms.Panel PrincipalPanel;
        private System.Windows.Forms.Label label1;
    }
}

