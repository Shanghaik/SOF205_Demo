using System;
using System.Collections.Generic;

namespace A_DAL.Models1
{
    public partial class Sanpham
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public DateTime? Createdate { get; set; }
        public bool? Status { get; set; }
    }
}
