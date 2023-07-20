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
    public partial class frmAddPart : Form
    {
        public new Form ParentForm { get; set; }

        public frmAddPart()
        {
            // Sets up form
            InitializeComponent();
            txtID.Text = "" + (Inventory.MaxPart() + 1) + "";
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

        private void radIn_CheckedChanged(object sender, EventArgs e)
        {
            // This method handles the validation for InHouse Parts
            if (radIn.Checked == true)
            {
                lblCoMa.Text = "Machine ID";
                if (txtCoMa.Text == "")
                {
                    txtCoMa.BackColor = Color.Red;
                    tipAddPart.SetToolTip(txtCoMa, "Machine ID requires whole number");
                }
                else if (!int.TryParse(txtCoMa.Text, out int result))
                {
                    txtCoMa.BackColor = Color.Red;
                    tipAddPart.SetToolTip(txtCoMa, "Machine ID requires whole number");
                }
                else
                {
                    txtCoMa.BackColor = Color.White;
                    tipAddPart.Hide(txtCoMa);
                }
            }
            else
            {
                lblCoMa.Text = "Company Name";
                if (txtCoMa.Text == "")
                {
                    txtCoMa.BackColor = Color.Red;
                    tipAddPart.SetToolTip(txtCoMa, "Company Name required");
                }
                else
                {
                    txtCoMa.BackColor = Color.White;
                    tipAddPart.Hide(txtCoMa);
                }
            }

            checkSave();
        }

        private void radOut_CheckedChanged(object sender, EventArgs e)
        {
            // This method handles the validation for OutSourced Parts
            if (radOut.Checked == true)
            {
                lblCoMa.Text = "Company Name";
                if (txtCoMa.Text == "")
                {
                    txtCoMa.BackColor = Color.Red;
                    tipAddPart.SetToolTip(txtCoMa, "Company Name required");
                }
                else
                {
                    txtCoMa.BackColor = Color.White;
                    tipAddPart.Hide(txtCoMa);
                }
            }
            else
            {
                lblCoMa.Text = "Machine ID";
                if (txtCoMa.Text == "")
                {
                    txtCoMa.BackColor = Color.Red;
                    tipAddPart.SetToolTip(txtCoMa, "Machine ID requires whole number");
                }
                else if (!int.TryParse(txtCoMa.Text, out int result))
                {
                    txtCoMa.BackColor = Color.Red;
                    tipAddPart.SetToolTip(txtCoMa, "Machine ID requires whole number");
                }
                else
                {
                    txtCoMa.BackColor = Color.White;
                    tipAddPart.Hide(txtCoMa);
                }
            }

            checkSave();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Validation for Name

            // Must not be blank
            if (txtName.Text == "")
            {
                txtName.BackColor = Color.Red;
                tipAddPart.SetToolTip(txtName, "Name required");
            }

            // Valid input
            else
            {
                txtName.BackColor = Color.White;
                tipAddPart.Hide(txtName);
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
                tipAddPart.SetToolTip(txtInventory, "Inventory requires whole number");
            }

            // Must be Integer
            else if (!int.TryParse(txtInventory.Text, out int result))
            {
                txtInventory.BackColor = Color.Red;
                tipAddPart.SetToolTip(txtInventory, "Inventory requires whole number");
            }

            // Valid input
            else
            {
                txtInventory.BackColor = Color.White;
                tipAddPart.Hide(txtInventory);
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
                tipAddPart.SetToolTip(txtPrice, "Price requires number");
            }

            // Must be Decimal
            else if (!decimal.TryParse(txtPrice.Text, out decimal result))
            {
                txtPrice.BackColor = Color.Red;
                tipAddPart.SetToolTip(txtPrice, "Price requires number");
            }

            // Valid input
            else
            {
                txtPrice.BackColor = Color.White;
                tipAddPart.Hide(txtPrice);
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
                tipAddPart.SetToolTip(txtMax, "Max requires whole number");
            }

            // Must be Integer
            else if (!int.TryParse(txtMax.Text, out int result))
            {
                txtMax.BackColor = Color.Red;
                tipAddPart.SetToolTip(txtMax, "Max requires whole number");
            }

            // Valid input
            else
            {
                txtMax.BackColor = Color.White;
                tipAddPart.Hide(txtMax);
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
                tipAddPart.SetToolTip(txtMin, "Min requires whole number");
            }

            // Must be Integer
            else if (!int.TryParse(txtMin.Text, out int result))
            {
                txtMin.BackColor = Color.Red;
                tipAddPart.SetToolTip(txtMin, "Min requires whole number");
            }

            // Valid input
            else
            {
                txtMin.BackColor = Color.White;
                tipAddPart.Hide(txtMin);
            }

            checkSave();
        }

        private void txtCoMa_TextChanged(object sender, EventArgs e)
        {
            // Validation for input based on whether the Part is InHouse or OutSourced
            if (radIn.Checked == true)
            {
                if (txtCoMa.Text == "")
                {
                    txtCoMa.BackColor = Color.Red;
                    tipAddPart.SetToolTip(txtCoMa, "Machine ID requires whole number");

                }
                else if (!int.TryParse(txtCoMa.Text, out int result))
                {
                    txtCoMa.BackColor = Color.Red;
                    tipAddPart.SetToolTip(txtCoMa, "Machine ID requires whole number");
                }
                else
                {
                    txtCoMa.BackColor = Color.White;
                    tipAddPart.Hide(txtCoMa);
                }
            }
            else if (radOut.Checked == true)
            {
                if (txtCoMa.Text == "")
                {
                    txtCoMa.BackColor = Color.Red;
                    tipAddPart.SetToolTip(txtCoMa, "Company Name required");
                }
                else
                {
                    txtCoMa.BackColor = Color.White;
                    tipAddPart.Hide(txtCoMa);
                }
            }

            checkSave();
        }

        public void checkSave()
        {
            // This method checks the state of the user inputs to validate the data entered and enables the user to Save if all checks out
            if (txtName.BackColor == Color.White && txtInventory.BackColor == Color.White && txtPrice.BackColor == Color.White && txtMax.BackColor == Color.White && txtMin.BackColor == Color.White && txtCoMa.BackColor == Color.White)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void frmAddPart_Load(object sender, EventArgs e)
        {
            // Initiates textboxes for the tooltips to work
            txtName.Text = "";
            tipAddPart.SetToolTip(txtName, "Name required");
            txtInventory.Text = "";
            tipAddPart.SetToolTip(txtInventory, "Inventory requires whole number");
            txtPrice.Text = "";
            tipAddPart.SetToolTip(txtPrice, "Price requires number");
            txtMax.Text = "";
            tipAddPart.SetToolTip(txtMax, "Max requires whole number");
            txtMin.Text = "";
            tipAddPart.SetToolTip(txtMin, "Min requires whole number");
            txtCoMa.Text = "";
            tipAddPart.SetToolTip(txtCoMa, "Company Name required");
        }

        private void frmAddPart_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This links all the forms together, returning to the Main form
            if (this.ParentForm != null)
            {
                this.ParentForm.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Saves any changes/user inputs after validation and closes the form, returning to Main
            if (int.Parse(txtMax.Text) < int.Parse(txtMin.Text))
            {
                txtMin.BackColor = Color.Red;
                tipAddPart.SetToolTip(txtMin, "Minimum exceeds maximum");
                MessageBox.Show("Minimum exceeds maximum", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtInventory.Text) > int.Parse(txtMax.Text) || int.Parse(txtInventory.Text) < int.Parse(txtMin.Text))
            {
                txtInventory.BackColor = Color.Red;
                tipAddPart.SetToolTip(txtInventory, "Inventory must be within the Maximum and Minimum");
                MessageBox.Show("Inventory must be within the Maximum and Minimum", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radIn.Checked)
                {
                    InHouse newPart = new InHouse(int.Parse(txtID.Text), txtName.Text, decimal.Parse(txtPrice.Text), int.Parse(txtInventory.Text), int.Parse(txtMin.Text), int.Parse(txtMax.Text), int.Parse(txtCoMa.Text));
                    Inventory.AddPart(newPart);
                }
                else
                {
                    OutSource newPart = new OutSource(int.Parse(txtID.Text), txtName.Text, decimal.Parse(txtPrice.Text), int.Parse(txtInventory.Text), int.Parse(txtMin.Text), int.Parse(txtMax.Text), txtCoMa.Text);
                    Inventory.AddPart(newPart);
                }
                this.Close();
            }
        }
    }
}
