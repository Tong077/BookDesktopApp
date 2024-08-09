namespace Transaction.Forms
{
    partial class FormSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpTxndate = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboSaleRep = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.txtRefNumber = new System.Windows.Forms.TextBox();
            this.txtSaleId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSaledetail = new System.Windows.Forms.DataGridView();
            this.SALEDETAILID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ITEMDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epCustomerName = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaledetail)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomerName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale Invoice";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepPink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1531, 49);
            this.panel2.TabIndex = 8;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnPrevious.Location = new System.Drawing.Point(8, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(71, 39);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(87, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 39);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Black;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(169, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 39);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(267, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 39);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1531, 48);
            this.panel3.TabIndex = 9;
            // 
            // dtpTxndate
            // 
            this.dtpTxndate.Location = new System.Drawing.Point(164, 136);
            this.dtpTxndate.Name = "dtpTxndate";
            this.dtpTxndate.Size = new System.Drawing.Size(165, 22);
            this.dtpTxndate.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(329, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 24);
            this.button4.TabIndex = 30;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(329, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 24);
            this.button3.TabIndex = 29;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(475, 152);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(225, 126);
            this.txtNote.TabIndex = 27;
            // 
            // cboSaleRep
            // 
            this.cboSaleRep.FormattingEnabled = true;
            this.cboSaleRep.Location = new System.Drawing.Point(161, 254);
            this.cboSaleRep.Name = "cboSaleRep";
            this.cboSaleRep.Size = new System.Drawing.Size(159, 24);
            this.cboSaleRep.TabIndex = 26;
            this.cboSaleRep.SelectedIndexChanged += new System.EventHandler(this.cboSaleRep_SelectedIndexChanged);
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(161, 207);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(159, 24);
            this.cboCustomer.TabIndex = 25;
            // 
            // txtRefNumber
            // 
            this.txtRefNumber.Location = new System.Drawing.Point(161, 169);
            this.txtRefNumber.Name = "txtRefNumber";
            this.txtRefNumber.Size = new System.Drawing.Size(159, 22);
            this.txtRefNumber.TabIndex = 24;
            // 
            // txtSaleId
            // 
            this.txtSaleId.Location = new System.Drawing.Point(161, 105);
            this.txtSaleId.Name = "txtSaleId";
            this.txtSaleId.Size = new System.Drawing.Size(159, 22);
            this.txtSaleId.TabIndex = 23;
            this.txtSaleId.TextChanged += new System.EventHandler(this.txtSaleId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "SalesRep Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "CustomerName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ref Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // dgSaledetail
            // 
            this.dgSaledetail.BackgroundColor = System.Drawing.Color.White;
            this.dgSaledetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSaledetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaledetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SALEDETAILID,
            this.SALEID,
            this.ITEMID,
            this.ITEMDESCRIPTION,
            this.QUANTITY,
            this.PRICE,
            this.Amount});
            this.dgSaledetail.Location = new System.Drawing.Point(15, 307);
            this.dgSaledetail.Name = "dgSaledetail";
            this.dgSaledetail.RowHeadersWidth = 51;
            this.dgSaledetail.RowTemplate.Height = 24;
            this.dgSaledetail.Size = new System.Drawing.Size(1504, 334);
            this.dgSaledetail.TabIndex = 32;
            this.dgSaledetail.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgSaledetail_CellPainting);
            // 
            // SALEDETAILID
            // 
            this.SALEDETAILID.Frozen = true;
            this.SALEDETAILID.HeaderText = "SALEDETAILID";
            this.SALEDETAILID.MinimumWidth = 6;
            this.SALEDETAILID.Name = "SALEDETAILID";
            this.SALEDETAILID.Visible = false;
            this.SALEDETAILID.Width = 200;
            // 
            // SALEID
            // 
            this.SALEID.HeaderText = "SALEID";
            this.SALEID.MinimumWidth = 6;
            this.SALEID.Name = "SALEID";
            this.SALEID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SALEID.Visible = false;
            this.SALEID.Width = 125;
            // 
            // ITEMID
            // 
            this.ITEMID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ITEMID.HeaderText = "ITEM";
            this.ITEMID.MinimumWidth = 6;
            this.ITEMID.Name = "ITEMID";
            this.ITEMID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ITEMID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ITEMID.Width = 300;
            // 
            // ITEMDESCRIPTION
            // 
            this.ITEMDESCRIPTION.HeaderText = "DESCRIPTION";
            this.ITEMDESCRIPTION.MinimumWidth = 6;
            this.ITEMDESCRIPTION.Name = "ITEMDESCRIPTION";
            this.ITEMDESCRIPTION.Width = 300;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Width = 200;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 6;
            this.PRICE.Name = "PRICE";
            this.PRICE.Width = 200;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 200;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel9.Controls.Add(this.btnClose);
            this.panel9.Controls.Add(this.btnSave);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 677);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1531, 57);
            this.panel9.TabIndex = 33;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1361, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1259, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 43);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epCustomerName
            // 
            this.epCustomerName.ContainerControl = this;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 734);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dgSaledetail);
            this.Controls.Add(this.dtpTxndate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboSaleRep);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.txtRefNumber);
            this.Controls.Add(this.txtSaleId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormSale";
            this.Text = "FormSale";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSaledetail)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epCustomerName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpTxndate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboSaleRep;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtRefNumber;
        private System.Windows.Forms.TextBox txtSaleId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgSaledetail;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALEDETAILID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALEID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ITEMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMDESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}