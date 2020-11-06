using Sell.Infrastructure.ShareKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sell.Data.Entities
{
    public class Tag : DomainEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }

        public virtual ICollection<BlogTag> BlogTags { get; set; }

        public virtual ICollection<ProductTag> ProductTags { get; set; }
    }
}