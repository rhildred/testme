namespace TestMe
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOddEven = new System.Windows.Forms.TextBox();
            this.textBoxPrime = new System.Windows.Forms.TextBox();
            this.textBoxSquareOf = new System.Windows.Forms.TextBox();
            this.textBoxFactors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(118, 33);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 0;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // textBoxOddEven
            // 
            this.textBoxOddEven.Location = new System.Drawing.Point(43, 71);
            this.textBoxOddEven.Name = "textBoxOddEven";
            this.textBoxOddEven.ReadOnly = true;
            this.textBoxOddEven.Size = new System.Drawing.Size(342, 20);
            this.textBoxOddEven.TabIndex = 2;
            // 
            // textBoxPrime
            // 
            this.textBoxPrime.Location = new System.Drawing.Point(43, 97);
            this.textBoxPrime.Name = "textBoxPrime";
            this.textBoxPrime.ReadOnly = true;
            this.textBoxPrime.Size = new System.Drawing.Size(342, 20);
            this.textBoxPrime.TabIndex = 2;
            // 
            // textBoxSquareOf
            // 
            this.textBoxSquareOf.Location = new System.Drawing.Point(43, 123);
            this.textBoxSquareOf.Name = "textBoxSquareOf";
            this.textBoxSquareOf.ReadOnly = true;
            this.textBoxSquareOf.Size = new System.Drawing.Size(342, 20);
            this.textBoxSquareOf.TabIndex = 2;
            // 
            // textBoxFactors
            // 
            this.textBoxFactors.Location = new System.Drawing.Point(43, 149);
            this.textBoxFactors.Name = "textBoxFactors";
            this.textBoxFactors.ReadOnly = true;
            this.textBoxFactors.Size = new System.Drawing.Size(342, 20);
            this.textBoxFactors.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 194);
            this.Controls.Add(this.textBoxFactors);
            this.Controls.Add(this.textBoxSquareOf);
            this.Controls.Add(this.textBoxPrime);
            this.Controls.Add(this.textBoxOddEven);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumber);
            this.Name = "Form1";
            this.Text = "TestMe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOddEven;
        private System.Windows.Forms.TextBox textBoxPrime;
        private System.Windows.Forms.TextBox textBoxSquareOf;
        private System.Windows.Forms.TextBox textBoxFactors;
    }
}

