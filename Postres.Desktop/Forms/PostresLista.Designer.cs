namespace Postres.Desktop.Forms
{
    partial class PostresLista
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridPostres = new System.Windows.Forms.DataGridView();
            this.AtrasBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPostres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista De Postres";
            // 
            // DataGridPostres
            // 
            this.DataGridPostres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPostres.Location = new System.Drawing.Point(47, 106);
            this.DataGridPostres.Name = "DataGridPostres";
            this.DataGridPostres.RowHeadersWidth = 62;
            this.DataGridPostres.RowTemplate.Height = 28;
            this.DataGridPostres.Size = new System.Drawing.Size(754, 267);
            this.DataGridPostres.TabIndex = 1;
            this.DataGridPostres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPostres_CellContentClick);
            // 
            // AtrasBtn
            // 
            this.AtrasBtn.Location = new System.Drawing.Point(60, 403);
            this.AtrasBtn.Name = "AtrasBtn";
            this.AtrasBtn.Size = new System.Drawing.Size(110, 42);
            this.AtrasBtn.TabIndex = 2;
            this.AtrasBtn.Text = "Nuevo";
            this.AtrasBtn.UseVisualStyleBackColor = true;
            this.AtrasBtn.Click += new System.EventHandler(this.AtrasBtn_Click);
            // 
            // PostresLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 506);
            this.Controls.Add(this.AtrasBtn);
            this.Controls.Add(this.DataGridPostres);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostresLista";
            this.Text = "Postres";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPostres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridPostres;
        private System.Windows.Forms.Button AtrasBtn;
    }
}