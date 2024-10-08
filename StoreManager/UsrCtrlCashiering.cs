using CustomComponents;
using StoreManager.CustomComponentsLinker;
using StoreManager.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class UsrCtrlCashiering : UserControl
    {

        private int currentPage = 1;
        private DBConnect dbConnection;

        ProductsAndOrdersLinker productsAndOrdersLinker;

        public UsrCtrlCashiering(DBConnect dbConnection)
        {
            InitializeComponent();
            this.dbConnection = dbConnection;
        }

        public void InitializeCardView()
        {

            this.PnlProductsPanel.InitializeItems(dbConnection.GetItemList(), this.BtnPdpClicked);
            this.PnlProductsPanel.InitializeCards();
            this.PnlProductsPanel.ArrangeProductPanels(currentPage);

            this.productsAndOrdersLinker = new ProductsAndOrdersLinker(this.PnlOrdersPanel, this.PnlProductsPanel);

            this.PnlOrdersPanel.InitializeCheckoutLabels(this.LblTotalOutput, this.LblTaxOutput, this.LblSubtotalOutput);
            this.CmbSizes.Items.AddRange(dbConnection.GetSizesList());
        }

        public void BtnPdpClicked(object sender, EventArgs e)
        {
            ProductDisplayPanel PdpPressed = productsAndOrdersLinker.GetProdDisplayPanel(sender.GetHashCode());
            this.PnlOrdersPanel.AddOrder(PdpPressed.Item.ToCartItem());
            this.PnlOrdersPanel.UpdateCheckoutLabels();
            //this.PnlOrdersPanel.DisplayOrders();
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
