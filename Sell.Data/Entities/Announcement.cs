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
    [Table("Announcements")]
    public class Announcement : DomainEntity<string>, ISwitchable, IDateTracking
    {
        public Announcement()
        {
            AnnouncementUsers = new List<AnnouncementUser>();
        }

        [Required]
        [StringLength(250)]
        public string Title { set; get; }

        [StringLength(250)]
        public string Content { set; get; }

        [StringLength(450)]
        public string UserId { set; get; }



        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        public Status Status {get;set;}

        public virtual ICollection<AnnouncementUser> AnnouncementUsers { get; set; }
    }
}
