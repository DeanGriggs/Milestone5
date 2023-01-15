namespace Milestone_3
{
    partial class InventoryMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMain));
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.TB_Quan = new System.Windows.Forms.TextBox();
            this.BTN_ClearForm = new System.Windows.Forms.Button();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.BTN_add = new System.Windows.Forms.Button();
            this.CB_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Sku = new System.Windows.Forms.Label();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.TB_Sku = new System.Windows.Forms.TextBox();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.Edit_seachField = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.Label();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.CB_Search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_seachField)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(273, 81);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(49, 13);
            this.lbl_Quantity.TabIndex = 46;
            this.lbl_Quantity.Text = "Quantity:";
            // 
            // TB_Quan
            // 
            this.TB_Quan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_Quan.Location = new System.Drawing.Point(276, 97);
            this.TB_Quan.Name = "TB_Quan";
            this.TB_Quan.Size = new System.Drawing.Size(219, 20);
            this.TB_Quan.TabIndex = 5;
            // 
            // BTN_ClearForm
            // 
            this.BTN_ClearForm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_ClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ClearForm.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearForm.Location = new System.Drawing.Point(38, 181);
            this.BTN_ClearForm.Name = "BTN_ClearForm";
            this.BTN_ClearForm.Size = new System.Drawing.Size(219, 36);
            this.BTN_ClearForm.TabIndex = 8;
            this.BTN_ClearForm.Text = "Clear";
            this.BTN_ClearForm.UseVisualStyleBackColor = false;
            this.BTN_ClearForm.Click += new System.EventHandler(this.BTN_ClearForm_Click_1);
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_Remove.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Remove.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Remove.Location = new System.Drawing.Point(276, 139);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(219, 36);
            this.BTN_Remove.TabIndex = 7;
            this.BTN_Remove.Text = "Remove";
            this.BTN_Remove.UseVisualStyleBackColor = false;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click_1);
            // 
            // BTN_add
            // 
            this.BTN_add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_add.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_add.Location = new System.Drawing.Point(38, 139);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(219, 36);
            this.BTN_add.TabIndex = 6;
            this.BTN_add.Text = "Add";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click_1);
            // 
            // CB_Department
            // 
            this.CB_Department.FormattingEnabled = true;
            this.CB_Department.Items.AddRange(new object[] {
            "Tools",
            "Appliances",
            "Consumables",
            "Hardware",
            "Misc"});
            this.CB_Department.Location = new System.Drawing.Point(38, 96);
            this.CB_Department.Name = "CB_Department";
            this.CB_Department.Size = new System.Drawing.Size(219, 21);
            this.CB_Department.TabIndex = 4;
            // 
            // lbl_Price
            // 
            this.lbl_Price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(518, 42);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(34, 13);
            this.lbl_Price.TabIndex = 39;
            this.lbl_Price.Text = "Price:";
            // 
            // lbl_Sku
            // 
            this.lbl_Sku.AutoSize = true;
            this.lbl_Sku.Location = new System.Drawing.Point(35, 42);
            this.lbl_Sku.Name = "lbl_Sku";
            this.lbl_Sku.Size = new System.Drawing.Size(36, 13);
            this.lbl_Sku.TabIndex = 38;
            this.lbl_Sku.Text = "Sku#:";
            // 
            // TB_Price
            // 
            this.TB_Price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_Price.Location = new System.Drawing.Point(521, 58);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(219, 20);
            this.TB_Price.TabIndex = 3;
            // 
            // TB_Sku
            // 
            this.TB_Sku.Location = new System.Drawing.Point(38, 58);
            this.TB_Sku.Name = "TB_Sku";
            this.TB_Sku.Size = new System.Drawing.Size(219, 20);
            this.TB_Sku.TabIndex = 1;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_Edit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Edit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.Location = new System.Drawing.Point(276, 181);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(219, 36);
            this.BTN_Edit.TabIndex = 9;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = false;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click_1);
            // 
            // TB_Name
            // 
            this.TB_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_Name.Location = new System.Drawing.Point(276, 58);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(219, 20);
            this.TB_Name.TabIndex = 2;
            // 
            // Edit_seachField
            // 
            this.Edit_seachField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_seachField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Edit_seachField.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.Edit_seachField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Edit_seachField.Location = new System.Drawing.Point(12, 240);
            this.Edit_seachField.Name = "Edit_seachField";
            this.Edit_seachField.Size = new System.Drawing.Size(752, 276);
            this.Edit_seachField.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Department:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(13, 16);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(44, 13);
            this.Search.TabIndex = 50;
            this.Search.Text = "Search:";
            // 
            // TB_Search
            // 
            this.TB_Search.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Search.Location = new System.Drawing.Point(16, 32);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(163, 20);
            this.TB_Search.TabIndex = 11;
            this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BTN_Reset);
            this.panel1.Controls.Add(this.CB_Search);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.TB_Search);
            this.panel1.Location = new System.Drawing.Point(521, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 121);
            this.panel1.TabIndex = 10;
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Location = new System.Drawing.Point(103, 86);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(75, 23);
            this.BTN_Reset.TabIndex = 13;
            this.BTN_Reset.Text = "Reset";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // CB_Search
            // 
            this.CB_Search.BackColor = System.Drawing.SystemColors.Control;
            this.CB_Search.FormattingEnabled = true;
            this.CB_Search.Items.AddRange(new object[] {
            "Tools",
            "Appliances",
            "Consumables",
            "Hardware",
            "Misc"});
            this.CB_Search.Location = new System.Drawing.Point(16, 58);
            this.CB_Search.Name = "CB_Search";
            this.CB_Search.Size = new System.Drawing.Size(163, 21);
            this.CB_Search.TabIndex = 12;
            this.CB_Search.Text = "Department";
            this.CB_Search.SelectedIndexChanged += new System.EventHandler(this.CB_Search_SelectedIndexChanged);
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_Sku);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.CB_Department);
            this.Controls.Add(this.TB_Quan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.BTN_ClearForm);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Sku);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.Edit_seachField);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InventoryMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Awesome Inventory Program";
            this.Load += new System.EventHandler(this.InventoryMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_seachField)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox TB_Quan;
        private System.Windows.Forms.Button BTN_ClearForm;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.ComboBox CB_Department;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Sku;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.TextBox TB_Sku;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.TextBox TB_Name;
        public System.Windows.Forms.DataGridView Edit_seachField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_Search;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

