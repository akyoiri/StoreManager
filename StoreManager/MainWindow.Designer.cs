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
            this.PanelPOS = new System.Windows.Forms.Panel();
            this.materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crownComboBox2 = new ReaLTaiizor.Controls.CrownComboBox();
            this.crownComboBox3 = new ReaLTaiizor.Controls.CrownComboBox();
            this.CmbSizes = new ReaLTaiizor.Controls.CrownComboBox();
            this.BtnPrevPage = new System.Windows.Forms.Button();
            this.BtnNextPage = new System.Windows.Forms.Button();
            this.PnlCheckout = new System.Windows.Forms.Panel();
            this.BtnCheckout = new ReaLTaiizor.Controls.Button();
            this.LblTaxOutput = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblSubtotalOutput = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblTotalOutput = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblSubtotal = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblTax = new ReaLTaiizor.Controls.HeaderLabel();
            this.LblTotal = new ReaLTaiizor.Controls.HeaderLabel();
            this.PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.PanelPOS.SuspendLayout();
            this.PnlCheckout.SuspendLayout();
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
            // PanelPOS
            // 
            this.PanelPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPOS.BackColor = System.Drawing.Color.Silver;
            this.PanelPOS.Controls.Add(this.materialCard1);
            this.PanelPOS.Controls.Add(this.label3);
            this.PanelPOS.Controls.Add(this.label2);
            this.PanelPOS.Controls.Add(this.label1);
            this.PanelPOS.Controls.Add(this.crownComboBox2);
            this.PanelPOS.Controls.Add(this.crownComboBox3);
            this.PanelPOS.Controls.Add(this.CmbSizes);
            this.PanelPOS.Controls.Add(this.BtnPrevPage);
            this.PanelPOS.Controls.Add(this.BtnNextPage);
            this.PanelPOS.Controls.Add(this.PnlCheckout);
            this.PanelPOS.Location = new System.Drawing.Point(203, 0);
            this.PanelPOS.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPOS.Name = "PanelPOS";
            this.PanelPOS.Size = new System.Drawing.Size(1061, 682);
            this.PanelPOS.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(7, 7);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(646, 47);
            this.materialCard1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(917, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "SIZE:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(790, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TYPE:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(663, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "SIZE:";
            // 
            // crownComboBox2
            // 
            this.crownComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crownComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.crownComboBox2.FormattingEnabled = true;
            this.crownComboBox2.Location = new System.Drawing.Point(793, 31);
            this.crownComboBox2.Name = "crownComboBox2";
            this.crownComboBox2.Size = new System.Drawing.Size(121, 21);
            this.crownComboBox2.TabIndex = 5;
            // 
            // crownComboBox3
            // 
            this.crownComboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crownComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.crownComboBox3.FormattingEnabled = true;
            this.crownComboBox3.Location = new System.Drawing.Point(920, 31);
            this.crownComboBox3.Name = "crownComboBox3";
            this.crownComboBox3.Size = new System.Drawing.Size(121, 21);
            this.crownComboBox3.TabIndex = 6;
            // 
            // CmbSizes
            // 
            this.CmbSizes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbSizes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbSizes.FormattingEnabled = true;
            this.CmbSizes.Location = new System.Drawing.Point(666, 31);
            this.CmbSizes.Name = "CmbSizes";
            this.CmbSizes.Size = new System.Drawing.Size(121, 21);
            this.CmbSizes.TabIndex = 5;
            // 
            // BtnPrevPage
            // 
            this.BtnPrevPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPrevPage.Location = new System.Drawing.Point(112, 656);
            this.BtnPrevPage.Name = "BtnPrevPage";
            this.BtnPrevPage.Size = new System.Drawing.Size(130, 23);
            this.BtnPrevPage.TabIndex = 4;
            this.BtnPrevPage.Text = "Previous Page";
            this.BtnPrevPage.UseVisualStyleBackColor = true;
            this.BtnPrevPage.Click += new System.EventHandler(this.BtnPrevPage_Click);
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNextPage.Location = new System.Drawing.Point(248, 656);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(129, 23);
            this.BtnNextPage.TabIndex = 3;
            this.BtnNextPage.Text = "Next Page";
            this.BtnNextPage.UseVisualStyleBackColor = true;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // PnlCheckout
            // 
            this.PnlCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCheckout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlCheckout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlCheckout.Controls.Add(this.BtnCheckout);
            this.PnlCheckout.Controls.Add(this.LblTaxOutput);
            this.PnlCheckout.Controls.Add(this.LblSubtotalOutput);
            this.PnlCheckout.Controls.Add(this.LblTotalOutput);
            this.PnlCheckout.Controls.Add(this.LblSubtotal);
            this.PnlCheckout.Controls.Add(this.LblTax);
            this.PnlCheckout.Controls.Add(this.LblTotal);
            this.PnlCheckout.Location = new System.Drawing.Point(666, 464);
            this.PnlCheckout.Name = "PnlCheckout";
            this.PnlCheckout.Size = new System.Drawing.Size(392, 215);
            this.PnlCheckout.TabIndex = 0;
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.BtnCheckout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCheckout.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCheckout.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckout.Image = null;
            this.BtnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckout.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCheckout.Location = new System.Drawing.Point(12, 106);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCheckout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCheckout.Size = new System.Drawing.Size(363, 97);
            this.BtnCheckout.TabIndex = 1;
            this.BtnCheckout.Text = "CHECKOUT";
            this.BtnCheckout.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LblTaxOutput
            // 
            this.LblTaxOutput.BackColor = System.Drawing.Color.Transparent;
            this.LblTaxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTaxOutput.ForeColor = System.Drawing.Color.White;
            this.LblTaxOutput.Location = new System.Drawing.Point(227, 71);
            this.LblTaxOutput.Name = "LblTaxOutput";
            this.LblTaxOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTaxOutput.Size = new System.Drawing.Size(143, 24);
            this.LblTaxOutput.TabIndex = 0;
            this.LblTaxOutput.Text = "0";
            // 
            // LblSubtotalOutput
            // 
            this.LblSubtotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.LblSubtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotalOutput.ForeColor = System.Drawing.Color.White;
            this.LblSubtotalOutput.Location = new System.Drawing.Point(227, 48);
            this.LblSubtotalOutput.Name = "LblSubtotalOutput";
            this.LblSubtotalOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblSubtotalOutput.Size = new System.Drawing.Size(143, 24);
            this.LblSubtotalOutput.TabIndex = 0;
            this.LblSubtotalOutput.Text = "0";
            // 
            // LblTotalOutput
            // 
            this.LblTotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalOutput.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalOutput.ForeColor = System.Drawing.Color.White;
            this.LblTotalOutput.Location = new System.Drawing.Point(227, 14);
            this.LblTotalOutput.Name = "LblTotalOutput";
            this.LblTotalOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTotalOutput.Size = new System.Drawing.Size(143, 24);
            this.LblTotalOutput.TabIndex = 0;
            this.LblTotalOutput.Text = "0";
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.LblSubtotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotal.ForeColor = System.Drawing.Color.White;
            this.LblSubtotal.Location = new System.Drawing.Point(14, 48);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(79, 22);
            this.LblSubtotal.TabIndex = 0;
            this.LblSubtotal.Text = "Subtotal";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.BackColor = System.Drawing.Color.Transparent;
            this.LblTax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTax.ForeColor = System.Drawing.Color.White;
            this.LblTax.Location = new System.Drawing.Point(14, 71);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(39, 22);
            this.LblTax.TabIndex = 0;
            this.LblTax.Text = "Tax";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotal.Location = new System.Drawing.Point(14, 14);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(78, 24);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "TOTAL";
            // 
            // MainWindow
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PanelPOS);
            this.Controls.Add(this.PnlNavigation);
            this.Name = "MainWindow";
            this.Text = "CLC Store Manager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.PnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.PanelPOS.ResumeLayout(false);
            this.PanelPOS.PerformLayout();
            this.PnlCheckout.ResumeLayout(false);
            this.PnlCheckout.PerformLayout();
            this.ResumeLayout(false);

        }


        //this.PnlOrdersPanel.AddOrder(new CartItem(123, "jed", "small", 240));

        //private 
        //private OrdersPanel PnlOrdersPanel;
        //private ProductsPanel PnlProductsPanel;

        #endregion

        private OrdersPanel PnlOrdersPanel;
        private ProductsPanel PnlProductsPanel;
        private Panel PnlNavigation;
        private PictureBox picBoxLogo;
        private PictureBox PicBoxSettings;
        private Panel PanelPOS;
        private Panel PnlCheckout;
        private ReaLTaiizor.Controls.HeaderLabel LblTotal;
        private ReaLTaiizor.Controls.HeaderLabel LblTotalOutput;
        private ReaLTaiizor.Controls.HeaderLabel LblSubtotalOutput;
        private ReaLTaiizor.Controls.HeaderLabel LblTax;
        private ReaLTaiizor.Controls.HeaderLabel LblTaxOutput;
        private ReaLTaiizor.Controls.HeaderLabel LblSubtotal;
        private ReaLTaiizor.Controls.Button BtnCheckout;
        private Button BtnNextPage;
        private Button BtnPrevPage;
        private ReaLTaiizor.Controls.ParrotButton BtnPos;
        private ReaLTaiizor.Controls.ParrotButton BtnAnalytics;
        private ReaLTaiizor.Controls.ParrotButton BtnInventory;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox3;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox2;
        private ReaLTaiizor.Controls.CrownComboBox CmbSizes;
        private Label label3;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private CustomMaterialMaskedTextBox TbPosSearch;
    }
}

