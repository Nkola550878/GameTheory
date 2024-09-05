namespace GameTheory
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Igrac1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igrac2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIgrac1 = new System.Windows.Forms.TextBox();
            this.txtIgrac2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Igrac1,
            this.Igrac2});
            this.dataGridView1.Location = new System.Drawing.Point(276, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // Igrac1
            // 
            this.Igrac1.HeaderText = "Igrac1";
            this.Igrac1.Name = "Igrac1";
            // 
            // Igrac2
            // 
            this.Igrac2.HeaderText = "Igrac2";
            this.Igrac2.Name = "Igrac2";
            // 
            // txtIgrac1
            // 
            this.txtIgrac1.Location = new System.Drawing.Point(89, 191);
            this.txtIgrac1.Name = "txtIgrac1";
            this.txtIgrac1.Size = new System.Drawing.Size(100, 20);
            this.txtIgrac1.TabIndex = 1;
            // 
            // txtIgrac2
            // 
            this.txtIgrac2.Location = new System.Drawing.Point(643, 191);
            this.txtIgrac2.Name = "txtIgrac2";
            this.txtIgrac2.Size = new System.Drawing.Size(100, 20);
            this.txtIgrac2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIgrac2);
            this.Controls.Add(this.txtIgrac1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igrac1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igrac2;
        private System.Windows.Forms.TextBox txtIgrac1;
        private System.Windows.Forms.TextBox txtIgrac2;
    }
}

