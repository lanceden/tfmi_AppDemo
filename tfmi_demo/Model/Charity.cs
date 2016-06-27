namespace tfmi_demo.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Charity")]
    public partial class Charity
    {
        [Key]
        public int tfmi_crId { get; set; }

        [StringLength(50)]
        public string tfmi_crSrc { get; set; }

        [StringLength(100)]
        public string tfmi_crTitle { get; set; }

        public string tfmi_crContent { get; set; }
    }
}
