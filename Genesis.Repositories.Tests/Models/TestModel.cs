﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Repositories.Tests.Models
{
    public class TestModel
    {
        public int IntField { get; set; }
        public long LongField { get; set; }
        public string StringField { get; set; } = string.Empty;
        public DateTime DateTimeField { get; set; }
        public bool BoolField { get; set; }
        public double DoubleField { get; set; }
        public decimal DecimalField { get; set; }
    }
}
