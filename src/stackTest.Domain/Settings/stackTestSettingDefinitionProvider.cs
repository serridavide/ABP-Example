using Volo.Abp.Settings;

namespace stackTest.Settings
{
    public class stackTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(stackTestSettings.MySetting1));
        }
    }
}
