using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Generator_App_Business
{
    public class clsColumnDetails
    {
        public string ColumnName { get; set; }
        public string DateType { get; set; }
        public string ColumnType { get; set; }

        public clsColumnDetails()
        {
            this.ColumnName = string.Empty;
            this.DateType = string.Empty;
            this.ColumnType = string.Empty;
        }

        clsColumnDetails( string ColumnName, string DateType , string ColumnType )
        {
            this.ColumnName = ColumnName;
            this.DateType = DateType;
            this.ColumnType = ColumnType;
        }
    }
}
