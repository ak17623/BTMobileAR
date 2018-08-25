using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Fuzzy
{
    public interface IRule
    {
        List<FuzzyValue> Antecedents { get; }
        FuzzyValue Consequent { get; set; }
        double FireStrength { get; }
        void CalcFiringStrength();
    }
}
