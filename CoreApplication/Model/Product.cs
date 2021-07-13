using System;
using System.Collections.Generic;

#nullable disable

namespace CoreApplication.Model
{
    public partial class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        public string Img { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Ratings { get; set; }
    }
}
