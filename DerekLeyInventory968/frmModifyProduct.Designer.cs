namespace DerekLeyInventory968
{
    partial class frmModifyProduct
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtSearchParts = new System.Windows.Forms.TextBox();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPartsDelete = new System.Windows.Forms.Button();
            this.dtaProducts = new System.Windows.Forms.DataGridView();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnPartsAdd = new System.Windows.Forms.Button();
            this.dtaParts = new System.Windows.Forms.DataGridView();
            this.lblParts = new System.Windows.Forms.Label();
            this.tipModifyProduct = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtaProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaParts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 25);
            this.lblTitle.TabIndex = 59;
            this.lblTitle.Text = "Modify Product";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(291, 293);
            this.txtMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 27);
            this.txtMin.TabIndex = 93;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(117, 293);
            this.txtMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 27);
            this.txtMax.TabIndex = 92;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(117, 260);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(167, 27);
            this.txtPrice.TabIndex = 91;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(117, 226);
            this.txtInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(167, 27);
            this.txtInventory.TabIndex = 90;
            this.txtInventory.TextChanged += new System.EventHandler(this.txtInventory_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(117, 193);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 27);
            this.txtName.TabIndex = 89;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(117, 160);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(167, 27);
            this.txtID.TabIndex = 88;
            this.txtID.TabStop = false;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(253, 300);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(30, 17);
            this.lblMin.TabIndex = 87;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(48, 300);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(33, 17);
            this.lblMax.TabIndex = 86;
            this.lblMax.Text = "Max";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(43, 267);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 85;
            this.lblPrice.Text = "Price";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(16, 234);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(66, 17);
            this.lblInventory.TabIndex = 84;
            this.lblInventory.Text = "Inventory";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 201);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 83;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(60, 167);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 82;
            this.lblID.Text = "ID";
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchParts.Location = new System.Drawing.Point(727, 39);
            this.txtSearchParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(231, 27);
            this.txtSearchParts.TabIndex = 103;
            this.txtSearchParts.TextChanged += new System.EventHandler(this.txtSearchParts_TextChanged);
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Location = new System.Drawing.Point(645, 38);
            this.btnSearchParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(75, 27);
            this.btnSearchParts.TabIndex = 102;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(884, 514);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(804, 514);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPartsDelete
            // 
            this.btnPartsDelete.Location = new System.Drawing.Point(884, 480);
            this.btnPartsDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartsDelete.Name = "btnPartsDelete";
            this.btnPartsDelete.Size = new System.Drawing.Size(75, 30);
            this.btnPartsDelete.TabIndex = 99;
            this.btnPartsDelete.Text = "Delete";
            this.btnPartsDelete.UseVisualStyleBackColor = true;
            this.btnPartsDelete.Click += new System.EventHandler(this.btnPartsDelete_Click);
            // 
            // dtaProducts
            // 
            this.dtaProducts.AllowUserToAddRows = false;
            this.dtaProducts.AllowUserToResizeColumns = false;
            this.dtaProducts.AllowUserToResizeRows = false;
            this.dtaProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaProducts.Location = new System.Drawing.Point(425, 325);
            this.dtaProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtaProducts.Name = "dtaProducts";
            this.dtaProducts.RowHeadersVisible = false;
            this.dtaProducts.RowHeadersWidth = 51;
            this.dtaProducts.RowTemplate.Height = 24;
            this.dtaProducts.Size = new System.Drawing.Size(533, 150);
            this.dtaProducts.TabIndex = 98;
            this.dtaProducts.SelectionChanged += new System.EventHandler(this.dtaProducts_SelectionChanged);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(421, 304);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(267, 18);
            this.lblProducts.TabIndex = 97;
            this.lblProducts.Text = "Parts Associated with this Product";
            // 
            // btnPartsAdd
            // 
            this.btnPartsAdd.Location = new System.Drawing.Point(884, 247);
            this.btnPartsAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartsAdd.Name = "btnPartsAdd";
            this.btnPartsAdd.Size = new System.Drawing.Size(75, 30);
            this.btnPartsAdd.TabIndex = 96;
            this.btnPartsAdd.Text = "Add";
            this.btnPartsAdd.UseVisualStyleBackColor = true;
            this.btnPartsAdd.Click += new System.EventHandler(this.btnPartsAdd_Click);
            // 
            // dtaParts
            // 
            this.dtaParts.AllowUserToAddRows = false;
            this.dtaParts.AllowUserToResizeColumns = false;
            this.dtaParts.AllowUserToResizeRows = false;
            this.dtaParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaParts.Location = new System.Drawing.Point(425, 92);
            this.dtaParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtaParts.Name = "dtaParts";
            this.dtaParts.RowHeadersVisible = false;
            this.dtaParts.RowHeadersWidth = 51;
            this.dtaParts.RowTemplate.Height = 24;
            this.dtaParts.Size = new System.Drawing.Size(533, 150);
            this.dtaParts.TabIndex = 95;
            this.dtaParts.SelectionChanged += new System.EventHandler(this.dtaParts_SelectionChanged);
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(421, 71);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(151, 18);
            this.lblParts.TabIndex = 94;
            this.lblParts.Text = "All Candidate Parts";
            // 
            // frmModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 567);
            this.Controls.Add(this.txtSearchParts);
            this.Controls.Add(this.btnSearchParts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPartsDelete);
            this.Controls.Add(this.dtaProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.btnPartsAdd);
            this.Controls.Add(this.dtaParts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmModifyProduct";
            this.Text = "Modify Product";
            this.Activated += new System.EventHandler(this.frmModifyProduct_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModifyProduct_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtaProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtSearchParts;
        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPartsDelete;
        private System.Windows.Forms.DataGridView dtaProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnPartsAdd;
        private System.Windows.Forms.DataGridView dtaParts;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.ToolTip tipModifyProduct;
    }
}