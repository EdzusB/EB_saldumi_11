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
            this.Nauda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check0 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // daudzums
            // 
            this.daudzums.Location = new System.Drawing.Point(337, 111);
            this.daudzums.Name = "daudzums";
            this.daudzums.Size = new System.Drawing.Size(100, 20);
            this.daudzums.TabIndex = 0;
            this.daudzums.TextChanged += new System.EventHandler(this.daudzums_TextChanged);
            // 
            // aprekins
            // 
            this.aprekins.Location = new System.Drawing.Point(348, 276);
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
            // Nauda
            // 
            this.Nauda.AutoSize = true;
            this.Nauda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Nauda.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Nauda.Location = new System.Drawing.Point(55, 110);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(89, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "(Daudzumu ievadiet ar komantu nevis punktu!!!)";
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(348, 179);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(137, 17);
            this.check1.TabIndex = 8;
            this.check1.Text = "Serenāde 17,63 eur/kg";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(348, 202);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(111, 17);
            this.check2.TabIndex = 9;
            this.check2.Text = "Migle 7,49 Eur/kg";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(348, 225);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(147, 17);
            this.check3.TabIndex = 10;
            this.check3.Text = "Rudzupuķe 12,19 Eur/kg";
            this.check3.UseVisualStyleBackColor = true;
            this.check3.CheckedChanged += new System.EventHandler(this.check3_CheckedChanged);
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(348, 248);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(122, 17);
            this.check4.TabIndex = 11;
            this.check4.Text = "Gotiņa 10,69 eur/kg";
            this.check4.UseVisualStyleBackColor = true;
            this.check4.CheckedChanged += new System.EventHandler(this.check4_CheckedChanged);
            // 
            // check0
            // 
            this.check0.AutoSize = true;
            this.check0.Location = new System.Drawing.Point(348, 156);
            this.check0.Name = "check0";
            this.check0.Size = new System.Drawing.Size(138, 17);
            this.check0.TabIndex = 12;
            this.check0.Text = "Marmelāde 9.88 Eur/kg";
            this.check0.UseVisualStyleBackColor = true;
            this.check0.CheckedChanged += new System.EventHandler(this.check0_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check0);
            this.Controls.Add(this.check4);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nauda);
            this.Controls.Add(this.daudzums_kg);
            this.Controls.Add(this.aprekins);
            this.Controls.Add(this.daudzums);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox daudzums;
        private System.Windows.Forms.Button aprekins;
        private System.Windows.Forms.TextBox daudzums_kg;
        private System.Windows.Forms.Label Nauda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check0;
    }
}

