namespace prepare
{
    partial class organizator
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
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auser1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user127_dbDataSet = new prepare.user127_dbDataSet();
            this.auser1TableAdapter = new prepare.user127_dbDataSetTableAdapters.Auser1TableAdapter();
            this.editorgbtn = new System.Windows.Forms.Button();
            this.deleteorgbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auser1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user127_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduserDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.auser1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // auser1BindingSource
            // 
            this.auser1BindingSource.DataMember = "Auser1";
            this.auser1BindingSource.DataSource = this.user127_dbDataSet;
            // 
            // user127_dbDataSet
            // 
            this.user127_dbDataSet.DataSetName = "user127_dbDataSet";
            this.user127_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auser1TableAdapter
            // 
            this.auser1TableAdapter.ClearBeforeFill = true;
            // 
            // editorgbtn
            // 
            this.editorgbtn.Location = new System.Drawing.Point(13, 326);
            this.editorgbtn.Name = "editorgbtn";
            this.editorgbtn.Size = new System.Drawing.Size(115, 32);
            this.editorgbtn.TabIndex = 1;
            this.editorgbtn.Text = "edit";
            this.editorgbtn.UseVisualStyleBackColor = true;
            this.editorgbtn.Click += new System.EventHandler(this.editorgbtn_Click);
            // 
            // deleteorgbtn
            // 
            this.deleteorgbtn.Location = new System.Drawing.Point(149, 326);
            this.deleteorgbtn.Name = "deleteorgbtn";
            this.deleteorgbtn.Size = new System.Drawing.Size(115, 32);
            this.deleteorgbtn.TabIndex = 2;
            this.deleteorgbtn.Text = "delete";
            this.deleteorgbtn.UseVisualStyleBackColor = true;
            this.deleteorgbtn.Click += new System.EventHandler(this.deleteorgbtn_Click);
            // 
            // organizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteorgbtn);
            this.Controls.Add(this.editorgbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "organizator";
            this.Text = "organizator";
            this.Load += new System.EventHandler(this.organizator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auser1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user127_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private user127_dbDataSet user127_dbDataSet;
        private System.Windows.Forms.BindingSource auser1BindingSource;
        private user127_dbDataSetTableAdapters.Auser1TableAdapter auser1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button editorgbtn;
        private System.Windows.Forms.Button deleteorgbtn;
    }
}