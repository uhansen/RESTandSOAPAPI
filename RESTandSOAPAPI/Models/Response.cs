﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RESTandSOAPAPI.Models
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public double Pressure { get; set; }
    }
}
