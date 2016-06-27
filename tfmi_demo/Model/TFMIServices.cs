namespace tfmi_demo.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TFMIServices
    {
        [Key]
        public int tfmi_serId { get; set; }

        [StringLength(100)]
        public string tfmi_serImgSrc { get; set; }

        [StringLength(100)]
        public string tfmi_serTitle { get; set; }

        public string tfmi_serContent { get; set; }
    }
}
