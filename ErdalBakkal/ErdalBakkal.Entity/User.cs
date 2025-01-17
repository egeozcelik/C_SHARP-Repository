﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalBakkal.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
