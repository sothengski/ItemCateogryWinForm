using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ItemCategoryWinForm
{
    public partial class ViewDetailForm : Form
    {

        //for category list
        // static IDictionary<string, string> categoryList = new Dictionary<string, string>();

        //store items data
        static Dictionary<string, dynamic> itemList = new Dictionary<string, dynamic>();

        public ViewDetailForm()
        {
            InitializeComponent();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.ShowDialog();

            this.Close();
        }

        private void ViewDetailForm_Load(object sender, EventArgs e)
        {
            transferCategoryDataToListViewCategory();
            transferDataForItem();
        }

        private void generatetable()
        {
            listViewItem.Items.Clear();
        }
        private void listViewCatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewItem.Items.Clear();
            var x = listViewCatList.SelectedIndices;

            for (int i = 0; i < x.Count; ++i)
            {
                txtBoxSearchCatCode.Text = listViewCatList.Items[x[i]].SubItems[0].Text;
            }

            foreach (KeyValuePair<string, dynamic> entry in itemList)
            {
                string s = itemList[entry.Key].catCode;

                int xx = int.Parse(s);

                if (xx.ToString().Equals(txtBoxSearchCatCode.Text))
                {
                    listViewItem.Items.Add(new ListViewItem(new String[] { entry.Key, itemList[entry.Key].itemName, itemList[entry.Key].itemName }));
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewItem.Items.Clear();
            var x = listViewCatList.SelectedIndices;

            foreach (KeyValuePair<string, dynamic> entry in itemList)
            {
                string s = itemList[entry.Key].catCode;

                int xx = int.Parse(s);

                if (xx.ToString().Equals(txtBoxSearchCatCode.Text))
                {
                    listViewItem.Items.Add(new ListViewItem(new String[] { entry.Key, itemList[entry.Key].itemName, itemList[entry.Key].itemName }));
                }
            }
        }

        public void transferCategoryDataToListViewCategory()
        {
            string[] cats;
            string data;

            var path = @"CategoryList.txt";

            //  categoryList.Clear();

            if (File.Exists("CategoryList.txt"))
            {
                //transfer the file from the textfile to the program
                // System.Console.WriteLine("Read File");

                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    //Split the line by space
                    string[] parts = line.Split(' ');


                    // Ensure that there are two parts (Cod and Name)
                    if (parts.Length == 2)
                    {
                        // System.Console.WriteLine($"parts: {parts[0]} {parts[1]}");

                        //  categoryList.Add(parts[0], parts[1]);
                        listViewCatList.Items.Add(new ListViewItem(new string[] { parts[0], parts[1] }));

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
                    }
                    else
                    {
                        System.Console.WriteLine($"Invalid Format on the line: {line}");
                    }
                }

                /*  var sr = new StreamReader(path);


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
                  */
            }
        }

        public void transferDataForItem()
        {
            string[] items;
            string data;

            var path = @"ItemList.txt";

            itemList.Clear();

            //  listViewItemForm.Items.Clear();

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
                    //  listViewItemForm.Items.Add(new ListViewItem(new string[] { items[0], items[1], items[2] }));
                }
                sr.Close();
            }
        }
    }
}
