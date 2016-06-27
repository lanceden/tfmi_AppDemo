namespace tfmi_demo.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string tfmi_fdName { get; set; }

        [StringLength(50)]
        public string tfmi_fdTitle { get; set; }

        public string tfmi_fdContent { get; set; }
    }
}
