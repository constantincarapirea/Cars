namespace Automobile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.firmaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet4 = new Automobile.AutomobilDataSet4();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet = new Automobile.AutomobilDataSet();
            this.firmaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.firmaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firmaListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.firmaTableAdapter = new Automobile.AutomobilDataSetTableAdapters.FirmaTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.culoareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet5 = new Automobile.AutomobilDataSet5();
            this.culoareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet1 = new Automobile.AutomobilDataSet1();
            this.culoareTableAdapter = new Automobile.AutomobilDataSet1TableAdapters.CuloareTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.combustibilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet6 = new Automobile.AutomobilDataSet6();
            this.combustibilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet2 = new Automobile.AutomobilDataSet2();
            this.combustibilTableAdapter = new Automobile.AutomobilDataSet2TableAdapters.CombustibilTableAdapter();
            this.taraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet7 = new Automobile.AutomobilDataSet7();
            this.taraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobilDataSet3 = new Automobile.AutomobilDataSet3();
            this.taraTableAdapter = new Automobile.AutomobilDataSet3TableAdapters.TaraTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.firmaTableAdapter1 = new Automobile.AutomobilDataSet4TableAdapters.FirmaTableAdapter();
            this.culoareTableAdapter1 = new Automobile.AutomobilDataSet5TableAdapters.CuloareTableAdapter();
            this.combustibilTableAdapter1 = new Automobile.AutomobilDataSet6TableAdapters.CombustibilTableAdapter();
            this.taraTableAdapter1 = new Automobile.AutomobilDataSet7TableAdapters.TaraTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.culoareBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.culoareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.firmaBindingSource4;
            this.comboBox1.DisplayMember = "Denumire";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 151);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IDFirma";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // firmaBindingSource4
            // 
            this.firmaBindingSource4.DataMember = "Firma";
            this.firmaBindingSource4.DataSource = this.automobilDataSet4;
            // 
            // automobilDataSet4
            // 
            this.automobilDataSet4.DataSetName = "AutomobilDataSet4";
            this.automobilDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataMember = "Firma";
            this.firmaBindingSource.DataSource = this.automobilDataSet;
            // 
            // automobilDataSet
            // 
            this.automobilDataSet.DataSetName = "AutomobilDataSet";
            this.automobilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaBindingSource1
            // 
            this.firmaBindingSource1.DataMember = "Firma";
            // 
            // firmaBindingSource2
            // 
            this.firmaBindingSource2.DataMember = "Firma";
            // 
            // firmaTableAdapter
            // 
            this.firmaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.culoareBindingSource1;
            this.comboBox2.DisplayMember = "Denumire";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(162, 186);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 27);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "IDCuloare";
            // 
            // culoareBindingSource1
            // 
            this.culoareBindingSource1.DataMember = "Culoare";
            this.culoareBindingSource1.DataSource = this.automobilDataSet5;
            // 
            // automobilDataSet5
            // 
            this.automobilDataSet5.DataSetName = "AutomobilDataSet5";
            this.automobilDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // culoareBindingSource
            // 
            this.culoareBindingSource.DataMember = "Culoare";
            this.culoareBindingSource.DataSource = this.automobilDataSet1;
            // 
            // automobilDataSet1
            // 
            this.automobilDataSet1.DataSetName = "AutomobilDataSet1";
            this.automobilDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // culoareTableAdapter
            // 
            this.culoareTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.combustibilBindingSource1;
            this.comboBox3.DisplayMember = "Denumire";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(162, 221);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(180, 27);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.ValueMember = "IDTipComb";
            // 
            // combustibilBindingSource1
            // 
            this.combustibilBindingSource1.DataMember = "Combustibil";
            this.combustibilBindingSource1.DataSource = this.automobilDataSet6;
            // 
            // automobilDataSet6
            // 
            this.automobilDataSet6.DataSetName = "AutomobilDataSet6";
            this.automobilDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combustibilBindingSource
            // 
            this.combustibilBindingSource.DataMember = "Combustibil";
            this.combustibilBindingSource.DataSource = this.automobilDataSet2;
            // 
            // automobilDataSet2
            // 
            this.automobilDataSet2.DataSetName = "AutomobilDataSet2";
            this.automobilDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combustibilTableAdapter
            // 
            this.combustibilTableAdapter.ClearBeforeFill = true;
            // 
            // taraBindingSource1
            // 
            this.taraBindingSource1.DataMember = "Tara";
            this.taraBindingSource1.DataSource = this.automobilDataSet7;
            // 
            // automobilDataSet7
            // 
            this.automobilDataSet7.DataSetName = "AutomobilDataSet7";
            this.automobilDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taraBindingSource
            // 
            this.taraBindingSource.DataMember = "Tara";
            this.taraBindingSource.DataSource = this.automobilDataSet3;
            // 
            // automobilDataSet3
            // 
            this.automobilDataSet3.DataSetName = "AutomobilDataSet3";
            this.automobilDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taraTableAdapter
            // 
            this.taraTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(69, 395);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Introdu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(162, 42);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 26);
            this.textBox4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Firma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Culoare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Combustibil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(117, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(162, 83);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 26);
            this.textBox5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(65, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Denumire";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(162, 117);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 26);
            this.textBox6.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(81, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "AnProd";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(162, 256);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(180, 26);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(162, 290);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 26);
            this.textBox8.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(91, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Capcil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(105, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pret";
            // 
            // firmaTableAdapter1
            // 
            this.firmaTableAdapter1.ClearBeforeFill = true;
            // 
            // culoareTableAdapter1
            // 
            this.culoareTableAdapter1.ClearBeforeFill = true;
            // 
            // combustibilTableAdapter1
            // 
            this.combustibilTableAdapter1.ClearBeforeFill = true;
            // 
            // taraTableAdapter1
            // 
            this.taraTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Introducere Auto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.culoareBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.culoareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
 
  
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource firmaListBindingSource;
        
        private System.Windows.Forms.BindingSource firmaBindingSource1;
   
      
        private System.Windows.Forms.BindingSource firmaBindingSource2;

        private System.Windows.Forms.BindingSource firmaBindingSource3;
        private AutomobilDataSet automobilDataSet;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private AutomobilDataSetTableAdapters.FirmaTableAdapter firmaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private AutomobilDataSet1 automobilDataSet1;
        private System.Windows.Forms.BindingSource culoareBindingSource;
        private AutomobilDataSet1TableAdapters.CuloareTableAdapter culoareTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private AutomobilDataSet2 automobilDataSet2;
        private System.Windows.Forms.BindingSource combustibilBindingSource;
        private AutomobilDataSet2TableAdapters.CombustibilTableAdapter combustibilTableAdapter;
        private AutomobilDataSet3 automobilDataSet3;
        private System.Windows.Forms.BindingSource taraBindingSource;
        private AutomobilDataSet3TableAdapters.TaraTableAdapter taraTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private AutomobilDataSet4 automobilDataSet4;
        private System.Windows.Forms.BindingSource firmaBindingSource4;
        private AutomobilDataSet4TableAdapters.FirmaTableAdapter firmaTableAdapter1;
        private AutomobilDataSet5 automobilDataSet5;
        private System.Windows.Forms.BindingSource culoareBindingSource1;
        private AutomobilDataSet5TableAdapters.CuloareTableAdapter culoareTableAdapter1;
        private AutomobilDataSet6 automobilDataSet6;
        private System.Windows.Forms.BindingSource combustibilBindingSource1;
        private AutomobilDataSet6TableAdapters.CombustibilTableAdapter combustibilTableAdapter1;
        private AutomobilDataSet7 automobilDataSet7;
        private System.Windows.Forms.BindingSource taraBindingSource1;
        private AutomobilDataSet7TableAdapters.TaraTableAdapter taraTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}