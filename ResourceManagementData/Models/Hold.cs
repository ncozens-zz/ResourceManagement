using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceManagementData.Models
{
    class Hold
    {
        public int Id { get; set; }
        public virtual Asset AssetName { get; set; }
        public DateTime HoldPlace { get; set; }
    }
}
