using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPAssist.Model
{
    public class EncodingModel:ObservableObject
    {
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
        public EncodingModel()
        {
            EncodingTable = new DataTable();
        }

    }
}
