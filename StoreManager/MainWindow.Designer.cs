using CustomComponents;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Runtime.CompilerServices;
using StoreManager.Database;
using System.Windows.Forms;

namespace StoreManager
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PnlNavigation = new System.Windows.Forms.Panel();
            this.BtnAnalytics = new ReaLTaiizor.Controls.ParrotButton();
            this.BtnInventory = new ReaLTaiizor.Controls.ParrotButton();
            this.BtnPos = new ReaLTaiizor.Controls.ParrotButton();
            this.PicBoxSettings = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlNavigation
            // 
            this.PnlNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlNavigation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PnlNavigation.Controls.Add(this.BtnAnalytics);
            this.PnlNavigation.Controls.Add(this.BtnInventory);
            this.PnlNavigation.Controls.Add(this.BtnPos);
            this.PnlNavigation.Controls.Add(this.PicBoxSettings);
            this.PnlNavigation.Controls.Add(this.picBoxLogo);
            this.PnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.PnlNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.PnlNavigation.Name = "PnlNavigation";
            this.PnlNavigation.Size = new System.Drawing.Size(203, 682);
            this.PnlNavigation.TabIndex = 0;
            // 
            // BtnAnalytics
            // 
            this.BtnAnalytics.AllowDrop = true;
            this.BtnAnalytics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAnalytics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAnalytics.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnAnalytics.ButtonImage")));
            this.BtnAnalytics.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnAnalytics.ButtonText = "ANALYTICS";
            this.BtnAnalytics.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAnalytics.ClickTextColor = System.Drawing.Color.Gainsboro;
            this.BtnAnalytics.CornerRadius = 5;
            this.BtnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnalytics.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalytics.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAnalytics.HoverBackgroundColor = System.Drawing.Color.Silver;
            this.BtnAnalytics.HoverTextColor = System.Drawing.Color.Black;
            this.BtnAnalytics.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnAnalytics.Location = new System.Drawing.Point(3, 257);
            this.BtnAnalytics.Name = "BtnAnalytics";
            this.BtnAnalytics.Size = new System.Drawing.Size(197, 50);
            this.BtnAnalytics.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnAnalytics.TabIndex = 1;
            this.BtnAnalytics.TextColor = System.Drawing.Color.Black;
            this.BtnAnalytics.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnAnalytics.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // BtnInventory
            // 
            this.BtnInventory.AllowDrop = true;
            this.BtnInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnInventory.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnInventory.ButtonImage")));
            this.BtnInventory.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnInventory.ButtonText = "INVENTORY";
            this.BtnInventory.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInventory.ClickTextColor = System.Drawing.Color.Gainsboro;
            this.BtnInventory.CornerRadius = 5;
            this.BtnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventory.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventory.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnInventory.HoverBackgroundColor = System.Drawing.Color.Silver;
            this.BtnInventory.HoverTextColor = System.Drawing.Color.Black;
            this.BtnInventory.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnInventory.Location = new System.Drawing.Point(3, 201);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(197, 50);
            this.BtnInventory.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnInventory.TabIndex = 1;
            this.BtnInventory.TextColor = System.Drawing.Color.Black;
            this.BtnInventory.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnInventory.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // BtnPos
            // 
            this.BtnPos.AllowDrop = true;
            this.BtnPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnPos.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnPos.ButtonImage")));
            this.BtnPos.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnPos.ButtonText = "CASHIERING";
            this.BtnPos.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPos.ClickTextColor = System.Drawing.Color.Gainsboro;
            this.BtnPos.CornerRadius = 5;
            this.BtnPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPos.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPos.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnPos.HoverBackgroundColor = System.Drawing.Color.Silver;
            this.BtnPos.HoverTextColor = System.Drawing.Color.Black;
            this.BtnPos.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnPos.Location = new System.Drawing.Point(3, 145);
            this.BtnPos.Name = "BtnPos";
            this.BtnPos.Size = new System.Drawing.Size(197, 50);
            this.BtnPos.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnPos.TabIndex = 1;
            this.BtnPos.TextColor = System.Drawing.Color.Black;
            this.BtnPos.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnPos.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnPos.Click += new System.EventHandler(this.BtnPos_Click);
            // 
            // PicBoxSettings
            // 
            this.PicBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PicBoxSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicBoxSettings.BackgroundImage")));
            this.PicBoxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxSettings.Location = new System.Drawing.Point(3, 653);
            this.PicBoxSettings.Name = "PicBoxSettings";
            this.PicBoxSettings.Size = new System.Drawing.Size(33, 26);
            this.PicBoxSettings.TabIndex = 0;
            this.PicBoxSettings.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.BackgroundImage")));
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(178, 80);
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // PnlContent
            // 
            this.PnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlContent.Location = new System.Drawing.Point(203, 0);
            this.PnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(1262, 682);
            this.PnlContent.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1464, 681);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlNavigation);
            this.Name = "MainWindow";
            this.Text = "CLC Store Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.PnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }


        //this.PnlOrdersPanel.AddOrder(new CartItem(123, "jed", "small", 240));

        //private 
        //private OrdersPanel PnlOrdersPanel;
        //private ProductsPanel PnlProductsPanel;

        #endregion
        private Panel PnlNavigation;
        private PictureBox picBoxLogo;
        private PictureBox PicBoxSettings;
        private ReaLTaiizor.Controls.ParrotButton BtnPos;
        private ReaLTaiizor.Controls.ParrotButton BtnAnalytics;
        private ReaLTaiizor.Controls.ParrotButton BtnInventory;
        private Panel PnlContent;
    }
}
