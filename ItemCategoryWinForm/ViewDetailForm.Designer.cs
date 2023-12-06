namespace ItemCategoryWinForm
{
    partial class ViewDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSearchCatCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listViewCatList = new System.Windows.Forms.ListView();
            this.listViewItem = new System.Windows.Forms.ListView();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.colCatCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter category code: ";
            // 
            // txtBoxSearchCatCode
            // 
            this.txtBoxSearchCatCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchCatCode.Location = new System.Drawing.Point(245, 33);
            this.txtBoxSearchCatCode.Name = "txtBoxSearchCatCode";
            this.txtBoxSearchCatCode.Size = new System.Drawing.Size(341, 32);
            this.txtBoxSearchCatCode.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(592, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listViewCatList
            // 
            this.listViewCatList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCatCode,
            this.colCategoryName});
            this.listViewCatList.HideSelection = false;
            this.listViewCatList.Location = new System.Drawing.Point(42, 101);
            this.listViewCatList.Name = "listViewCatList";
            this.listViewCatList.Size = new System.Drawing.Size(311, 195);
            this.listViewCatList.TabIndex = 3;
            this.listViewCatList.UseCompatibleStateImageBehavior = false;
            this.listViewCatList.View = System.Windows.Forms.View.Details;
            this.listViewCatList.SelectedIndexChanged += new System.EventHandler(this.listViewCatList_SelectedIndexChanged);
            // 
            // listViewItem
            // 
            this.listViewItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemNum,
            this.colItemName});
            this.listViewItem.HideSelection = false;
            this.listViewItem.Location = new System.Drawing.Point(372, 101);
            this.listViewItem.Name = "listViewItem";
            this.listViewItem.Size = new System.Drawing.Size(316, 195);
            this.listViewItem.TabIndex = 3;
            this.listViewItem.UseCompatibleStateImageBehavior = false;
            this.listViewItem.View = System.Windows.Forms.View.Details;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(42, 323);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(646, 30);
            this.btnBackToMenu.TabIndex = 2;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // colCatCode
            // 
            this.colCatCode.Text = "Category Code";
            this.colCatCode.Width = 120;
            // 
            // colCategoryName
            // 
            this.colCategoryName.Text = "Category Name";
            this.colCategoryName.Width = 180;
            // 
            // colItemNum
            // 
            this.colItemNum.Text = "Item Number";
            this.colItemNum.Width = 120;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Item Name";
            this.colItemName.Width = 180;
            // 
            // ViewDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 394);
            this.Controls.Add(this.listViewItem);
            this.Controls.Add(this.listViewCatList);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearchCatCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewDetailForm";
            this.Text = "ViewDetailForm";
            this.Load += new System.EventHandler(this.ViewDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSearchCatCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listViewCatList;
        private System.Windows.Forms.ListView listViewItem;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.ColumnHeader colCatCode;
        private System.Windows.Forms.ColumnHeader colCategoryName;
        private System.Windows.Forms.ColumnHeader colItemNum;
        private System.Windows.Forms.ColumnHeader colItemName;
    }
}