﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganisationBitches.Models
{
    public class TimesheetEntryDTO : TimesheetEntryModel
    {
        public PersonModel Person { get; set; }
    }
}
