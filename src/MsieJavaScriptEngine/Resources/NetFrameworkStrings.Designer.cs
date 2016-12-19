//------------------------------------------------------------------------------
// <auto-generated>
//	 This code was generated by a tool.
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace MsieJavaScriptEngine.Resources
{
	using System;
	using System.Globalization;
	using System.Reflection;
	using System.Resources;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	public class NetFrameworkStrings
	{
		private static Lazy<ResourceManager> _resourceManager =
			new Lazy<ResourceManager>(() => new ResourceManager(
				"MsieJavaScriptEngine.Resources.NetFrameworkStrings",
#if NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETCOREAPP1_0 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462 || NET463
				typeof(NetFrameworkStrings).GetTypeInfo().Assembly
#elif NET40
				typeof(NetFrameworkStrings).Assembly
#else
#error No implementation for this target
#endif
			));

		private static CultureInfo _resourceCulture;

		/// <summary>
		/// Returns a cached ResourceManager instance used by this class
		/// </summary>
		public static ResourceManager ResourceManager
		{
			get
			{
				return _resourceManager.Value;
			}
		}

		/// <summary>
		/// Overrides a current thread's CurrentUICulture property for all
		/// resource lookups using this strongly typed resource class
		/// </summary>
		public static CultureInfo Culture
		{
			get
			{
				return _resourceCulture;
			}
			set
			{
				_resourceCulture = value;
			}
		}

		/// <summary>
		/// Looks up a localized string similar to "ActiveScript dispatcher is not initialized."
		/// </summary>
		public static string Runtime_ActiveScriptDispatcherNotInitialized
		{
			get { return GetString("Runtime_ActiveScriptDispatcherNotInitialized"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Failed to set '{0}' version of script language for the ActiveScript JavaScript engine."
		/// </summary>
		public static string Runtime_ActiveScriptLanguageVersionSelectionFailed
		{
			get { return GetString("Runtime_ActiveScriptLanguageVersionSelectionFailed"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "The parser you passed implements neither `IActiveScriptParse32` nor `IActiveScriptParse64`."
		/// </summary>
		public static string Runtime_InvalidParserImplementationError
		{
			get { return GetString("Runtime_InvalidParserImplementationError"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Item with name '{0}' not found."
		/// </summary>
		public static string Runtime_ItemNotFound
		{
			get { return GetString("Runtime_ItemNotFound"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Could not found none of the JavaScript engines. Perhaps you have not installed the Internet Explorer..."
		/// </summary>
		public static string Runtime_JsEnginesNotFound
		{
			get { return GetString("Runtime_JsEnginesNotFound"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "The variable with the name '{0}' does not exist."
		/// </summary>
		public static string Runtime_VariableNotExist
		{
			get { return GetString("Runtime_VariableNotExist"); }
		}

			private static string GetString(string name)
			{
				string value = ResourceManager.GetString(name, _resourceCulture);

				return value;
			}
		}
	}