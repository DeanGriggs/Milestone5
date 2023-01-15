namespace Milestone_3
{
    partial class Edit
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
            this.lbl_Department = new System.Windows.Forms.Label();
            this.CB_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Sku = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.TB_Sku = new System.Windows.Forms.TextBox();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.Edit_seachField = new System.Windows.Forms.DataGridView();
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.BTN_ClearForm = new System.Windows.Forms.Button();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.TB_Quan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_seachField)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Location = new System.Drawing.Point(16, 95);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(65, 13);
            this.lbl_Department.TabIndex = 24;
            this.lbl_Department.Text = "Department:";
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
            this.CB_Department.Location = new System.Drawing.Point(19, 111);
            this.CB_Department.Name = "CB_Department";
            this.CB_Department.Size = new System.Drawing.Size(219, 21);
            this.CB_Department.TabIndex = 23;
            this.CB_Department.Text = "cc";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(499, 57);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(19, 13);
            this.lbl_Price.TabIndex = 22;
            this.lbl_Price.Text = "cc";
            // 
            // lbl_Sku
            // 
            this.lbl_Sku.AutoSize = true;
            this.lbl_Sku.Location = new System.Drawing.Point(254, 57);
            this.lbl_Sku.Name = "lbl_Sku";
            this.lbl_Sku.Size = new System.Drawing.Size(19, 13);
            this.lbl_Sku.TabIndex = 21;
            this.lbl_Sku.Text = "cc";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(16, 57);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 13);
            this.lbl_Name.TabIndex = 20;
            this.lbl_Name.Text = "Item Name:";
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(502, 73);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(219, 20);
            this.TB_Price.TabIndex = 19;
            this.TB_Price.Text = "cc";
            // 
            // TB_Sku
            // 
            this.TB_Sku.Location = new System.Drawing.Point(257, 73);
            this.TB_Sku.Name = "TB_Sku";
            this.TB_Sku.Size = new System.Drawing.Size(219, 20);
            this.TB_Sku.TabIndex = 18;
            this.TB_Sku.Text = "cc";
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackColor = System.Drawing.Color.MistyRose;
            this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Search.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.Location = new System.Drawing.Point(502, 155);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(219, 36);
            this.BTN_Search.TabIndex = 17;
            this.BTN_Search.Text = "cc";
            this.BTN_Search.UseVisualStyleBackColor = false;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.MistyRose;
            this.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Edit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.Location = new System.Drawing.Point(257, 197);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(219, 36);
            this.BTN_Edit.TabIndex = 16;
            this.BTN_Edit.Text = "cc";
            this.BTN_Edit.UseVisualStyleBackColor = false;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.MistyRose;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Save.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.Location = new System.Drawing.Point(19, 197);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(219, 36);
            this.BTN_Save.TabIndex = 15;
            this.BTN_Save.Text = "cc";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(19, 73);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(219, 20);
            this.TB_Name.TabIndex = 14;
            this.TB_Name.Text = "cc";
            // 
            // Edit_seachField
            // 
            this.Edit_seachField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_seachField.BackgroundColor = System.Drawing.Color.LightCoral;
            this.Edit_seachField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Edit_seachField.Location = new System.Drawing.Point(19, 256);
            this.Edit_seachField.Name = "Edit_seachField";
            this.Edit_seachField.Size = new System.Drawing.Size(702, 283);
            this.Edit_seachField.TabIndex = 13;
            // 
            // BTN_add
            // 
            this.BTN_add.BackColor = System.Drawing.Color.MistyRose;
            this.BTN_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_add.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_add.Location = new System.Drawing.Point(19, 155);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(219, 36);
            this.BTN_add.TabIndex = 25;
            this.BTN_add.Text = "cc";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.BackColor = System.Drawing.Color.MistyRose;
            this.BTN_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Remove.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Remove.Location = new System.Drawing.Point(257, 155);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(219, 36);
            this.BTN_Remove.TabIndex = 26;
            this.BTN_Remove.Text = "cc";
            this.BTN_Remove.UseVisualStyleBackColor = false;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // BTN_ClearForm
            // 
            this.BTN_ClearForm.BackColor = System.Drawing.Color.MistyRose;
            this.BTN_ClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ClearForm.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearForm.Location = new System.Drawing.Point(502, 197);
            this.BTN_ClearForm.Name = "BTN_ClearForm";
            this.BTN_ClearForm.Size = new System.Drawing.Size(219, 36);
            this.BTN_ClearForm.TabIndex = 27;
            this.BTN_ClearForm.Text = "cc";
            this.BTN_ClearForm.UseVisualStyleBackColor = false;
            this.BTN_ClearForm.Click += new System.EventHandler(this.BTN_ClearForm_Click);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(254, 96);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(19, 13);
            this.lbl_Quantity.TabIndex = 29;
            this.lbl_Quantity.Text = "cc";
            // 
            // TB_Quan
            // 
            this.TB_Quan.Location = new System.Drawing.Point(257, 112);
            this.TB_Quan.Name = "TB_Quan";
            this.TB_Quan.Size = new System.Drawing.Size(219, 20);
            this.TB_Quan.TabIndex = 28;
            this.TB_Quan.Text = "cc";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(741, 544);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.TB_Quan);
            this.Controls.Add(this.BTN_ClearForm);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.CB_Department);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Sku);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.TB_Sku);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.Edit_seachField);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_seachField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.ComboBox CB_Department;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Sku;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.TextBox TB_Sku;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.Button BTN_ClearForm;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox TB_Quan;
        public System.Windows.Forms.DataGridView Edit_seachField;
    }
}