using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using TipsXamarinForms.Base;
using Xamarin.Forms;

namespace TipsXamarinForms.Sections.NewTip.ViewModel
{
	public class AddTipViewModel : BaseViewModel
	{
        #region Attributes
        private string title;
        private string description;
        public Data.Tip tip;
        #endregion

        #region Properties
        public Data.Tip Tip
        {
            get { return this.tip; }
            set { SetValue(ref this.tip, value); }
        }
        public string TitleText
        {
            get { return this.title; }
            set { SetValue(ref this.title, value); }
        }
        public string DescriptionText
        {
            get { return this.description; }
            set { SetValue(ref this.description, value); }
        }
        #endregion

        #region Commands
        public ICommand SaveCommand
        {
            get { return new RelayCommand(Save); }
            set { }
        }
        #endregion

        #region Methods
        private async void Save()
        {
            if (string.IsNullOrEmpty(this.TitleText)) 
            {
                await Application.Current.MainPage.DisplayAlert("", "El campo título es obligatorio", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(this.DescriptionText))
            {
                await Application.Current.MainPage.DisplayAlert("", "El campo descripción es obligatorio", "Ok");
                return;
            }
            try
            {
                var tip = new Data.Tip();
                if (Tip != null)
                {
                    tip = new Data.Tip
                    {
                        Id = Tip.Id,
                        Title = TitleText.ToString(),
                        Description = DescriptionText.ToString(),
                        CreateDate = Tip.CreateDate,
                        UpdateDate = DateTime.UtcNow.Date
                    };
                }
                else
                {
                    tip = new Data.Tip
                    {
                        Title = TitleText.ToString(),
                        Description = DescriptionText.ToString(),
                        CreateDate = DateTime.UtcNow.Date,
                        UpdateDate = DateTime.UtcNow.Date
                    };
                }
                var result = await Tips_XamarinForms.App.Context.SaveTipAsync(tip);
                if (result == 1)
                {
                    if (tip.Id != 0)
                    {
                        await Application.Current.MainPage.Navigation.PopToRootAsync();
                    }
                    else
                    {
                        await Application.Current.MainPage.Navigation.PopAsync();
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Ha ocurrido un error al guardar el tip, intenta nuevamente", "Aceptar");
                }
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Ha ocurrido un error al guardar el tip, intenta nuevamente", "Aceptar");
            }
        }
        #endregion

        #region Constructor
        public AddTipViewModel(Data.Tip _tip)
        {
            if (_tip == null) { return; }
            Tip = _tip;
            TitleText = _tip.Title;
            DescriptionText = _tip.Description;
        }
        #endregion
    }
}

