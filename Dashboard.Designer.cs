namespace WindowsFormsApp1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providerEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.productItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packReToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeExplosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleContentCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.merchandiseGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commodityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seasonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chnagePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.productItemToolStripMenuItem,
            this.packReToolStripMenuItem,
            this.referenceToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1818, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.providerToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.ordersDetailsToolStripMenuItem,
            this.inventoryToolStripMenuItem1,
            this.locationToolStripMenuItem,
            this.productReturnToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.deliveryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory System";
            // 
            // providerToolStripMenuItem
            // 
            this.providerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.providerEntryToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.providerToolStripMenuItem.Name = "providerToolStripMenuItem";
            this.providerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.providerToolStripMenuItem.Text = "Provider";
            this.providerToolStripMenuItem.MouseLeave += new System.EventHandler(this.providerToolStripMenuItem_MouseLeave);
            this.providerToolStripMenuItem.MouseHover += new System.EventHandler(this.providerToolStripMenuItem_MouseHover);
            this.providerToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.providerToolStripMenuItem_MouseMove);
            // 
            // providerEntryToolStripMenuItem
            // 
            this.providerEntryToolStripMenuItem.Name = "providerEntryToolStripMenuItem";
            this.providerEntryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.providerEntryToolStripMenuItem.Text = "ProviderEntry";
            this.providerEntryToolStripMenuItem.Click += new System.EventHandler(this.providerEntryToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderEntryToolStripMenuItem,
            this.orderDetailsToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            this.ordersToolStripMenuItem.MouseHover += new System.EventHandler(this.ordersToolStripMenuItem_MouseHover);
            // 
            // orderEntryToolStripMenuItem
            // 
            this.orderEntryToolStripMenuItem.Name = "orderEntryToolStripMenuItem";
            this.orderEntryToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.orderEntryToolStripMenuItem.Text = "OrderEntry";
            this.orderEntryToolStripMenuItem.Click += new System.EventHandler(this.orderEntryToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.orderDetailsToolStripMenuItem.Text = "OrderDetails";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // ordersDetailsToolStripMenuItem
            // 
            this.ordersDetailsToolStripMenuItem.Name = "ordersDetailsToolStripMenuItem";
            this.ordersDetailsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ordersDetailsToolStripMenuItem.Text = "Warehouse";
            this.ordersDetailsToolStripMenuItem.Click += new System.EventHandler(this.ordersDetailsToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem1
            // 
            this.inventoryToolStripMenuItem1.Name = "inventoryToolStripMenuItem1";
            this.inventoryToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.inventoryToolStripMenuItem1.Text = "Inventory";
            this.inventoryToolStripMenuItem1.Click += new System.EventHandler(this.inventoryToolStripMenuItem1_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // productReturnToolStripMenuItem
            // 
            this.productReturnToolStripMenuItem.Name = "productReturnToolStripMenuItem";
            this.productReturnToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.productReturnToolStripMenuItem.Text = "ProductReturn";
            this.productReturnToolStripMenuItem.Click += new System.EventHandler(this.productReturnToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliveryEntryToolStripMenuItem,
            this.detailsToolStripMenuItem1});
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            // 
            // deliveryEntryToolStripMenuItem
            // 
            this.deliveryEntryToolStripMenuItem.Name = "deliveryEntryToolStripMenuItem";
            this.deliveryEntryToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deliveryEntryToolStripMenuItem.Text = "DeliveryEntry";
            this.deliveryEntryToolStripMenuItem.Click += new System.EventHandler(this.deliveryEntryToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem1
            // 
            this.detailsToolStripMenuItem1.Name = "detailsToolStripMenuItem1";
            this.detailsToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.detailsToolStripMenuItem1.Text = "Details";
            this.detailsToolStripMenuItem1.Click += new System.EventHandler(this.detailsToolStripMenuItem1_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.divisionToolStripMenuItem,
            this.countryToolStripMenuItem,
            this.stateToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.vendorToolStripMenuItem1});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.divisionToolStripMenuItem.Text = "Division";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stateToolStripMenuItem.Text = "State";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.stateToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientEntryToolStripMenuItem,
            this.detailsToolStripMenuItem3});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // clientEntryToolStripMenuItem
            // 
            this.clientEntryToolStripMenuItem.Name = "clientEntryToolStripMenuItem";
            this.clientEntryToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clientEntryToolStripMenuItem.Text = "ClientEntry";
            this.clientEntryToolStripMenuItem.Click += new System.EventHandler(this.clientEntryToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem3
            // 
            this.detailsToolStripMenuItem3.Name = "detailsToolStripMenuItem3";
            this.detailsToolStripMenuItem3.Size = new System.Drawing.Size(132, 22);
            this.detailsToolStripMenuItem3.Text = "Details";
            this.detailsToolStripMenuItem3.Click += new System.EventHandler(this.detailsToolStripMenuItem3_Click);
            // 
            // vendorToolStripMenuItem1
            // 
            this.vendorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorEntryToolStripMenuItem1,
            this.detailsToolStripMenuItem4});
            this.vendorToolStripMenuItem1.Name = "vendorToolStripMenuItem1";
            this.vendorToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.vendorToolStripMenuItem1.Text = "Vendor";
            // 
            // vendorEntryToolStripMenuItem1
            // 
            this.vendorEntryToolStripMenuItem1.Name = "vendorEntryToolStripMenuItem1";
            this.vendorEntryToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.vendorEntryToolStripMenuItem1.Text = "VendorEntry";
            this.vendorEntryToolStripMenuItem1.Click += new System.EventHandler(this.vendorEntryToolStripMenuItem1_Click);
            // 
            // detailsToolStripMenuItem4
            // 
            this.detailsToolStripMenuItem4.Name = "detailsToolStripMenuItem4";
            this.detailsToolStripMenuItem4.Size = new System.Drawing.Size(138, 22);
            this.detailsToolStripMenuItem4.Text = "Details";
            this.detailsToolStripMenuItem4.Click += new System.EventHandler(this.detailsToolStripMenuItem4_Click);
            // 
            // productItemToolStripMenuItem
            // 
            this.productItemToolStripMenuItem.Name = "productItemToolStripMenuItem";
            this.productItemToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.productItemToolStripMenuItem.Text = "Product Item Master Screen";
            this.productItemToolStripMenuItem.Click += new System.EventHandler(this.productItemToolStripMenuItem_Click);
            // 
            // packReToolStripMenuItem
            // 
            this.packReToolStripMenuItem.Name = "packReToolStripMenuItem";
            this.packReToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.packReToolStripMenuItem.Text = "Pack Reference";
            this.packReToolStripMenuItem.Click += new System.EventHandler(this.packReToolStripMenuItem_Click);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.administrativeToolStripMenuItem});
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.referenceToolStripMenuItem.Text = "Reference";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleMasterToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.sizeRangeToolStripMenuItem,
            this.sizeExplosionToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.styleContentCodeToolStripMenuItem,
            this.merchandiseGroupToolStripMenuItem,
            this.commodityToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // styleMasterToolStripMenuItem
            // 
            this.styleMasterToolStripMenuItem.Name = "styleMasterToolStripMenuItem";
            this.styleMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.styleMasterToolStripMenuItem.Text = "Style Master";
            this.styleMasterToolStripMenuItem.Click += new System.EventHandler(this.styleMasterToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // sizeRangeToolStripMenuItem
            // 
            this.sizeRangeToolStripMenuItem.Name = "sizeRangeToolStripMenuItem";
            this.sizeRangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sizeRangeToolStripMenuItem.Text = "Size Range";
            this.sizeRangeToolStripMenuItem.Click += new System.EventHandler(this.sizeRangeToolStripMenuItem_Click);
            // 
            // sizeExplosionToolStripMenuItem
            // 
            this.sizeExplosionToolStripMenuItem.Name = "sizeExplosionToolStripMenuItem";
            this.sizeExplosionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sizeExplosionToolStripMenuItem.Text = "Size Explosion";
            this.sizeExplosionToolStripMenuItem.Click += new System.EventHandler(this.sizeExplosionToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colourToolStripMenuItem.Text = "Colour";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // styleContentCodeToolStripMenuItem
            // 
            this.styleContentCodeToolStripMenuItem.Name = "styleContentCodeToolStripMenuItem";
            this.styleContentCodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.styleContentCodeToolStripMenuItem.Text = "Style Content";
            this.styleContentCodeToolStripMenuItem.Click += new System.EventHandler(this.styleContentCodeToolStripMenuItem_Click);
            // 
            // merchandiseGroupToolStripMenuItem
            // 
            this.merchandiseGroupToolStripMenuItem.Name = "merchandiseGroupToolStripMenuItem";
            this.merchandiseGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.merchandiseGroupToolStripMenuItem.Text = "Merchandise Group";
            // 
            // commodityToolStripMenuItem
            // 
            this.commodityToolStripMenuItem.Name = "commodityToolStripMenuItem";
            this.commodityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commodityToolStripMenuItem.Text = "Commodity";
            // 
            // administrativeToolStripMenuItem
            // 
            this.administrativeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seasonToolStripMenuItem});
            this.administrativeToolStripMenuItem.Name = "administrativeToolStripMenuItem";
            this.administrativeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administrativeToolStripMenuItem.Text = "Administrative";
            // 
            // seasonToolStripMenuItem
            // 
            this.seasonToolStripMenuItem.Name = "seasonToolStripMenuItem";
            this.seasonToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.seasonToolStripMenuItem.Text = "Season";
            this.seasonToolStripMenuItem.Click += new System.EventHandler(this.seasonToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.chnagePasswordToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // chnagePasswordToolStripMenuItem
            // 
            this.chnagePasswordToolStripMenuItem.Name = "chnagePasswordToolStripMenuItem";
            this.chnagePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chnagePasswordToolStripMenuItem.Text = "Change Password";
            this.chnagePasswordToolStripMenuItem.Click += new System.EventHandler(this.chnagePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 747);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(1818, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1818, 769);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Dashboard";
            this.ShowInTaskbar = false;
            this.Text = "Enterprise Rresource Planning Systems Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providerEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendorEntryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem productItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packReToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chnagePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeExplosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleContentCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem merchandiseGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seasonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commodityToolStripMenuItem;
    }
}



