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
using System.Data.SqlClient;

namespace Milestone_3
{
    public partial class Edit : Form
    {

        public static Edit editInstance;

        public DataGridView eDGV;

        public Edit()
        {
            InitializeComponent();
            editInstance = this;
            
        }

        


        DataTable inventory = new DataTable();
        DataTable inventorySave = new DataTable();

        private void Edit_Load(object sender, EventArgs e)
        {
            
            inventory.Columns.Add("Name");
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Department");
            inventory.Columns.Add("Quantity");

            
            
            Edit_seachField.DataSource = inventory;
            
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            string name = TB_Name.Text;
            string price = TB_Price.Text;
            string sku = TB_Sku.Text;
            string quantity = TB_Quan.Text;
            string department = (string)CB_Department.SelectedItem;

            inventory.Rows.Add(name, sku, price, department, quantity);

            //clear after save
            BTN_ClearForm_Click(sender, e);
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
           


        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                TB_Name.Text = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[0].ToString();
                TB_Sku.Text = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[1].ToString();
                TB_Price.Text = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[2].ToString();
                TB_Quan.Text = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[4].ToString();
                

                string itemtolookfor = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[3].ToString();
                CB_Department.SelectedIndex = CB_Department.Items.IndexOf(itemtolookfor);
            }
            catch (Exception err)
            {
                MessageBox.Show("This is an illegal move " + err);
            }
            try
            {
                inventory.Rows[Edit_seachField.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error " + err);
            }
        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[Edit_seachField.CurrentCell.RowIndex].Delete();
            }
            catch(Exception err)
            {
                MessageBox.Show("Error " + err);
            }
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            inventory = inventorySave;
        }

        private void BTN_ClearForm_Click(object sender, EventArgs e)
        {
            TB_Name.Text = "";
            TB_Price.Text = "";
            TB_Sku.Text = "";
            TB_Quan.Text = "";
            CB_Department.SelectedIndex = -1;
        }

        
    }
}
