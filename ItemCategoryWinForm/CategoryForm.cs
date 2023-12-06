using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ItemCategoryWinForm
{
    public partial class CategoryForm : Form
    {
        // for category list
        static IDictionary<string, string> categoryList = new Dictionary<string, string>();

        // for Editing Data
        string oldCatCode = "";

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnBackToMenuCatForm_Click(object sender, EventArgs e)
        {
            // Hide Current Form
            this.Hide();

            // Get Menu Form and show
            Menu mainMenu = new Menu();
            mainMenu.ShowDialog();

            // close current forms
            this.Close();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            //  listViewCat.Items.Clear();

            //fill up the data structures
            transferCategoryDataInToCategoryForm();

            //    foreach (var category in categoryList)
            //   {
            //System.Console.WriteLine($"Category: {category.Key} {category.Value}");
            //     listViewCat.Items.Add(new ListViewItem(new string[] { category.Key, category.Value }));
            //   }

            // Enable and Disable Add and Edit button functions
            enableAndDisableAddAndEditBtn(oldCatCode);
        }

        private void btnClearFormCat_Click(object sender, EventArgs e)
        {
            txtBoxCatCode.Text = "";
            txtBoxCatName.Text = "";
            oldCatCode = "";

            // Enable and Disable Add and Edit button functions
            enableAndDisableAddAndEditBtn(oldCatCode);
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            // validate if text box is empty
            if (txtBoxCatCode.Text.Equals("") || txtBoxCatName.Text.Equals(""))
            {
                MessageBox.Show("You must enter data!");
                return;
            }

            // Validate if category code is already existing
            bool isCatCodeExist = categoryList.ContainsKey(txtBoxCatCode.Text);

            if (isCatCodeExist)
            {
                MessageBox.Show("Record already existing!");
                //  txtBoxItemNum.Text = "";
                //  txtBoxItemName.Text = "";
                btnClearFormCat.PerformClick();
                return;
            }

            // add the object to the dictionary
            categoryList.Add(txtBoxCatCode.Text, txtBoxCatName.Text);
            btnClearFormCat.PerformClick();

            // write the new data

            writeCategoryData();
            MessageBox.Show("One record updated!");
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            // Remove old data
            categoryList.Remove(oldCatCode);

            // Add new data
            btnAddCat.PerformClick();

            // Call clear button to Performs
            btnClearFormCat.PerformClick();
        }

        private void listViewCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when a record in the listview is clicked, update the textboxes
            var x = listViewCat.SelectedIndices;

            for (int i = 0; i < x.Count; i++)
            {
                string s;
                txtBoxCatCode.Text = listViewCat.Items[x[i]].SubItems[0].Text;
                oldCatCode = listViewCat.Items[x[i]].SubItems[0].Text;
                txtBoxCatName.Text = listViewCat.Items[x[i]].SubItems[1].Text;
            }

            // Enable and Disable Add and Edit button functions
            enableAndDisableAddAndEditBtn(oldCatCode);
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            // confirm action
            var confirmResult = MessageBox.Show("Do you really want to delete this item?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // remove data
                categoryList.Remove(txtBoxCatCode.Text);

                // update file
                writeCategoryData();

                // Call clear button to Performs
                btnClearFormCat.PerformClick();
            }
            else
            {
                // If no, do nothing
            }
        }

        public void enableAndDisableAddAndEditBtn(string editingData)
        {
            if (editingData == "")
            {
                // Disable and Invisable btn Edit for no data to editing
                btnEditCat.Enabled = false;
                btnEditCat.Visible = false;

                // Enable and Visable btn Add for no data to editing
                btnAddCat.Enabled = true;
                btnAddCat.Visible = true;
            }
            else
            {
                // Enable and Visable btn Edit for selected data to editing
                btnEditCat.Enabled = true;
                btnEditCat.Visible = true;

                // Disable and Invisable btn Add for seleted data to editing
                btnAddCat.Enabled = false;
                btnAddCat.Visible = false;
            }
        }

        public void transferCategoryDataInToCategoryForm()
        {
            string[] cats;
            string data;

            var path = @"CategoryList.txt";

            categoryList.Clear();
            listViewCat.Items.Clear();

            if (File.Exists("CategoryList.txt"))
            {
                //transfer the file from the textfile to the program
                // System.Console.WriteLine("Read File");

                var sr = new StreamReader(path);

                while (sr.Peek() >= 0)
                {
                    data = sr.ReadLine();
                    cats = data.Split(' ');

                    categoryList.Add(cats[0], cats[1]);
                    listViewCat.Items.Add(new ListViewItem(new string[] { cats[0], cats[1] }));

                    // System.Console.WriteLine("Data " + data);
                }
                //  System.Console.WriteLine("After Data" + categoryList);
                // foreach (var category in categoryList)
                //   {
                //System.Console.WriteLine($"Category: {category.Key} {category.Value}");
                // }

                sr.Close();
            }
        }

        public void writeCategoryData()
        {
            string data;

            var path = @"CategoryList.txt";
            FileStream fs = new FileStream(path, FileMode.Create);

            StreamWriter sw = new StreamWriter(fs);

            foreach (KeyValuePair<string, string> entry in categoryList)
            {
                data = entry.Key + " " + entry.Value + "\n";

                sw.Write(data);
            }

            sw.Flush();
            sw.Close();

            // update the list view
            transferCategoryDataInToCategoryForm();
        }


    }
}
