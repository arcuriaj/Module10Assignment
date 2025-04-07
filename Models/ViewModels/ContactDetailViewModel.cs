using CommunityToolkit.Mvvm.ComponentModel;

namespace Module10Assignment.Models.ViewModels
{
    partial class ContactDetailViewModel:ObservableObject
    {
        [ObservableProperty]
        private Contact contact;
    }
}
