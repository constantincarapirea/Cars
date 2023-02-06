namespace Automobile
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anProducereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capCilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustibilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.culoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet9 = new Automobile.AutomobilDataSet9();
            this.ex3TableAdapter = new Automobile.AutomobilDataSet9TableAdapters.Ex3TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ex3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.taraDataGridViewTextBoxColumn,
            this.anProducereDataGridViewTextBoxColumn,
            this.capCilDataGridViewTextBoxColumn,
            this.combustibilDataGridViewTextBoxColumn,
            this.culoareDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ex3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            this.firmaDataGridViewTextBoxColumn.DataPropertyName = "Firma";
            this.firmaDataGridViewTextBoxColumn.HeaderText = "Firma";
            this.firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // taraDataGridViewTextBoxColumn
            // 
            this.taraDataGridViewTextBoxColumn.DataPropertyName = "Tara";
            this.taraDataGridViewTextBoxColumn.HeaderText = "Tara";
            this.taraDataGridViewTextBoxColumn.Name = "taraDataGridViewTextBoxColumn";
            // 
            // anProducereDataGridViewTextBoxColumn
            // 
            this.anProducereDataGridViewTextBoxColumn.DataPropertyName = "AnProducere";
            this.anProducereDataGridViewTextBoxColumn.HeaderText = "AnProducere";
            this.anProducereDataGridViewTextBoxColumn.Name = "anProducereDataGridViewTextBoxColumn";
            // 
            // capCilDataGridViewTextBoxColumn
            // 
            this.capCilDataGridViewTextBoxColumn.DataPropertyName = "CapCil";
            this.capCilDataGridViewTextBoxColumn.HeaderText = "CapCil";
            this.capCilDataGridViewTextBoxColumn.Name = "capCilDataGridViewTextBoxColumn";
            // 
            // combustibilDataGridViewTextBoxColumn
            // 
            this.combustibilDataGridViewTextBoxColumn.DataPropertyName = "Combustibil";
            this.combustibilDataGridViewTextBoxColumn.HeaderText = "Combustibil";
            this.combustibilDataGridViewTextBoxColumn.Name = "combustibilDataGridViewTextBoxColumn";
            // 
            // culoareDataGridViewTextBoxColumn
            // 
            this.culoareDataGridViewTextBoxColumn.DataPropertyName = "Culoare";
            this.culoareDataGridViewTextBoxColumn.HeaderText = "Culoare";
            this.culoareDataGridViewTextBoxColumn.Name = "culoareDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // ex3BindingSource
            // 
            this.ex3BindingSource.DataMember = "Ex3";
            this.ex3BindingSource.DataSource = this.automobilDataSet9;
            // 
            // automobilDataSet9
            // 
            this.automobilDataSet9.DataSetName = "AutomobilDataSet9";
            this.automobilDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ex3TableAdapter
            // 
            this.ex3TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Lista Automobilelor";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ex3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet9)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AutomobilDataSet9 automobilDataSet9;
        private System.Windows.Forms.BindingSource ex3BindingSource;
        private AutomobilDataSet9TableAdapters.Ex3TableAdapter ex3TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anProducereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capCilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustibilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn culoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
    }
}