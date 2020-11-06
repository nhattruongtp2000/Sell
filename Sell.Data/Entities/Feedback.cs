using Sell.Data.Enums;
using Sell.Data.Interfaces;
using Sell.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sell.Data.Entities
{
    [Table("Feedbacks")]
    public class Feedback : DomainEntity<int>, IDateTracking, ISwitchable
    {
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(500)]
        public string Message { set; get; }

        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        public Status Status {get;set;}
    }
}
