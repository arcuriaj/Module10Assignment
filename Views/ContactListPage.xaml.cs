using Module10Assignment.Models.ViewModels;
using Module10Assignment.Models;

namespace Module10Assignment.Views;

public partial class ContactListPage : ContentPage
{
	public ContactListPage()
	{
		InitializeComponent();
	}

    private void Lv_ItemTapped(object sender, ItemTappedEventArgs e) {
        var contact = e.Item as Models.Contact;
        var contactViewModel = new ContactDetailViewModel { Contact = contact };
        var contactDetail = new StudentDetailsPage();
        contactDetail.BindingContext = contactViewModel;
        Navigation.PushAsync(contactDetail);
    }
}