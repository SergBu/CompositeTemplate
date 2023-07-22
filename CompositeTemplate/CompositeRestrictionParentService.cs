using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTemplate
{
    public class CompositeRestrictionParentService : IQuotaModelFilterByParent
    {
        private readonly IEnumerable<IQuotaModelFilterByParent> _quotaModelFilters;

        public CompositeRestrictionParentService(IEnumerable<IQuotaModelFilterByParent> quotaModelFilters)
        {
            _quotaModelFilters = quotaModelFilters;
        }
        public List<string> FilterOut(string terminalRestrictionsGroupedByParentIdModel, MemberType requestMemberType, int requestMemberId, List<string> restrictionsWithVehiclesAndOwners)
        {
            foreach (var quotaFilter in _quotaModelFilters)
            {
                restrictionsWithVehiclesAndOwners =
                    quotaFilter.FilterOut(
                    terminalRestrictionsGroupedByParentIdModel,
                    requestMemberType,
                    requestMemberId,
                    restrictionsWithVehiclesAndOwners);
            }

            return restrictionsWithVehiclesAndOwners;
        }
    }
}
