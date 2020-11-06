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
    [Table("Blogs")]
    public class Blog : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        public string Tags { get; set; }

        public Status Status {get;set;}
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        [MaxLength(256)]
        public string SeoPageTitle {get;set;}
        [MaxLength(256)]
        public string SeoAlias {get;set;}
        [MaxLength(256)]
        public string SeoKeywords {get;set;}
        [MaxLength(256)]
        public string SeoDescription {get;set;}

        public virtual ICollection<BlogTag> BlogTags { get; set; }
    }
}
