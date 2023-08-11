﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xpense_Tracker.Data
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitlewithIcon
        {
            get {
                return this.Icon + " " + this.Title;
            }
        }
    }
}
