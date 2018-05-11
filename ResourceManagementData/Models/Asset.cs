using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResourceManagementData.Models
{
    class Asset
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string AssetName { get; set; }


    }
}
