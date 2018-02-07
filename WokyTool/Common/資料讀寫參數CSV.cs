using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public class 資料讀寫參數CSV : 資料讀寫參數
    {
        public CsvFileDescription CSV描述;

        public static CsvFileDescription 通用讀取格式 = new CsvFileDescription
        {
            SeparatorChar = ',',
            FirstLineHasColumnNames = true,
            IgnoreUnknownColumns = true,
            TextEncoding = Encoding.Unicode,
            DetectEncodingFromByteOrderMarks = true,
        };

        public static CsvFileDescription 無標頭讀取格式 = new CsvFileDescription
        {
            SeparatorChar = ',',
            FirstLineHasColumnNames = false,
            EnforceCsvColumnAttribute = true,
            IgnoreUnknownColumns = true,
            TextEncoding = Encoding.Unicode,
            DetectEncodingFromByteOrderMarks = true,
        };


        public override bool InitRead()
        {
            if (CSV描述 == null)
                return false;

            return base.InitRead();
        }
    }
}
