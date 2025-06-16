using Library.eCommerce.Services;
using Maui.eCommerce.ViewModels;
using Library.eCommerce.Models;

namespace Maui.eCommerce.Views;

[QueryProperty(nameof(ProductId), "productId")]
public partial class ProductDetailsView : ContentPage
{
    public ProductDetailsView()
    {
        InitializeComponent();
		
    }

    public int ProductId { get; set; }

    async private void GoBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//InventoryManagementView");
    }

    async private void SaveClicked(object sender, EventArgs e)
    {
        (BindingContext as ProductViewModel).AddOrUpdate();
        
        await Shell.Current.GoToAsync("//InventoryManagementView");
    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        if(ProductId == 0)
        {
            BindingContext = new ProductViewModel();
        }
        else
        {
            BindingContext = new ProductViewModel(ProductServiceProxy.Current.GetById(ProductId));
        }
        
    }
}