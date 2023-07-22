using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTemplate
{
    public interface IQuotaModelFilterByParent
    {
        List<string> FilterOut(string terminalRestrictionsGroupedByParentIdModel,
            MemberType requestMemberType,
            int requestMemberId,
            List<string> restrictionsWithVehiclesAndOwners);
    }
}
