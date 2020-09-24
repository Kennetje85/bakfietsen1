namespace bakfietsen1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OptieBikeTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Aantaldagen = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.helm_Bx = new System.Windows.Forms.CheckBox();
            this.KaartHouder = new System.Windows.Forms.CheckBox();
            this.Smartphone_Bx = new System.Windows.Forms.CheckBox();
            this.babystoeltje_Bx = new System.Windows.Forms.CheckBox();
            this.regendakBx = new System.Windows.Forms.CheckBox();
            this.Titel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotaleKosten = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aantaldagen)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(724, 321);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(94, 29);
            this.Total.TabIndex = 1;
            this.Total.Text = "Totaal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.OptieBikeTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 404);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Kies een fiets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kies je optie 1t/m4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "4. Clasic Large E(6pers. Ebike)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "3. Clasic Large(6pers.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. Clasic Short E(4pers.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Classic Short (4pers.)";
            // 
            // OptieBikeTxt
            // 
            this.OptieBikeTxt.Location = new System.Drawing.Point(144, 358);
            this.OptieBikeTxt.Name = "OptieBikeTxt";
            this.OptieBikeTxt.Size = new System.Drawing.Size(126, 26);
            this.OptieBikeTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Aantaldagen);
            this.groupBox2.Location = new System.Drawing.Point(299, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Aantal dagen selecteren";
            // 
            // Aantaldagen
            // 
            this.Aantaldagen.Location = new System.Drawing.Point(13, 59);
            this.Aantaldagen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Aantaldagen.Name = "Aantaldagen";
            this.Aantaldagen.Size = new System.Drawing.Size(120, 26);
            this.Aantaldagen.TabIndex = 0;
            this.Aantaldagen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.helm_Bx);
            this.groupBox3.Controls.Add(this.KaartHouder);
            this.groupBox3.Controls.Add(this.Smartphone_Bx);
            this.groupBox3.Controls.Add(this.babystoeltje_Bx);
            this.groupBox3.Controls.Add(this.regendakBx);
            this.groupBox3.Location = new System.Drawing.Point(299, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 260);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Accesoires";
            // 
            // helm_Bx
            // 
            this.helm_Bx.AutoSize = true;
            this.helm_Bx.Location = new System.Drawing.Point(20, 198);
            this.helm_Bx.Name = "helm_Bx";
            this.helm_Bx.Size = new System.Drawing.Size(72, 24);
            this.helm_Bx.TabIndex = 4;
            this.helm_Bx.Text = "Helm";
            this.helm_Bx.UseVisualStyleBackColor = true;
            // 
            // KaartHouder
            // 
            this.KaartHouder.AutoSize = true;
            this.KaartHouder.Location = new System.Drawing.Point(20, 158);
            this.KaartHouder.Name = "KaartHouder";
            this.KaartHouder.Size = new System.Drawing.Size(123, 24);
            this.KaartHouder.TabIndex = 3;
            this.KaartHouder.Text = "Kaarthouder";
            this.KaartHouder.UseVisualStyleBackColor = true;
            // 
            // Smartphone_Bx
            // 
            this.Smartphone_Bx.AutoSize = true;
            this.Smartphone_Bx.Location = new System.Drawing.Point(20, 118);
            this.Smartphone_Bx.Name = "Smartphone_Bx";
            this.Smartphone_Bx.Size = new System.Drawing.Size(176, 24);
            this.Smartphone_Bx.TabIndex = 2;
            this.Smartphone_Bx.Text = "SmartphoneHouder";
            this.Smartphone_Bx.UseVisualStyleBackColor = true;
            // 
            // babystoeltje_Bx
            // 
            this.babystoeltje_Bx.AutoSize = true;
            this.babystoeltje_Bx.Location = new System.Drawing.Point(20, 81);
            this.babystoeltje_Bx.Name = "babystoeltje_Bx";
            this.babystoeltje_Bx.Size = new System.Drawing.Size(122, 24);
            this.babystoeltje_Bx.TabIndex = 1;
            this.babystoeltje_Bx.Text = "Babystoeltje";
            this.babystoeltje_Bx.UseVisualStyleBackColor = true;
            // 
            // regendakBx
            // 
            this.regendakBx.AutoSize = true;
            this.regendakBx.Location = new System.Drawing.Point(20, 40);
            this.regendakBx.Name = "regendakBx";
            this.regendakBx.Size = new System.Drawing.Size(109, 24);
            this.regendakBx.TabIndex = 0;
            this.regendakBx.Text = "Regendak";
            this.regendakBx.UseVisualStyleBackColor = true;
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel.Location = new System.Drawing.Point(554, 70);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(517, 38);
            this.Titel.TabIndex = 5;
            this.Titel.Text = "Welkom bij van der Binckes Bakfietsen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // TotaleKosten
            // 
            this.TotaleKosten.AutoSize = true;
            this.TotaleKosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaleKosten.Location = new System.Drawing.Point(543, 321);
            this.TotaleKosten.Name = "TotaleKosten";
            this.TotaleKosten.Size = new System.Drawing.Size(19, 29);
            this.TotaleKosten.TabIndex = 7;
            this.TotaleKosten.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 480);
            this.Controls.Add(this.TotaleKosten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "BakFietsen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Aantaldagen)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OptieBikeTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown Aantaldagen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox regendakBx;
        private System.Windows.Forms.CheckBox helm_Bx;
        private System.Windows.Forms.CheckBox KaartHouder;
        private System.Windows.Forms.CheckBox Smartphone_Bx;
        private System.Windows.Forms.CheckBox babystoeltje_Bx;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotaleKosten;
    }
}

