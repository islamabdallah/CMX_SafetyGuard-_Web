﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverViolation.Models.Models.Entity;

namespace WebDriverViolation.Models.Models
{
    public class CameraViolation : EntityWithIdentityId<long>
    {
        public string TruckID { get; set; }

        public int ViolationTypeID { get; set; }
    }
}
