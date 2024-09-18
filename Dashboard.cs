using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        private int childFormNumber = 0;
        protected StatusBar mainStatusBar = new StatusBar();
        protected StatusBarPanel statusPanel = new StatusBarPanel();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void styleMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Style_Master childForm = new Style_Master();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void packReToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pack_Refer pack_Refer = new Pack_Refer();
            pack_Refer.MdiParent = this;
            pack_Refer.Show();
        }

        private void productItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Item_Master product = new Product_Item_Master();
            product.MdiParent = this;
            product.Show();
        }

        private void providerEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Provider provider = new Provider();
            provider.MdiParent = this;
            provider.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provider_List providerList = new Provider_List();
            providerList.MdiParent = this;
            providerList.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void orderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.MdiParent = this;
            orders.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OrderDetails orders = new OrderDetails();
            orders.MdiParent = this;
            orders.Show();
            
        }

        private void ordersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            warehouse.MdiParent = this;
            warehouse.Show();
           
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void inventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.MdiParent = this;
            inventory.Show();
            
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.MdiParent = this;
            location.Show();
         
        }

        private void productReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.MdiParent = this;
            transfer.Show();
            
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.MdiParent = this;
            customer.Show();
            
        }

        private void deliveryEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.MdiParent = this;
            delivery.Show();
            
        }

        private void detailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeliveryDetails deliveryDetails = new DeliveryDetails();
            deliveryDetails.MdiParent = this;
            deliveryDetails.Show();
            
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Division division = new Division();
            division.MdiParent = this;
            division.Show();
            
        }

        private void clientEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.MdiParent = this;
            customer.Show();
            
        }

        private void detailsToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void vendorEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vendor vendor = new Vendor();
            vendor.MdiParent = this;
            vendor.Show();
        }

        private void detailsToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Vendor_Details vendorDetails = new Vendor_Details();
            vendorDetails.Show();
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            country.MdiParent = this;
            country.Show();
            
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State state = new State();
            state.MdiParent = this;
            state.Show();
            
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.MdiParent = this;
            registration.Show();
        }

        private void chnagePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Password update_Password = new Update_Password();
            update_Password.MdiParent = this;
            update_Password.Show();
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                    c.BackColor = Color.FromArgb(21,210,181);
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CreateStatusBar()
        {
            
            //mainStatusBar.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            statusPanel.Text = "Application started. No action yet.";
            statusPanel.ToolTipText = "Last Activity";
            statusPanel.AutoSize = StatusBarPanelAutoSize.Spring;
            mainStatusBar.Panels.Add(statusPanel);
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void providerToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void providerToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Provider";
        }

        private void providerToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void ordersToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Order";
        }

        private void ordersToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void ordersDetailsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Warehouse";
        }

        private void ordersDetailsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void productToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Product";
        }

        private void productToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void inventoryToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Inventory";
        }

        private void inventoryToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void locationToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Location";
        }

        private void locationToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void productReturnToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "ProductReturn";
        }

        private void productReturnToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void customerToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Customer";
        }

        private void customerToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void deliveryToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Delivery";
        }

        private void deliveryToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void productEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.MdiParent = this;
            product.Show();
        }

        private void detailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Product_Details details = new Product_Details();
            details.MdiParent = this;
            details.Show();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size size = new Size();
            size.MdiParent=this;
            size.Show();
        }

        private void sizeRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size_Range size = new Size_Range();
            size.MdiParent=this;
            size.Show();
        }

        private void sizeExplosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeExplosion size = new SizeExplosion();
            size.MdiParent=this;
            size.Show();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientColor colour = new ClientColor();
            colour.MdiParent=this;
            colour.Show();
        }

        private void seasonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.MdiParent = this;
            session.Show();
        }

        private void styleContentCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StyleContent code = new StyleContent();
            code.MdiParent=this;
            code.Show();
        }
    }
}
