using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPAssist.Model
{
    public class MainModel:ObservableObject
    {
        private string pageSource;

        public string PageSource
        {
            get { return pageSource; }
            set
            {
                pageSource = value;
                RaisePropertyChanged(nameof(PageSource));
            }
        }

    }
}
