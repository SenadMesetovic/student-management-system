namespace StudentManagmentSystem
{
    partial class StudentDocumentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox_showPreview = new System.Windows.Forms.CheckBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_scan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DataGridView_files = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_documentDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_fileUploaded = new System.Windows.Forms.Label();
            this.comboBox_documentName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Back = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_files)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.checkBox_showPreview);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(934, 27);
            this.panel4.TabIndex = 26;
            // 
            // checkBox_showPreview
            // 
            this.checkBox_showPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_showPreview.AutoSize = true;
            this.checkBox_showPreview.Location = new System.Drawing.Point(12, 2);
            this.checkBox_showPreview.Name = "checkBox_showPreview";
            this.checkBox_showPreview.Size = new System.Drawing.Size(150, 25);
            this.checkBox_showPreview.TabIndex = 0;
            this.checkBox_showPreview.Text = "Show preview";
            this.checkBox_showPreview.UseVisualStyleBackColor = true;
            this.checkBox_showPreview.CheckedChanged += new System.EventHandler(this.checkBox_showPreview_CheckedChanged);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(788, 198);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(126, 36);
            this.button_add.TabIndex = 33;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_click);
            // 
            // button_browse
            // 
            this.button_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_browse.BackColor = System.Drawing.Color.Chocolate;
            this.button_browse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_browse.ForeColor = System.Drawing.Color.White;
            this.button_browse.Location = new System.Drawing.Point(656, 83);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(258, 36);
            this.button_browse.TabIndex = 32;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = false;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.BackColor = System.Drawing.Color.Firebrick;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(656, 198);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(126, 36);
            this.button_delete.TabIndex = 28;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_scan
            // 
            this.button_scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_scan.BackColor = System.Drawing.Color.Green;
            this.button_scan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scan.ForeColor = System.Drawing.Color.White;
            this.button_scan.Location = new System.Drawing.Point(656, 40);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(258, 36);
            this.button_scan.TabIndex = 28;
            this.button_scan.Text = "Scan document";
            this.button_scan.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(12, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Description:";
            // 
            // DataGridView_files
            // 
            this.DataGridView_files.AllowUserToAddRows = false;
            this.DataGridView_files.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_files.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_files.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_files.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_files.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_files.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_files.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_files.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_files.EnableHeadersVisualStyles = false;
            this.DataGridView_files.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_files.Location = new System.Drawing.Point(12, 6);
            this.DataGridView_files.Name = "DataGridView_files";
            this.DataGridView_files.ReadOnly = true;
            this.DataGridView_files.RowHeadersVisible = false;
            this.DataGridView_files.RowTemplate.Height = 80;
            this.DataGridView_files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_files.Size = new System.Drawing.Size(910, 261);
            this.DataGridView_files.TabIndex = 1;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_files.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_files.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_files.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_files.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_files.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_files.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_files.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_files.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_files.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_files.ThemeStyle.ReadOnly = true;
            this.DataGridView_files.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_files.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_files.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_files.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_files.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_files.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_files.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_files.Click += new System.EventHandler(this.DataGridView_files_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.DataGridView_files);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 273);
            this.panel2.TabIndex = 24;
            // 
            // textBox_documentDescription
            // 
            this.textBox_documentDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_documentDescription.Location = new System.Drawing.Point(16, 114);
            this.textBox_documentDescription.Multiline = true;
            this.textBox_documentDescription.Name = "textBox_documentDescription";
            this.textBox_documentDescription.Size = new System.Drawing.Size(634, 111);
            this.textBox_documentDescription.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type of Document:";
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(208, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(240, 24);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Manage Documents";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label_fileUploaded);
            this.panel3.Controls.Add(this.comboBox_documentName);
            this.panel3.Controls.Add(this.button_add);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button_browse);
            this.panel3.Controls.Add(this.button_delete);
            this.panel3.Controls.Add(this.button_scan);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox_documentDescription);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 254);
            this.panel3.TabIndex = 25;
            // 
            // label_fileUploaded
            // 
            this.label_fileUploaded.AutoSize = true;
            this.label_fileUploaded.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fileUploaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_fileUploaded.Location = new System.Drawing.Point(656, 126);
            this.label_fileUploaded.Name = "label_fileUploaded";
            this.label_fileUploaded.Size = new System.Drawing.Size(0, 21);
            this.label_fileUploaded.TabIndex = 35;
            this.label_fileUploaded.MouseHover += new System.EventHandler(this.label_fileUploaded_MouseHover);
            // 
            // comboBox_documentName
            // 
            this.comboBox_documentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_documentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox_documentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_documentName.FormattingEnabled = true;
            this.comboBox_documentName.Location = new System.Drawing.Point(16, 40);
            this.comboBox_documentName.Name = "comboBox_documentName";
            this.comboBox_documentName.Size = new System.Drawing.Size(634, 29);
            this.comboBox_documentName.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(656, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 36);
            this.button1.TabIndex = 32;
            this.button1.Text = "Generate new document";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.button_Back);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 48);
            this.panel1.TabIndex = 23;
            // 
            // button_Back
            // 
            this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Back.BackColor = System.Drawing.Color.Chocolate;
            this.button_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.ForeColor = System.Drawing.Color.White;
            this.button_Back.Location = new System.Drawing.Point(758, 10);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(164, 32);
            this.button_Back.TabIndex = 34;
            this.button_Back.Text = "<< Back";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click_1);
            // 
            // StudentDocumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentDocumentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDocumentsForm";
            this.Load += new System.EventHandler(this.StudentDocumentsForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_files)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_files;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_documentDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_documentName;
        private System.Windows.Forms.Label label_fileUploaded;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox_showPreview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Back;
    }
}