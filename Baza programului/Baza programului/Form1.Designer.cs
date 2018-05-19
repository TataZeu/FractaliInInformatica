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
            this.SuspendLayout();
            // 
            // Koch
            // 
            this.Koch.Location = new System.Drawing.Point(88, 301);
            this.Koch.Name = "Koch";
            this.Koch.Size = new System.Drawing.Size(107, 36);
            this.Koch.TabIndex = 0;
            this.Koch.Text = "Koch";
            this.Koch.UseVisualStyleBackColor = true;
            this.Koch.Click += new System.EventHandler(this.Koch_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 519);
            this.Controls.Add(this.Koch);
            this.Name = "Meniu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Koch;
    }
}

