﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialComPort.Model
{
    public class Ports
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public string Status { get; set; }
    }
}
