using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ERPAssist.Model
{
    public class EncodingModel:ObservableObject
    {
        private DataTable totalTable;

        public DataTable TotalTable
        {
            get { return totalTable; }
            set
            {
                totalTable = value;
                RaisePropertyChanged(nameof(TotalTable));
            }
        }

        private DataTable currentTable;

        public DataTable CurrentTable
        {
            get { return currentTable; }
            set
            {
                currentTable = value;
                RaisePropertyChanged(nameof(CurrentTable));
            }
        }

        private DataTable encodingTable;

        public DataTable EncodingTable
        {
            get { return encodingTable; }
            set
            {
                encodingTable = value;
                RaisePropertyChanged(nameof(EncodingTable));
            }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                RaisePropertyChanged(nameof(Status));
            }
        }
        private int totalCount;

        public int TotalCount
        {
            get { return totalCount; }
            set
            {
                totalCount = value;
                RaisePropertyChanged(nameof(TotalCount));
            }
        }
        private int currentCount;

        public int CurrentCount
        {
            get { return currentCount; }
            set
            {
                currentCount = value;
                RaisePropertyChanged(nameof(CurrentCount));
            }
        }


        public EncodingModel()
        {
            EncodingTable = new DataTable();
            CurrentTable = new DataTable();
            TotalTable = new DataTable();
        }

    }
}
