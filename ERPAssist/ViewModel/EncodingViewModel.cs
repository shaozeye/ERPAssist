using ERPAssist.Model;
using ERPAssist.Service;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPAssist.ViewModel
{
    public class EncodingViewModel:ViewModelBase
    {
        public RelayCommand GetTotalTableCMD { get; set; }
        public RelayCommand OpenExcelFileCMD { get; set; }
        public RelayCommand StartEncodingCMD { get; set; }
        public RelayCommand SaveResultCMD { get; set; }
        public EncodingModel  encodingModel { get; set; }

        public EncodingViewModel()
        {
            encodingModel = new EncodingModel();
            //encodingModel.EncodingTable = new DataTable();
            GetTotalTableCMD = new RelayCommand(GetTotalTable) ;
            OpenExcelFileCMD= new RelayCommand(OpenExcelFile);
            StartEncodingCMD = new RelayCommand(StartEncoding);
            SaveResultCMD = new RelayCommand(SaveResult);
        }

        private void SaveResult()
        {
            throw new NotImplementedException();
        }

        private void StartEncoding()
        {
            throw new NotImplementedException();
        }

        private void OpenExcelFile()
        {
            throw new NotImplementedException();
        }

        private void GetTotalTable()
        {
            string path = @"\\192.168.0.17\记录表格\物料编码及规则\\仓库物料总表标准版.xls";

            encodingModel.EncodingTable = NPOIServices.ExcelToDatatable(path);
        }
    }
}
