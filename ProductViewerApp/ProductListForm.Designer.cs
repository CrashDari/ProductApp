using System.ComponentModel;

namespace ProductViewerApp;

partial class ProductListForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ListBox listBox1;


    private void InitializeComponent()
    {
        this.listBox1 = new System.Windows.Forms.ListBox();

        // listBox1
        this.listBox1.Location = new System.Drawing.Point(12, 12);
        this.listBox1.Size = new System.Drawing.Size(260, 150);

        // ProductListForm
        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Controls.Add(this.listBox1);
        this.Text = "Product List";
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

