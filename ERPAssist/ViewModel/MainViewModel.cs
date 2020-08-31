using ERPAssist.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;

namespace ERPAssist.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 

        public MainModel mainModel { get; set; }
        public RelayCommand<string> ChangePageCMD { get; set; }
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ///
            mainModel = new MainModel();
            mainModel.PageSource = "/ERPAssist;component/View/EncodingPage.xaml";
            ChangePageCMD = new RelayCommand<string>(ChangePage);
        }

        private void ChangePage(string obj)
        {
            mainModel.PageSource = "/ERPAssist;component/View/" + obj + ".xaml";
        }
    }
}