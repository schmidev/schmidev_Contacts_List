public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ContactsViewModel();
    }

    private async void OnContactSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Contact selectedContact)
        {
            await Navigation.PushAsync(new ContactDetailsPage(selectedContact));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}