using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManager.Database;
using StoreManager.CustomComponentsLinker;
using CustomComponents;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace StoreManager
{

    public partial class MainWindow : Form
    {

        int currentPage = 1;

        ProductsAndOrdersLinker productsAndOrdersLinker;
        DBConnect dbConnection = new DBConnect();

        public MainWindow()
        {
            //DBConnect dbConnection = new DBConnect();
            InitializeComponent();

            //this.PnlProductsPanel.InitializeDisplay(dbConnection.GetItemList(), BtnPdpClicked);
            //this.productsAndOrdersLinker = new ProductsAndOrdersLinker(this.PnlOrdersPanel, this.PnlProductsPanel);
            //this.PnlProductsPanel.PanelSizeUpdated();

        }

        public void BtnPdpClicked(object sender, EventArgs e)
        {
            ProductDisplayPanel PdpPressed = productsAndOrdersLinker.GetProdDisplayPanel(sender.GetHashCode());
            this.PnlOrdersPanel.AddOrder(PdpPressed.Item.ToCartItem());
            this.PnlOrdersPanel.UpdateCheckoutLabels();
            //this.PnlOrdersPanel.DisplayOrders();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //this.PnlProductsPanel.PanelSizeUpdated();
            this.PnlProductsPanel.InitializeItems(dbConnection.GetItemList(), this.BtnPdpClicked);
            this.PnlProductsPanel.InitializeCards();
            this.PnlProductsPanel.ArrangeProductPanels(currentPage);

            this.productsAndOrdersLinker = new ProductsAndOrdersLinker(this.PnlOrdersPanel, this.PnlProductsPanel);

            this.PnlOrdersPanel.InitializeCheckoutLabels(this.LblTotalOutput, this.LblTaxOutput, this.LblSubtotalOutput);
            this.CmbSizes.Items.AddRange(dbConnection.GetSizesList());
            //this.MinimumSize = this.Size;
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (PnlProductsPanel.IsOnLastPage()) return;
            this.currentPage += 1;
            this.PnlProductsPanel.ArrangeProductPanels(currentPage);
        }

        private void BtnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage - 1 <= 0) return;
            this.currentPage -= 1;
            this.PnlProductsPanel.ArrangeProductPanels(currentPage);
        }

        private void TbPosSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            var regex = new Regex(@"[^a-zA-Z0-9\s]");

            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void TbPosSearch_Enter(object sender, EventArgs e)
        {
            this.TbPosSearch.SelectAll();
        }
    }
}
