﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Repository
{
    public class UserMaster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }

        public string MobileNo { get; set; }
    }
}