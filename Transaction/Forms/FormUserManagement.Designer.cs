namespace Transaction.Forms
{
    partial class FormUserManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnPermission = new System.Windows.Forms.Panel();
            this.SaleDelete = new System.Windows.Forms.CheckBox();
            this.SaleModify = new System.Windows.Forms.CheckBox();
            this.SaleCreate = new System.Windows.Forms.CheckBox();
            this.SaleView = new System.Windows.Forms.CheckBox();
            this.CustomerDelete = new System.Windows.Forms.CheckBox();
            this.CustomerModify = new System.Windows.Forms.CheckBox();
            this.CustomerCrate = new System.Windows.Forms.CheckBox();
            this.CustomerView = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnApplyPermission = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPermission.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPermission
            // 
            this.pnPermission.Controls.Add(this.SaleDelete);
            this.pnPermission.Controls.Add(this.SaleModify);
            this.pnPermission.Controls.Add(this.SaleCreate);
            this.pnPermission.Controls.Add(this.SaleView);
            this.pnPermission.Controls.Add(this.CustomerDelete);
            this.pnPermission.Controls.Add(this.CustomerModify);
            this.pnPermission.Controls.Add(this.CustomerCrate);
            this.pnPermission.Controls.Add(this.CustomerView);
            this.pnPermission.Controls.Add(this.label3);
            this.pnPermission.Controls.Add(this.label2);
            this.pnPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPermission.Location = new System.Drawing.Point(249, 100);
            this.pnPermission.Name = "pnPermission";
            this.pnPermission.Size = new System.Drawing.Size(777, 342);
            this.pnPermission.TabIndex = 14;
            this.pnPermission.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPermission_Paint);
            // 
            // SaleDelete
            // 
            this.SaleDelete.AutoSize = true;
            this.SaleDelete.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleDelete.Location = new System.Drawing.Point(251, 124);
            this.SaleDelete.Name = "SaleDelete";
            this.SaleDelete.Size = new System.Drawing.Size(68, 28);
            this.SaleDelete.TabIndex = 37;
            this.SaleDelete.Text = "Delete";
            this.SaleDelete.UseVisualStyleBackColor = true;
            // 
            // SaleModify
            // 
            this.SaleModify.AutoSize = true;
            this.SaleModify.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleModify.Location = new System.Drawing.Point(176, 124);
            this.SaleModify.Name = "SaleModify";
            this.SaleModify.Size = new System.Drawing.Size(69, 28);
            this.SaleModify.TabIndex = 36;
            this.SaleModify.Text = "Modify";
            this.SaleModify.UseVisualStyleBackColor = true;
            // 
            // SaleCreate
            // 
            this.SaleCreate.AutoSize = true;
            this.SaleCreate.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleCreate.Location = new System.Drawing.Point(106, 124);
            this.SaleCreate.Name = "SaleCreate";
            this.SaleCreate.Size = new System.Drawing.Size(69, 28);
            this.SaleCreate.TabIndex = 35;
            this.SaleCreate.Text = "Create";
            this.SaleCreate.UseVisualStyleBackColor = true;
            // 
            // SaleView
            // 
            this.SaleView.AutoSize = true;
            this.SaleView.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleView.Location = new System.Drawing.Point(41, 124);
            this.SaleView.Name = "SaleView";
            this.SaleView.Size = new System.Drawing.Size(59, 28);
            this.SaleView.TabIndex = 34;
            this.SaleView.Text = "View";
            this.SaleView.UseVisualStyleBackColor = true;
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.AutoSize = true;
            this.CustomerDelete.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDelete.Location = new System.Drawing.Point(255, 53);
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.Size = new System.Drawing.Size(68, 28);
            this.CustomerDelete.TabIndex = 33;
            this.CustomerDelete.Text = "Delete";
            this.CustomerDelete.UseVisualStyleBackColor = true;
            // 
            // CustomerModify
            // 
            this.CustomerModify.AutoSize = true;
            this.CustomerModify.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerModify.Location = new System.Drawing.Point(180, 53);
            this.CustomerModify.Name = "CustomerModify";
            this.CustomerModify.Size = new System.Drawing.Size(69, 28);
            this.CustomerModify.TabIndex = 32;
            this.CustomerModify.Text = "Modify";
            this.CustomerModify.UseVisualStyleBackColor = true;
            // 
            // CustomerCrate
            // 
            this.CustomerCrate.AutoSize = true;
            this.CustomerCrate.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCrate.Location = new System.Drawing.Point(110, 53);
            this.CustomerCrate.Name = "CustomerCrate";
            this.CustomerCrate.Size = new System.Drawing.Size(69, 28);
            this.CustomerCrate.TabIndex = 31;
            this.CustomerCrate.Text = "Create";
            this.CustomerCrate.UseVisualStyleBackColor = true;
            // 
            // CustomerView
            // 
            this.CustomerView.AutoSize = true;
            this.CustomerView.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerView.Location = new System.Drawing.Point(45, 53);
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.Size = new System.Drawing.Size(59, 28);
            this.CustomerView.TabIndex = 30;
            this.CustomerView.Text = "View";
            this.CustomerView.UseVisualStyleBackColor = true;
            this.CustomerView.CheckedChanged += new System.EventHandler(this.CustomerView_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sale Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Customer Center";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnApplyPermission);
            this.panel5.Controls.Add(this.btnClearAll);
            this.panel5.Controls.Add(this.btnSelectAll);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(249, 442);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(777, 52);
            this.panel5.TabIndex = 13;
            // 
            // btnApplyPermission
            // 
            this.btnApplyPermission.BackColor = System.Drawing.Color.Transparent;
            this.btnApplyPermission.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPermission.ForeColor = System.Drawing.Color.Black;
            this.btnApplyPermission.Location = new System.Drawing.Point(224, 6);
            this.btnApplyPermission.Name = "btnApplyPermission";
            this.btnApplyPermission.Size = new System.Drawing.Size(167, 39);
            this.btnApplyPermission.TabIndex = 12;
            this.btnApplyPermission.Text = "Apply Permissions";
            this.btnApplyPermission.UseVisualStyleBackColor = false;
            this.btnApplyPermission.Click += new System.EventHandler(this.btnPermission_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.Black;
            this.btnClearAll.Location = new System.Drawing.Point(122, 6);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(88, 39);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectAll.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.ForeColor = System.Drawing.Color.Black;
            this.btnSelectAll.Location = new System.Drawing.Point(22, 5);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(88, 39);
            this.btnSelectAll.TabIndex = 10;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(248, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 394);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgUsers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 394);
            this.panel3.TabIndex = 11;
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUsers.Location = new System.Drawing.Point(0, 0);
            this.dgUsers.MultiSelect = false;
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nokora", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgUsers.RowHeadersVisible = false;
            this.dgUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(106)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgUsers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgUsers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUsers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Snow;
            this.dgUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.dgUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgUsers.RowTemplate.Height = 30;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(248, 394);
            this.dgUsers.TabIndex = 3;
            this.dgUsers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgUsers_CellPainting);
            this.dgUsers.SelectionChanged += new System.EventHandler(this.dgUsers_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 47);
            this.panel2.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(199, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 39);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(102, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(8, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 39);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 53);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Managenment";
            // 
            // FormUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 494);
            this.Controls.Add(this.pnPermission);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormUserManagement";
            this.Text = "FormUserManagement";
            this.Load += new System.EventHandler(this.FormUserManagement_Load);
            this.pnPermission.ResumeLayout(false);
            this.pnPermission.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPermission;
        private System.Windows.Forms.CheckBox SaleDelete;
        private System.Windows.Forms.CheckBox SaleModify;
        private System.Windows.Forms.CheckBox SaleCreate;
        private System.Windows.Forms.CheckBox SaleView;
        private System.Windows.Forms.CheckBox CustomerDelete;
        private System.Windows.Forms.CheckBox CustomerModify;
        private System.Windows.Forms.CheckBox CustomerCrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnApplyPermission;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CustomerView;
    }
}