﻿using Microsoft.AspNetCore.Identity;
using Sell.Data.Enums;
using Sell.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sell.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser :IdentityUser<Guid>,IDateTracking,ISwitchable 
    {
        public string FullName { get; set; }
        public DateTime? BirthDay { set; get; }
        public decimal Balance { set; get; }
        public string Avatar { get; set; }
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        public Status Status {get;set;}
    }
}
