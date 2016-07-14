// <auto-generated />
namespace Microsoft.EntityFrameworkCore.Internal
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
    using JetBrains.Annotations;

	/// <summary>
	///		This API supports the Entity Framework Core infrastructure and is not intended to be used 
    ///     directly from your code. This API may change or be removed in future releases.
	/// </summary>
    public static class ToolsStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Tools.Console.Properties.ToolsStrings", typeof(ToolsStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// Cannot execute this command because Microsoft.EntityFrameworkCore.Design is not installed.
        /// </summary>
        public static string DesignDependencyNotFound
        {
            get { return GetString("DesignDependencyNotFound"); }
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
