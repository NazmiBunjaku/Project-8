namespace Homework_Project_7___Nazmi_Bunjaku
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
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sales_Box = new System.Windows.Forms.TextBox();
            this.Tax_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Total_Box = new System.Windows.Forms.TextBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(302, 144);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button.TabIndex = 0;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Location = new System.Drawing.Point(302, 70);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(75, 23);
            this.Calculate_Button.TabIndex = 1;
            this.Calculate_Button.Text = "Calculate";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Tax Amount is (6.25%):\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(59, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please Enter Sales Amount:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sales_Box
            // 
            this.Sales_Box.Location = new System.Drawing.Point(58, 73);
            this.Sales_Box.Name = "Sales_Box";
            this.Sales_Box.Size = new System.Drawing.Size(100, 20);
            this.Sales_Box.TabIndex = 4;
            // 
            // Tax_Box
            // 
            this.Tax_Box.BackColor = System.Drawing.Color.Gold;
            this.Tax_Box.Location = new System.Drawing.Point(58, 162);
            this.Tax_Box.Name = "Tax_Box";
            this.Tax_Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tax_Box.Size = new System.Drawing.Size(100, 20);
            this.Tax_Box.TabIndex = 5;
            this.Tax_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Total Amount You Have To Pay Is:";
            // 
            // Total_Box
            // 
            this.Total_Box.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Total_Box.Location = new System.Drawing.Point(58, 251);
            this.Total_Box.Name = "Total_Box";
            this.Total_Box.Size = new System.Drawing.Size(100, 20);
            this.Total_Box.TabIndex = 7;
            this.Total_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_Box.TextChanged += new System.EventHandler(this.Total_Box_TextChanged);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(302, 227);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 8;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 309);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Total_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tax_Box);
            this.Controls.Add(this.Sales_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate_Button);
            this.Controls.Add(this.Clear_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Sales_Box;
        private System.Windows.Forms.TextBox Tax_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Total_Box;
        private System.Windows.Forms.Button Exit_Button;
    }
}

