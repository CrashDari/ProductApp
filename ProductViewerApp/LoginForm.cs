namespace ProductViewerApp;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }
    
    // Хранение данных пользователей и соответствующих товаров
    private Dictionary<string, (string password, List<string> products)> userData = new Dictionary<string, (string, List<string>)>
    {
        { "admin", ("password", new List<string> { "Яблоки", "Бананы", "Хлеб", "Молоко", "Куриные яйца" }) },
        { "user1", ("pass1", new List<string> { "Картофель", "Морковь", "Рис", "Макароны", "Апельсины" }) },
        { "user2", ("pass2", new List<string> { "Сыр", "Йогурт", "Шоколад", "Кофе", "Чай", "Помидоры" }) }
    };
    
    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;

        if (userData.ContainsKey(username) && userData[username].password == password)
        {
            // Получаем список продуктов для пользователя
            List<string> userProducts = userData[username].products;

            // Открываем форму с соответствующими продуктами
            ProductListForm productListForm = new ProductListForm(userProducts);
            productListForm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль");
        }
    }
}

