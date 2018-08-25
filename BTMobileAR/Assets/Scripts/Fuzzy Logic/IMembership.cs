using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Fuzzy
{
    public interface IMembership
    {
        void setMembershipValue(double value);
        double getMembershipValue();
        double centroid();

        //bool IsResultInRange(double result);
    }
}
