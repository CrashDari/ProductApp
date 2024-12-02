namespace ProductViewerApp;

public partial class ProductListForm : Form
{
    public ProductListForm()
    {
        InitializeComponent();
        LoadProducts();
    }

    private void LoadProducts()
    {
        // Для примера добавим несколько строк в listBox
        listBox1.Items.Add("Product 1");
        listBox1.Items.Add("Product 2");
        listBox1.Items.Add("Product 3");
    }
}