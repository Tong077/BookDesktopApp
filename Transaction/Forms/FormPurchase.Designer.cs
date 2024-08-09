namespace Transaction.Forms
{
    partial class FormPurchase
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.dtpTxndate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.cboVendor = new System.Windows.Forms.ComboBox();
            this.txtPurchaseId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dgPurchaseDetail = new System.Windows.Forms.DataGridView();
            this.PURCHASEDETAILID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PURCHASEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ITEMDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epVendorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseDetail)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVendorName)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1531, 49);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Moul", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase";
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
            this.panel3.TabIndex = 10;
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
            // dtpTxndate
            // 
            this.dtpTxndate.Location = new System.Drawing.Point(172, 153);
            this.dtpTxndate.Name = "dtpTxndate";
            this.dtpTxndate.Size = new System.Drawing.Size(165, 22);
            this.dtpTxndate.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(337, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 24);
            this.button3.TabIndex = 41;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cboVendor
            // 
            this.cboVendor.FormattingEnabled = true;
            this.cboVendor.Location = new System.Drawing.Point(169, 198);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Size = new System.Drawing.Size(159, 24);
            this.cboVendor.TabIndex = 39;
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.Location = new System.Drawing.Point(169, 122);
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.Size = new System.Drawing.Size(159, 22);
            this.txtPurchaseId.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Vendor Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(476, 150);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(225, 126);
            this.txtNote.TabIndex = 44;
            // 
            // dgPurchaseDetail
            // 
            this.dgPurchaseDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgPurchaseDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PURCHASEDETAILID,
            this.PURCHASEID,
            this.ITEMID,
            this.ITEMDESCRIPTION,
            this.QUANTITY,
            this.PRICE,
            this.Amount});
            this.dgPurchaseDetail.Location = new System.Drawing.Point(12, 330);
            this.dgPurchaseDetail.Name = "dgPurchaseDetail";
            this.dgPurchaseDetail.RowHeadersWidth = 51;
            this.dgPurchaseDetail.RowTemplate.Height = 24;
            this.dgPurchaseDetail.Size = new System.Drawing.Size(1507, 321);
            this.dgPurchaseDetail.TabIndex = 46;
            this.dgPurchaseDetail.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgPurchaseDetail_CellPainting);
            // 
            // PURCHASEDETAILID
            // 
            this.PURCHASEDETAILID.HeaderText = "PurchaseDeteailId";
            this.PURCHASEDETAILID.MinimumWidth = 6;
            this.PURCHASEDETAILID.Name = "PURCHASEDETAILID";
            this.PURCHASEDETAILID.Visible = false;
            this.PURCHASEDETAILID.Width = 125;
            // 
            // PURCHASEID
            // 
            this.PURCHASEID.HeaderText = "PurchaseId";
            this.PURCHASEID.MinimumWidth = 6;
            this.PURCHASEID.Name = "PURCHASEID";
            this.PURCHASEID.Visible = false;
            this.PURCHASEID.Width = 125;
            // 
            // ITEMID
            // 
            this.ITEMID.HeaderText = "Item";
            this.ITEMID.MinimumWidth = 6;
            this.ITEMID.Name = "ITEMID";
            this.ITEMID.Width = 300;
            // 
            // ITEMDESCRIPTION
            // 
            this.ITEMDESCRIPTION.HeaderText = "Description";
            this.ITEMDESCRIPTION.MinimumWidth = 6;
            this.ITEMDESCRIPTION.Name = "ITEMDESCRIPTION";
            this.ITEMDESCRIPTION.Width = 300;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "Quantity";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Width = 300;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "Price";
            this.PRICE.MinimumWidth = 6;
            this.PRICE.Name = "PRICE";
            this.PRICE.Width = 250;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 300;
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
            this.panel9.TabIndex = 47;
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
            // epVendorName
            // 
            this.epVendorName.ContainerControl = this;
            // 
            // FormPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 734);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dgPurchaseDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpTxndate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cboVendor);
            this.Controls.Add(this.txtPurchaseId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormPurchase";
            this.Text = "FormPurchase";
            this.Load += new System.EventHandler(this.FormPurchase_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseDetail)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epVendorName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DateTimePicker dtpTxndate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cboVendor;
        private System.Windows.Forms.TextBox txtPurchaseId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DataGridView dgPurchaseDetail;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epVendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PURCHASEDETAILID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PURCHASEID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ITEMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMDESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}