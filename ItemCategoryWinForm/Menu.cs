using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemCategoryWinForm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            ItemForm itemForm = new ItemForm();
            itemForm.ShowDialog();

            this.Close();
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewDetailForm viewDetailForm = new ViewDetailForm();
            viewDetailForm.ShowDialog();

            this.Close();
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            this.Hide();

            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();

            this.Close();
        }
    }
}
