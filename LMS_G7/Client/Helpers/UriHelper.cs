namespace LMS_G7.Client.Helpers
{
    public static class UriHelper
    {
        private const string modulePrefix = "/module";
        private const string addSuffix = "add";
        private const string updateSuffix = "update";
        private const string deleteSuffix = "delete";
        private const string detailsSuffix = "details";

        public const string ModuleDetails = $"{modulePrefix}{detailsSuffix}/{{moduleId:guid}}";
        public const string ModuleUpdate = $"{modulePrefix}{updateSuffix}/{{moduleId:guid}}";
        public const string ModuleAdd = $"{modulePrefix}{addSuffix}/{{courseId:guid}}";
        public const string ModuleDelete = $"{modulePrefix}{deleteSuffix}/{{moduleId:guid}}";

        public static string ModulesBaseUri => "api/modules/";

        public static string GetModuleUri<T>(T moduleId, bool includeActivities = false)
        {
            return ModulesBaseUri + moduleId!.ToString() + $"?includeActivities={includeActivities}";
        }

        public static string GetModulesUri()
        {
            return ModulesBaseUri;
        }

        public static string GetModuleAddUri<T>(T courseId)
        {
            return $"{modulePrefix}{addSuffix}/{courseId}";
        }
        public static string GetModuleUpdateUri<T>(T moduleId)
        {
            return $"{modulePrefix}{updateSuffix}/{moduleId}";
        }
        public static string GetModuleDeleteUri<T>(T moduleId)
        {
            return $"{modulePrefix}{deleteSuffix}/{moduleId}";
        }
        public static string GetModuleDetailsUri<T>(T moduleId)
        {
            return $"{modulePrefix}{detailsSuffix}/{moduleId}>";
        }
    }
}
