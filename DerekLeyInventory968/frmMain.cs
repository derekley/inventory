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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            // Sets up form
            InitializeComponent();
            dtaParts.ClearSelection();
            dtaParts.CurrentCell = null;
            dtaProducts.ClearSelection();
            dtaProducts.CurrentCell = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Terminates the Application
            this.Close();
        }

        private void btnPartsAdd_Click(object sender, EventArgs e)
        {
            // Opens form for adding a new Part
            frmAddPart form = new frmAddPart();
            form.ParentForm = this;
            this.Hide();
            form.ShowDialog();
        }

        private void btnProductsAdd_Click(object sender, EventArgs e)
        {
            // Opens form for adding a new Product
            frmAddProduct form = new frmAddProduct();
            form.ParentForm = this;
            this.Hide();
            form.ShowDialog();
        }

        private void btnProductsModify_Click(object sender, EventArgs e)
        {
            // Checks if a Product is selected (prompt otherwise), then opens form to Modify
            if (dtaProducts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a Product to modify.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Product prod = (Product)dtaProducts.CurrentRow.DataBoundItem;
                frmModifyProduct form = new frmModifyProduct(prod);
                form.ParentForm = this;
                this.Hide();
                form.ShowDialog();
            }
        }

        private void btnPartsModify_Click(object sender, EventArgs e)
        {
            // Checks if a Part is selected (prompt otherwise), then opens form to Modify
            if (dtaParts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a Part to modify.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dtaParts.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
                {
                    InHouse inPart = (InHouse)dtaParts.CurrentRow.DataBoundItem;
                    frmModifyPart form = new frmModifyPart(inPart);
                    form.ParentForm = this;
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    OutSource outPart = (OutSource)dtaParts.CurrentRow.DataBoundItem;
                    frmModifyPart form = new frmModifyPart(outPart);
                    form.ParentForm = this;
                    this.Hide();
                    form.ShowDialog();
                }
            }
        }

        private void btnPartsDelete_Click(object sender, EventArgs e)
        {
            // Checks if a Part is selected (prompt otherwise), then deletes selected Part
            if (dtaParts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a Part to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Part part = (Part)dtaParts.CurrentRow.DataBoundItem;
                var res = MessageBox.Show("Are you sure that you would like to delete selected Part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Inventory.DeletePart(part);
                    dtaParts.DataSource = Inventory.AllParts;
                }
            }
        }

        private void btnProductsDelete_Click(object sender, EventArgs e)
        {
            // Checks if a Product is selected (prompt otherwise), then deletes selected Product
            if (dtaProducts.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a Product to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Product prod = (Product)dtaProducts.CurrentRow.DataBoundItem;
                var res = MessageBox.Show("Are you sure that you would like to delete selected Product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Inventory.RemoveProduct(prod.ProductID);
                    dtaProducts.DataSource = Inventory.Products;
                }
            }
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            // This method searches through the available Parts and selects matching results

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

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            // This method searches through the available Products and selects matching results

            // First clear any selection(s), then search against user input and select matching results
            dtaProducts.ClearSelection();
            dtaProducts.CurrentCell = null;
            foreach (DataGridViewRow row in dtaProducts.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().ToLower().Contains(txtSearchProducts.Text.ToLower()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
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

        private void frmMain_Activated(object sender, EventArgs e)
        {
            // All Parts in Inventory show in the left table
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

            // All Products in Inventory show in the right table
            var bndProd = new BindingSource();
            bndProd.DataSource = Inventory.Products;
            dtaProducts.DataSource = bndProd;
            dtaProducts.Columns["ProductID"].HeaderText = "Product ID";
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
            foreach (DataGridViewRow row in dtaParts.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Yellow)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
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
