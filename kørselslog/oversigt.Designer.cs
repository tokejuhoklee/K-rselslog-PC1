namespace kørselslog
{
    partial class oversigt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kørselDataSet = new WindowsFormsApp1.kørselDataSet();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logTableAdapter = new WindowsFormsApp1.kørselDataSetTableAdapters.logTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redigeringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmKørtBilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmKørtBrugerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.redigeringDataGridViewTextBoxColumn,
            this.kmKørtBilDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.kmKørtBrugerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // kørselDataSet
            // 
            this.kørselDataSet.DataSetName = "kørselDataSet";
            this.kørselDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "log";
            this.logBindingSource.DataSource = this.kørselDataSet;
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "opretForbindelse";
            this.dataGridViewTextBoxColumn2.HeaderText = "opretForbindelse";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "opretBruger";
            this.dataGridViewTextBoxColumn3.HeaderText = "opretBruger";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "opretBil";
            this.dataGridViewTextBoxColumn4.HeaderText = "opretBil";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // redigeringDataGridViewTextBoxColumn
            // 
            this.redigeringDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.redigeringDataGridViewTextBoxColumn.DataPropertyName = "redigering";
            this.redigeringDataGridViewTextBoxColumn.HeaderText = "redigering";
            this.redigeringDataGridViewTextBoxColumn.Name = "redigeringDataGridViewTextBoxColumn";
            this.redigeringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kmKørtBilDataGridViewTextBoxColumn
            // 
            this.kmKørtBilDataGridViewTextBoxColumn.DataPropertyName = "kmKørtBil";
            this.kmKørtBilDataGridViewTextBoxColumn.HeaderText = "kmKørtBil";
            this.kmKørtBilDataGridViewTextBoxColumn.Name = "kmKørtBilDataGridViewTextBoxColumn";
            this.kmKørtBilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "handling";
            this.dataGridViewTextBoxColumn1.HeaderText = "handling";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 157;
            // 
            // kmKørtBrugerDataGridViewTextBoxColumn
            // 
            this.kmKørtBrugerDataGridViewTextBoxColumn.DataPropertyName = "kmKørtBruger";
            this.kmKørtBrugerDataGridViewTextBoxColumn.HeaderText = "kmKørtBruger";
            this.kmKørtBrugerDataGridViewTextBoxColumn.Name = "kmKørtBrugerDataGridViewTextBoxColumn";
            this.kmKørtBrugerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oversigt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "oversigt";
            this.Text = "oversigt";
            this.Load += new System.EventHandler(this.oversigt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kørselDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn handlingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmKørtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opretBrugerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opretBilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opretForbindelseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsApp1.kørselDataSet kørselDataSet;
        private System.Windows.Forms.BindingSource logBindingSource;
        private WindowsFormsApp1.kørselDataSetTableAdapters.logTableAdapter logTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn redigeringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmKørtBilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmKørtBrugerDataGridViewTextBoxColumn;
    }
}