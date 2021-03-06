﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace ERPAssist.Service
{
    public static class NPOIServices
    {
        public static DataTable ExcelToDatatable(string path)
        {
            DataTable table = new DataTable();
            IWorkbook workbook = null;
            ISheet sheet = null;
            IRow cells = null;
            FileStream fs;
            if (!File.Exists(path))
            {
                return null;
            }
           
            fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (Path.GetExtension(path).ToLower()==".xlsx")
            {
                workbook = new XSSFWorkbook(fs);
            }
            else if (Path.GetExtension(path).ToLower() == ".xls")
            {
                workbook = new HSSFWorkbook(fs);
            }
            sheet = workbook.GetSheetAt(0);
          
            return table;
        }
    }
}
