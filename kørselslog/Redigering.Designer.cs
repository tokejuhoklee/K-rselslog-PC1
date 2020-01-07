namespace kørselslog
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
            this.bil = new System.Windows.Forms.ListBox();
            this.bilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Brugere = new System.Windows.Forms.ListBox();
            this.Aktiv = new System.Windows.Forms.LinkLabel();
            this.kørteKm = new System.Windows.Forms.Label();
            this.efterNavnMenu = new System.Windows.Forms.Label();
            this.forNavnMenu = new System.Windows.Forms.Label();
            this.kmKørtBilLabel = new System.Windows.Forms.Label();
            this.nummerpladeNavn = new System.Windows.Forms.Label();
            this.modelNavn = new System.Windows.Forms.Label();
            this.bilfabrikantNavn = new System.Windows.Forms.Label();
            this.forNavnRedigering = new System.Windows.Forms.TextBox();
            this.redigeringEfternavn = new System.Windows.Forms.TextBox();
            this.redigeringMærke = new System.Windows.Forms.TextBox();
            this.redigeringModel = new System.Windows.Forms.TextBox();
            this.redigeringNummerplade = new System.Windows.Forms.TextBox();
            this.redigeringKørteKm = new System.Windows.Forms.TextBox();
            this.aktivBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.godkendBruger = new System.Windows.Forms.Button();
            this.godkendBil = new System.Windows.Forms.Button();
            this.redigeringNavn = new System.Windows.Forms.Label();
            this.redigeringKørteKmBruger = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.kørselDataSet = new WindowsFormsApp1.kørselDataSet();
            this.brugerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.brugerTableAdapter = new WindowsFormsApp1.kørselDataSetTableAdapters.brugerTableAdapter();
            this.bilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bilTableAdapter = new WindowsFormsApp1.kørselDataSetTableAdapters.bilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bil
            // 
            this.bil.AccessibleName = "";
            this.bil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bil.DataSource = this.bilBindingSource1;
            this.bil.DisplayMember = "bilNavn";
            this.bil.FormattingEnabled = true;
            this.bil.Location = new System.Drawing.Point(5, 10);
            this.bil.Name = "bil";
            this.bil.Size = new System.Drawing.Size(185, 329);
            this.bil.TabIndex = 6;
            this.bil.ValueMember = "bilNr";
            this.bil.SelectedIndexChanged += new System.EventHandler(this.bilValg);
            // 
            // brugerBindingSource
            // 
            this.brugerBindingSource.Sort = "";
            // 
            // Brugere
            // 
            this.Brugere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Brugere.DataSource = this.brugerBindingSource1;
            this.Brugere.DisplayMember = "samletNavn";
            this.Brugere.FormattingEnabled = true;
            this.Brugere.Location = new System.Drawing.Point(3, 10);
            this.Brugere.Name = "Brugere";
            this.Brugere.Size = new System.Drawing.Size(185, 329);
            this.Brugere.TabIndex = 5;
            this.Brugere.ValueMember = "brugerNr";
            this.Brugere.SelectedIndexChanged += new System.EventHandler(this.brugerValg);
            // 
            // Aktiv
            // 
            this.Aktiv.AutoSize = true;
            this.Aktiv.Location = new System.Drawing.Point(191, 49);
            this.Aktiv.Name = "Aktiv";
            this.Aktiv.Size = new System.Drawing.Size(31, 13);
            this.Aktiv.TabIndex = 10;
            this.Aktiv.TabStop = true;
            this.Aktiv.Text = "Aktiv";
            // 
            // kørteKm
            // 
            this.kørteKm.AutoSize = true;
            this.kørteKm.Location = new System.Drawing.Point(191, 36);
            this.kørteKm.Name = "kørteKm";
            this.kørteKm.Size = new System.Drawing.Size(76, 13);
            this.kørteKm.TabIndex = 9;
            this.kørteKm.Text = "kørte kilometer";
            // 
            // efterNavnMenu
            // 
            this.efterNavnMenu.AutoSize = true;
            this.efterNavnMenu.Location = new System.Drawing.Point(191, 23);
            this.efterNavnMenu.Name = "efterNavnMenu";
            this.efterNavnMenu.Size = new System.Drawing.Size(52, 13);
            this.efterNavnMenu.TabIndex = 8;
            this.efterNavnMenu.Text = "efternavn";
            // 
            // forNavnMenu
            // 
            this.forNavnMenu.AutoSize = true;
            this.forNavnMenu.Location = new System.Drawing.Point(191, 10);
            this.forNavnMenu.Name = "forNavnMenu";
            this.forNavnMenu.Size = new System.Drawing.Size(43, 13);
            this.forNavnMenu.TabIndex = 7;
            this.forNavnMenu.Text = "fornavn";
            // 
            // kmKørtBilLabel
            // 
            this.kmKørtBilLabel.AutoSize = true;
            this.kmKørtBilLabel.Location = new System.Drawing.Point(196, 48);
            this.kmKørtBilLabel.Name = "kmKørtBilLabel";
            this.kmKørtBilLabel.Size = new System.Drawing.Size(80, 13);
            this.kmKørtBilLabel.TabIndex = 14;
            this.kmKørtBilLabel.Text = "Kørte kilometer:";
            // 
            // nummerpladeNavn
            // 
            this.nummerpladeNavn.AutoSize = true;
            this.nummerpladeNavn.Location = new System.Drawing.Point(196, 36);
            this.nummerpladeNavn.Name = "nummerpladeNavn";
            this.nummerpladeNavn.Size = new System.Drawing.Size(72, 13);
            this.nummerpladeNavn.TabIndex = 13;
            this.nummerpladeNavn.Text = "Nummerplade";
            // 
            // modelNavn
            // 
            this.modelNavn.AutoSize = true;
            this.modelNavn.Location = new System.Drawing.Point(196, 10);
            this.modelNavn.Name = "modelNavn";
            this.modelNavn.Size = new System.Drawing.Size(36, 13);
            this.modelNavn.TabIndex = 12;
            this.modelNavn.Text = "Model";
            // 
            // bilfabrikantNavn
            // 
            this.bilfabrikantNavn.AutoSize = true;
            this.bilfabrikantNavn.Location = new System.Drawing.Point(196, 23);
            this.bilfabrikantNavn.Name = "bilfabrikantNavn";
            this.bilfabrikantNavn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bilfabrikantNavn.Size = new System.Drawing.Size(41, 13);
            this.bilfabrikantNavn.TabIndex = 11;
            this.bilfabrikantNavn.Text = "Mærke";
            // 
            // forNavnRedigering
            // 
            this.forNavnRedigering.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forNavnRedigering.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brugerBindingSource, "fornavn", true));
            this.forNavnRedigering.Location = new System.Drawing.Point(192, 113);
            this.forNavnRedigering.Name = "forNavnRedigering";
            this.forNavnRedigering.Size = new System.Drawing.Size(186, 20);
            this.forNavnRedigering.TabIndex = 15;
            // 
            // redigeringEfternavn
            // 
            this.redigeringEfternavn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redigeringEfternavn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brugerBindingSource, "efternavn", true));
            this.redigeringEfternavn.Location = new System.Drawing.Point(192, 150);
            this.redigeringEfternavn.Name = "redigeringEfternavn";
            this.redigeringEfternavn.Size = new System.Drawing.Size(186, 20);
            this.redigeringEfternavn.TabIndex = 16;
            // 
            // redigeringMærke
            // 
            this.redigeringMærke.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redigeringMærke.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bilBindingSource, "mærke", true));
            this.redigeringMærke.Location = new System.Drawing.Point(197, 69);
            this.redigeringMærke.Name = "redigeringMærke";
            this.redigeringMærke.Size = new System.Drawing.Size(190, 20);
            this.redigeringMærke.TabIndex = 18;
            // 
            // redigeringModel
            // 
            this.redigeringModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redigeringModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bilBindingSource, "model", true));
            this.redigeringModel.Location = new System.Drawing.Point(197, 96);
            this.redigeringModel.Name = "redigeringModel";
            this.redigeringModel.Size = new System.Drawing.Size(190, 20);
            this.redigeringModel.TabIndex = 19;
            // 
            // redigeringNummerplade
            // 
            this.redigeringNummerplade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redigeringNummerplade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bilBindingSource, "nummerplade", true));
            this.redigeringNummerplade.Location = new System.Drawing.Point(197, 123);
            this.redigeringNummerplade.Name = "redigeringNummerplade";
            this.redigeringNummerplade.Size = new System.Drawing.Size(190, 20);
            this.redigeringNummerplade.TabIndex = 20;
            // 
            // redigeringKørteKm
            // 
            this.redigeringKørteKm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redigeringKørteKm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bilBindingSource, "kmKørt", true));
            this.redigeringKørteKm.Location = new System.Drawing.Point(197, 150);
            this.redigeringKørteKm.Name = "redigeringKørteKm";
            this.redigeringKørteKm.Size = new System.Drawing.Size(190, 20);
            this.redigeringKørteKm.TabIndex = 21;
            // 
            // aktivBox
            // 
            this.aktivBox.AutoSize = true;
            this.aktivBox.Checked = true;
            this.aktivBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aktivBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.brugerBindingSource, "aktiv", true));
            this.aktivBox.Location = new System.Drawing.Point(228, 48);
            this.aktivBox.Name = "aktivBox";
            this.aktivBox.Size = new System.Drawing.Size(67, 17);
            this.aktivBox.TabIndex = 22;
            this.aktivBox.Text = "aktivBox";
            this.aktivBox.UseVisualStyleBackColor = true;
            this.aktivBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "service";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // godkendBruger
            // 
            this.godkendBruger.Location = new System.Drawing.Point(194, 248);
            this.godkendBruger.Name = "godkendBruger";
            this.godkendBruger.Size = new System.Drawing.Size(184, 52);
            this.godkendBruger.TabIndex = 24;
            this.godkendBruger.Text = "godkend ændring";
            this.godkendBruger.UseVisualStyleBackColor = true;
            this.godkendBruger.Click += new System.EventHandler(this.godkendBruger_Click);
            // 
            // godkendBil
            // 
            this.godkendBil.Location = new System.Drawing.Point(196, 248);
            this.godkendBil.Name = "godkendBil";
            this.godkendBil.Size = new System.Drawing.Size(185, 52);
            this.godkendBil.TabIndex = 25;
            this.godkendBil.Text = "godkend ændring";
            this.godkendBil.UseVisualStyleBackColor = true;
            this.godkendBil.Click += new System.EventHandler(this.godkendBil_Click);
            // 
            // redigeringNavn
            // 
            this.redigeringNavn.AutoSize = true;
            this.redigeringNavn.Location = new System.Drawing.Point(194, 94);
            this.redigeringNavn.Name = "redigeringNavn";
            this.redigeringNavn.Size = new System.Drawing.Size(35, 13);
            this.redigeringNavn.TabIndex = 26;
            this.redigeringNavn.Text = "label1";
            // 
            // redigeringKørteKmBruger
            // 
            this.redigeringKørteKmBruger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redigeringKørteKmBruger.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brugerBindingSource, "kmKørt", true));
            this.redigeringKørteKmBruger.Location = new System.Drawing.Point(192, 190);
            this.redigeringKørteKmBruger.Name = "redigeringKørteKmBruger";
            this.redigeringKørteKmBruger.Size = new System.Drawing.Size(186, 20);
            this.redigeringKørteKmBruger.TabIndex = 28;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.redigeringKørteKmBruger);
            this.splitContainer1.Panel1.Controls.Add(this.Brugere);
            this.splitContainer1.Panel1.Controls.Add(this.forNavnMenu);
            this.splitContainer1.Panel1.Controls.Add(this.efterNavnMenu);
            this.splitContainer1.Panel1.Controls.Add(this.redigeringNavn);
            this.splitContainer1.Panel1.Controls.Add(this.kørteKm);
            this.splitContainer1.Panel1.Controls.Add(this.godkendBruger);
            this.splitContainer1.Panel1.Controls.Add(this.Aktiv);
            this.splitContainer1.Panel1.Controls.Add(this.aktivBox);
            this.splitContainer1.Panel1.Controls.Add(this.redigeringEfternavn);
            this.splitContainer1.Panel1.Controls.Add(this.forNavnRedigering);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.bil);
            this.splitContainer1.Panel2.Controls.Add(this.modelNavn);
            this.splitContainer1.Panel2.Controls.Add(this.godkendBil);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.redigeringNummerplade);
            this.splitContainer1.Panel2.Controls.Add(this.nummerpladeNavn);
            this.splitContainer1.Panel2.Controls.Add(this.redigeringKørteKm);
            this.splitContainer1.Panel2.Controls.Add(this.redigeringModel);
            this.splitContainer1.Panel2.Controls.Add(this.kmKørtBilLabel);
            this.splitContainer1.Panel2.Controls.Add(this.redigeringMærke);
            this.splitContainer1.Panel2.Controls.Add(this.bilfabrikantNavn);
            this.splitContainer1.Size = new System.Drawing.Size(775, 356);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.TabIndex = 29;
            // 
            // kørselDataSet
            // 
            this.kørselDataSet.DataSetName = "kørselDataSet";
            this.kørselDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brugerBindingSource1
            // 
            this.brugerBindingSource1.DataMember = "bruger";
            this.brugerBindingSource1.DataSource = this.kørselDataSet;
            // 
            // brugerTableAdapter
            // 
            this.brugerTableAdapter.ClearBeforeFill = true;
            // 
            // bilBindingSource1
            // 
            this.bilBindingSource1.DataMember = "bil";
            this.bilBindingSource1.DataSource = this.kørselDataSet;
            // 
            // bilTableAdapter
            // 
            this.bilTableAdapter.ClearBeforeFill = true;
            // 
            // Redigering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Redigering";
            this.Text = "Redigering";
            this.Load += new System.EventHandler(this.Redigering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bil;
        private System.Windows.Forms.ListBox Brugere;
        private System.Windows.Forms.BindingSource brugerBindingSource;
        private System.Windows.Forms.BindingSource bilBindingSource;
        private System.Windows.Forms.LinkLabel Aktiv;
        private System.Windows.Forms.Label kørteKm;
        private System.Windows.Forms.Label efterNavnMenu;
        private System.Windows.Forms.Label forNavnMenu;
        private System.Windows.Forms.Label kmKørtBilLabel;
        private System.Windows.Forms.Label nummerpladeNavn;
        private System.Windows.Forms.Label modelNavn;
        private System.Windows.Forms.Label bilfabrikantNavn;
        private System.Windows.Forms.TextBox forNavnRedigering;
        private System.Windows.Forms.TextBox redigeringEfternavn;
        private System.Windows.Forms.TextBox redigeringMærke;
        private System.Windows.Forms.TextBox redigeringModel;
        private System.Windows.Forms.TextBox redigeringNummerplade;
        private System.Windows.Forms.TextBox redigeringKørteKm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button godkendBruger;
        private System.Windows.Forms.Button godkendBil;
        private System.Windows.Forms.Label redigeringNavn;
        private System.Windows.Forms.CheckBox aktivBox;
        private System.Windows.Forms.TextBox redigeringKørteKmBruger;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private WindowsFormsApp1.kørselDataSet kørselDataSet;
        private System.Windows.Forms.BindingSource brugerBindingSource1;
        private WindowsFormsApp1.kørselDataSetTableAdapters.brugerTableAdapter brugerTableAdapter;
        private System.Windows.Forms.BindingSource bilBindingSource1;
        private WindowsFormsApp1.kørselDataSetTableAdapters.bilTableAdapter bilTableAdapter;
    }
}