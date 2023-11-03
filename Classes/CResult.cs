using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal class CResult
    {
        public bool IsOk = false;
        public string Msg;

        public CResult(bool isOk, string ErrorMsg) 
        {
            this.IsOk = isOk;
            this.Msg = ErrorMsg;
        }
    }
}
