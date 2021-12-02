
namespace Calculator
{
    partial class Calculator
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
            this.cmbO = new System.Windows.Forms.ComboBox();
            this.lblO = new System.Windows.Forms.Label();
            this.lblNilaiA = new System.Windows.Forms.Label();
            this.lblNilaiB = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(100, 100);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 0;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // cmbO
            // 
            this.cmbO.FormattingEnabled = true;
            this.cmbO.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmbO.Location = new System.Drawing.Point(75, 12);
            this.cmbO.Name = "cmbO";
            this.cmbO.Size = new System.Drawing.Size(100, 21);
            this.cmbO.TabIndex = 1;
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(12, 15);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(48, 13);
            this.lblO.TabIndex = 2;
            this.lblO.Text = "Operator";
            // 
            // lblNilaiA
            // 
            this.lblNilaiA.AutoSize = true;
            this.lblNilaiA.Location = new System.Drawing.Point(12, 42);
            this.lblNilaiA.Name = "lblNilaiA";
            this.lblNilaiA.Size = new System.Drawing.Size(37, 13);
            this.lblNilaiA.TabIndex = 3;
            this.lblNilaiA.Text = "Nilai A";
            // 
            // lblNilaiB
            // 
            this.lblNilaiB.AutoSize = true;
            this.lblNilaiB.Location = new System.Drawing.Point(12, 68);
            this.lblNilaiB.Name = "lblNilaiB";
            this.lblNilaiB.Size = new System.Drawing.Size(37, 13);
            this.lblNilaiB.TabIndex = 4;
            this.lblNilaiB.Text = "Nilai B";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(75, 39);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiA.TabIndex = 5;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(75, 65);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiB.TabIndex = 6;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 133);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.lblNilaiB);
            this.Controls.Add(this.lblNilaiA);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.cmbO);
            this.Controls.Add(this.btnProses);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.ComboBox cmbO;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblNilaiA;
        private System.Windows.Forms.Label lblNilaiB;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
    }
}

