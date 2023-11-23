namespace SportsiTim
{
    partial class DodajTim
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 76);
            this.button2.TabIndex = 18;
            this.button2.Text = "Natrag";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 76);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(39, 335);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(444, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Unesi adresu tima";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(39, 272);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(444, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Unesi kontakt tima";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(444, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Unesi  maticni broj tima ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Unesi ime tima";
            // 
            // DodajTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "DodajTim";
            this.Text = "DodajTim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}