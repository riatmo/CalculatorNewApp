namespace CalculatorNewForm
{
    partial class frmInput
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
            this.btnProses = new System.Windows.Forms.Button();
            this.txtNilai1 = new System.Windows.Forms.TextBox();
            this.lblOperasi = new System.Windows.Forms.Label();
            this.txtOperasi = new System.Windows.Forms.ComboBox();
            this.lblNilaiA = new System.Windows.Forms.Label();
            this.lblNilaiB = new System.Windows.Forms.Label();
            this.txtNilai2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(146, 127);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 0;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // txtNilai1
            // 
            this.txtNilai1.Location = new System.Drawing.Point(100, 50);
            this.txtNilai1.Name = "txtNilai1";
            this.txtNilai1.Size = new System.Drawing.Size(121, 20);
            this.txtNilai1.TabIndex = 1;
            // 
            // lblOperasi
            // 
            this.lblOperasi.AutoSize = true;
            this.lblOperasi.Location = new System.Drawing.Point(12, 18);
            this.lblOperasi.Name = "lblOperasi";
            this.lblOperasi.Size = new System.Drawing.Size(43, 13);
            this.lblOperasi.TabIndex = 2;
            this.lblOperasi.Text = "Operasi";
            // 
            // txtOperasi
            // 
            this.txtOperasi.FormattingEnabled = true;
            this.txtOperasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Pembagian",
            "Perkalian"});
            this.txtOperasi.Location = new System.Drawing.Point(100, 10);
            this.txtOperasi.Name = "txtOperasi";
            this.txtOperasi.Size = new System.Drawing.Size(121, 21);
            this.txtOperasi.TabIndex = 3;
            this.txtOperasi.Text = "Penjumlahan";
            // 
            // lblNilaiA
            // 
            this.lblNilaiA.AutoSize = true;
            this.lblNilaiA.Location = new System.Drawing.Point(12, 53);
            this.lblNilaiA.Name = "lblNilaiA";
            this.lblNilaiA.Size = new System.Drawing.Size(37, 13);
            this.lblNilaiA.TabIndex = 4;
            this.lblNilaiA.Text = "Nilai A";
            // 
            // lblNilaiB
            // 
            this.lblNilaiB.AutoSize = true;
            this.lblNilaiB.Location = new System.Drawing.Point(12, 93);
            this.lblNilaiB.Name = "lblNilaiB";
            this.lblNilaiB.Size = new System.Drawing.Size(37, 13);
            this.lblNilaiB.TabIndex = 6;
            this.lblNilaiB.Text = "Nilai B";
            // 
            // txtNilai2
            // 
            this.txtNilai2.Location = new System.Drawing.Point(100, 90);
            this.txtNilai2.Name = "txtNilai2";
            this.txtNilai2.Size = new System.Drawing.Size(121, 20);
            this.txtNilai2.TabIndex = 5;
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 157);
            this.Controls.Add(this.lblNilaiB);
            this.Controls.Add(this.txtNilai2);
            this.Controls.Add(this.lblNilaiA);
            this.Controls.Add(this.txtOperasi);
            this.Controls.Add(this.lblOperasi);
            this.Controls.Add(this.txtNilai1);
            this.Controls.Add(this.btnProses);
            this.Name = "frmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label lblOperasi;
        private System.Windows.Forms.Label lblNilaiA;
        private System.Windows.Forms.Label lblNilaiB;
        private System.Windows.Forms.TextBox txtNilai1;
        private System.Windows.Forms.ComboBox txtOperasi;
        private System.Windows.Forms.TextBox txtNilai2;
    }
}

