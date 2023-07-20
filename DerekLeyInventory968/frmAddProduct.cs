/*
 * Name:        Derek Ley
 * Student ID:  #001053885
 * Course:      C968
 * Date:        Sunday, December 1, 2019
 * Purpose:     This program will act as an inventory management system that allows for users to add/modify Parts
 *              in their inventory and add/modify Products and link the Parts to those Products.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerekLeyInventory968
{
    public partial class frmAddProduct : Form
    {

        BindingList<Part> partsToAdd = new BindingList<Part>();
        BindingList<Part> partsToRemove = new BindingList<Part>();

        public new Form ParentForm { get; set; }

        public frmAddProduct()
        {
            // Sets up Form
            InitializeComponent();
            dtaParts.ClearSelection();
            dtaParts.CurrentCell = null;
            dtaProducts.ClearSelection();
            dtaProducts.CurrentCell = null;
            txtID.Text = "" + (Inventory.MaxProd() + 1) + "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // This method prompts user if they would actually like to cancel, cancels all changes made, and closes form returning to Main
            var res = MessageBox.Show("Are you sure that you would like to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Validation for Name

            // Must not be blank
            if (txtName.Text == "")
            {
                txtName.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtName, "Name required");
            }

            // Valid input
            else
            {
                txtName.BackColor = Color.White;
                tipAddProduct.Hide(txtName);
            }

            checkSave();
        }

        private void txtInventory_TextChanged(object sender, EventArgs e)
        {
            // Validation for Inventory

            // Must not be blank
            if (txtInventory.Text == "")
            {
                txtInventory.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtInventory, "Inventory requires whole number");
            }

            // Must be Integer
            else if (!int.TryParse(txtInventory.Text, out int result))
            {
                txtInventory.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtInventory, "Inventory requires whole number");
            }

            // Valid input
            else
            {
                txtInventory.BackColor = Color.White;
                tipAddProduct.Hide(txtInventory);
            }

            checkSave();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            // Validation for Price

            // Must not be blank
            if (txtPrice.Text == "")
            {
                txtPrice.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtPrice, "Price requires number");
            }

            // Must be Decimal
            else if (!decimal.TryParse(txtPrice.Text, out decimal result))
            {
                txtPrice.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtPrice, "Price requires number");
            }

            // Valid input
            else
            {
                txtPrice.BackColor = Color.White;
                tipAddProduct.Hide(txtPrice);
            }

            checkSave();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            // Validation for Max number

            // Must not be blank
            if (txtMax.Text == "")
            {
                txtMax.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtMax, "Max requires whole number");
            }

            // Must be Integer
            else if (!int.TryParse(txtMax.Text, out int result))
            {
                txtMax.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtMax, "Max requires whole number");
            }

            // Valid input
            else
            {
                txtMax.BackColor = Color.White;
                tipAddProduct.Hide(txtMax);
            }

            checkSave();
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            // Validation for Min number

            // Must not be blank
            if (txtMin.Text == "")
            {
                txtMin.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtMin, "Min requires whole number");
            }

            // Must be Integer
            else if (!int.TryParse(txtMin.Text, out int result))
            {
                txtMin.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtMin, "Min requires whole number");
            }

            // Valid input
            else
            {
                txtMin.BackColor = Color.White;
                tipAddProduct.Hide(txtMin);
            }

            checkSave();
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            // This method searches through the available Parts from the top list and selects matching results

            // First clear any selection(s), then search against user input and select matching results
            dtaParts.ClearSelection();
            dtaParts.CurrentCell = null;
            foreach (DataGridViewRow row in dtaParts.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().ToLower().Contains(txtSearchParts.Text.ToLower()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void btnPartsAdd_Click(object sender, EventArgs e)
        {
            // This method adds selected Parts from the top list to the Associated Parts of the Product in the bottom list

            // If no rows are selected, alert user; otherwise, add the selected rows
            if (dtaParts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a Part to add.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dtaParts.SelectedRows)
                {
                    Part partToAdd = (Part)dtaParts.Rows[row.Index].DataBoundItem;
                    partsToAdd.Add(partToAdd);
                    dtaProducts.DataSource = partsToAdd;
                }
            }
        }

        private void btnPartsDelete_Click(object sender, EventArgs e)
        {
            // This method removes selected Parts from the bottom list (Associated Parts of the Product)

            // If no rows are selected, alert user; otherwise, add the selected rows
            if (dtaProducts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a Part to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dtaProducts.SelectedRows)
                {
                    Part part = (Part)dtaProducts.Rows[row.Index].DataBoundItem;
                    partsToRemove.Add(part);
                }
                var res = MessageBox.Show("Are you sure that you would like to delete selected Part(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    foreach (Part part in partsToRemove)
                    {
                        partsToAdd.Remove(part);
                        dtaProducts.DataSource = partsToAdd;
                    }
                    partsToRemove.Clear();
                }
                else
                {
                    partsToRemove.Clear();
                    dtaProducts.DataSource = partsToAdd;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // This method saves the user changes to the textboxes and the Associated Parts; Program only gets here after checkSave() method passes

            // Check if Min is greater than Max
            if (int.Parse(txtMax.Text) < int.Parse(txtMin.Text))
            {
                txtMin.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtMin, "Minimum exceeds maximum");
                MessageBox.Show("Minimum exceeds maximum", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Check if InStock is within Min and Max
            else if (int.Parse(txtInventory.Text) > int.Parse(txtMax.Text) || int.Parse(txtInventory.Text) < int.Parse(txtMin.Text))
            {
                txtInventory.BackColor = Color.Red;
                tipAddProduct.SetToolTip(txtInventory, "Inventory must be within the Maximum and Minimum");
                MessageBox.Show("Inventory must be within the Maximum and Minimum", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Check if Product has at least 1 Associated Part
            else if (dtaProducts.Rows.Count == 0)
            {
                MessageBox.Show("Products must have at least one associated Part.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // All validation has passed; this saves all changes and uses the appropriate methods to do so; then closes the form and returns to Main
            else
            {
                var res = MessageBox.Show("Are you sure that you would like to save this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Product prod = new Product(int.Parse(txtID.Text), txtName.Text, decimal.Parse(txtPrice.Text), int.Parse(txtInventory.Text), int.Parse(txtMax.Text), int.Parse(txtMin.Text));
                    Inventory.AddProduct(prod);
                    foreach (Part newPart in partsToAdd)
                    {
                        prod.AddAssociatedPart(newPart);
                    }
                    Inventory.UpdateProduct(int.Parse(txtID.Text), prod);
                    this.Close();
                }
            }
        }

        public void checkSave()
        {
            // This method checks the state of the user inputs to validate the data entered and enables the user to Save if all checks out
            if (txtName.BackColor == Color.White && txtInventory.BackColor == Color.White && txtPrice.BackColor == Color.White && txtMax.BackColor == Color.White && txtMin.BackColor == Color.White)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void dtaParts_SelectionChanged(object sender, EventArgs e)
        {
            // HELPER METHOD: To select an entire row at a time based on user-selected cell
            if (dtaParts.SelectedCells.Count > 0)
            {
                dtaParts.CurrentRow.Selected = true;
            }
            foreach (DataGridViewRow row in dtaParts.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Yellow)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dtaProducts_SelectionChanged(object sender, EventArgs e)
        {
            // HELPER METHOD: To select an entire row at a time based on user-selected cell
            if (dtaProducts.SelectedCells.Count > 0)
            {
                dtaProducts.CurrentRow.Selected = true;
            }
            foreach (DataGridViewRow row in dtaProducts.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Yellow)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void frmAddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This links all the forms together, returning to the Main form
            if (this.ParentForm != null)
            {
                this.ParentForm.Show();
            }
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            // Initiates textboxes for the tooltips to work
            txtName.Text = "";
            tipAddProduct.SetToolTip(txtName, "Name required");
            txtInventory.Text = "";
            tipAddProduct.SetToolTip(txtInventory, "Inventory requires whole number");
            txtPrice.Text = "";
            tipAddProduct.SetToolTip(txtPrice, "Price requires number");
            txtMax.Text = "";
            tipAddProduct.SetToolTip(txtMax, "Max requires whole number");
            txtMin.Text = "";
            tipAddProduct.SetToolTip(txtMin, "Min requires whole number");
        }

        private void frmAddProduct_Activated(object sender, EventArgs e)
        {
            // Sets up the form to display all Parts within the Inventory
            var bndPart = new BindingSource();
            bndPart.DataSource = Inventory.AllParts;
            dtaParts.DataSource = bndPart;
            dtaParts.Columns["PartID"].HeaderText = "Part ID";
            dtaParts.Columns["InStock"].HeaderText = "Inventory";
            dtaParts.Columns["Max"].Visible = false;
            dtaParts.Columns["Min"].Visible = false;
            dtaParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtaParts.ClearSelection();
            dtaParts.CurrentCell = null;

            var bndProduct = new BindingSource();
            bndProduct.DataSource = partsToAdd;
            dtaProducts.DataSource = bndProduct;
            dtaProducts.Columns["PartID"].HeaderText = "Part ID";
            dtaProducts.Columns["InStock"].HeaderText = "Inventory";
            dtaProducts.Columns["Max"].Visible = false;
            dtaProducts.Columns["Min"].Visible = false;
            dtaProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtaProducts.ClearSelection();
            dtaProducts.CurrentCell = null;
        }

        private void txtSearchParts_TextChanged(object sender, EventArgs e)
        {
            // This method clears the last Search result(s) for new Searches
            foreach (DataGridViewRow row in dtaProducts.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Yellow)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
