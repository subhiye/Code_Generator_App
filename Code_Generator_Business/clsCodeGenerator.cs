using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Generator_Business
{
    public class clsCodeGenerator
    {
        public struct ColumnInfo
        {
            public string ColumnName;
            public string DataType;
        }
        
        public string GenerateStruct(string structName, List<ColumnInfo> columns)
        { 
                StringBuilder structBuilder = new StringBuilder();
                structBuilder.AppendLine($"public struct {structName}");
                structBuilder.AppendLine("{");

                foreach (var column in columns)
                {
                    structBuilder.AppendLine($"    public {column.DataType} {column.ColumnName};");
                }

                structBuilder.AppendLine("}");
                return structBuilder.ToString();
        }

        public static string GenerateCRUDMethods(string structName, List<ColumnInfo> columns)
        {
            StringBuilder methodsBuilder = new StringBuilder();

            // Create Method
            methodsBuilder.AppendLine($"public static void Create{structName}({structName} entity)");
            methodsBuilder.AppendLine("{");
            methodsBuilder.AppendLine("    // Add your database insertion logic here");
            methodsBuilder.AppendLine("}");

            // Read Method
            methodsBuilder.AppendLine($"public static {structName} Read{structName}(int id)");
            methodsBuilder.AppendLine("{");
            methodsBuilder.AppendLine("    // Add your database retrieval logic here");
            methodsBuilder.AppendLine($"    return new {structName}();");
            methodsBuilder.AppendLine("}");

            // Update Method
            methodsBuilder.AppendLine($"public static void Update{structName}({structName} entity)");
            methodsBuilder.AppendLine("{");
            methodsBuilder.AppendLine("    // Add your database update logic here");
            methodsBuilder.AppendLine("}");

            // Delete Method
            methodsBuilder.AppendLine($"public static void Delete{structName}(int id)");
            methodsBuilder.AppendLine("{");
            methodsBuilder.AppendLine("    // Add your database deletion logic here");
            methodsBuilder.AppendLine("}");

            return methodsBuilder.ToString();
        }
    }
}