namespace WindowsFormsApp1
{
    partial class Redigering
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
            this.Brugere = new System.Windows.Forms.ListBox();
            this.bil = new System.Windows.Forms.ListBox();
            this.kørselDataSet = new WindowsFormsApp1.kørselDataSet();
            this.brugerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerTableAdapter = new WindowsFormsApp1.kørselDataSetTableAdapters.brugerTableAdapter();
            this.bilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilTableAdapter = new WindowsFormsApp1.kørselDataSetTableAdapters.bilTableAdapter();
            this.Aktiv = new System.Windows.Forms.LinkLabel();
            this.kørteKm = new System.Windows.Forms.Label();
            this.efterNavnMenu = new System.Windows.Forms.Label();
            this.forNavnMenu = new System.Windows.Forms.Label();
            this.kmKørtBilLabel = new System.Windows.Forms.Label();
            this.nummerpladeNavn = new System.Windows.Forms.Label();
            this.modelNavn = new System.Windows.Forms.Label();
            this.bilfabrikantNavn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Brugere
            // 
            this.Brugere.AccessibleName = "";
            this.Brugere.DataSource = this.brugerBindingSource;
            this.Brugere.DisplayMember = "samletNavn";
            this.Brugere.FormattingEnabled = true;
            this.Brugere.Location = new System.Drawing.Point(402, 46);
            this.Brugere.Name = "Brugere";
            this.Brugere.Size = new System.Drawing.Size(185, 290);
            this.Brugere.TabIndex = 6;
            this.Brugere.UseTabStops = false;
            this.Brugere.ValueMember = "brugerNr";
            // 
            // bil
            // 
            this.bil.DataSource = this.bilBindingSource;
            this.bil.DisplayMember = "bilNavn";
            this.bil.FormattingEnabled = true;
            this.bil.Location = new System.Drawing.Point(12, 46);
            this.bil.Name = "bil";
            this.bil.Size = new System.Drawing.Size(185, 290);
            this.bil.TabIndex = 5;
            // 
            // kørselDataSet
            // 
            this.kørselDataSet.DataSetName = "kørselDataSet";
            this.kørselDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brugerBindingSource
            // 
            this.brugerBindingSource.DataMember = "bruger";
            this.brugerBindingSource.DataSource = this.kørselDataSet;
            // 
            // brugerTableAdapter
            // 
            this.brugerTableAdapter.ClearBeforeFill = true;
            // 
            // bilBindingSource
            // 
            this.bilBindingSource.DataMember = "bil";
            this.bilBindingSource.DataSource = this.kørselDataSet;
            // 
            // bilTableAdapter
            // 
            this.bilTableAdapter.ClearBeforeFill = true;
            // 
            // Aktiv
            // 
            this.Aktiv.AutoSize = true;
            this.Aktiv.Location = new System.Drawing.Point(200, 85);
            this.Aktiv.Name = "Aktiv";
            this.Aktiv.Size = new System.Drawing.Size(31, 13);
            this.Aktiv.TabIndex = 10;
            this.Aktiv.TabStop = true;
            this.Aktiv.Text = "Aktiv";
            // 
            // kørteKm
            // 
            this.kørteKm.AutoSize = true;
            this.kørteKm.Location = new System.Drawing.Point(200, 72);
            this.kørteKm.Name = "kørteKm";
            this.kørteKm.Size = new System.Drawing.Size(76, 13);
            this.kørteKm.TabIndex = 9;
            this.kørteKm.Text = "kørte kilometer";
            // 
            // efterNavnMenu
            // 
            this.efterNavnMenu.AutoSize = true;
            this.efterNavnMenu.Location = new System.Drawing.Point(200, 59);
            this.efterNavnMenu.Name = "efterNavnMenu";
            this.efterNavnMenu.Size = new System.Drawing.Size(52, 13);
            this.efterNavnMenu.TabIndex = 8;
            this.efterNavnMenu.Text = "efternavn";
            // 
            // forNavnMenu
            // 
            this.forNavnMenu.AutoSize = true;
            this.forNavnMenu.Location = new System.Drawing.Point(200, 46);
            this.forNavnMenu.Name = "forNavnMenu";
            this.forNavnMenu.Size = new System.Drawing.Size(43, 13);
            this.forNavnMenu.TabIndex = 7;
            this.forNavnMenu.Text = "fornavn";
            // 
            // kmKørtBilLabel
            // 
            this.kmKørtBilLabel.AutoSize = true;
            this.kmKørtBilLabel.Location = new System.Drawing.Point(591, 85);
            this.kmKørtBilLabel.Name = "kmKørtBilLabel";
            this.kmKørtBilLabel.Size = new System.Drawing.Size(80, 13);
            this.kmKørtBilLabel.TabIndex = 14;
            this.kmKørtBilLabel.Text = "Kørte kilometer:";
            // 
            // nummerpladeNavn
            // 
            this.nummerpladeNavn.AutoSize = true;
            this.nummerpladeNavn.Location = new System.Drawing.Point(591, 72);
            this.nummerpladeNavn.Name = "nummerpladeNavn";
            this.nummerpladeNavn.Size = new System.Drawing.Size(72, 13);
            this.nummerpladeNavn.TabIndex = 13;
            this.nummerpladeNavn.Text = "Nummerplade";
            // 
            // modelNavn
            // 
            this.modelNavn.AutoSize = true;
            this.modelNavn.Location = new System.Drawing.Point(591, 59);
            this.modelNavn.Name = "modelNavn";
            this.modelNavn.Size = new System.Drawing.Size(36, 13);
            this.modelNavn.TabIndex = 12;
            this.modelNavn.Text = "Model";
            // 
            // bilfabrikantNavn
            // 
            this.bilfabrikantNavn.AutoSize = true;
            this.bilfabrikantNavn.Location = new System.Drawing.Point(591, 46);
            this.bilfabrikantNavn.Name = "bilfabrikantNavn";
            this.bilfabrikantNavn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bilfabrikantNavn.Size = new System.Drawing.Size(41, 13);
            this.bilfabrikantNavn.TabIndex = 11;
            this.bilfabrikantNavn.Text = "Mærke";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(594, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(594, 132);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 20);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(594, 159);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(190, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(594, 186);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(190, 20);
            this.textBox7.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(203, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "service";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 52);
            this.button2.TabIndex = 24;
            this.button2.Text = "godkend ændring";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 52);
            this.button3.TabIndex = 25;
            this.button3.Text = "godkend ændring";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Redigering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kmKørtBilLabel);
            this.Controls.Add(this.nummerpladeNavn);
            this.Controls.Add(this.modelNavn);
            this.Controls.Add(this.bilfabrikantNavn);
            this.Controls.Add(this.Aktiv);
            this.Controls.Add(this.kørteKm);
            this.Controls.Add(this.efterNavnMenu);
            this.Controls.Add(this.forNavnMenu);
            this.Controls.Add(this.Brugere);
            this.Controls.Add(this.bil);
            this.Name = "Redigering";
            this.Text = "Redigering";
            this.Load += new System.EventHandler(this.Redigering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Brugere;
        private System.Windows.Forms.ListBox bil;
        private kørselDataSet kørselDataSet;
        private System.Windows.Forms.BindingSource brugerBindingSource;
        private kørselDataSetTableAdapters.brugerTableAdapter brugerTableAdapter;
        private System.Windows.Forms.BindingSource bilBindingSource;
        private kørselDataSetTableAdapters.bilTableAdapter bilTableAdapter;
        private System.Windows.Forms.LinkLabel Aktiv;
        private System.Windows.Forms.Label kørteKm;
        private System.Windows.Forms.Label efterNavnMenu;
        private System.Windows.Forms.Label forNavnMenu;
        private System.Windows.Forms.Label kmKørtBilLabel;
        private System.Windows.Forms.Label nummerpladeNavn;
        private System.Windows.Forms.Label modelNavn;
        private System.Windows.Forms.Label bilfabrikantNavn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}