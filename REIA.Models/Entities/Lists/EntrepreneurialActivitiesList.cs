﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities.Other
{
    public class EntrepreneurialActivitiesList : DomainObject
    {
        [Required]
        public string ListEntrepreneurialActivities { get; set; }
    }
}
