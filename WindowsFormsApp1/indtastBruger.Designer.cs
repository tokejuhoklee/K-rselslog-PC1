namespace WindowsFormsApp1
{
    partial class indtastBruger
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
            this.indtastNavn = new System.Windows.Forms.TextBox();
            this.indtastEfternavn = new System.Windows.Forms.TextBox();
            this.fornavn = new System.Windows.Forms.Label();
            this.efternavn = new System.Windows.Forms.Label();
            this.indsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // indtastNavn
            // 
            this.indtastNavn.Location = new System.Drawing.Point(71, 12);
            this.indtastNavn.Name = "indtastNavn";
            this.indtastNavn.Size = new System.Drawing.Size(100, 20);
            this.indtastNavn.TabIndex = 0;
            this.indtastNavn.TextChanged += new System.EventHandler(this.indtastNavn_TextChanged);
            // 
            // indtastEfternavn
            // 
            this.indtastEfternavn.Location = new System.Drawing.Point(71, 47);
            this.indtastEfternavn.Name = "indtastEfternavn";
            this.indtastEfternavn.Size = new System.Drawing.Size(100, 20);
            this.indtastEfternavn.TabIndex = 1;
            this.indtastEfternavn.TextChanged += new System.EventHandler(this.indtastEfternavn_TextChanged);
            // 
            // fornavn
            // 
            this.fornavn.AutoSize = true;
            this.fornavn.Location = new System.Drawing.Point(12, 15);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(46, 13);
            this.fornavn.TabIndex = 3;
            this.fornavn.Text = "Fornavn";
            this.fornavn.Click += new System.EventHandler(this.fornavn_Click);
            // 
            // efternavn
            // 
            this.efternavn.AutoSize = true;
            this.efternavn.Location = new System.Drawing.Point(12, 50);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(53, 13);
            this.efternavn.TabIndex = 4;
            this.efternavn.Text = "Efternavn";
            this.efternavn.Click += new System.EventHandler(this.efternavn_Click);
            // 
            // indsend
            // 
            this.indsend.Location = new System.Drawing.Point(177, 12);
            this.indsend.Name = "indsend";
            this.indsend.Size = new System.Drawing.Size(72, 55);
            this.indsend.TabIndex = 5;
            this.indsend.Text = "Bekræft";
            this.indsend.UseVisualStyleBackColor = true;
            this.indsend.Click += new System.EventHandler(this.indsend_Click);
            // 
            // indtastBruger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 85);
            this.Controls.Add(this.indsend);
            this.Controls.Add(this.efternavn);
            this.Controls.Add(this.fornavn);
            this.Controls.Add(this.indtastEfternavn);
            this.Controls.Add(this.indtastNavn);
            this.Name = "indtastBruger";
            this.Text = "indtastBruger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox indtastNavn;
        private System.Windows.Forms.TextBox indtastEfternavn;
        private System.Windows.Forms.Label fornavn;
        private System.Windows.Forms.Label efternavn;
        private System.Windows.Forms.Button indsend;
    }
}