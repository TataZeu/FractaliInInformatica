namespace Baza_programului
{
    partial class Meniu
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
            this.Koch = new System.Windows.Forms.Button();
            this.Sierpinski = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nivelul = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Koch
            // 
            this.Koch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Koch.Location = new System.Drawing.Point(109, 301);
            this.Koch.Name = "Koch";
            this.Koch.Size = new System.Drawing.Size(111, 36);
            this.Koch.TabIndex = 0;
            this.Koch.Text = "Koch";
            this.Koch.UseVisualStyleBackColor = true;
            this.Koch.Click += new System.EventHandler(this.Koch_Click);
            // 
            // Sierpinski
            // 
            this.Sierpinski.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sierpinski.Location = new System.Drawing.Point(361, 301);
            this.Sierpinski.Name = "Sierpinski";
            this.Sierpinski.Size = new System.Drawing.Size(111, 36);
            this.Sierpinski.TabIndex = 1;
            this.Sierpinski.Text = "Sierpinski";
            this.Sierpinski.UseVisualStyleBackColor = true;
            this.Sierpinski.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(588, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "T-square";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nivelul
            // 
            this.nivelul.Location = new System.Drawing.Point(345, 409);
            this.nivelul.Name = "nivelul";
            this.nivelul.Size = new System.Drawing.Size(152, 38);
            this.nivelul.TabIndex = 3;
            this.nivelul.Text = "";
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 519);
            this.Controls.Add(this.nivelul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sierpinski);
            this.Controls.Add(this.Koch);
            this.Name = "Meniu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Koch;
        private System.Windows.Forms.Button Sierpinski;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox nivelul;
    }
}

