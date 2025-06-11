﻿using Library.eCommerce.Services;

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
        Shell.Current.GoToAsync("//InventoryManagementView");
    }

    private void ShopClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//InventoryManagementView");
    }
    
    private void CartClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ShoppingCartView");
    }
    private void ConfigClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ConfigurationView");
    }
    
    private void CartSelected(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonText = button.Text;
    
        if (int.TryParse(buttonText.Replace("Cart ", ""), out int cartId))
        {
            try
            {
                for (int i = 0; i <= cartId; i++)
                {
                    if (!CartManagerService.Current.CartItems.ContainsKey(i))
                    {
                        ShoppingCartService newCart = new ShoppingCartService();
                        CartManagerService.Current.CartItems.Add(i, newCart);
                    }
                }
            
                CartManagerService.Current.SwitchActiveCart(cartId);
            
                DisplayAlert("Cart Selected", $"You are now using {buttonText}", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}