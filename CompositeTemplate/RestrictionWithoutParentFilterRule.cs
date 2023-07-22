using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTemplate
{
    public class RestrictionWithoutParentFilterRule : IQuotaModelFilterByParent
    {
        public RestrictionWithoutParentFilterRule()
        {
        }
        public List<string> FilterOut(
            string restrictionByTerminalAndDate,
            MemberType requestMemberType,
            int requestMemberId,
            List<string> restrictionsWithVehiclesAndOwners)
        {

            restrictionsWithVehiclesAndOwners.Add("test1");
            return restrictionsWithVehiclesAndOwners;
        }
    }
}
