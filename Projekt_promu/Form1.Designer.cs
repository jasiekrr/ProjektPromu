
namespace Projekt_promu
{
    partial class Przeprawa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UstawieniaGRBX = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.numericAutaPrawe = new System.Windows.Forms.NumericUpDown();
            this.numericAutaLewe = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericProg = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericPojemnosc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericSzerokosc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.ekran = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLewe_oczekujace = new System.Windows.Forms.Label();
            this.lbl_czas_lewy = new System.Windows.Forms.Label();
            this.pasek_czasu = new System.Windows.Forms.ProgressBar();
            this.rzeka = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.UstawieniaGRBX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutaPrawe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutaLewe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPojemnosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSzerokosc)).BeginInit();
            this.ekran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rzeka)).BeginInit();
            this.SuspendLayout();
            // 
            // UstawieniaGRBX
            // 
            this.UstawieniaGRBX.Controls.Add(this.btnOK);
            this.UstawieniaGRBX.Controls.Add(this.numericAutaPrawe);
            this.UstawieniaGRBX.Controls.Add(this.numericAutaLewe);
            this.UstawieniaGRBX.Controls.Add(this.label5);
            this.UstawieniaGRBX.Controls.Add(this.label4);
            this.UstawieniaGRBX.Controls.Add(this.numericProg);
            this.UstawieniaGRBX.Controls.Add(this.label3);
            this.UstawieniaGRBX.Controls.Add(this.numericPojemnosc);
            this.UstawieniaGRBX.Controls.Add(this.label2);
            this.UstawieniaGRBX.Controls.Add(this.numericSzerokosc);
            this.UstawieniaGRBX.Controls.Add(this.label1);
            this.UstawieniaGRBX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UstawieniaGRBX.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UstawieniaGRBX.Location = new System.Drawing.Point(24, 243);
            this.UstawieniaGRBX.Name = "UstawieniaGRBX";
            this.UstawieniaGRBX.Size = new System.Drawing.Size(318, 325);
            this.UstawieniaGRBX.TabIndex = 1;
            this.UstawieniaGRBX.TabStop = false;
            this.UstawieniaGRBX.Text = "Ustawienia";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(6, 278);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 41);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numericAutaPrawe
            // 
            this.numericAutaPrawe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericAutaPrawe.Location = new System.Drawing.Point(181, 222);
            this.numericAutaPrawe.Name = "numericAutaPrawe";
            this.numericAutaPrawe.Size = new System.Drawing.Size(120, 23);
            this.numericAutaPrawe.TabIndex = 8;
            // 
            // numericAutaLewe
            // 
            this.numericAutaLewe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericAutaLewe.Location = new System.Drawing.Point(181, 182);
            this.numericAutaLewe.Name = "numericAutaLewe";
            this.numericAutaLewe.Size = new System.Drawing.Size(120, 23);
            this.numericAutaLewe.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Liczba aut z prawej strony";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Liczba aut z lewej strony";
            // 
            // numericProg
            // 
            this.numericProg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericProg.Location = new System.Drawing.Point(181, 142);
            this.numericProg.Name = "numericProg";
            this.numericProg.Size = new System.Drawing.Size(120, 23);
            this.numericProg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Próg cierpliwości promu";
            // 
            // numericPojemnosc
            // 
            this.numericPojemnosc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericPojemnosc.Location = new System.Drawing.Point(181, 102);
            this.numericPojemnosc.Name = "numericPojemnosc";
            this.numericPojemnosc.Size = new System.Drawing.Size(120, 23);
            this.numericPojemnosc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pojemność promu";
            // 
            // numericSzerokosc
            // 
            this.numericSzerokosc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericSzerokosc.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericSzerokosc.Location = new System.Drawing.Point(181, 62);
            this.numericSzerokosc.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericSzerokosc.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericSzerokosc.Name = "numericSzerokosc";
            this.numericSzerokosc.Size = new System.Drawing.Size(120, 23);
            this.numericSzerokosc.TabIndex = 1;
            this.numericSzerokosc.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szerokość rzeki w metrach";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Location = new System.Drawing.Point(30, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 79);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ekran
            // 
            this.ekran.AccessibleDescription = "";
            this.ekran.AccessibleName = "";
            this.ekran.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ekran.Controls.Add(this.label6);
            this.ekran.Controls.Add(this.lblLewe_oczekujace);
            this.ekran.Controls.Add(this.lbl_czas_lewy);
            this.ekran.Controls.Add(this.pasek_czasu);
            this.ekran.Controls.Add(this.rzeka);
            this.ekran.Dock = System.Windows.Forms.DockStyle.Right;
            this.ekran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekran.Location = new System.Drawing.Point(349, 0);
            this.ekran.Name = "ekran";
            this.ekran.Size = new System.Drawing.Size(1200, 607);
            this.ekran.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(959, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "liczba aut oczekujących:";
            // 
            // lblLewe_oczekujace
            // 
            this.lblLewe_oczekujace.AutoSize = true;
            this.lblLewe_oczekujace.Location = new System.Drawing.Point(16, 95);
            this.lblLewe_oczekujace.Name = "lblLewe_oczekujace";
            this.lblLewe_oczekujace.Size = new System.Drawing.Size(124, 13);
            this.lblLewe_oczekujace.TabIndex = 8;
            this.lblLewe_oczekujace.Text = "liczba aut oczekujących:";
            // 
            // lbl_czas_lewy
            // 
            this.lbl_czas_lewy.AutoSize = true;
            this.lbl_czas_lewy.Location = new System.Drawing.Point(16, 18);
            this.lbl_czas_lewy.Name = "lbl_czas_lewy";
            this.lbl_czas_lewy.Size = new System.Drawing.Size(131, 13);
            this.lbl_czas_lewy.TabIndex = 6;
            this.lbl_czas_lewy.Text = "Poziom Cierpliwości promu";
            // 
            // pasek_czasu
            // 
            this.pasek_czasu.Location = new System.Drawing.Point(16, 36);
            this.pasek_czasu.Name = "pasek_czasu";
            this.pasek_czasu.Size = new System.Drawing.Size(227, 11);
            this.pasek_czasu.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pasek_czasu.TabIndex = 4;
            this.pasek_czasu.Tag = "pasek_czasu";
            // 
            // rzeka
            // 
            this.rzeka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rzeka.BackColor = System.Drawing.Color.Aqua;
            this.rzeka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rzeka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rzeka.Location = new System.Drawing.Point(462, 0);
            this.rzeka.Name = "rzeka";
            this.rzeka.Size = new System.Drawing.Size(115, 607);
            this.rzeka.TabIndex = 0;
            this.rzeka.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(192, 38);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 79);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "WYJDŹ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(98, 167);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(65, 51);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "Lewy";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(192, 167);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(65, 51);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "Prawy";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // Przeprawa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 607);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ekran);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.UstawieniaGRBX);
            this.Name = "Przeprawa";
            this.Text = "Pojemność promu";
            this.UstawieniaGRBX.ResumeLayout(false);
            this.UstawieniaGRBX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutaPrawe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutaLewe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPojemnosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSzerokosc)).EndInit();
            this.ekran.ResumeLayout(false);
            this.ekran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rzeka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox UstawieniaGRBX;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown numericAutaLewe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericProg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericPojemnosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericSzerokosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel ekran;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown numericAutaPrawe;
        private System.Windows.Forms.PictureBox rzeka;
        public System.Windows.Forms.ProgressBar pasek_czasu;
        private System.Windows.Forms.Label lbl_czas_lewy;
        private System.Windows.Forms.Label lblLewe_oczekujace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
    }
}

