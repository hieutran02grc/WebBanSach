﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hieutran02grc.WebBanSach.Data
{
    public class BookGallery
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        public Books Book { get; set; }
    }
}
