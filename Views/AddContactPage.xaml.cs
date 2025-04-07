using Module10Assignment.Models.ViewModels;

namespace Module10Assignment.Views;

public partial class AddStudentPage : ContentPage
{
	private ContactsListViewModel contactsListViewModel;
	public AddStudentPage()
	{
		InitializeComponent();
        contactsListViewModel = new ContactsListViewModel();
		BindingContext = contactsListViewModel;
	}

    private void Button_Clicked(object sender, EventArgs e) {
		var contactList = new ContactListPage();
		contactList.BindingContext = contactsListViewModel;
		Navigation.PushAsync(contactList);
    }
}