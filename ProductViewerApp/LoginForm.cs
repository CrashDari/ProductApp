namespace ProductViewerApp;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }
    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;

        // Простая проверка логина и пароля
        if (username == "admin" && password == "password")
        {
            // Открываем форму с товарами
            ProductListForm productListForm = new ProductListForm();
            productListForm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль");
        }
    }
}