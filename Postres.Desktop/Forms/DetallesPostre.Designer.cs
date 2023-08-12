namespace Postres.Desktop.Forms
{
    partial class DetallesPostre
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreTxtLabel = new System.Windows.Forms.Label();
            this.AgregarIngredieteBtn = new System.Windows.Forms.Button();
            this.AtrasBtn = new System.Windows.Forms.Button();
            this.EstadoTxtLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingredientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(562, 166);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 6;
            // 
            // NombreTxtLabel
            // 
            this.NombreTxtLabel.AutoSize = true;
            this.NombreTxtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTxtLabel.Location = new System.Drawing.Point(160, 83);
            this.NombreTxtLabel.Name = "NombreTxtLabel";
            this.NombreTxtLabel.Size = new System.Drawing.Size(21, 22);
            this.NombreTxtLabel.TabIndex = 7;
            this.NombreTxtLabel.Text = "n";
            // 
            // AgregarIngredieteBtn
            // 
            this.AgregarIngredieteBtn.Location = new System.Drawing.Point(68, 392);
            this.AgregarIngredieteBtn.Name = "AgregarIngredieteBtn";
            this.AgregarIngredieteBtn.Size = new System.Drawing.Size(88, 46);
            this.AgregarIngredieteBtn.TabIndex = 8;
            this.AgregarIngredieteBtn.Text = "Aggregar";
            this.AgregarIngredieteBtn.UseVisualStyleBackColor = true;
            this.AgregarIngredieteBtn.Click += new System.EventHandler(this.AgregarIngredieteBtn_Click);
            // 
            // AtrasBtn
            // 
            this.AtrasBtn.Location = new System.Drawing.Point(162, 392);
            this.AtrasBtn.Name = "AtrasBtn";
            this.AtrasBtn.Size = new System.Drawing.Size(88, 46);
            this.AtrasBtn.TabIndex = 9;
            this.AtrasBtn.Text = "Atras";
            this.AtrasBtn.UseVisualStyleBackColor = true;
            this.AtrasBtn.Click += new System.EventHandler(this.AtrasBtn_Click);
            // 
            // EstadoTxtLbl
            // 
            this.EstadoTxtLbl.AutoSize = true;
            this.EstadoTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoTxtLbl.Location = new System.Drawing.Point(162, 119);
            this.EstadoTxtLbl.Name = "EstadoTxtLbl";
            this.EstadoTxtLbl.Size = new System.Drawing.Size(21, 22);
            this.EstadoTxtLbl.TabIndex = 12;
            this.EstadoTxtLbl.Text = "n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 22);
            this.label7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Estado";
            // 
            // DetallesPostre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.EstadoTxtLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AtrasBtn);
            this.Controls.Add(this.AgregarIngredieteBtn);
            this.Controls.Add(this.NombreTxtLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetallesPostre";
            this.Text = "DetallesPostre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NombreTxtLabel;
        private System.Windows.Forms.Button AgregarIngredieteBtn;
        private System.Windows.Forms.Button AtrasBtn;
        private System.Windows.Forms.Label EstadoTxtLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}