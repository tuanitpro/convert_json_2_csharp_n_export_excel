using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ToolConvertJson2Excel
{
    public static class JsonToCsharpHelper
    {
        /// <summary>
        /// GenerateFileClass from JSON Object
        /// </summary>
        /// <param name="jsonText">{a:1, b:2}</param>
        /// <param name="className">Your Class Name</param>
        /// <param name="ns">Your Namespace of Class</param>
        public static void GenerateFileClass(string jsonText, string className = "MathInfo", string ns = "ToolConvertJson2Excel")
        {
            var namespaces = new List<string>
            {
                "using System;",
                "using Newtonsoft.Json;",
                "namespace "+ns+" { "
            };
            JObject jObj = (JObject)JsonConvert.DeserializeObject(jsonText);
            Dictionary<string, string> dictObj = jObj.ToObject<Dictionary<string, string>>();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in namespaces)
            {
                stringBuilder.AppendLine(item);
            }
            stringBuilder.AppendLine("  public class " + className);
            stringBuilder.AppendLine("  {");
            foreach (var item in dictObj)
            {
                var type = "string";
                var getValue = item.Value;
                int getValueInt = 0;
                var isNumber = int.TryParse(getValue, out getValueInt);
                if (isNumber)
                {
                    type = "int";
                }
                /// more type...
                string propertyName = CreatePropertyName(type, item.Key).ToString();
                stringBuilder.AppendLine(propertyName);
            }

            stringBuilder.AppendLine("  }");
            stringBuilder.AppendLine("}");

            File.WriteAllText(className + ".cs", stringBuilder.ToString());
        }

        private static StringBuilder CreatePropertyName(string type, string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("      [JsonProperty(PropertyName = \"" + name + "\")]");
                string cleanPropName = name.Replace(" ", string.Empty).Replace(".", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Trim();
                stringBuilder.AppendLine("      public " + type + " " + cleanPropName + " { get; set; }");

                return stringBuilder;
            }

            return new StringBuilder();
        }
    }
}