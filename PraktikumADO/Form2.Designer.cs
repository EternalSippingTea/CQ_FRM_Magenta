namespace PraktikumADO
{
    partial class Form2
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
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnCountDosen = new System.Windows.Forms.Button();
            this.btnUpdateMk = new System.Windows.Forms.Button();
            this.btnInsertProdi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(321, 146);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(170, 22);
            this.txtHasil.TabIndex = 0;
            // 
            // btnCountDosen
            // 
            this.btnCountDosen.Location = new System.Drawing.Point(110, 314);
            this.btnCountDosen.Name = "btnCountDosen";
            this.btnCountDosen.Size = new System.Drawing.Size(108, 35);
            this.btnCountDosen.TabIndex = 1;
            this.btnCountDosen.Text = "Count Dosen";
            this.btnCountDosen.UseVisualStyleBackColor = true;
            this.btnCountDosen.Click += new System.EventHandler(this.btnCountDosen_Click);
            // 
            // btnUpdateMk
            // 
            this.btnUpdateMk.Location = new System.Drawing.Point(344, 314);
            this.btnUpdateMk.Name = "btnUpdateMk";
            this.btnUpdateMk.Size = new System.Drawing.Size(108, 35);
            this.btnUpdateMk.TabIndex = 2;
            this.btnUpdateMk.Text = "Update Mk";
            this.btnUpdateMk.UseVisualStyleBackColor = true;
            this.btnUpdateMk.Click += new System.EventHandler(this.btnUpdateMk_Click);
            // 
            // btnInsertProdi
            // 
            this.btnInsertProdi.Location = new System.Drawing.Point(577, 314);
            this.btnInsertProdi.Name = "btnInsertProdi";
            this.btnInsertProdi.Size = new System.Drawing.Size(108, 35);
            this.btnInsertProdi.TabIndex = 3;
            this.btnInsertProdi.Text = "Insert Prodi";
            this.btnInsertProdi.UseVisualStyleBackColor = true;
            this.btnInsertProdi.Click += new System.EventHandler(this.btnInsertProdi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasil";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertProdi);
            this.Controls.Add(this.btnUpdateMk);
            this.Controls.Add(this.btnCountDosen);
            this.Controls.Add(this.txtHasil);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnCountDosen;
        private System.Windows.Forms.Button btnUpdateMk;
        private System.Windows.Forms.Button btnInsertProdi;
        private System.Windows.Forms.Label label1;
    }
}