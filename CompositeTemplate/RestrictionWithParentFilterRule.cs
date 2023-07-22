using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTemplate
{
    public class RestrictionWithParentFilterRule : IQuotaModelFilterByParent
    {
        public RestrictionWithParentFilterRule()
        {
        }

        public List<string> FilterOut(
            string terminalRestrictionsGroupedByParentIdModel,
            MemberType requestMemberType,
            int requestMemberId,
            List<string> restrictionsWithVehiclesAndOwners)
        {
            restrictionsWithVehiclesAndOwners.Add("test2");
            return restrictionsWithVehiclesAndOwners;
        }
    }
}
