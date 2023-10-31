using HotelApp.Business.Manager;
using HotelApp.Entities.Entity;

namespace HotelApp.WindowsApp
{
    public partial class frmMain : Form
    {
        CategoryManager categoryManager = new CategoryManager();
        Category category = new Category();
        short id;
        public frmMain()
        {
            InitializeComponent();
            ToList();
        }

        void ToList()
        {
            dgvCategory.DataSource = categoryManager.Select();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length != 0)
                category.Name = txtName.Text;
            else
            {
                MessageBox.Show("Category Name Null Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (categoryManager.Insert(category))
            {
                MessageBox.Show("Category addition was successful");
                ToList();
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("An error occurred while adding the category!");
            }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCategory.CurrentRow.Cells["Name"].Value.ToString();
            id = Convert.ToInt16(dgvCategory.CurrentRow.Cells["Id"].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length != 0)
            {
                category.Id = id;
                category.Name = txtName.Text;
            }
            else
            {
                MessageBox.Show("Please select the category you want to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (categoryManager.Update(category))
            {
                MessageBox.Show("Category update successful");
                ToList();
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("An error occurred while updating the category!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length != 0)
            {
                category.Id = id;
                category.Name = txtName.Text;
            }
            else
            {
                MessageBox.Show("Please select the category you want to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (categoryManager.Delete(category))
            {
                MessageBox.Show("Category deletion was successful");
                ToList();
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("An error occurred while deleting the category!");
            }
        }
    }
}