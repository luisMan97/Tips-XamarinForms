using System;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Tips_XamarinForms;
using TipsXamarinForms.Base;
using Xamarin.Forms;

namespace TipsXamarinForms.Sections.ListTips.ViewModel
{
	public class TipsViewModel : BaseViewModel
	{
        #region Attributes
        public object listViewSource;
        #endregion

        #region Properties
        public object ListViewSource
        {
            get { return this.listViewSource; }
            set { SetValue(ref this.listViewSource, value); }
        }
        #endregion

        #region Commands
        public ICommand OnDelete { get; set; }
        #endregion


        #region Constructor
        public TipsViewModel()
        {
            OnDelete = new Command(DeleteTip);
            _ = LoadData();
        }
        #endregion

        #region Methods
        public async Task LoadData()
        {
            this.ListViewSource = await App.Context.GetTipsAsync();
        }

        private async void DeleteTip(object sender)
        {
            if (await Application.Current.MainPage.DisplayAlert("", "¿Estás seguro de eliminar el tip?", "Aceptar", "Cancelar"))
            {
                var tip = sender as Data.Tip;
                var result = await App.Context.DeleteTipAsync(tip);
                if (result == 1) { _ = LoadData(); }
            }
        }
        #endregion

    }
}

