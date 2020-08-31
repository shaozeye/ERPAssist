using ERPAssist.Model;
using ERPAssist.Service;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        public string ExcelPath { get; set; }

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
        //    if (encodingModel.EncodingTable.Columns.Count<1)
        //    {
        //        encodingModel.Status = "没有加载总表";
        //        return;
        //    }
            OpenFileDialog openFileDialog = new OpenFileDialog();
           
            if (openFileDialog.ShowDialog()==true)
            {
                ExcelPath = openFileDialog.FileName;
                var e = Path.GetExtension(ExcelPath);
                if (Path.GetExtension(ExcelPath)==".xls"|| Path.GetExtension(ExcelPath) == ".xlsx")
                {
                    encodingModel.Status = Path.GetFileName(ExcelPath);
                    encodingModel.CurrentTable = NPOIServices.ExcelToDatatable(ExcelPath);

                    encodingModel.EncodingTable = encodingModel.CurrentTable;
                    encodingModel.CurrentCount = encodingModel.CurrentTable.Rows.Count;
                }
                else
                {
                    encodingModel.Status = "不是有效的Excle文件";
                }
               
            }
           
        }
       

        private void GetTotalTable()
        {

            //  string path = @"\\192.168.0.17\记录表格\物料编码及规则\\仓库物料总表标准版.xls";
            string path = @"D:\仓库物料总表标准版.xls";
            encodingModel.EncodingTable = encodingModel.TotalTable = NPOIServices.ExcelToDatatable(path);
            encodingModel.Status = "总表加载完成";
            encodingModel.TotalCount = encodingModel.TotalTable.Rows.Count;
        }
    }
}
