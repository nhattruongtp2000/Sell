using Sell.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sell.Data.Entities
{
    [Table("Permissions")]
    public class Permission : DomainEntity<int>
    {
        [StringLength(450)]
        [Required]
        public string RoleId { get; set; }

        [StringLength(128)]
        [Required]
        public string FunctionId { get; set; }
        public bool CanCreate { set; get; }
        public bool CanRead { set; get; }
        public bool CanUpdate { set; get; }
        public bool CanDelete { set; get; }


    }
}
