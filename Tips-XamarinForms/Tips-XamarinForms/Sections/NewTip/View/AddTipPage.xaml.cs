using TipsXamarinForms.Sections.NewTip.ViewModel;
using Xamarin.Forms;

namespace TipsXamarinForms.Views
{	
	public partial class AddTipPage : ContentPage
	{	
		public AddTipPage (Data.Tip _tip)
		{
			InitializeComponent ();
			BindingContext = new AddTipViewModel(_tip);
		}
    }
}

