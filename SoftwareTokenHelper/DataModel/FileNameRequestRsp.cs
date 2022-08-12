using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTokenHelper.DataModel
{
    internal class FileNameRequestRsp
    {
        public int file_count { get; set; }

        public List<string>? file_name { get; set; }
    }
}
