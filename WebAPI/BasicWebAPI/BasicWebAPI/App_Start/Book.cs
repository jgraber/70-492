﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebAPI.App_Start
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string ISBN { get; set; }
    }
}