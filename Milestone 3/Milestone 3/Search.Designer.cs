namespace Milestone_3
{
    partial class Search
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
            this.seachField = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.BTN_clearSearch = new System.Windows.Forms.Button();
            this.BTN_ClrResults = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.TB_Sku = new System.Windows.Forms.TextBox();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Sku = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.CB_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seachField)).BeginInit();
            this.SuspendLayout();
            // 
            // seachField
            // 
            this.seachField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seachField.BackgroundColor = System.Drawing.Color.Wheat;
            this.seachField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seachField.Location = new System.Drawing.Point(12, 230);
            this.seachField.Name = "seachField";
            this.seachField.Size = new System.Drawing.Size(702, 182);
            this.seachField.TabIndex = 0;
            this.seachField.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seachField_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Exisiting Inventory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(12, 107);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(219, 20);
            this.TB_Name.TabIndex = 2;
            // 
            // BTN_clearSearch
            // 
            this.BTN_clearSearch.BackColor = System.Drawing.Color.LightYellow;
            this.BTN_clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_clearSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_clearSearch.Location = new System.Drawing.Point(12, 175);
            this.BTN_clearSearch.Name = "BTN_clearSearch";
            this.BTN_clearSearch.Size = new System.Drawing.Size(219, 36);
            this.BTN_clearSearch.TabIndex = 3;
            this.BTN_clearSearch.Text = "Clear Search";
            this.BTN_clearSearch.UseVisualStyleBackColor = false;
            this.BTN_clearSearch.Click += new System.EventHandler(this.BTN_clearSearch_Click);
            // 
            // BTN_ClrResults
            // 
            this.BTN_ClrResults.BackColor = System.Drawing.Color.LightYellow;
            this.BTN_ClrResults.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ClrResults.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClrResults.Location = new System.Drawing.Point(250, 175);
            this.BTN_ClrResults.Name = "BTN_ClrResults";
            this.BTN_ClrResults.Size = new System.Drawing.Size(219, 36);
            this.BTN_ClrResults.TabIndex = 4;
            this.BTN_ClrResults.Text = "Clear Results";
            this.BTN_ClrResults.UseVisualStyleBackColor = false;
            this.BTN_ClrResults.Click += new System.EventHandler(this.BTN_ClrResults_Click);
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackColor = System.Drawing.Color.LightYellow;
            this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Search.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.Location = new System.Drawing.Point(495, 175);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(219, 36);
            this.BTN_Search.TabIndex = 5;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = false;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // TB_Sku
            // 
            this.TB_Sku.Location = new System.Drawing.Point(250, 107);
            this.TB_Sku.Name = "TB_Sku";
            this.TB_Sku.Size = new System.Drawing.Size(219, 20);
            this.TB_Sku.TabIndex = 6;
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(495, 107);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(219, 20);
            this.TB_Price.TabIndex = 7;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(13, 85);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 13);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "Item Name:";
            // 
            // lbl_Sku
            // 
            this.lbl_Sku.AutoSize = true;
            this.lbl_Sku.Location = new System.Drawing.Point(250, 85);
            this.lbl_Sku.Name = "lbl_Sku";
            this.lbl_Sku.Size = new System.Drawing.Size(39, 13);
            this.lbl_Sku.TabIndex = 9;
            this.lbl_Sku.Text = "SKU#:";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(495, 85);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(34, 13);
            this.lbl_Price.TabIndex = 10;
            this.lbl_Price.Text = "Price:";
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
            this.CB_Department.Location = new System.Drawing.Point(250, 148);
            this.CB_Department.Name = "CB_Department";
            this.CB_Department.Size = new System.Drawing.Size(219, 21);
            this.CB_Department.TabIndex = 11;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Location = new System.Drawing.Point(250, 132);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(65, 13);
            this.lbl_Department.TabIndex = 12;
            this.lbl_Department.Text = "Department:";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(726, 424);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.CB_Department);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Sku);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.TB_Sku);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.BTN_ClrResults);
            this.Controls.Add(this.BTN_clearSearch);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seachField);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.seachField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView seachField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button BTN_clearSearch;
        private System.Windows.Forms.Button BTN_ClrResults;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.TextBox TB_Sku;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Sku;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.ComboBox CB_Department;
        private System.Windows.Forms.Label lbl_Department;
    }
}