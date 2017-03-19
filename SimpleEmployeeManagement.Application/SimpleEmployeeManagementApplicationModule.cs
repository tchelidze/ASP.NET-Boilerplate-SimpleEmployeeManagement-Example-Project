using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace SimpleEmployeeManagement
{
    [DependsOn(typeof(SimpleEmployeeManagementCoreModule), typeof(AbpAutoMapperModule))]
    public class SimpleEmployeeManagementApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
