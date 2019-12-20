﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StartEFCore.Data
{
    // generic base class
    public class Entity<T> : CommonEntity
    {
        // [Key]
        public T Id { get; set; }
        // Generic olarak belirtmek demek onun tip degiskenligine sahip olmasi demek
    }
    // default base class
    public class Entity : CommonEntity
    {
        // [Key]
        public int Id { get; set; }
    }

    // non generic base class fields
    public class CommonEntity
    {
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        [Display(Name = "Son Güncelleme")]
        public DateTime? ModifiedDate { get; set; }
        [Display(Name = "Gizli Alan")]
        public string HiddenValue { get; set; }
    }
}
