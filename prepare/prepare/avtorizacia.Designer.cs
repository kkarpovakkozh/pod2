namespace prepare
{
    partial class avtorizacia
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
            this.ideventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkVKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkTimepadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user127_dbDataSet = new prepare.user127_dbDataSet();
            this.eventTableAdapter = new prepare.user127_dbDataSetTableAdapters.EventTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user127_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ideventDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.daysCountDataGridViewTextBoxColumn,
            this.linkVKDataGridViewTextBoxColumn,
            this.linkTimepadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // ideventDataGridViewTextBoxColumn
            // 
            this.ideventDataGridViewTextBoxColumn.DataPropertyName = "Id_event";
            this.ideventDataGridViewTextBoxColumn.HeaderText = "Id_event";
            this.ideventDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ideventDataGridViewTextBoxColumn.Name = "ideventDataGridViewTextBoxColumn";
            this.ideventDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // daysCountDataGridViewTextBoxColumn
            // 
            this.daysCountDataGridViewTextBoxColumn.DataPropertyName = "DaysCount";
            this.daysCountDataGridViewTextBoxColumn.HeaderText = "DaysCount";
            this.daysCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysCountDataGridViewTextBoxColumn.Name = "daysCountDataGridViewTextBoxColumn";
            // 
            // linkVKDataGridViewTextBoxColumn
            // 
            this.linkVKDataGridViewTextBoxColumn.DataPropertyName = "LinkVK";
            this.linkVKDataGridViewTextBoxColumn.HeaderText = "LinkVK";
            this.linkVKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.linkVKDataGridViewTextBoxColumn.Name = "linkVKDataGridViewTextBoxColumn";
            // 
            // linkTimepadDataGridViewTextBoxColumn
            // 
            this.linkTimepadDataGridViewTextBoxColumn.DataPropertyName = "LinkTimepad";
            this.linkTimepadDataGridViewTextBoxColumn.HeaderText = "LinkTimepad";
            this.linkTimepadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.linkTimepadDataGridViewTextBoxColumn.Name = "linkTimepadDataGridViewTextBoxColumn";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.user127_dbDataSet;
            // 
            // user127_dbDataSet
            // 
            this.user127_dbDataSet.DataSetName = "user127_dbDataSet";
            this.user127_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // avtorizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "avtorizacia";
            this.Text = "avtorizacia";
            this.Load += new System.EventHandler(this.avtorizacia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user127_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private user127_dbDataSet user127_dbDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private user127_dbDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkVKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkTimepadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}