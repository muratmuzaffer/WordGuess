namespace WindowsFormsApp4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnkolay = new System.Windows.Forms.Button();
            this.btnorta = new System.Windows.Forms.Button();
            this.btnzor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkolay
            // 
            this.btnkolay.BackColor = System.Drawing.Color.White;
            this.btnkolay.Location = new System.Drawing.Point(124, 33);
            this.btnkolay.Name = "btnkolay";
            this.btnkolay.Size = new System.Drawing.Size(198, 39);
            this.btnkolay.TabIndex = 0;
            this.btnkolay.Text = "KOLAY";
            this.btnkolay.UseVisualStyleBackColor = false;
            this.btnkolay.Click += new System.EventHandler(this.btnkolay_Click);
            // 
            // btnorta
            // 
            this.btnorta.BackColor = System.Drawing.Color.White;
            this.btnorta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnorta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnorta.Location = new System.Drawing.Point(123, 87);
            this.btnorta.Name = "btnorta";
            this.btnorta.Size = new System.Drawing.Size(198, 39);
            this.btnorta.TabIndex = 1;
            this.btnorta.Text = "ORTA";
            this.btnorta.UseVisualStyleBackColor = false;
            this.btnorta.Click += new System.EventHandler(this.btnorta_Click);
            // 
            // btnzor
            // 
            this.btnzor.BackColor = System.Drawing.Color.White;
            this.btnzor.Location = new System.Drawing.Point(123, 143);
            this.btnzor.Name = "btnzor";
            this.btnzor.Size = new System.Drawing.Size(198, 39);
            this.btnzor.TabIndex = 2;
            this.btnzor.Text = "ZOR";
            this.btnzor.UseVisualStyleBackColor = false;
            this.btnzor.Click += new System.EventHandler(this.btnzor_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 207);
            this.Controls.Add(this.btnzor);
            this.Controls.Add(this.btnorta);
            this.Controls.Add(this.btnkolay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOD SEÇİNİZ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkolay;
        private System.Windows.Forms.Button btnorta;
        private System.Windows.Forms.Button btnzor;
    }
}