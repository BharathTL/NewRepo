namespace HookedMedia.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Creative")]
    public partial class Creative
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string campaign_code { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        public string vast_url { get; set; }

        public string xml_content { get; set; }

        public virtual Campaign Campaign { get; set; }
    }
}
