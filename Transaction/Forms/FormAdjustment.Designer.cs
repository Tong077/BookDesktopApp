namespace Transaction.Forms
{
    partial class FormAdjustment
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dtpTxndate = new System.Windows.Forms.DateTimePicker();
            this.txtRefNumber = new System.Windows.Forms.TextBox();
            this.txtAdjustmentId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgAdjustmentDetail = new System.Windows.Forms.DataGridView();
            this.ADJUSTMENTDETAILID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADJUSTMENTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ITEMDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epRefNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdjustmentDetail)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRefNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1440, 49);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adjustment";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1440, 48);
            this.panel3.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel6.Location = new System.Drawing.Point(258, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 48);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(159, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 48);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(79, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 48);
            this.panel4.TabIndex = 2;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(355, 120);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(225, 126);
            this.txtNote.TabIndex = 64;
            // 
            // dtpTxndate
            // 
            this.dtpTxndate.Location = new System.Drawing.Point(110, 151);
            this.dtpTxndate.Name = "dtpTxndate";
            this.dtpTxndate.Size = new System.Drawing.Size(165, 22);
            this.dtpTxndate.TabIndex = 63;
            // 
            // txtRefNumber
            // 
            this.txtRefNumber.Location = new System.Drawing.Point(107, 184);
            this.txtRefNumber.Name = "txtRefNumber";
            this.txtRefNumber.Size = new System.Drawing.Size(159, 22);
            this.txtRefNumber.TabIndex = 62;
            // 
            // txtAdjustmentId
            // 
            this.txtAdjustmentId.Location = new System.Drawing.Point(107, 120);
            this.txtAdjustmentId.Name = "txtAdjustmentId";
            this.txtAdjustmentId.Size = new System.Drawing.Size(159, 22);
            this.txtAdjustmentId.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Ref Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID";
            // 
            // dgAdjustmentDetail
            // 
            this.dgAdjustmentDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgAdjustmentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdjustmentDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ADJUSTMENTDETAILID,
            this.ADJUSTMENTID,
            this.ITEMID,
            this.ITEMDESCRIPTION,
            this.QUANTITY,
            this.PRICE,
            this.Amount});
            this.dgAdjustmentDetail.Location = new System.Drawing.Point(25, 297);
            this.dgAdjustmentDetail.Name = "dgAdjustmentDetail";
            this.dgAdjustmentDetail.RowHeadersWidth = 51;
            this.dgAdjustmentDetail.RowTemplate.Height = 24;
            this.dgAdjustmentDetail.Size = new System.Drawing.Size(1379, 336);
            this.dgAdjustmentDetail.TabIndex = 66;
            // 
            // ADJUSTMENTDETAILID
            // 
            this.ADJUSTMENTDETAILID.HeaderText = "AdjustmentDetail";
            this.ADJUSTMENTDETAILID.MinimumWidth = 6;
            this.ADJUSTMENTDETAILID.Name = "ADJUSTMENTDETAILID";
            this.ADJUSTMENTDETAILID.Visible = false;
            this.ADJUSTMENTDETAILID.Width = 200;
            // 
            // ADJUSTMENTID
            // 
            this.ADJUSTMENTID.HeaderText = "Adjustment";
            this.ADJUSTMENTID.MinimumWidth = 6;
            this.ADJUSTMENTID.Name = "ADJUSTMENTID";
            this.ADJUSTMENTID.Visible = false;
            this.ADJUSTMENTID.Width = 125;
            // 
            // ITEMID
            // 
            this.ITEMID.HeaderText = "Item";
            this.ITEMID.MinimumWidth = 6;
            this.ITEMID.Name = "ITEMID";
            this.ITEMID.Width = 200;
            // 
            // ITEMDESCRIPTION
            // 
            this.ITEMDESCRIPTION.HeaderText = "Description";
            this.ITEMDESCRIPTION.MinimumWidth = 6;
            this.ITEMDESCRIPTION.Name = "ITEMDESCRIPTION";
            this.ITEMDESCRIPTION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ITEMDESCRIPTION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ITEMDESCRIPTION.Width = 200;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "Quantity";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Width = 200;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "Price";
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
            this.panel9.Size = new System.Drawing.Size(1440, 57);
            this.panel9.TabIndex = 67;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1318, 5);
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
            this.btnSave.Location = new System.Drawing.Point(1216, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 43);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epRefNumber
            // 
            this.epRefNumber.ContainerControl = this;
            // 
            // FormAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 734);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dgAdjustmentDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpTxndate);
            this.Controls.Add(this.txtRefNumber);
            this.Controls.Add(this.txtAdjustmentId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormAdjustment";
            this.Text = "FormAdjustment";
            this.Load += new System.EventHandler(this.FormAdjustment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdjustmentDetail)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epRefNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dtpTxndate;
        private System.Windows.Forms.TextBox txtRefNumber;
        private System.Windows.Forms.TextBox txtAdjustmentId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgAdjustmentDetail;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADJUSTMENTDETAILID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADJUSTMENTID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ITEMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMDESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.ErrorProvider epRefNumber;
    }
}