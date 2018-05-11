using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResourceManagementData.Models
{
    class Checkout
    {
        public int Id { get; set; }

        [Required]
        public Asset AssetName { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
    }
}
