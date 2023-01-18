using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using TipsXamarinForms.Sections.TipDetail.ViewModel;
using Xamarin.Forms;

namespace TipsXamarinForms.Sections.TipDetail
{	
	public partial class TipDetailPage : ContentPage
	{
        Data.Tip tip;

		public TipDetailPage (Data.Tip _tip)
		{
			InitializeComponent ();
            this.tip = _tip;
            BindingContext = new TipDetailViewModel(_tip);
		}

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Views.AddTipPage(tip));
        }
    }
}

