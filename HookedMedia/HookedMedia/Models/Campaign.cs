namespace HookedMedia.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Campaign")]
    public partial class Campaign
    {
        public Campaign()
        {
            Creatives = new HashSet<Creative>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(50)]
        public string campaign_code { get; set; }

        [StringLength(50)]
        public string advertiser_id { get; set; }

        public string title { get; set; }

        public string ad_domain { get; set; }

        [StringLength(50)]
        public string campaign_type { get; set; }

        [StringLength(50)]
        public string goal { get; set; }

        [StringLength(50)]
        public string timezone { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        public string macros { get; set; }

        public long? impression_user_per_day { get; set; }

        public string schedule { get; set; }

        public string country { get; set; }

        public string age_range { get; set; }

        public string gender { get; set; }

        public string household { get; set; }

        public string income { get; set; }

        public string education { get; set; }

        public string marital_status { get; set; }

        public string own_pets { get; set; }

        public string manufacturers { get; set; }

        public string carriers { get; set; }

        public string os { get; set; }

        public string osv { get; set; }

        public string connection_type { get; set; }

        public string traffic_type { get; set; }

        public string exchanges { get; set; }

        public string interests { get; set; }

        public string categories { get; set; }

        public string finance_and_insurance { get; set; }

        public string shopping { get; set; }

        public string travel { get; set; }

        public string groceries { get; set; }

        public string dining { get; set; }

        public string health_and_beauty { get; set; }

        public string wl_device { get; set; }

        public string wl_ip { get; set; }

        public string wl_bundle { get; set; }

        public string wl_app { get; set; }

        public string bl_device { get; set; }

        public string bl_ip { get; set; }

        public string bl_bundle { get; set; }

        public string bl_app { get; set; }

        public long? max_bid_cpm { get; set; }

        public long? daily_budget { get; set; }

        public long? total_budget { get; set; }

        public long? daily_impression { get; set; }

        public long? total_impression { get; set; }

        public long? daily_clicks { get; set; }

        public long? total_clicks { get; set; }

        public long? daily_conversions { get; set; }

        public long? total_conversions { get; set; }

        public long? bid_optimization { get; set; }

        public long? bid_pacing { get; set; }

        [StringLength(50)]
        public string campaign_status { get; set; }

        public virtual ICollection<Creative> Creatives { get; set; }
    }
}
