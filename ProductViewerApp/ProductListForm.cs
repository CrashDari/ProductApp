namespace ProductViewerApp;

public partial class ProductListForm : Form
{

    public ProductListForm(List<string> products)
    {
        InitializeComponent();
        LoadProducts(products);
    }

    private void LoadProducts(List<string> products)
    {
        foreach (string product in products)
        {
            listBox1.Items.Add(product);
        }
    }
}