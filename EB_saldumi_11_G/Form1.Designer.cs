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
            this.label1 = new System.Windows.Forms.Label();
            this.Nauda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daudzums
            // 
            this.daudzums.Location = new System.Drawing.Point(337, 174);
            this.daudzums.Name = "daudzums";
            this.daudzums.Size = new System.Drawing.Size(100, 20);
            this.daudzums.TabIndex = 0;
            // 
            // aprekins
            // 
            this.aprekins.Location = new System.Drawing.Point(348, 247);
            this.aprekins.Name = "aprekins";
            this.aprekins.Size = new System.Drawing.Size(75, 23);
            this.aprekins.TabIndex = 1;
            this.aprekins.Text = "Aprekinat";
            this.aprekins.UseVisualStyleBackColor = true;
            this.aprekins.Click += new System.EventHandler(this.aprekins_Click);
            // 
            // daudzums_kg
            // 
            this.daudzums_kg.Location = new System.Drawing.Point(337, 316);
            this.daudzums_kg.Name = "daudzums_kg";
            this.daudzums_kg.Size = new System.Drawing.Size(100, 20);
            this.daudzums_kg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(270, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldumu cena: 9,88Eur/kg";
            // 
            // Nauda
            // 
            this.Nauda.AutoSize = true;
            this.Nauda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Nauda.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Nauda.Location = new System.Drawing.Point(55, 174);
            this.Nauda.Name = "Nauda";
            this.Nauda.Size = new System.Drawing.Size(276, 18);
            this.Nauda.TabIndex = 4;
            this.Nauda.Text = "Ievadiet sev pieejamo naudas daudzumu!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(115, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daudzums, ko jus varat nopirkt!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(85, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(640, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iespejama daudzuma aprekinasana!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nauda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daudzums_kg);
            this.Controls.Add(this.aprekins);
            this.Controls.Add(this.daudzums);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox daudzums;
        private System.Windows.Forms.Button aprekins;
        private System.Windows.Forms.TextBox daudzums_kg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nauda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

