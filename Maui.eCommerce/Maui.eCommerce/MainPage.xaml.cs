namespace Maui.eCommerce;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void InventoryClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//InventoryManagement");
    }

    private void ShopClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//InventoryManagement");
    }
    
    private void CartClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ShoppingCart");
    }
    private void ConfigClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Configuration");
    }
}