namespace Transaction.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.pnManu = new System.Windows.Forms.Panel();
            this.mUserManagement = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.mInventoryCenterSub = new System.Windows.Forms.Panel();
            this.smPurchase = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.smCerateAdjustments = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.smItemlist = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.mInventoryCenter = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.mCustomerCenterSub = new System.Windows.Forms.Panel();
            this.smCreateSale = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.smSaleRepList = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.smCustomerList = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.mCustomerCenter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mDashboard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnTitle.SuspendLayout();
            this.pnManu.SuspendLayout();
            this.mUserManagement.SuspendLayout();
            this.mInventoryCenterSub.SuspendLayout();
            this.smPurchase.SuspendLayout();
            this.smCerateAdjustments.SuspendLayout();
            this.smItemlist.SuspendLayout();
            this.mInventoryCenter.SuspendLayout();
            this.mCustomerCenterSub.SuspendLayout();
            this.smCreateSale.SuspendLayout();
            this.smSaleRepList.SuspendLayout();
            this.smCustomerList.SuspendLayout();
            this.mCustomerCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.White;
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1578, 53);
            this.pnTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS System Demo";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // pnManu
            // 
            this.pnManu.Controls.Add(this.mUserManagement);
            this.pnManu.Controls.Add(this.mInventoryCenterSub);
            this.pnManu.Controls.Add(this.mInventoryCenter);
            this.pnManu.Controls.Add(this.mCustomerCenterSub);
            this.pnManu.Controls.Add(this.mCustomerCenter);
            this.pnManu.Controls.Add(this.mDashboard);
            this.pnManu.Controls.Add(this.panel1);
            this.pnManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnManu.Location = new System.Drawing.Point(0, 53);
            this.pnManu.Name = "pnManu";
            this.pnManu.Size = new System.Drawing.Size(311, 710);
            this.pnManu.TabIndex = 1;
            // 
            // mUserManagement
            // 
            this.mUserManagement.Controls.Add(this.pictureBox4);
            this.mUserManagement.Controls.Add(this.label4);
            this.mUserManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mUserManagement.Location = new System.Drawing.Point(0, 651);
            this.mUserManagement.Name = "mUserManagement";
            this.mUserManagement.Size = new System.Drawing.Size(311, 59);
            this.mUserManagement.TabIndex = 11;
            this.mUserManagement.Click += new System.EventHandler(this.mUserManagement_Click);
            this.mUserManagement.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.mUserManagement.MouseEnter += new System.EventHandler(this.mUserManagement_MouseEnter);
            this.mUserManagement.MouseLeave += new System.EventHandler(this.mUserManagement_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usermanagement";
            // 
            // mInventoryCenterSub
            // 
            this.mInventoryCenterSub.Controls.Add(this.smPurchase);
            this.mInventoryCenterSub.Controls.Add(this.smCerateAdjustments);
            this.mInventoryCenterSub.Controls.Add(this.smItemlist);
            this.mInventoryCenterSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.mInventoryCenterSub.Location = new System.Drawing.Point(0, 376);
            this.mInventoryCenterSub.Name = "mInventoryCenterSub";
            this.mInventoryCenterSub.Size = new System.Drawing.Size(311, 209);
            this.mInventoryCenterSub.TabIndex = 10;
            this.mInventoryCenterSub.Visible = false;
            this.mInventoryCenterSub.Click += new System.EventHandler(this.mInventoryCenterSub_Click);
            this.mInventoryCenterSub.Paint += new System.Windows.Forms.PaintEventHandler(this.mInventoryCenterSub_Paint);
            // 
            // smPurchase
            // 
            this.smPurchase.Controls.Add(this.pictureBox11);
            this.smPurchase.Controls.Add(this.label5);
            this.smPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.smPurchase.Location = new System.Drawing.Point(0, 112);
            this.smPurchase.Name = "smPurchase";
            this.smPurchase.Size = new System.Drawing.Size(311, 65);
            this.smPurchase.TabIndex = 5;
            this.smPurchase.Visible = false;
            this.smPurchase.Click += new System.EventHandler(this.smPurchase_Click);
            this.smPurchase.MouseEnter += new System.EventHandler(this.smPurchase_MouseEnter);
            this.smPurchase.MouseLeave += new System.EventHandler(this.smPurchase_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Purchase";
            // 
            // smCerateAdjustments
            // 
            this.smCerateAdjustments.Controls.Add(this.pictureBox7);
            this.smCerateAdjustments.Controls.Add(this.label16);
            this.smCerateAdjustments.Dock = System.Windows.Forms.DockStyle.Top;
            this.smCerateAdjustments.Location = new System.Drawing.Point(0, 54);
            this.smCerateAdjustments.Name = "smCerateAdjustments";
            this.smCerateAdjustments.Size = new System.Drawing.Size(311, 58);
            this.smCerateAdjustments.TabIndex = 4;
            this.smCerateAdjustments.Visible = false;
            this.smCerateAdjustments.Click += new System.EventHandler(this.smCerateAdjustments_Click);
            this.smCerateAdjustments.MouseEnter += new System.EventHandler(this.panel13_MouseEnter);
            this.smCerateAdjustments.MouseLeave += new System.EventHandler(this.panel13_MouseLeave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(113, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 36);
            this.label16.TabIndex = 0;
            this.label16.Text = "Create Adjustments";
            // 
            // smItemlist
            // 
            this.smItemlist.Controls.Add(this.pictureBox6);
            this.smItemlist.Controls.Add(this.label17);
            this.smItemlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.smItemlist.Location = new System.Drawing.Point(0, 0);
            this.smItemlist.Name = "smItemlist";
            this.smItemlist.Size = new System.Drawing.Size(311, 54);
            this.smItemlist.TabIndex = 3;
            this.smItemlist.Visible = false;
            this.smItemlist.Click += new System.EventHandler(this.smItemlist_Click);
            this.smItemlist.MouseEnter += new System.EventHandler(this.panel14_MouseEnter);
            this.smItemlist.MouseLeave += new System.EventHandler(this.smItemlist_MouseLeave);
            this.smItemlist.MouseHover += new System.EventHandler(this.panel14_MouseHover);
            this.smItemlist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.smItemlist_MouseMove);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(160, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 36);
            this.label17.TabIndex = 0;
            this.label17.Text = "Item List";
            // 
            // mInventoryCenter
            // 
            this.mInventoryCenter.Controls.Add(this.pictureBox5);
            this.mInventoryCenter.Controls.Add(this.label14);
            this.mInventoryCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.mInventoryCenter.Location = new System.Drawing.Point(0, 322);
            this.mInventoryCenter.Name = "mInventoryCenter";
            this.mInventoryCenter.Size = new System.Drawing.Size(311, 54);
            this.mInventoryCenter.TabIndex = 9;
            this.mInventoryCenter.Click += new System.EventHandler(this.mInventoryCenter_Click);
            this.mInventoryCenter.MouseEnter += new System.EventHandler(this.mInventoryCenter_MouseEnter);
            this.mInventoryCenter.MouseLeave += new System.EventHandler(this.mInventoryCenter_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(89, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 36);
            this.label14.TabIndex = 0;
            this.label14.Text = "Inventory Center";
            // 
            // mCustomerCenterSub
            // 
            this.mCustomerCenterSub.Controls.Add(this.smCreateSale);
            this.mCustomerCenterSub.Controls.Add(this.smSaleRepList);
            this.mCustomerCenterSub.Controls.Add(this.smCustomerList);
            this.mCustomerCenterSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.mCustomerCenterSub.Location = new System.Drawing.Point(0, 114);
            this.mCustomerCenterSub.Name = "mCustomerCenterSub";
            this.mCustomerCenterSub.Size = new System.Drawing.Size(311, 208);
            this.mCustomerCenterSub.TabIndex = 8;
            this.mCustomerCenterSub.Visible = false;
            this.mCustomerCenterSub.Paint += new System.Windows.Forms.PaintEventHandler(this.mCustomerCenterSub_Paint);
            // 
            // smCreateSale
            // 
            this.smCreateSale.BackColor = System.Drawing.Color.White;
            this.smCreateSale.Controls.Add(this.pictureBox10);
            this.smCreateSale.Controls.Add(this.label13);
            this.smCreateSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.smCreateSale.Location = new System.Drawing.Point(0, 104);
            this.smCreateSale.Name = "smCreateSale";
            this.smCreateSale.Size = new System.Drawing.Size(311, 56);
            this.smCreateSale.TabIndex = 5;
            this.smCreateSale.Visible = false;
            this.smCreateSale.Click += new System.EventHandler(this.smCreateSale_Click);
            this.smCreateSale.MouseEnter += new System.EventHandler(this.smCreateSale_MouseEnter);
            this.smCreateSale.MouseLeave += new System.EventHandler(this.smCreateSale_MouseLeave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(160, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 36);
            this.label13.TabIndex = 0;
            this.label13.Text = "Create Sale";
            // 
            // smSaleRepList
            // 
            this.smSaleRepList.BackColor = System.Drawing.Color.White;
            this.smSaleRepList.Controls.Add(this.pictureBox9);
            this.smSaleRepList.Controls.Add(this.label12);
            this.smSaleRepList.Dock = System.Windows.Forms.DockStyle.Top;
            this.smSaleRepList.Location = new System.Drawing.Point(0, 50);
            this.smSaleRepList.Name = "smSaleRepList";
            this.smSaleRepList.Size = new System.Drawing.Size(311, 54);
            this.smSaleRepList.TabIndex = 4;
            this.smSaleRepList.Visible = false;
            this.smSaleRepList.Click += new System.EventHandler(this.smSaleRepList_Click);
            this.smSaleRepList.MouseEnter += new System.EventHandler(this.smSaleRepList_MouseEnter);
            this.smSaleRepList.MouseLeave += new System.EventHandler(this.smSaleRepList_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(160, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 36);
            this.label12.TabIndex = 0;
            this.label12.Text = "SaleRep List";
            // 
            // smCustomerList
            // 
            this.smCustomerList.BackColor = System.Drawing.Color.White;
            this.smCustomerList.Controls.Add(this.pictureBox8);
            this.smCustomerList.Controls.Add(this.label11);
            this.smCustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.smCustomerList.Location = new System.Drawing.Point(0, 0);
            this.smCustomerList.Name = "smCustomerList";
            this.smCustomerList.Size = new System.Drawing.Size(311, 50);
            this.smCustomerList.TabIndex = 3;
            this.smCustomerList.Visible = false;
            this.smCustomerList.Click += new System.EventHandler(this.smCustomerList_Click);
            this.smCustomerList.Paint += new System.Windows.Forms.PaintEventHandler(this.smCustomerList_Paint);
            this.smCustomerList.MouseEnter += new System.EventHandler(this.smCustomerList_MouseEnter);
            this.smCustomerList.MouseLeave += new System.EventHandler(this.smCustomerList_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(160, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 36);
            this.label11.TabIndex = 0;
            this.label11.Text = "Customer List";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // mCustomerCenter
            // 
            this.mCustomerCenter.BackColor = System.Drawing.Color.White;
            this.mCustomerCenter.Controls.Add(this.pictureBox3);
            this.mCustomerCenter.Controls.Add(this.label3);
            this.mCustomerCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.mCustomerCenter.Location = new System.Drawing.Point(0, 64);
            this.mCustomerCenter.Name = "mCustomerCenter";
            this.mCustomerCenter.Size = new System.Drawing.Size(311, 50);
            this.mCustomerCenter.TabIndex = 2;
            this.mCustomerCenter.Click += new System.EventHandler(this.mCustomerCenter_Click);
            this.mCustomerCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.mCustomerCenter_Paint);
            this.mCustomerCenter.MouseEnter += new System.EventHandler(this.mCustomerCenter_MouseEnter);
            this.mCustomerCenter.MouseLeave += new System.EventHandler(this.mCustomerCenter_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Center";
            // 
            // mDashboard
            // 
            this.mDashboard.BackColor = System.Drawing.Color.White;
            this.mDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.mDashboard.Location = new System.Drawing.Point(0, 0);
            this.mDashboard.Name = "mDashboard";
            this.mDashboard.Size = new System.Drawing.Size(311, 64);
            this.mDashboard.TabIndex = 1;
            this.mDashboard.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 3);
            this.panel1.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(311, 53);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1267, 710);
            this.pnMain.TabIndex = 2;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Transaction.Properties.Resources._9637797;
            this.pictureBox4.Location = new System.Drawing.Point(9, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(4, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(65, 55);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 2;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(6, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 55);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(6, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(6, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(61, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(7, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(60, 52);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 3;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(5, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(56, 52);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(8, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(55, 47);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 763);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnManu);
            this.Controls.Add(this.pnTitle);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnManu.ResumeLayout(false);
            this.mUserManagement.ResumeLayout(false);
            this.mUserManagement.PerformLayout();
            this.mInventoryCenterSub.ResumeLayout(false);
            this.smPurchase.ResumeLayout(false);
            this.smPurchase.PerformLayout();
            this.smCerateAdjustments.ResumeLayout(false);
            this.smCerateAdjustments.PerformLayout();
            this.smItemlist.ResumeLayout(false);
            this.smItemlist.PerformLayout();
            this.mInventoryCenter.ResumeLayout(false);
            this.mInventoryCenter.PerformLayout();
            this.mCustomerCenterSub.ResumeLayout(false);
            this.smCreateSale.ResumeLayout(false);
            this.smCreateSale.PerformLayout();
            this.smSaleRepList.ResumeLayout(false);
            this.smSaleRepList.PerformLayout();
            this.smCustomerList.ResumeLayout(false);
            this.smCustomerList.PerformLayout();
            this.mCustomerCenter.ResumeLayout(false);
            this.mCustomerCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Panel pnManu;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mCustomerCenterSub;
        private System.Windows.Forms.Panel mCustomerCenter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel mDashboard;
        private System.Windows.Forms.Panel smCustomerList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel smCreateSale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel smSaleRepList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel mInventoryCenterSub;
        private System.Windows.Forms.Panel smCerateAdjustments;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel smItemlist;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel mInventoryCenter;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel mUserManagement;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel smPurchase;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label5;
    }
}