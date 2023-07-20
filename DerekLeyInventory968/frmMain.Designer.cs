namespace DerekLeyInventory968
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.txtSearchParts = new System.Windows.Forms.TextBox();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.dtaParts = new System.Windows.Forms.DataGridView();
            this.dtaProducts = new System.Windows.Forms.DataGridView();
            this.btnPartsAdd = new System.Windows.Forms.Button();
            this.btnPartsModify = new System.Windows.Forms.Button();
            this.btnPartsDelete = new System.Windows.Forms.Button();
            this.btnProductsAdd = new System.Windows.Forms.Button();
            this.btnProductsModify = new System.Windows.Forms.Button();
            this.btnProductsDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory Management System";
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Location = new System.Drawing.Point(332, 75);
            this.btnSearchParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(75, 27);
            this.btnSearchParts.TabIndex = 1;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Location = new System.Drawing.Point(985, 75);
            this.btnSearchProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(75, 27);
            this.btnSearchProducts.TabIndex = 7;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            this.btnSearchProducts.Click += new System.EventHandler(this.btnSearchProducts_Click);
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchParts.Location = new System.Drawing.Point(412, 76);
            this.txtSearchParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(231, 27);
            this.txtSearchParts.TabIndex = 2;
            this.txtSearchParts.TextChanged += new System.EventHandler(this.txtSearchParts_TextChanged);
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProducts.Location = new System.Drawing.Point(1065, 76);
            this.txtSearchProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(231, 27);
            this.txtSearchProducts.TabIndex = 8;
            this.txtSearchProducts.TextChanged += new System.EventHandler(this.txtSearchProducts_TextChanged);
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(12, 78);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(62, 25);
            this.lblParts.TabIndex = 5;
            this.lblParts.Text = "Parts";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(665, 78);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(97, 25);
            this.lblProducts.TabIndex = 6;
            this.lblProducts.Text = "Products";
            // 
            // dtaParts
            // 
            this.dtaParts.AllowUserToAddRows = false;
            this.dtaParts.AllowUserToDeleteRows = false;
            this.dtaParts.AllowUserToResizeColumns = false;
            this.dtaParts.AllowUserToResizeRows = false;
            this.dtaParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaParts.Location = new System.Drawing.Point(17, 110);
            this.dtaParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtaParts.Name = "dtaParts";
            this.dtaParts.ReadOnly = true;
            this.dtaParts.RowHeadersVisible = false;
            this.dtaParts.RowHeadersWidth = 51;
            this.dtaParts.RowTemplate.Height = 24;
            this.dtaParts.Size = new System.Drawing.Size(627, 289);
            this.dtaParts.TabIndex = 3;
            this.dtaParts.SelectionChanged += new System.EventHandler(this.dtaParts_SelectionChanged);
            // 
            // dtaProducts
            // 
            this.dtaProducts.AllowUserToAddRows = false;
            this.dtaProducts.AllowUserToDeleteRows = false;
            this.dtaProducts.AllowUserToResizeColumns = false;
            this.dtaProducts.AllowUserToResizeRows = false;
            this.dtaProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaProducts.Location = new System.Drawing.Point(671, 110);
            this.dtaProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtaProducts.Name = "dtaProducts";
            this.dtaProducts.ReadOnly = true;
            this.dtaProducts.RowHeadersVisible = false;
            this.dtaProducts.RowHeadersWidth = 51;
            this.dtaProducts.RowTemplate.Height = 24;
            this.dtaProducts.Size = new System.Drawing.Size(627, 289);
            this.dtaProducts.TabIndex = 9;
            this.dtaProducts.SelectionChanged += new System.EventHandler(this.dtaProducts_SelectionChanged);
            // 
            // btnPartsAdd
            // 
            this.btnPartsAdd.Location = new System.Drawing.Point(407, 404);
            this.btnPartsAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartsAdd.Name = "btnPartsAdd";
            this.btnPartsAdd.Size = new System.Drawing.Size(75, 30);
            this.btnPartsAdd.TabIndex = 4;
            this.btnPartsAdd.Text = "Add";
            this.btnPartsAdd.UseVisualStyleBackColor = true;
            this.btnPartsAdd.Click += new System.EventHandler(this.btnPartsAdd_Click);
            // 
            // btnPartsModify
            // 
            this.btnPartsModify.Location = new System.Drawing.Point(488, 404);
            this.btnPartsModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartsModify.Name = "btnPartsModify";
            this.btnPartsModify.Size = new System.Drawing.Size(75, 30);
            this.btnPartsModify.TabIndex = 5;
            this.btnPartsModify.Text = "Modify";
            this.btnPartsModify.UseVisualStyleBackColor = true;
            this.btnPartsModify.Click += new System.EventHandler(this.btnPartsModify_Click);
            // 
            // btnPartsDelete
            // 
            this.btnPartsDelete.Location = new System.Drawing.Point(569, 404);
            this.btnPartsDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartsDelete.Name = "btnPartsDelete";
            this.btnPartsDelete.Size = new System.Drawing.Size(75, 30);
            this.btnPartsDelete.TabIndex = 6;
            this.btnPartsDelete.Text = "Delete";
            this.btnPartsDelete.UseVisualStyleBackColor = true;
            this.btnPartsDelete.Click += new System.EventHandler(this.btnPartsDelete_Click);
            // 
            // btnProductsAdd
            // 
            this.btnProductsAdd.Location = new System.Drawing.Point(1063, 404);
            this.btnProductsAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductsAdd.Name = "btnProductsAdd";
            this.btnProductsAdd.Size = new System.Drawing.Size(75, 30);
            this.btnProductsAdd.TabIndex = 10;
            this.btnProductsAdd.Text = "Add";
            this.btnProductsAdd.UseVisualStyleBackColor = true;
            this.btnProductsAdd.Click += new System.EventHandler(this.btnProductsAdd_Click);
            // 
            // btnProductsModify
            // 
            this.btnProductsModify.Location = new System.Drawing.Point(1143, 404);
            this.btnProductsModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductsModify.Name = "btnProductsModify";
            this.btnProductsModify.Size = new System.Drawing.Size(75, 30);
            this.btnProductsModify.TabIndex = 11;
            this.btnProductsModify.Text = "Modify";
            this.btnProductsModify.UseVisualStyleBackColor = true;
            this.btnProductsModify.Click += new System.EventHandler(this.btnProductsModify_Click);
            // 
            // btnProductsDelete
            // 
            this.btnProductsDelete.Location = new System.Drawing.Point(1223, 404);
            this.btnProductsDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductsDelete.Name = "btnProductsDelete";
            this.btnProductsDelete.Size = new System.Drawing.Size(75, 30);
            this.btnProductsDelete.TabIndex = 12;
            this.btnProductsDelete.Text = "Delete";
            this.btnProductsDelete.UseVisualStyleBackColor = true;
            this.btnProductsDelete.Click += new System.EventHandler(this.btnProductsDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1223, 524);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductsDelete);
            this.Controls.Add(this.btnProductsModify);
            this.Controls.Add(this.btnProductsAdd);
            this.Controls.Add(this.btnPartsDelete);
            this.Controls.Add(this.btnPartsModify);
            this.Controls.Add(this.btnPartsAdd);
            this.Controls.Add(this.dtaProducts);
            this.Controls.Add(this.dtaParts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.txtSearchProducts);
            this.Controls.Add(this.txtSearchParts);
            this.Controls.Add(this.btnSearchProducts);
            this.Controls.Add(this.btnSearchParts);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Main Screen";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dtaParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.TextBox txtSearchParts;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnPartsAdd;
        private System.Windows.Forms.Button btnPartsModify;
        private System.Windows.Forms.Button btnPartsDelete;
        private System.Windows.Forms.Button btnProductsAdd;
        private System.Windows.Forms.Button btnProductsModify;
        private System.Windows.Forms.Button btnProductsDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dtaParts;
        private System.Windows.Forms.DataGridView dtaProducts;
    }
}

