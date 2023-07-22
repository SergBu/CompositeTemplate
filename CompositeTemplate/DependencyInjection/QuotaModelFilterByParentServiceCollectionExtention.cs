using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTemplate.DependencyInjection
{
    public static class QuotaModelFilterByParentServiceCollectionExtention
    {
        public static IServiceCollection AddQuotaModelFilterByParent(this IServiceCollection services)
        {
            services.TryAddSingleton<RestrictionWithoutParentFilterRule>();
            services.TryAddSingleton<RestrictionWithParentFilterRule>();
            services.AddSingleton<IQuotaModelFilterByParent>(sp => new CompositeRestrictionParentService(new IQuotaModelFilterByParent[]
            {
                sp.GetRequiredService<RestrictionWithoutParentFilterRule>(),
                sp.GetRequiredService<RestrictionWithParentFilterRule>()
            }));

            return services;
        }
    }
}
