using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8Sln.DataSQL
{
    public class Tools
    {
        [PrimaryKey, AutoIncrement] public int ToolsId { get; set; }
        public string ToolImage { get; set; }
        public string ToolName { get; set; }
        public string ToolDescription { get; set; }
        public double ToolPrice { get; set; }
        public int ToolQuantity { get; set; }
    }
}
