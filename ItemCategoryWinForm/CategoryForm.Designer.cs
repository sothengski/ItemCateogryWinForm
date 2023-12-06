namespace ItemCategoryWinForm
{
    partial class CategoryForm
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
            this.btnBackToMenuCatForm = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnEditCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.listViewCat = new System.Windows.Forms.ListView();
            this.colCatCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxCatName = new System.Windows.Forms.TextBox();
            this.txtBoxCatCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnClearFormCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackToMenuCatForm
            // 
            this.btnBackToMenuCatForm.BackColor = System.Drawing.Color.DimGray;
            this.btnBackToMenuCatForm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenuCatForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToMenuCatForm.Location = new System.Drawing.Point(619, 387);
            this.btnBackToMenuCatForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackToMenuCatForm.Name = "btnBackToMenuCatForm";
            this.btnBackToMenuCatForm.Size = new System.Drawing.Size(131, 47);
            this.btnBackToMenuCatForm.TabIndex = 10;
            this.btnBackToMenuCatForm.Text = "Back to Menu";
            this.btnBackToMenuCatForm.UseVisualStyleBackColor = false;
            this.btnBackToMenuCatForm.Click += new System.EventHandler(this.btnBackToMenuCatForm_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteCat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCat.Location = new System.Drawing.Point(619, 304);
            this.btnDeleteCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(131, 45);
            this.btnDeleteCat.TabIndex = 11;
            this.btnDeleteCat.Text = "Delete";
            this.btnDeleteCat.UseVisualStyleBackColor = false;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnEditCat
            // 
            this.btnEditCat.BackColor = System.Drawing.Color.Orange;
            this.btnEditCat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditCat.Location = new System.Drawing.Point(619, 229);
            this.btnEditCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditCat.Name = "btnEditCat";
            this.btnEditCat.Size = new System.Drawing.Size(131, 45);
            this.btnEditCat.TabIndex = 13;
            this.btnEditCat.Text = "Edit";
            this.btnEditCat.UseVisualStyleBackColor = false;
            this.btnEditCat.Click += new System.EventHandler(this.btnEditCat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddCat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCat.Location = new System.Drawing.Point(619, 140);
            this.btnAddCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(131, 43);
            this.btnAddCat.TabIndex = 14;
            this.btnAddCat.Text = "Add";
            this.btnAddCat.UseVisualStyleBackColor = false;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // listViewCat
            // 
            this.listViewCat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCatCode,
            this.colItemName});
            this.listViewCat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCat.HideSelection = false;
            this.listViewCat.Location = new System.Drawing.Point(49, 229);
            this.listViewCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewCat.Name = "listViewCat";
            this.listViewCat.Size = new System.Drawing.Size(542, 205);
            this.listViewCat.TabIndex = 9;
            this.listViewCat.UseCompatibleStateImageBehavior = false;
            this.listViewCat.View = System.Windows.Forms.View.Details;
            this.listViewCat.SelectedIndexChanged += new System.EventHandler(this.listViewCat_SelectedIndexChanged);
            // 
            // colCatCode
            // 
            this.colCatCode.Text = "Item Number";
            this.colCatCode.Width = 150;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Item Name";
            this.colItemName.Width = 180;
            // 
            // txtBoxCatName
            // 
            this.txtBoxCatName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCatName.Location = new System.Drawing.Point(303, 151);
            this.txtBoxCatName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCatName.Name = "txtBoxCatName";
            this.txtBoxCatName.Size = new System.Drawing.Size(288, 32);
            this.txtBoxCatName.TabIndex = 7;
            // 
            // txtBoxCatCode
            // 
            this.txtBoxCatCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCatCode.Location = new System.Drawing.Point(303, 87);
            this.txtBoxCatCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCatCode.Name = "txtBoxCatCode";
            this.txtBoxCatCode.Size = new System.Drawing.Size(288, 32);
            this.txtBoxCatCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Category Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Category Code";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(253, 21);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(270, 41);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "Category Form";
            // 
            // btnClearFormCat
            // 
            this.btnClearFormCat.BackColor = System.Drawing.Color.Red;
            this.btnClearFormCat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFormCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearFormCat.Location = new System.Drawing.Point(619, 75);
            this.btnClearFormCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearFormCat.Name = "btnClearFormCat";
            this.btnClearFormCat.Size = new System.Drawing.Size(131, 45);
            this.btnClearFormCat.TabIndex = 15;
            this.btnClearFormCat.Text = "Clear Form";
            this.btnClearFormCat.UseVisualStyleBackColor = false;
            this.btnClearFormCat.Click += new System.EventHandler(this.btnClearFormCat_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 489);
            this.Controls.Add(this.btnClearFormCat);
            this.Controls.Add(this.btnBackToMenuCatForm);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnEditCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.listViewCat);
            this.Controls.Add(this.txtBoxCatName);
            this.Controls.Add(this.txtBoxCatCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblItem);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMenuCatForm;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnEditCat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.ListView listViewCat;
        private System.Windows.Forms.ColumnHeader colItemName;
        private System.Windows.Forms.ColumnHeader colCatCode;
        private System.Windows.Forms.TextBox txtBoxCatName;
        private System.Windows.Forms.TextBox txtBoxCatCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnClearFormCat;
    }
}