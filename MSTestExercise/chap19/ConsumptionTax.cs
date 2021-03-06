﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTestExercise.chap19
{
    public class ConsumptionTax
    {
        private int _taxRate;

        public ConsumptionTax(int taxRate)
        {
            _taxRate = taxRate;
        }

        public int Apply(int price)
        {
            return price + (price * _taxRate / 100);
        }
    }
}
