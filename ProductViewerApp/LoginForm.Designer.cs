using System.ComponentModel;

namespace ProductViewerApp;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox usernameTextBox;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.Button loginButton;

    private void InitializeComponent()
    {
        this.usernameTextBox = new System.Windows.Forms.TextBox();
        this.passwordTextBox = new System.Windows.Forms.TextBox();
        this.loginButton = new System.Windows.Forms.Button();

        // usernameTextBox
        this.usernameTextBox.PlaceholderText = "Username";
        this.usernameTextBox.Location = new System.Drawing.Point(50, 30);
            
        // passwordTextBox
        this.passwordTextBox.PlaceholderText = "Password";
        this.passwordTextBox.Location = new System.Drawing.Point(50, 70);
        this.passwordTextBox.UseSystemPasswordChar = true;
            
        // loginButton
        this.loginButton.Text = "Login";
        this.loginButton.Location = new System.Drawing.Point(50, 110);
        this.loginButton.Click += new System.EventHandler(this.loginButton_Click);

        // LoginForm
        this.ClientSize = new System.Drawing.Size(250, 180);
        this.Controls.Add(this.usernameTextBox);
        this.Controls.Add(this.passwordTextBox);
        this.Controls.Add(this.loginButton);
        this.Text = "Login";
    }
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
}


