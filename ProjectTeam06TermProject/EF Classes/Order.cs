namespace ProjectTeam06TermProject.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int BuyerNum { get; set; }

        public int ItemNum { get; set; }

        public int OrderId { get; set; }

        public virtual Item Item { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
