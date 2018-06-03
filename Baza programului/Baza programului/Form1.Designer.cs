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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu));
            this.Koch = new System.Windows.Forms.Button();
            this.Sierpinski = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nivelul = new System.Windows.Forms.RichTextBox();
            this.Iesire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Koch
            // 
            this.Koch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Koch.Location = new System.Drawing.Point(104, 345);
            this.Koch.Name = "Koch";
            this.Koch.Size = new System.Drawing.Size(111, 36);
            this.Koch.TabIndex = 0;
            this.Koch.Text = "Koch";
            this.Koch.UseVisualStyleBackColor = true;
            this.Koch.Click += new System.EventHandler(this.Koch_Click);
            // 
            // Sierpinski
            // 
            this.Sierpinski.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sierpinski.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sierpinski.Location = new System.Drawing.Point(104, 204);
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
            this.button1.Location = new System.Drawing.Point(104, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "T-square";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nivelul
            // 
            this.nivelul.Location = new System.Drawing.Point(104, 137);
            this.nivelul.Name = "nivelul";
            this.nivelul.Size = new System.Drawing.Size(111, 25);
            this.nivelul.TabIndex = 3;
            this.nivelul.Text = "";
            // 
            // Iesire
            // 
            this.Iesire.BackColor = System.Drawing.Color.DodgerBlue;
            this.Iesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Iesire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Iesire.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iesire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Iesire.Location = new System.Drawing.Point(747, 491);
            this.Iesire.Name = "Iesire";
            this.Iesire.Size = new System.Drawing.Size(151, 55);
            this.Iesire.TabIndex = 4;
            this.Iesire.Text = "Iesire";
            this.Iesire.UseVisualStyleBackColor = false;
            this.Iesire.Click += new System.EventHandler(this.Iesire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(254, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nivel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.pictureBox1.Location = new System.Drawing.Point(85, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 335);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(641, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(257, 335);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Iesire);
            this.Controls.Add(this.nivelul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sierpinski);
            this.Controls.Add(this.Koch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Meniu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Koch;
        private System.Windows.Forms.Button Sierpinski;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox nivelul;
        private System.Windows.Forms.Button Iesire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

