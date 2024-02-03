
namespace AmbarAdreslemeLokasyon
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
            this.txtKutuNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBUL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLokasyon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKutuNo
            // 
            this.txtKutuNo.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKutuNo.Location = new System.Drawing.Point(191, 77);
            this.txtKutuNo.Name = "txtKutuNo";
            this.txtKutuNo.Size = new System.Drawing.Size(167, 27);
            this.txtKutuNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kutu Numarası";
            // 
            // btnBUL
            // 
            this.btnBUL.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBUL.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBUL.Location = new System.Drawing.Point(392, 42);
            this.btnBUL.Name = "btnBUL";
            this.btnBUL.Size = new System.Drawing.Size(187, 94);
            this.btnBUL.TabIndex = 2;
            this.btnBUL.Text = "BUL";
            this.btnBUL.UseVisualStyleBackColor = false;
            this.btnBUL.Click += new System.EventHandler(this.btnBUL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lokasyon";
            // 
            // txtLokasyon
            // 
            this.txtLokasyon.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLokasyon.Location = new System.Drawing.Point(171, 239);
            this.txtLokasyon.Multiline = true;
            this.txtLokasyon.Name = "txtLokasyon";
            this.txtLokasyon.ReadOnly = true;
            this.txtLokasyon.Size = new System.Drawing.Size(257, 37);
            this.txtLokasyon.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(504, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "YENİLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLokasyon);
            this.Controls.Add(this.btnBUL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKutuNo);
            this.Name = "Form1";
            this.Text = "POLYTEKS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKutuNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBUL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLokasyon;
        private System.Windows.Forms.Button button1;
    }
}

