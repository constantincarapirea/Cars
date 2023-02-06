namespace Automobile
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anProducereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capCilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustibilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex51BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet12 = new Automobile.AutomobilDataSet12();
            this.ex51TableAdapter = new Automobile.AutomobilDataSet12TableAdapters.Ex51TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.firmaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anProducereDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capCilDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustibilDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex52BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet13 = new Automobile.AutomobilDataSet13();
            this.ex52TableAdapter = new Automobile.AutomobilDataSet13TableAdapters.Ex52TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ex51BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ex52BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaDataGridViewTextBoxColumn,
            this.taraDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.anProducereDataGridViewTextBoxColumn,
            this.capCilDataGridViewTextBoxColumn,
            this.combustibilDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ex51BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(251, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            this.firmaDataGridViewTextBoxColumn.DataPropertyName = "Firma";
            this.firmaDataGridViewTextBoxColumn.HeaderText = "Firma";
            this.firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            // 
            // taraDataGridViewTextBoxColumn
            // 
            this.taraDataGridViewTextBoxColumn.DataPropertyName = "Tara";
            this.taraDataGridViewTextBoxColumn.HeaderText = "Tara";
            this.taraDataGridViewTextBoxColumn.Name = "taraDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
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
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // ex51BindingSource
            // 
            this.ex51BindingSource.DataMember = "Ex51";
            this.ex51BindingSource.DataSource = this.automobilDataSet12;
            // 
            // automobilDataSet12
            // 
            this.automobilDataSet12.DataSetName = "AutomobilDataSet12";
            this.automobilDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ex51TableAdapter
            // 
            this.ex51TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaDataGridViewTextBoxColumn1,
            this.taraDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.anProducereDataGridViewTextBoxColumn1,
            this.capCilDataGridViewTextBoxColumn1,
            this.combustibilDataGridViewTextBoxColumn1,
            this.pretDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.ex52BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(251, 281);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(766, 183);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // firmaDataGridViewTextBoxColumn1
            // 
            this.firmaDataGridViewTextBoxColumn1.DataPropertyName = "Firma";
            this.firmaDataGridViewTextBoxColumn1.HeaderText = "Firma";
            this.firmaDataGridViewTextBoxColumn1.Name = "firmaDataGridViewTextBoxColumn1";
            // 
            // taraDataGridViewTextBoxColumn1
            // 
            this.taraDataGridViewTextBoxColumn1.DataPropertyName = "Tara";
            this.taraDataGridViewTextBoxColumn1.HeaderText = "Tara";
            this.taraDataGridViewTextBoxColumn1.Name = "taraDataGridViewTextBoxColumn1";
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            // 
            // anProducereDataGridViewTextBoxColumn1
            // 
            this.anProducereDataGridViewTextBoxColumn1.DataPropertyName = "AnProducere";
            this.anProducereDataGridViewTextBoxColumn1.HeaderText = "AnProducere";
            this.anProducereDataGridViewTextBoxColumn1.Name = "anProducereDataGridViewTextBoxColumn1";
            // 
            // capCilDataGridViewTextBoxColumn1
            // 
            this.capCilDataGridViewTextBoxColumn1.DataPropertyName = "CapCil";
            this.capCilDataGridViewTextBoxColumn1.HeaderText = "CapCil";
            this.capCilDataGridViewTextBoxColumn1.Name = "capCilDataGridViewTextBoxColumn1";
            // 
            // combustibilDataGridViewTextBoxColumn1
            // 
            this.combustibilDataGridViewTextBoxColumn1.DataPropertyName = "Combustibil";
            this.combustibilDataGridViewTextBoxColumn1.HeaderText = "Combustibil";
            this.combustibilDataGridViewTextBoxColumn1.Name = "combustibilDataGridViewTextBoxColumn1";
            // 
            // pretDataGridViewTextBoxColumn1
            // 
            this.pretDataGridViewTextBoxColumn1.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn1.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn1.Name = "pretDataGridViewTextBoxColumn1";
            // 
            // ex52BindingSource
            // 
            this.ex52BindingSource.DataMember = "Ex52";
            this.ex52BindingSource.DataSource = this.automobilDataSet13;
            // 
            // automobilDataSet13
            // 
            this.automobilDataSet13.DataSetName = "AutomobilDataSet13";
            this.automobilDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ex52TableAdapter
            // 
            this.ex52TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1005, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(410, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cele mai ieftin automobile de culoare verde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(376, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cele mai scumpe automobile de culoare verde";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Cele mai scumpe automobile";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ex51BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ex52BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AutomobilDataSet12 automobilDataSet12;
        private System.Windows.Forms.BindingSource ex51BindingSource;
        private AutomobilDataSet12TableAdapters.Ex51TableAdapter ex51TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anProducereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capCilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustibilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AutomobilDataSet13 automobilDataSet13;
        private System.Windows.Forms.BindingSource ex52BindingSource;
        private AutomobilDataSet13TableAdapters.Ex52TableAdapter ex52TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anProducereDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn capCilDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustibilDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}