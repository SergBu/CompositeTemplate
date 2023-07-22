// See https://aka.ms/new-console-template for more information
using CompositeTemplate;
using CompositeTemplate.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
//setup our DI

var services = new ServiceCollection()
    .AddQuotaModelFilterByParent()
    .BuildServiceProvider();


//do the actual work here
var _quotaModelFilter = services.GetService<IQuotaModelFilterByParent>();

var list = new List<string>();

//method adds items to list
_quotaModelFilter.FilterOut(terminalRestrictionsGroupedByParentIdModel: "test", MemberType.CargoOwner, 32, restrictionsWithVehiclesAndOwners: list);

list.ForEach(x => Console.WriteLine(x));
