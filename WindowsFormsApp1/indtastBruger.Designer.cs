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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.indsendBruger = new System.Windows.Forms.Button();
            this.efternavn = new System.Windows.Forms.Label();
            this.fornavn = new System.Windows.Forms.Label();
            this.indtastEfternavn = new System.Windows.Forms.TextBox();
            this.indtastNavn = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.indtastModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.indsendBil = new System.Windows.Forms.Button();
            this.Nummerplade = new System.Windows.Forms.Label();
            this.Bilfabrikant = new System.Windows.Forms.Label();
            this.indtastNummerplade = new System.Windows.Forms.TextBox();
            this.indtastFabrikant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.indsendBruger);
            this.splitContainer1.Panel1.Controls.Add(this.efternavn);
            this.splitContainer1.Panel1.Controls.Add(this.fornavn);
            this.splitContainer1.Panel1.Controls.Add(this.indtastEfternavn);
            this.splitContainer1.Panel1.Controls.Add(this.indtastNavn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.Model);
            this.splitContainer1.Panel2.Controls.Add(this.indtastModel);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.indsendBil);
            this.splitContainer1.Panel2.Controls.Add(this.Nummerplade);
            this.splitContainer1.Panel2.Controls.Add(this.Bilfabrikant);
            this.splitContainer1.Panel2.Controls.Add(this.indtastNummerplade);
            this.splitContainer1.Panel2.Controls.Add(this.indtastFabrikant);
            this.splitContainer1.Size = new System.Drawing.Size(512, 269);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Indtast information for at\r\noprette en ny bruger";
            // 
            // indsendBruger
            // 
            this.indsendBruger.Location = new System.Drawing.Point(428, 28);
            this.indsendBruger.Name = "indsendBruger";
            this.indsendBruger.Size = new System.Drawing.Size(72, 55);
            this.indsendBruger.TabIndex = 29;
            this.indsendBruger.Text = "Bekræft";
            this.indsendBruger.UseVisualStyleBackColor = true;
            this.indsendBruger.Click += new System.EventHandler(this.indsendBruger_Click);
            // 
            // efternavn
            // 
            this.efternavn.AutoSize = true;
            this.efternavn.Location = new System.Drawing.Point(245, 66);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(53, 13);
            this.efternavn.TabIndex = 28;
            this.efternavn.Text = "Efternavn";
            // 
            // fornavn
            // 
            this.fornavn.AutoSize = true;
            this.fornavn.Location = new System.Drawing.Point(245, 31);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(46, 13);
            this.fornavn.TabIndex = 27;
            this.fornavn.Text = "Fornavn";
            // 
            // indtastEfternavn
            // 
            this.indtastEfternavn.Location = new System.Drawing.Point(322, 63);
            this.indtastEfternavn.Name = "indtastEfternavn";
            this.indtastEfternavn.Size = new System.Drawing.Size(100, 20);
            this.indtastEfternavn.TabIndex = 26;
            // 
            // indtastNavn
            // 
            this.indtastNavn.Location = new System.Drawing.Point(322, 28);
            this.indtastNavn.Name = "indtastNavn";
            this.indtastNavn.Size = new System.Drawing.Size(100, 20);
            this.indtastNavn.TabIndex = 25;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(245, 83);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 44;
            this.Model.Text = "Model";
            // 
            // indtastModel
            // 
            this.indtastModel.Location = new System.Drawing.Point(322, 80);
            this.indtastModel.Name = "indtastModel";
            this.indtastModel.Size = new System.Drawing.Size(100, 20);
            this.indtastModel.TabIndex = 43;
            this.indtastModel.TextChanged += new System.EventHandler(this.indtastModel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "Indtast information for at\r\noprette en ny bil";
            // 
            // indsendBil
            // 
            this.indsendBil.Location = new System.Drawing.Point(428, 37);
            this.indsendBil.Name = "indsendBil";
            this.indsendBil.Size = new System.Drawing.Size(72, 55);
            this.indsendBil.TabIndex = 41;
            this.indsendBil.Text = "Bekræft";
            this.indsendBil.UseVisualStyleBackColor = true;
            this.indsendBil.Click += new System.EventHandler(this.indsendBil_Click);
            // 
            // Nummerplade
            // 
            this.Nummerplade.AutoSize = true;
            this.Nummerplade.Location = new System.Drawing.Point(245, 57);
            this.Nummerplade.Name = "Nummerplade";
            this.Nummerplade.Size = new System.Drawing.Size(72, 13);
            this.Nummerplade.TabIndex = 40;
            this.Nummerplade.Text = "Nummerplade";
            // 
            // Bilfabrikant
            // 
            this.Bilfabrikant.AutoSize = true;
            this.Bilfabrikant.Location = new System.Drawing.Point(245, 31);
            this.Bilfabrikant.Name = "Bilfabrikant";
            this.Bilfabrikant.Size = new System.Drawing.Size(59, 13);
            this.Bilfabrikant.TabIndex = 39;
            this.Bilfabrikant.Text = "Bilfabrikant";
            // 
            // indtastNummerplade
            // 
            this.indtastNummerplade.Location = new System.Drawing.Point(322, 54);
            this.indtastNummerplade.Name = "indtastNummerplade";
            this.indtastNummerplade.Size = new System.Drawing.Size(100, 20);
            this.indtastNummerplade.TabIndex = 38;
            this.indtastNummerplade.TextChanged += new System.EventHandler(this.indtastNummerplade_TextChanged);
            // 
            // indtastFabrikant
            // 
            this.indtastFabrikant.Location = new System.Drawing.Point(322, 28);
            this.indtastFabrikant.Name = "indtastFabrikant";
            this.indtastFabrikant.Size = new System.Drawing.Size(100, 20);
            this.indtastFabrikant.TabIndex = 37;
            this.indtastFabrikant.TextChanged += new System.EventHandler(this.indtastFabrikant_TextChanged);
            // 
            // indtastBruger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 269);
            this.Controls.Add(this.splitContainer1);
            this.Name = "indtastBruger";
            this.Text = "indtastBruger";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button indsendBruger;
        private System.Windows.Forms.Label efternavn;
        private System.Windows.Forms.Label fornavn;
        private System.Windows.Forms.TextBox indtastEfternavn;
        private System.Windows.Forms.TextBox indtastNavn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button indsendBil;
        private System.Windows.Forms.Label Nummerplade;
        private System.Windows.Forms.Label Bilfabrikant;
        private System.Windows.Forms.TextBox indtastNummerplade;
        private System.Windows.Forms.TextBox indtastFabrikant;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.TextBox indtastModel;

        public string GetModelText()
        {
            return indtastModel.Text;
            
        }

    }
}