using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    [Table("User")]
    class User
    {
        public User() : base()
        {
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }

    }
}
