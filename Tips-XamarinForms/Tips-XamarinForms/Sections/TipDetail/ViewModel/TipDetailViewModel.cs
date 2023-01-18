using System;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Input;

namespace TipsXamarinForms.Sections.TipDetail.ViewModel
{
	public class TipDetailViewModel : Base.BaseViewModel
    {
        #region Attributes
        public string date;
        public Data.Tip tip;
        #endregion

        #region Properties
        public Data.Tip Tip
        {
            get { return this.tip; }
            set { SetValue(ref this.tip, value); }
        }
        public string DateText
        {
            get { return this.date; }
            set { SetValue(ref this.date, value); }
        }
        #endregion

        #region Constructor
        public TipDetailViewModel(Data.Tip _tip)
		{
            Tip = _tip;
            DateText = _tip.UpdateDate.Date.ToString();
        }
        #endregion
    }
}

