namespace WindowsFormsApp1
{
    partial class hovedmenu
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
            this.kmInput = new System.Windows.Forms.Button();
            this.opretBilBruger = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.redigering = new System.Windows.Forms.Button();
            this.forbind = new System.Windows.Forms.Button();
            this.kmKørtTableAdapter1 = new WindowsFormsApp1.kørselDataSetTableAdapters.kmKørtTableAdapter();
            this.udskriv = new System.Windows.Forms.Button();
            this.kørselDataSet = new WindowsFormsApp1.kørselDataSet();
            this.brugerTableAdapter = new WindowsFormsApp1.kørselDataSetTableAdapters.brugerTableAdapter();
            this.Brugere = new System.Windows.Forms.ListBox();
            this.brugerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kørselDataSet2 = new WindowsFormsApp1.kørselDataSet();
            this.sletadata = new System.Windows.Forms.Button();
            this.bilTableAdapter = new WindowsFormsApp1.kørselDataSetTableAdapters.bilTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.kørteKm = new System.Windows.Forms.Label();
            this.efterNavnMenu = new System.Windows.Forms.Label();
            this.forNavnMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kørselDataSet1 = new WindowsFormsApp1.kørselDataSet1();
            this.bilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kmInput
            // 
            this.kmInput.AccessibleDescription = "";
            this.kmInput.Location = new System.Drawing.Point(12, 324);
            this.kmInput.Name = "kmInput";
            this.kmInput.Size = new System.Drawing.Size(189, 59);
            this.kmInput.TabIndex = 0;
            this.kmInput.Text = "Indberetning af kørsel";
            this.kmInput.UseVisualStyleBackColor = true;
            this.kmInput.Click += new System.EventHandler(this.KM_input_Click);
            // 
            // opretBilBruger
            // 
            this.opretBilBruger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opretBilBruger.Location = new System.Drawing.Point(209, 324);
            this.opretBilBruger.Name = "opretBilBruger";
            this.opretBilBruger.Size = new System.Drawing.Size(189, 59);
            this.opretBilBruger.TabIndex = 1;
            this.opretBilBruger.Text = "Oprettelse af køretøj/bruger";
            this.opretBilBruger.UseCompatibleTextRendering = true;
            this.opretBilBruger.UseVisualStyleBackColor = true;
            this.opretBilBruger.Click += new System.EventHandler(this.ny_bil_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(404, 324);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(189, 59);
            this.Log.TabIndex = 2;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.oversigt_Click);
            this.Log.MouseHover += new System.EventHandler(this.ShowMyMessage);
            // 
            // redigering
            // 
            this.redigering.Location = new System.Drawing.Point(599, 324);
            this.redigering.Name = "redigering";
            this.redigering.Size = new System.Drawing.Size(189, 59);
            this.redigering.TabIndex = 3;
            this.redigering.Text = "Redigering af bil/bruger";
            this.redigering.UseVisualStyleBackColor = true;
            this.redigering.Click += new System.EventHandler(this.redigering_Click);
            // 
            // forbind
            // 
            this.forbind.Location = new System.Drawing.Point(690, 12);
            this.forbind.Name = "forbind";
            this.forbind.Size = new System.Drawing.Size(98, 23);
            this.forbind.TabIndex = 4;
            this.forbind.Text = "Forbind til server";
            this.forbind.UseVisualStyleBackColor = true;
            this.forbind.Click += new System.EventHandler(this.button1_Click);
            // 
            // kmKørtTableAdapter1
            // 
            this.kmKørtTableAdapter1.ClearBeforeFill = true;
            // 
            // udskriv
            // 
            this.udskriv.Location = new System.Drawing.Point(564, 11);
            this.udskriv.Name = "udskriv";
            this.udskriv.Size = new System.Drawing.Size(75, 23);
            this.udskriv.TabIndex = 6;
            this.udskriv.Text = "test";
            this.udskriv.UseVisualStyleBackColor = true;
            this.udskriv.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kørselDataSet
            // 
            this.kørselDataSet.DataSetName = "kørselDataSet";
            this.kørselDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brugerTableAdapter
            // 
            this.brugerTableAdapter.ClearBeforeFill = true;
            // 
            // Brugere
            // 
            this.Brugere.AccessibleName = "";
            this.Brugere.DataSource = this.brugerBindingSource;
            this.Brugere.DisplayMember = "samletNavn";
            this.Brugere.FormattingEnabled = true;
            this.Brugere.Location = new System.Drawing.Point(598, 53);
            this.Brugere.Name = "Brugere";
            this.Brugere.Size = new System.Drawing.Size(189, 264);
            this.Brugere.TabIndex = 7;
            this.Brugere.TabStop = false;
            this.Brugere.UseTabStops = false;
            this.Brugere.ValueMember = "brugerNr";
            this.Brugere.SelectedIndexChanged += new System.EventHandler(this.brugerValg);
            // 
            // brugerBindingSource
            // 
            this.brugerBindingSource.DataMember = "bruger";
            this.brugerBindingSource.DataSource = this.kørselDataSet2;
            // 
            // kørselDataSet2
            // 
            this.kørselDataSet2.DataSetName = "kørselDataSet";
            this.kørselDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sletadata
            // 
            this.sletadata.Location = new System.Drawing.Point(483, 12);
            this.sletadata.Name = "sletadata";
            this.sletadata.Size = new System.Drawing.Size(75, 23);
            this.sletadata.TabIndex = 8;
            this.sletadata.Text = "slet";
            this.sletadata.UseVisualStyleBackColor = true;
            this.sletadata.Click += new System.EventHandler(this.sletadata_Click);
            // 
            // bilTableAdapter
            // 
            this.bilTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 263);
            this.panel1.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.kørteKm);
            this.splitContainer1.Panel1.Controls.Add(this.efterNavnMenu);
            this.splitContainer1.Panel1.Controls.Add(this.forNavnMenu);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(580, 263);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 0;
            // 
            // kørteKm
            // 
            this.kørteKm.AutoSize = true;
            this.kørteKm.Location = new System.Drawing.Point(4, 140);
            this.kørteKm.Name = "kørteKm";
            this.kørteKm.Size = new System.Drawing.Size(35, 13);
            this.kørteKm.TabIndex = 4;
            this.kørteKm.Text = "label1";
            // 
            // efterNavnMenu
            // 
            this.efterNavnMenu.AutoSize = true;
            this.efterNavnMenu.Location = new System.Drawing.Point(3, 123);
            this.efterNavnMenu.Name = "efterNavnMenu";
            this.efterNavnMenu.Size = new System.Drawing.Size(35, 13);
            this.efterNavnMenu.TabIndex = 3;
            this.efterNavnMenu.Text = "label1";
            // 
            // forNavnMenu
            // 
            this.forNavnMenu.AutoSize = true;
            this.forNavnMenu.Location = new System.Drawing.Point(3, 110);
            this.forNavnMenu.Name = "forNavnMenu";
            this.forNavnMenu.Size = new System.Drawing.Size(72, 13);
            this.forNavnMenu.TabIndex = 1;
            this.forNavnMenu.Text = "forNavnMenu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // kørselDataSet1
            // 
            this.kørselDataSet1.DataSetName = "kørselDataSet1";
            this.kørselDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilBindingSource
            // 
            this.bilBindingSource.DataMember = "bil";
            this.bilBindingSource.DataSource = this.kørselDataSet2;
            // 
            // hovedmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sletadata);
            this.Controls.Add(this.Brugere);
            this.Controls.Add(this.udskriv);
            this.Controls.Add(this.forbind);
            this.Controls.Add(this.redigering);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.opretBilBruger);
            this.Controls.Add(this.kmInput);
            this.Name = "hovedmenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.hovedmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kmInput;
        private System.Windows.Forms.Button opretBilBruger;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button redigering;
        private System.Windows.Forms.Button forbind;
        private kørselDataSetTableAdapters.kmKørtTableAdapter kmKørtTableAdapter1;
        private System.Windows.Forms.Button udskriv;
        private kørselDataSet kørselDataSet;
        private kørselDataSetTableAdapters.brugerTableAdapter brugerTableAdapter;
        private System.Windows.Forms.Button sletadata;
        private kørselDataSetTableAdapters.bilTableAdapter bilTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label forNavnMenu;
        private System.Windows.Forms.Label efterNavnMenu;
        private System.Windows.Forms.Label kørteKm;
        private System.Windows.Forms.ListBox Brugere;
        private System.Windows.Forms.CheckBox checkBox1;
        private kørselDataSet1 kørselDataSet1;
        private kørselDataSet kørselDataSet2;
        private System.Windows.Forms.BindingSource bilBindingSource;
        private System.Windows.Forms.BindingSource brugerBindingSource;
    }
}

