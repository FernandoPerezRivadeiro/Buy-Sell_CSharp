namespace ProjectTeam06TermProject.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Posting
    {
        public int PostingId { get; set; }

        public int SellerNum { get; set; }

        public int ItemNum { get; set; }

        public virtual Item Item { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
