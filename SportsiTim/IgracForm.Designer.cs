namespace SportsiTim
{
    partial class IgracForm
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
            this.Igrac = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Igrac
            // 
            this.Igrac.FormattingEnabled = true;
            this.Igrac.Location = new System.Drawing.Point(39, 72);
            this.Igrac.Margin = new System.Windows.Forms.Padding(2);
            this.Igrac.Name = "Igrac";
            this.Igrac.Size = new System.Drawing.Size(467, 290);
            this.Igrac.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 189);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 59);
            this.button3.TabIndex = 15;
            this.button3.Text = "Obrisi";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 303);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 59);
            this.button2.TabIndex = 14;
            this.button2.Text = "Izmijeni";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IgracForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Igrac);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "IgracForm";
            this.Text = "IgracForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Igrac;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}