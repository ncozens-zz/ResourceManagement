using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResourceManagementData.Models
{
    class CheckoutHistory
    {
        public int Id { get; set; }

        [Required]
        public Asset AssetName { get; set; }

        [Required]
        public DateTime CheckedOUt { get; set; }
        public DateTime? CheckedIn { get; set; }

    }
}
