
using WareHouse.Classes;

namespace WareHouse;

public partial class AddProductForm : Form
{
    public AddProductForm()
    {
        InitializeComponent();
    }

    private void AddProductForm_Load(object sender, EventArgs e)
    {
        comboBoxGroups.Items.AddRange(new Manage().GetGroups());
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {

    }
}
