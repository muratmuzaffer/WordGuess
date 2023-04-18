namespace WindowsFormsApp4
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.txtdogru = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bitirbttn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.surelbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yanlıslbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dogrulbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.atlabttn = new System.Windows.Forms.Button();
            this.kntrlbttn = new System.Windows.Forms.Button();
            this.txtcevap = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txting = new System.Windows.Forms.TextBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdogru
            // 
            this.txtdogru.BackColor = System.Drawing.SystemColors.Control;
            this.txtdogru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdogru.Location = new System.Drawing.Point(365, 379);
            this.txtdogru.Multiline = true;
            this.txtdogru.Name = "txtdogru";
            this.txtdogru.Size = new System.Drawing.Size(135, 30);
            this.txtdogru.TabIndex = 23;
            this.txtdogru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bitirbttn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.surelbl);
            this.groupBox2.Location = new System.Drawing.Point(30, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 211);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // bitirbttn
            // 
            this.bitirbttn.Location = new System.Drawing.Point(38, 156);
            this.bitirbttn.Name = "bitirbttn";
            this.bitirbttn.Size = new System.Drawing.Size(105, 35);
            this.bitirbttn.TabIndex = 8;
            this.bitirbttn.Text = "OYUNU BİTİR";
            this.bitirbttn.UseVisualStyleBackColor = true;
            this.bitirbttn.Click += new System.EventHandler(this.bitirbttn_click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "--------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mod :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Kalan Süre";
            // 
            // surelbl
            // 
            this.surelbl.AutoSize = true;
            this.surelbl.Font = new System.Drawing.Font("Erbos Draco 1st NBP", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surelbl.Location = new System.Drawing.Point(59, 103);
            this.surelbl.Name = "surelbl";
            this.surelbl.Size = new System.Drawing.Size(46, 23);
            this.surelbl.TabIndex = 5;
            this.surelbl.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yanlıslbl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dogrulbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(649, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 209);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // yanlıslbl
            // 
            this.yanlıslbl.AutoSize = true;
            this.yanlıslbl.Font = new System.Drawing.Font("Erbos Draco 1st NBP", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yanlıslbl.Location = new System.Drawing.Point(70, 168);
            this.yanlıslbl.Name = "yanlıslbl";
            this.yanlıslbl.Size = new System.Drawing.Size(28, 23);
            this.yanlıslbl.TabIndex = 4;
            this.yanlıslbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Yanlış Cevap";
            // 
            // dogrulbl
            // 
            this.dogrulbl.AutoSize = true;
            this.dogrulbl.Font = new System.Drawing.Font("Erbos Draco 1st NBP", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogrulbl.Location = new System.Drawing.Point(70, 91);
            this.dogrulbl.Name = "dogrulbl";
            this.dogrulbl.Size = new System.Drawing.Size(28, 23);
            this.dogrulbl.TabIndex = 2;
            this.dogrulbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Doğru Cevap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "ScoreBoard";
            // 
            // atlabttn
            // 
            this.atlabttn.Location = new System.Drawing.Point(435, 289);
            this.atlabttn.Name = "atlabttn";
            this.atlabttn.Size = new System.Drawing.Size(93, 34);
            this.atlabttn.TabIndex = 20;
            this.atlabttn.Text = "ATLA";
            this.atlabttn.UseVisualStyleBackColor = true;
            this.atlabttn.Click += new System.EventHandler(this.atlabttn_click);
            // 
            // kntrlbttn
            // 
            this.kntrlbttn.Location = new System.Drawing.Point(321, 289);
            this.kntrlbttn.Name = "kntrlbttn";
            this.kntrlbttn.Size = new System.Drawing.Size(93, 34);
            this.kntrlbttn.TabIndex = 19;
            this.kntrlbttn.Text = "KONTROL ET";
            this.kntrlbttn.UseVisualStyleBackColor = true;
            this.kntrlbttn.Click += new System.EventHandler(this.kontrolbttn_click);
            // 
            // txtcevap
            // 
            this.txtcevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcevap.Location = new System.Drawing.Point(365, 225);
            this.txtcevap.MaxLength = 35;
            this.txtcevap.Multiline = true;
            this.txtcevap.Name = "txtcevap";
            this.txtcevap.Size = new System.Drawing.Size(135, 30);
            this.txtcevap.TabIndex = 18;
            this.txtcevap.Text = "Cevap";
            this.txtcevap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.txting);
            this.panel1.Location = new System.Drawing.Point(308, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 94);
            this.panel1.TabIndex = 17;
            // 
            // txting
            // 
            this.txting.BackColor = System.Drawing.SystemColors.Control;
            this.txting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txting.Enabled = false;
            this.txting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txting.Location = new System.Drawing.Point(2, 28);
            this.txting.Multiline = true;
            this.txting.Name = "txting";
            this.txting.Size = new System.Drawing.Size(240, 38);
            this.txting.TabIndex = 9;
            this.txting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 446);
            this.Controls.Add(this.txtdogru);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.atlabttn);
            this.Controls.Add(this.kntrlbttn);
            this.Controls.Add(this.txtcevap);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordGuess (ZOR)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdogru;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bitirbttn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label surelbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label yanlıslbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dogrulbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button atlabttn;
        private System.Windows.Forms.Button kntrlbttn;
        private System.Windows.Forms.TextBox txtcevap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txting;
        private System.Windows.Forms.Timer timer4;
    }
}