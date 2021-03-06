namespace NetFinalProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("net.notice")]
    public partial class Notice
    {
        public int id { get; set; }

        [StringLength(250)]
        public string title { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(250)]
        public string img { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content { get; set; }

        public DateTime? time { get; set; }
    }
}
