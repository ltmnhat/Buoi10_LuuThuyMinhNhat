namespace buoi10
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cau hoi";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(195, 217);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(40, 103);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(32, 17);
            this.rbA.TabIndex = 2;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(42, 140);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(32, 17);
            this.rbB.TabIndex = 3;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(38, 177);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(32, 17);
            this.rbC.TabIndex = 4;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
           // this.rbC.CheckedChanged += new System.EventHandler(this.rdC_CheckedChanged);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(51, 211);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(33, 17);
            this.rbD.TabIndex = 5;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
    }
}

