namespace AdvancedTextBox
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
            this.advanedTextBox3 = new AdvancedTextBox.AdvanedTextBox();
            this.advanedTextBox2 = new AdvancedTextBox.AdvanedTextBox();
            this.advanedTextBox1 = new AdvancedTextBox.AdvanedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // advanedTextBox3
            // 
            this.advanedTextBox3.FocusedlBorderColor = System.Drawing.Color.Red;
            this.advanedTextBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.advanedTextBox3.IdelBorderColor = System.Drawing.Color.DarkGray;
            this.advanedTextBox3.ISPassword = true;
            this.advanedTextBox3.Location = new System.Drawing.Point(92, 103);
            this.advanedTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.advanedTextBox3.MyPasswordChart = "#";
            this.advanedTextBox3.Name = "advanedTextBox3";
            this.advanedTextBox3.PlaceHolder = "Password";
            this.advanedTextBox3.Size = new System.Drawing.Size(238, 30);
            this.advanedTextBox3.TabIndex = 2;
            this.advanedTextBox3.Text = "Password";
            // 
            // advanedTextBox2
            // 
            this.advanedTextBox2.FocusedlBorderColor = System.Drawing.Color.Red;
            this.advanedTextBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.advanedTextBox2.IdelBorderColor = System.Drawing.Color.DarkGray;
            this.advanedTextBox2.ISPassword = false;
            this.advanedTextBox2.Location = new System.Drawing.Point(92, 143);
            this.advanedTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.advanedTextBox2.MyPasswordChart = "";
            this.advanedTextBox2.Name = "advanedTextBox2";
            this.advanedTextBox2.PlaceHolder = "";
            this.advanedTextBox2.Size = new System.Drawing.Size(238, 30);
            this.advanedTextBox2.TabIndex = 1;
            // 
            // advanedTextBox1
            // 
            this.advanedTextBox1.FocusedlBorderColor = System.Drawing.Color.Red;
            this.advanedTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.advanedTextBox1.IdelBorderColor = System.Drawing.Color.Blue;
            this.advanedTextBox1.ISPassword = false;
            this.advanedTextBox1.Location = new System.Drawing.Point(92, 64);
            this.advanedTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.advanedTextBox1.MyPasswordChart = "";
            this.advanedTextBox1.Name = "advanedTextBox1";
            this.advanedTextBox1.PlaceHolder = "UserName";
            this.advanedTextBox1.Size = new System.Drawing.Size(238, 30);
            this.advanedTextBox1.TabIndex = 0;
            this.advanedTextBox1.Text = "UserName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 215);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 24);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 273);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.advanedTextBox3);
            this.Controls.Add(this.advanedTextBox2);
            this.Controls.Add(this.advanedTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdvanedTextBox advanedTextBox1;
        private AdvanedTextBox advanedTextBox2;
        private AdvanedTextBox advanedTextBox3;
        private System.Windows.Forms.TextBox textBox1;




















    }
}

