namespace EB_saldumi_11_G
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
            this.daudzums = new System.Windows.Forms.TextBox();
            this.aprekins = new System.Windows.Forms.Button();
            this.daudzums_kg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // daudzums
            // 
            this.daudzums.Location = new System.Drawing.Point(80, 223);
            this.daudzums.Name = "daudzums";
            this.daudzums.Size = new System.Drawing.Size(100, 20);
            this.daudzums.TabIndex = 0;
            // 
            // aprekins
            // 
            this.aprekins.Location = new System.Drawing.Point(204, 220);
            this.aprekins.Name = "aprekins";
            this.aprekins.Size = new System.Drawing.Size(75, 23);
            this.aprekins.TabIndex = 1;
            this.aprekins.Text = "Aprekinat";
            this.aprekins.UseVisualStyleBackColor = true;
            this.aprekins.Click += new System.EventHandler(this.aprekins_Click);
            // 
            // daudzums_kg
            // 
            this.daudzums_kg.Location = new System.Drawing.Point(302, 223);
            this.daudzums_kg.Name = "daudzums_kg";
            this.daudzums_kg.Size = new System.Drawing.Size(100, 20);
            this.daudzums_kg.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daudzums_kg);
            this.Controls.Add(this.aprekins);
            this.Controls.Add(this.daudzums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox daudzums;
        private System.Windows.Forms.Button aprekins;
        private System.Windows.Forms.TextBox daudzums_kg;
    }
}

