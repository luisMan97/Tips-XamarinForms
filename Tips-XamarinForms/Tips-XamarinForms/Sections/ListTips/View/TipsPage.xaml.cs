using TipsXamarinForms.Sections.TipDetail;
using TipsXamarinForms.Sections.ListTips.ViewModel;
using Xamarin.Forms;

namespace TipsXamarinForms.Views
{	
	public partial class TipsPage : ContentPage
	{
        TipsViewModel modelObject;
        public TipsPage ()
		{
			InitializeComponent();
            modelObject = new TipsViewModel();
            BindingContext = modelObject;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            _ = modelObject.LoadData();
        }

        private async void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddTipPage(null));
        }

        void tipsListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new TipDetailPage(e.SelectedItem as Data.Tip));
        }
    }
}

