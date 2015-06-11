namespace HookedMedia.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CampaignMaster")]
    public partial class CampaignMaster
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string keys { get; set; }

        [StringLength(100)]
        public string groups { get; set; }

        [Required]
        [StringLength(4000)]
        public string value { get; set; }
    }
}
