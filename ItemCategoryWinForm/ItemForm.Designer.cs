namespace ItemCategoryWinForm
{
    partial class ItemForm
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
            this.lblItem = new System.Windows.Forms.Label();
            this.txtBoxItemNum = new System.Windows.Forms.TextBox();
            this.txtBoxItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCatDesc = new System.Windows.Forms.TextBox();
            this.listViewItemForm = new System.Windows.Forms.ListView();
            this.colItemNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCatCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnBackToMenuItemForm = new System.Windows.Forms.Button();
            this.comboBoxCatCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(298, 28);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(198, 41);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item Form";
            // 
            // txtBoxItemNum
            // 
            this.txtBoxItemNum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemNum.Location = new System.Drawing.Point(305, 98);
            this.txtBoxItemNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxItemNum.Name = "txtBoxItemNum";
            this.txtBoxItemNum.Size = new System.Drawing.Size(288, 32);
            this.txtBoxItemNum.TabIndex = 1;
            // 
            // txtBoxItemName
            // 
            this.txtBoxItemName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemName.Location = new System.Drawing.Point(305, 162);
            this.txtBoxItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxItemName.Name = "txtBoxItemName";
            this.txtBoxItemName.Size = new System.Drawing.Size(288, 32);
            this.txtBoxItemName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category Description";
            // 
            // txtBoxCatDesc
            // 
            this.txtBoxCatDesc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCatDesc.Location = new System.Drawing.Point(305, 293);
            this.txtBoxCatDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCatDesc.Name = "txtBoxCatDesc";
            this.txtBoxCatDesc.ReadOnly = true;
            this.txtBoxCatDesc.Size = new System.Drawing.Size(288, 32);
            this.txtBoxCatDesc.TabIndex = 1;
            // 
            // listViewItemForm
            // 
            this.listViewItemForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemNum,
            this.colItemName,
            this.colCatCode});
            this.listViewItemForm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewItemForm.HideSelection = false;
            this.listViewItemForm.Location = new System.Drawing.Point(51, 358);
            this.listViewItemForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewItemForm.Name = "listViewItemForm";
            this.listViewItemForm.Size = new System.Drawing.Size(542, 223);
            this.listViewItemForm.TabIndex = 2;
            this.listViewItemForm.UseCompatibleStateImageBehavior = false;
            this.listViewItemForm.View = System.Windows.Forms.View.Details;
            this.listViewItemForm.SelectedIndexChanged += new System.EventHandler(this.listViewItemForm_SelectedIndexChanged);
            // 
            // colItemNum
            // 
            this.colItemNum.Text = "Item Number";
            this.colItemNum.Width = 150;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Item Name";
            this.colItemName.Width = 180;
            // 
            // colCatCode
            // 
            this.colCatCode.Text = "Cat Code";
            this.colCatCode.Width = 180;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItem.Location = new System.Drawing.Point(621, 162);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(131, 163);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackColor = System.Drawing.Color.Orange;
            this.btnEditItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditItem.Location = new System.Drawing.Point(621, 358);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(131, 45);
            this.btnEditItem.TabIndex = 3;
            this.btnEditItem.Text = "Edit";
            this.btnEditItem.UseVisualStyleBackColor = false;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteItem.Location = new System.Drawing.Point(621, 449);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(131, 45);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnClearItem
            // 
            this.btnClearItem.BackColor = System.Drawing.Color.Red;
            this.btnClearItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearItem.Location = new System.Drawing.Point(621, 98);
            this.btnClearItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(131, 45);
            this.btnClearItem.TabIndex = 3;
            this.btnClearItem.Text = "Clear Form";
            this.btnClearItem.UseVisualStyleBackColor = false;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // btnBackToMenuItemForm
            // 
            this.btnBackToMenuItemForm.BackColor = System.Drawing.Color.DimGray;
            this.btnBackToMenuItemForm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenuItemForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToMenuItemForm.Location = new System.Drawing.Point(621, 534);
            this.btnBackToMenuItemForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackToMenuItemForm.Name = "btnBackToMenuItemForm";
            this.btnBackToMenuItemForm.Size = new System.Drawing.Size(131, 47);
            this.btnBackToMenuItemForm.TabIndex = 3;
            this.btnBackToMenuItemForm.Text = "Back to Menu";
            this.btnBackToMenuItemForm.UseVisualStyleBackColor = false;
            this.btnBackToMenuItemForm.Click += new System.EventHandler(this.btnBackToMenuItemForm_Click);
            // 
            // comboBoxCatCode
            // 
            this.comboBoxCatCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCatCode.FormattingEnabled = true;
            this.comboBoxCatCode.Location = new System.Drawing.Point(305, 233);
            this.comboBoxCatCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCatCode.Name = "comboBoxCatCode";
            this.comboBoxCatCode.Size = new System.Drawing.Size(288, 32);
            this.comboBoxCatCode.TabIndex = 4;
            this.comboBoxCatCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxCatCode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Item Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Category Code";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 626);
            this.Controls.Add(this.comboBoxCatCode);
            this.Controls.Add(this.btnBackToMenuItemForm);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnClearItem);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.listViewItemForm);
            this.Controls.Add(this.txtBoxCatDesc);
            this.Controls.Add(this.txtBoxItemName);
            this.Controls.Add(this.txtBoxItemNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblItem);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemForm";
            this.Text = "Item Form";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtBoxItemNum;
        private System.Windows.Forms.TextBox txtBoxItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCatDesc;
        private System.Windows.Forms.ListView listViewItemForm;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnBackToMenuItemForm;
        private System.Windows.Forms.ColumnHeader colItemNum;
        private System.Windows.Forms.ColumnHeader colItemName;
        private System.Windows.Forms.ColumnHeader colCatCode;
        private System.Windows.Forms.ComboBox comboBoxCatCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}