namespace TaxCalculator
{
    partial class TaxCalculator
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
            this.income = new System.Windows.Forms.TextBox();
            this.ComputedTax = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(254, 106);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(124, 20);
            this.income.TabIndex = 0;
            // 
            // ComputedTax
            // 
            this.ComputedTax.Location = new System.Drawing.Point(254, 173);
            this.ComputedTax.Name = "ComputedTax";
            this.ComputedTax.ReadOnly = true;
            this.ComputedTax.Size = new System.Drawing.Size(124, 20);
            this.ComputedTax.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(158, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(109, 20);
            this.Title.TabIndex = 2;
            this.Title.Text = "Tax Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Income Here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Computed Tax";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileLocation
            // 
            this.FileLocation.Location = new System.Drawing.Point(91, 304);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.ReadOnly = true;
            this.FileLocation.Size = new System.Drawing.Size(253, 20);
            this.FileLocation.TabIndex = 7;
            // 
            // TaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 348);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ComputedTax);
            this.Controls.Add(this.income);
            this.Name = "TaxCalculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox income;
        private System.Windows.Forms.TextBox ComputedTax;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FileLocation;
    }
}

