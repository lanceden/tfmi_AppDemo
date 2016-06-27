namespace tfmi_demo.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string tfmi_newsHref { get; set; }

        [StringLength(100)]
        public string tfmi_newsTitle { get; set; }
    }
}
