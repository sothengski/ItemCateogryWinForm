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
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();

            //fill up the data structures
            transferDataForItem();
            transferDataForCategory();
        }

        //for category list
        static IDictionary<string, string> categoryList = new Dictionary<string, string>();

        //store items data
        static Dictionary<string, dynamic> itemList = new Dictionary<string, dynamic>();

        //to save old item number for editing
        string oldNum = "";

        private void btnBackToMenuItemForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.ShowDialog();

            this.Close();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            //System.Console.WriteLine("Form Load");

            foreach (var category in categoryList)
            {
                //System.Console.WriteLine($"Category: {category.Key} {category.Value}");
                comboBoxCatCode.Items.Add(category.Key);
            }

            //provide default value for the combo box and text description
            comboBoxCatCode.SelectedIndex = 0;
            string s = comboBoxCatCode.Text;

            txtBoxCatDesc.Text = categoryList[s];

            enableAndDisableAddAndEditBtn(oldNum);

            //  System.Console.WriteLine("End Form Load");
        }

        private void comboBoxCatCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBoxCatCode.Text;
            // System.Console.WriteLine($"s: {s}");
            txtBoxCatDesc.Text = categoryList[s];

        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            txtBoxItemNum.Text = "";
            txtBoxItemName.Text = "";
            oldNum = "";

            enableAndDisableAddAndEditBtn(oldNum);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // validate if text box is empty
            if (txtBoxItemNum.Text.Equals("") || txtBoxItemName.Text.Equals(""))
            {
                MessageBox.Show("You must enter data!");
                return;
            }

            // Validate if item number is already existing
            bool isItemCodeExist = itemList.ContainsKey(txtBoxItemNum.Text);

            if (isItemCodeExist)
            {
                MessageBox.Show("Record already existing!");
                //  txtBoxItemNum.Text = "";
                //  txtBoxItemName.Text = "";
                btnClearItem.PerformClick();
                return;
            }

            // create an object

            Item obj = new Item();

            obj.itemNum = txtBoxItemNum.Text;
            obj.itemName = txtBoxItemName.Text;
            obj.catCode = comboBoxCatCode.Text;

            // add the object to the dictionary

            itemList.Add(txtBoxItemNum.Text, obj);
            btnClearItem.PerformClick();

            // write the new data

            writeDataForItem();
            MessageBox.Show("One record updated!");
        }

        private void listViewItemForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when a record in the listview is clicked, update the textboxes
            var x = listViewItemForm.SelectedIndices;

            for (int i = 0; i < x.Count; i++)
            {
                string s;
                txtBoxItemNum.Text = listViewItemForm.Items[x[i]].SubItems[0].Text;
                oldNum = listViewItemForm.Items[x[i]].SubItems[0].Text;
                txtBoxItemName.Text = listViewItemForm.Items[x[i]].SubItems[1].Text;
                comboBoxCatCode.Text = listViewItemForm.Items[x[i]].SubItems[2].Text;

                s = listViewItemForm.Items[x[i]].SubItems[2].Text;

                int xx = int.Parse(s);

                txtBoxCatDesc.Text = categoryList[xx.ToString()];
            }
            enableAndDisableAddAndEditBtn(oldNum);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // Remove old data
            itemList.Remove(oldNum);

            // Add new data
            btnAddItem.PerformClick();

            btnClearItem.PerformClick();
        }


        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            // confirm action
            var confirmResult = MessageBox.Show("Do you really want to delete this item?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // remove data
                itemList.Remove(txtBoxItemNum.Text);

                // update file
                writeDataForItem();

                btnClearItem.PerformClick();
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
                btnEditItem.Enabled = false;
                btnEditItem.Visible = false;

                // Enable and Visable btn Add for no data to editing
                btnAddItem.Enabled = true;
                btnAddItem.Visible = true;
            }
            else
            {
                // Enable and Visable btn Edit for selected data to editing
                btnEditItem.Enabled = true;
                btnEditItem.Visible = true;

                // Disable and Invisable btn Add for seleted data to editing
                btnAddItem.Enabled = false;
                btnAddItem.Visible = false;
            }
        }


        public void transferDataForCategory()
        {
            string[] cats;
            string data;

            var path = @"CategoryList.txt";

            categoryList.Clear();

            if (File.Exists("CategoryList.txt"))
            {
                //transfer the file from the textfile to the program
                // System.Console.WriteLine("Read File");

                //  string[] lines = File.ReadAllLines(path);

                //   foreach (string line in lines)
                //   {
                //Split the line by space
                //  string[] parts = line.Split(' ');


                // Ensure that there are two parts (Cod and Name)
                // if (parts.Length == 2)
                //  {
                //  System.Console.WriteLine($"parts: {parts[0]} {parts[1]}");

                //  categoryList.Add(parts[0], parts[1]);

                // part ID
                /*  if(int.TryParse(parts[0], out int id))
                  {
                      // Add the ID and Name to the dictionary
                      categoryList[id] = parts[1];
                  }
                  else
                  {
                      System.Console.WriteLine($"Invalid ID Format on the line: {line}");
                  }
                */
                //  }
                //  else
                //   {
                //     System.Console.WriteLine($"Invalid Format on the line: {line}");
                //  }
                //  }

                var sr = new StreamReader(path);

                while (sr.Peek() >= 0)
                {
                    data = sr.ReadLine();
                    cats = data.Split(' ');

                    categoryList.Add(cats[0], cats[1]);

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

        public void transferDataForItem()
        {
            string[] items;
            string data;

            var path = @"ItemList.txt";

            itemList.Clear();

            listViewItemForm.Items.Clear();

            //  System.Console.WriteLine("Item List");

            if (File.Exists("ItemList.txt"))
            {
                //transfer the file from the textfile to the program

                var sr = new StreamReader(path);

                while (sr.Peek() >= 0)
                {
                    data = sr.ReadLine();

                    //tokenize the words
                    items = data.Split(',');

                    //create a new object
                    Item obj1 = new Item();

                    obj1.itemNum = items[0];
                    obj1.itemName = items[1];
                    obj1.catCode = items[2];

                    //add the object
                    itemList.Add(items[0], obj1);
                    //   System.Console.WriteLine("obj1");

                    //update the listview
                    listViewItemForm.Items.Add(new ListViewItem(new string[] { items[0], items[1], items[2] }));
                }
                sr.Close();
            }
        }

        public void writeDataForItem()
        {
            string data;

            var path = @"ItemList.txt";
            FileStream fs = new FileStream(path, FileMode.Create);

            StreamWriter sw = new StreamWriter(fs);

            foreach (KeyValuePair<string, dynamic> entry in itemList)
            {
                data = entry.Key + "," + itemList[entry.Key].itemName + "," + itemList[entry.Key].catCode + "\n";

                sw.Write(data);
            }

            sw.Flush();
            sw.Close();

            // update the list view
            transferDataForItem();
        }
    }
}
