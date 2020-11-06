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
    [Table("Functions")]
    public class Function : DomainEntity<string>, ISwitchable, ISortable
    {
        [Required]
        [StringLength(128)]
        public string Name { set; get; }
        [Required]
        [StringLength(250)]
        public string URL { set; get; }
        [StringLength(128)]
        public string ParentId { set; get; }
        public string IconCss { get; set; }


        public Status Status {get;set;}
      
        public int SortOrder { get; set; }
    }
}
