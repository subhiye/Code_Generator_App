using Code_Generator_App_Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Code_Generator_App
{
    public partial class CodeGenerator_App : Form
    {
        enum EnFunction { BusinessLayer = 0, DataLayer = 1 }
        EnFunction _FunctionMode;
        enum EnCrudFunction { Creating = 0, Reading = 1, Updating = 2, Deleting = 3, All = 4 , Object = 5}
        EnCrudFunction _CrudMode;
        StringBuilder functionBody = new StringBuilder();
        StringBuilder variables = new StringBuilder();
        StringBuilder queryColumns = new StringBuilder();
        StringBuilder queryValues = new StringBuilder();
        StringBuilder parameterAssignments = new StringBuilder();
        public CodeGenerator_App()
        {
            InitializeComponent();
        }
        private void AddColumn(string headerText, int width)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = headerText;
            column.Width = width;
            dataGridView1.Columns.Add(column);
        }
        private void SetDataGridViewColumns()
        {
            dataGridView1.Columns.Clear();
            AddColumn("Column Type", 111);
            AddColumn("Column Name", 111);
            AddColumn("Data Type", 111);
        }
        private void rbBusinessLyaer_Click(object sender, EventArgs e)
        {
            _FunctionMode = EnFunction.BusinessLayer;
            MessageBox.Show("If You Want To Generate An Object Code You Are Not Have To Fill Code Type Fields , Good Job");
            gbCrudChoices.Enabled = true;
            rbObject.Enabled = true;
            txtTableName.Text = "";
            txtTableName.Enabled = false;
            lblClassname.Text = "Data class Name";
            lblConnectionString.Text = "Data Function Name";
        }
        private void txtClassName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(txtClassName, string.IsNullOrEmpty(txtClassName.Text) ? "this Field Is Empty Please" : "");
        }
        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(txtTableName, string.IsNullOrEmpty(txtTableName.Text) ? "this Field Is Empty Please" : "");
        }
        private void textBox5_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(txtFunctionName, string.IsNullOrEmpty(txtFunctionName.Text)  ? "this Field Is Empty Please" : "");
        }
        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(txtAddColumn, string.IsNullOrEmpty(txtAddColumn.Text) ? "Add A Column Name First Please" : "");
        }
        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(txtConnectionString, string.IsNullOrEmpty(txtConnectionString.Text) ? "Add A Column Name First Please" : "");
        }
        private clsColumnDetails AddColumnsInfo(clsColumnDetails ColumnDetails)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = cbColumnType.Text;
            ColumnDetails.DateType = cbColumnType.Text;
            row.Cells[1].Value = txtAddColumn.Text;
            ColumnDetails.ColumnName = txtAddColumn.Text;
            string Type = rbNotNull.Checked ? "Not Null" : "Null";
            row.Cells[2].Value = Type;
            ColumnDetails.ColumnType = Type;
            dataGridView1.Rows.Add(row);
            txtAddColumn.Clear();
            cbColumnType.SelectedIndex = -1;
            return ColumnDetails;
        }
        List<clsColumnDetails> dynamicArrayOfObjects = new List<clsColumnDetails>();
        private List<clsColumnDetails> FillColumnsArray(List<clsColumnDetails> ArrayOfColumnsObjects)
        {
            for (short i = 0; i < 1; i++)
            {
                clsColumnDetails ColumnDetails = new clsColumnDetails();
                ColumnDetails = AddColumnsInfo(ColumnDetails);
                dynamicArrayOfObjects.Add(ColumnDetails);
            }
            return ArrayOfColumnsObjects;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtAddColumn.Text) || string.IsNullOrEmpty(cbColumnType.Text))
            {
                txtAddColumn.Focus();
                errorProvider1.SetError(txtAddColumn, "Add A Column Name First Please");
            }
            else
            {
                errorProvider1.SetError(txtAddColumn, "");
            }
            
            btnGenerate.Enabled = true;
            FillColumnsArray(dynamicArrayOfObjects);
        }
        private void HandleRetrievingFunction(string TableName, string FunctionName, string ClassName, string ConnectionString)
        {
            functionBody.AppendLine($"public static DataTable {FunctionName}()");
            functionBody.AppendLine("{");
            functionBody.AppendLine("    DataTable dt = new DataTable();");
            functionBody.AppendLine("    try");
            functionBody.AppendLine("    {");
            functionBody.AppendLine($"        using (SqlConnection connection = new SqlConnection({ClassName}.{ConnectionString}))");
            functionBody.AppendLine("        {");
            functionBody.AppendLine("            connection.Open();");
            functionBody.AppendLine("            string query = @\"SELECT *");
            functionBody.AppendLine($" FROM {TableName}\";");
            functionBody.AppendLine("            using (SqlCommand command = new SqlCommand(query, connection))");
            functionBody.AppendLine("            {");
            functionBody.AppendLine("                using (SqlDataReader reader = command.ExecuteReader())");
            functionBody.AppendLine("                {");
            functionBody.AppendLine("                    if (reader.HasRows)");
            functionBody.AppendLine("                    {");
            functionBody.AppendLine("                        dt.Load(reader);");
            functionBody.AppendLine("                    }");
            functionBody.AppendLine("                }");
            functionBody.AppendLine("            }");
            functionBody.AppendLine("        }");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    catch (Exception ex)");
            functionBody.AppendLine("    {");
            functionBody.AppendLine("        // Handle exception");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    return dt;");
            functionBody.AppendLine("}");

            rtxtbString.Text = functionBody.ToString();
            clsUtil.ColorText(TableName, Color.Green, rtxtbString);
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
        }       
        private void HandleAddingFunction(string TableName, string FunctionName, string FunctionType, string ClassName, string ConnectionString, List<clsColumnDetails> ArrayOfColumns)
        {
            functionBody.AppendLine($"public static {FunctionType} {FunctionName}(");
            foreach (clsColumnDetails column in ArrayOfColumns)
            {
                if (column.ColumnType != "Null")
                {
                    variables.Append($"{column.DateType} {column.ColumnName}, ");
                    queryColumns.Append($"{column.ColumnName}, ");
                    queryValues.Append($"@{column.ColumnName}, ");
                    parameterAssignments.AppendLine($"command.Parameters.AddWithValue(\"@{column.ColumnName}\", {column.ColumnName});");
                }
                else
                {
                    queryColumns.Append($"{column.ColumnName}, ");
                    queryValues.Append($"@{column.ColumnName}, ");
                    parameterAssignments.AppendLine($"command.Parameters.AddWithValue(\"@{column.ColumnName}\", {column.ColumnName} ?? DBNull.Value);");                
                }
            }
            if (variables.Length > 0)
            {
                variables.Length -= 2;
                queryColumns.Length -= 2;
                queryValues.Length -= 2;
            }
            string connectionStringFull = ClassName + "." + ConnectionString;
            functionBody.AppendLine(variables.ToString());
            functionBody.AppendLine(")");
            functionBody.AppendLine("{");
            functionBody.AppendLine("    int ID = -1;");
            functionBody.AppendLine("    try");
            functionBody.AppendLine("    {");
            functionBody.AppendLine($"        using (SqlConnection connection = new SqlConnection({connectionStringFull}))");
            functionBody.AppendLine("        {");
            functionBody.AppendLine("            connection.Open();");
            functionBody.AppendLine($"            string query = @\"INSERT INTO {TableName} ({queryColumns}) VALUES ({queryValues}); SELECT SCOPE_IDENTITY();\";");
            functionBody.AppendLine("            using (SqlCommand command = new SqlCommand(query, connection))");
            functionBody.AppendLine("            {");
            functionBody.AppendLine(parameterAssignments.ToString());
            functionBody.AppendLine("                object result = command.ExecuteScalar();");
            functionBody.AppendLine("                if (result != null && int.TryParse(result.ToString(), out int insertedID))");
            functionBody.AppendLine("                {");
            functionBody.AppendLine("                    ID = insertedID;");
            functionBody.AppendLine("                }");
            functionBody.AppendLine("            }");
            functionBody.AppendLine("        }");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    catch (Exception ex)");
            functionBody.AppendLine("    {");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    return ID;");
            functionBody.AppendLine("}");
            rtxtbString.Text = functionBody.ToString();
            clsUtil.ColorText(TableName, Color.Green, rtxtbString);
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(FunctionType, Color.Blue, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
        }
        private void HandleUpdatingFunction(string TableName, string FunctionName, string FunctionType, string ClassName, string ConnectionString, List<clsColumnDetails> ArrayOfColumns)
        {
            StringBuilder setClauses = new StringBuilder();
            functionBody.AppendLine($"public static {FunctionType} {FunctionName}(");
            foreach (clsColumnDetails column in ArrayOfColumns)
            {
                if (column.ColumnType != "Null")
                {
                    variables.Append($"{column.DateType} {column.ColumnName}, ");
                    setClauses.AppendLine($"{column.ColumnName} = @{column.ColumnName}, ");
                    parameterAssignments.AppendLine($"command.Parameters.AddWithValue(\"@{column.ColumnName}\", {column.ColumnName});");
                }
                else
                {
                    setClauses.AppendLine($"{column.ColumnName} = @{column.ColumnName}, ");
                    parameterAssignments.AppendLine($"command.Parameters.AddWithValue(\"@{column.ColumnName}\", {column.ColumnName} ?? DBNull.Value);");
                }
            }
            if (variables.Length > 0)
            {
                variables.Length -= 2; 
                setClauses.Length -= 4;
            }
            string connectionStringFull = $"{ClassName}.{ConnectionString}";
            functionBody.AppendLine(variables.ToString());
            functionBody.AppendLine(")");
            functionBody.AppendLine("{");
            functionBody.AppendLine("    int rowsAffected = 0;");
            functionBody.AppendLine("    try");
            functionBody.AppendLine("    {");
            functionBody.AppendLine($"        using (SqlConnection connection = new SqlConnection({connectionStringFull}))");
            functionBody.AppendLine("        {");
            functionBody.AppendLine("connection.Open();");
            functionBody.AppendLine($"            string query = @\"UPDATE {TableName} SET {setClauses} WHERE PersonID = @PersonID;\";");
            functionBody.AppendLine("            using (SqlCommand command = new SqlCommand(query, connection))");
            functionBody.AppendLine("            {");
            functionBody.AppendLine("                command.Parameters.AddWithValue(\"@PersonID\", PersonID);");
            functionBody.AppendLine(parameterAssignments.ToString());
            functionBody.AppendLine("                rowsAffected = command.ExecuteNonQuery();");
            functionBody.AppendLine("            }");
            functionBody.AppendLine("        }");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    catch (Exception ex)");
            functionBody.AppendLine("    {");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    return (rowsAffected > 0);");
            functionBody.AppendLine("}");
            rtxtbString.Text = functionBody.ToString();
            clsUtil.ColorText(TableName, Color.Green, rtxtbString);
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(FunctionType, Color.Blue, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
        }
        private void HandleDeletingFunction(string TableName, string FunctionName, string FunctionType, string ClassName, string ConnectionString, string KeyColumnName, string KeyColumnType)
        {
            functionBody.AppendLine($"public static {FunctionType} {FunctionName}({KeyColumnType} {KeyColumnName})");
            functionBody.AppendLine("{");
            functionBody.AppendLine("    int rowsAffected = 0;");
            functionBody.AppendLine($"    using (SqlConnection connection = new SqlConnection({ClassName}.{ConnectionString}))");
            functionBody.AppendLine("    {");
            functionBody.AppendLine("        string query = @\"DELETE FROM " + TableName + " WHERE " + KeyColumnName + " = @" + KeyColumnName + "\";");
            functionBody.AppendLine("        using (SqlCommand command = new SqlCommand(query, connection))");
            functionBody.AppendLine("        {");
            if (KeyColumnType != "Null") functionBody.AppendLine("            command.Parameters.AddWithValue(\"@" + KeyColumnName + "\", " + KeyColumnName + ");");           
            else functionBody.AppendLine("            command.Parameters.AddWithValue(\"@" + KeyColumnName + "\", " + KeyColumnName + " ?? DBNull.Value);");  
            functionBody.AppendLine("            try");
            functionBody.AppendLine("            {");
            functionBody.AppendLine("                connection.Open();");
            functionBody.AppendLine("                rowsAffected = command.ExecuteNonQuery();");
            functionBody.AppendLine("            }");
            functionBody.AppendLine("            catch (Exception ex)");
            functionBody.AppendLine("            {");
            functionBody.AppendLine("                // Handle exception");
            functionBody.AppendLine("            }");
            functionBody.AppendLine("        }");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    return (rowsAffected > 0);");
            functionBody.AppendLine("}");
            rtxtbString.Text = functionBody.ToString();
            clsUtil.ColorText(KeyColumnName, Color.Red, rtxtbString);
            clsUtil.ColorText(KeyColumnType, Color.Purple, rtxtbString);
            clsUtil.ColorText(TableName, Color.Green, rtxtbString);
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(FunctionType, Color.Blue, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
        }
        private void HandleReadingFunction(string TableName, string FunctionName, string FunctionType, string ClassName, string ConnectionString, List<clsColumnDetails> ArrayOfColumns)
        {
            string connectionStringFull = $"{ClassName}.{ConnectionString}";
            functionBody.AppendLine($"public static {FunctionType} {FunctionName}(");
            foreach (clsColumnDetails column in ArrayOfColumns)
            {
                variables.Append($"{column.DateType} {column.ColumnName}, ");
                queryColumns.Append($"{column.ColumnName}, ");
                queryValues.Append($"@{column.ColumnName}, ");

                if (column.ColumnType != "Null")
                {
                    parameterAssignments.AppendLine($"command.Parameters.AddWithValue(\"@{column.ColumnName}\", {column.ColumnName});");
                }
                else
                {
                    parameterAssignments.AppendLine($"command.Parameters.AddWithValue(\"@{column.ColumnName}\", {column.ColumnName} ?? DBNull.Value);");
                }
            }
            if (variables.Length > 0)
            {
                variables.Length -= 2; 
                queryColumns.Length -= 2;
                queryValues.Length -= 2;
            }
            functionBody.AppendLine(variables.ToString());
            functionBody.AppendLine(")");
            functionBody.AppendLine("{");
            functionBody.AppendLine("    bool isFound = false;");
            functionBody.AppendLine("    try");
            functionBody.AppendLine("    {");
            functionBody.AppendLine($"        using (SqlConnection connection = new SqlConnection({connectionStringFull}))");
            functionBody.AppendLine("        {");
            functionBody.AppendLine("            string query = \"SELECT * FROM " + TableName + " WHERE PersonID = @PersonID\";");
            functionBody.AppendLine("            using (SqlCommand command = new SqlCommand(query, connection))");
            functionBody.AppendLine("            {");
            functionBody.AppendLine("                command.Parameters.AddWithValue(\"@ID\", ID);");
            functionBody.AppendLine("                connection.Open();");
            functionBody.AppendLine("                using (SqlDataReader reader = command.ExecuteReader())");
            functionBody.AppendLine("                {");
            functionBody.AppendLine("                    if (reader.Read())");
            functionBody.AppendLine("                    {");
            functionBody.AppendLine("                        isFound = true;");
            functionBody.AppendLine(parameterAssignments.ToString());
            functionBody.AppendLine("                    }");
            functionBody.AppendLine("                }");
            functionBody.AppendLine("            }");
            functionBody.AppendLine("        }");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    catch (Exception ex)");
            functionBody.AppendLine("    {");
            functionBody.AppendLine("        isFound = false;");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    return isFound;");
            functionBody.AppendLine("}");
            rtxtbString.Text = functionBody.ToString();
            clsUtil.ColorText(TableName, Color.Green, rtxtbString);
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(FunctionType, Color.Blue, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
        }
        private void rbCrud_Click(object sender, EventArgs e)
        {
            RadioButton rbCurdChoice = (RadioButton)sender;
            switch (rbCurdChoice.Text)
            {
                case "Adding":
                    _CrudMode = EnCrudFunction.Creating;
                    break;
                case "Deleting":
                    _CrudMode = EnCrudFunction.Deleting;
                    break;
                case "Reading":
                    _CrudMode = EnCrudFunction.Reading;
                    break;
                case "Updating":
                    _CrudMode = EnCrudFunction.Updating;
                    break;
                case "GetingAll":
                    _CrudMode = EnCrudFunction.All;
                    break;
                case "Object":
                    _CrudMode = EnCrudFunction.Object;
                    gbColumnChoices.Enabled = true;
                    btnAdding.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private void PerformDataLayerGenerating()
        {
            var actions = new Dictionary<EnCrudFunction, Action>
            {
                { EnCrudFunction.Creating, () => HandleAddingFunction(txtTableName.Text, txtFunctionName.Text, cbFunctionType.Text, txtClassName.Text, txtConnectionString.Text, dynamicArrayOfObjects) },
                { EnCrudFunction.Deleting, () => HandleDeletingFunction(txtTableName.Text, txtFunctionName.Text, cbFunctionType.Text, txtClassName.Text, txtConnectionString.Text, dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString()) },
                { EnCrudFunction.Reading, () => HandleReadingFunction(txtTableName.Text, txtFunctionName.Text, cbFunctionType.Text, txtClassName.Text, txtConnectionString.Text, dynamicArrayOfObjects) },
                { EnCrudFunction.Updating, () => HandleUpdatingFunction(txtTableName.Text, txtFunctionName.Text, cbFunctionType.Text, txtClassName.Text, txtConnectionString.Text, dynamicArrayOfObjects) },
                { EnCrudFunction.All, () => HandleRetrievingFunction(txtTableName.Text, txtFunctionName.Text, txtClassName.Text, txtConnectionString.Text) }
            };
            if (actions.TryGetValue(_CrudMode, out var action)) action();
        }
        private void CodeGenerator_App_Load(object sender, EventArgs e)
        {
            _FunctionMode = EnFunction.DataLayer;
            SetDataGridViewColumns();
            btnDelete.Enabled = false;
            rbObject.Enabled = false;
            rbDataLayer.Checked = true;
            gbCrudChoices.Enabled = false;
            gbColumnChoices.Enabled = false;
            gbTableChoices.Enabled = true;
            btnAdding.Enabled = false;
            btnCopy.Enabled = false;
            btnGenerate.Enabled = false;
        }   
        private void BusinessLayerAdding( string FunctionName, string FunctionType, string ClassName, string ConnectionString, List<clsColumnDetails> ArrayOfColumns)
        {
            functionBody.AppendLine($"public static {FunctionType} {FunctionName}(");
            functionBody.AppendLine(")");
            functionBody.AppendLine("{");
            functionBody.AppendLine($"    this.ID = {ClassName}.{FunctionName}(");
            foreach (clsColumnDetails column in ArrayOfColumns)
            {
                variables.AppendLine($"    this.{column.ColumnName},");
            }
            functionBody.Append(variables.ToString().TrimEnd(',', '\n'));
            functionBody.AppendLine(");");
            functionBody.AppendLine("    return (this.ID != -1);");
            functionBody.AppendLine("}");
            rtxtbString.Text = functionBody.ToString();
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(FunctionType, Color.Blue, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
        }
        private void BusinessLayerUpdating( string FunctionName, string FunctionType, string ClassName, string ConnectionString, List<clsColumnDetails> ArrayOfColumns)
        {
            functionBody.AppendLine($"public static {FunctionType} {FunctionName}(");
            functionBody.AppendLine(")");
            functionBody.AppendLine("{");
            functionBody.AppendLine("    return ");
            functionBody.AppendLine($" {ClassName}.{FunctionName}(");
            foreach (clsColumnDetails column in ArrayOfColumns)
            {
                variables.AppendLine($"this.{column.ColumnName},");
            }
            functionBody.AppendLine(");");
            functionBody.AppendLine("}");
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(FunctionType, Color.Blue, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
        }
        private void GenerateFindFunction(string FunctionName, string FunctionType, string ClassName, string ConnectionString, List<clsColumnDetails> ArrayOfColumns)
        {
            StringBuilder refParameters = new StringBuilder();
            StringBuilder constructorParameters = new StringBuilder();
            functionBody.AppendLine($"public static {FunctionType} {FunctionName}(int ID)");
            functionBody.AppendLine("{");
            functionBody.AppendLine("    // Add Type Of Variables");
            foreach (var column in ArrayOfColumns)
            {
                variables.AppendLine($"    {column.DateType} {column.ColumnName};");
                refParameters.AppendLine($"        ref {column.ColumnName},");
                constructorParameters.AppendLine($"        {column.ColumnName},");
            }
            functionBody.Append(variables.ToString());
            functionBody.AppendLine($"    bool IsFound = {ClassName}.{ConnectionString}(");
            functionBody.AppendLine("        ID,");
            functionBody.Append(refParameters.ToString().TrimEnd(',', '\n'));
            functionBody.AppendLine("    );");
            functionBody.AppendLine("    if (IsFound)");
            functionBody.AppendLine("    {");
            functionBody.AppendLine($"        return new // Add Your Constructor Name Here(");
            functionBody.AppendLine("            ID,");
            functionBody.Append(constructorParameters.ToString().TrimEnd(',', '\n'));
            functionBody.AppendLine("        );");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("    else");
            functionBody.AppendLine("    {");
            functionBody.AppendLine("        return null;");
            functionBody.AppendLine("    }");
            functionBody.AppendLine("}");
            rtxtbString.Text = functionBody.ToString();
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(FunctionType, Color.Blue, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
        }
        private void BusinessLayerDeleting(string FunctionName, string FunctionType, string ClassName, string ConnectionString)
        {
            functionBody.AppendLine($"public static {FunctionType} {FunctionName}(int ID)");
            functionBody.AppendLine("{");
            functionBody.AppendLine($"return {ClassName}.{ConnectionString}(ID)");
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(FunctionType, Color.Blue, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
            rtxtbString.Text = functionBody.ToString();

        }
        private void BusinessLayerAll(string FunctionName, string FunctionType, string ClassName, string ConnectionString)
        {
            functionBody.AppendLine($"public static {FunctionType} {FunctionName}()");
            functionBody.AppendLine("{");
            functionBody.AppendLine($"return {ClassName}.{ConnectionString}()");
            clsUtil.ColorText(FunctionName, Color.Yellow, rtxtbString);
            clsUtil.ColorText(FunctionType, Color.Blue, rtxtbString);
            clsUtil.ColorText(ClassName, Color.Green, rtxtbString);
            clsUtil.ColorText(ConnectionString, Color.Aqua, rtxtbString);
            rtxtbString.Text = functionBody.ToString();
        }
        private void ObjectFunctionHandle(List<clsColumnDetails> ArrayOfColumns)
        {
            StringBuilder variables = new StringBuilder();
            StringBuilder functionBody = new StringBuilder();

            foreach (clsColumnDetails column in ArrayOfColumns)
            {
                variables.AppendLine($"public {column.DateType} {column.ColumnName} {{ get; set; }}");
            }
            functionBody.AppendLine(variables.ToString());

            // Empty Constructor
            functionBody.AppendLine("public /*Add Your Constructor Name*/()");
            functionBody.AppendLine("{");
            foreach (clsColumnDetails column in ArrayOfColumns)
            {
                functionBody.AppendLine($"    this.{column.ColumnName} = default({column.DateType});");
            }
            functionBody.AppendLine("}");

            // Full Constructor
            functionBody.AppendLine("public /*Add Your Constructor Name*/(");
            variables.Clear(); // Clear the variables StringBuilder for reuse
            foreach (clsColumnDetails column in ArrayOfColumns)
            {
                variables.AppendLine($"{column.DateType} {column.ColumnName},");
            }
            functionBody.AppendLine(variables.ToString().TrimEnd(',', '\n')); // Remove the trailing comma
            functionBody.AppendLine(")");
            functionBody.AppendLine("{");
            foreach (clsColumnDetails column in ArrayOfColumns)
            {
                functionBody.AppendLine($"    this.{column.ColumnName} = {column.ColumnName};");
            }
            functionBody.AppendLine("}");

            rtxtbString.Text = functionBody.ToString();


        }
        private void PerformBusinessLayerGenerating()
        {
            //Instead of using a switch in the code i decided to use this simplified code which provides more flexibility in the code
            var actions = new Dictionary<EnCrudFunction, Action>
            {
                { EnCrudFunction.Creating, () => BusinessLayerAdding(txtFunctionName.Text, cbFunctionType.Text, txtClassName.Text, txtConnectionString.Text, dynamicArrayOfObjects) },
                { EnCrudFunction.Deleting, () => BusinessLayerDeleting(txtFunctionName.Text, cbFunctionType.Text, txtClassName.Text, txtConnectionString.Text) },
                { EnCrudFunction.Reading,  () => GenerateFindFunction(txtFunctionName.Text, cbFunctionType.Text, txtClassName.Text, txtConnectionString.Text, dynamicArrayOfObjects) },
                { EnCrudFunction.Updating, () => BusinessLayerUpdating(txtFunctionName.Text, cbFunctionType.Text, txtClassName.Text, txtConnectionString.Text, dynamicArrayOfObjects) },
                { EnCrudFunction.All,      () => BusinessLayerAll(txtFunctionName.Text, cbFunctionType.Text, txtClassName.Text, txtConnectionString.Text) },
                { EnCrudFunction.Object,      () => ObjectFunctionHandle(dynamicArrayOfObjects)
                }
            };
                if (actions.TryGetValue(_CrudMode, out var action)){ action(); }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnCopy.Enabled = true; 
            if (rtxtbString.Text.Length > 0){  rtxtbString.Text = ""; }
            if (dynamicArrayOfObjects.Count == 0 && rbObject.Checked == false)
            {
                errorProvider1.SetError(btnGenerate, "Write Some Columns to Generate Your Function");
                return;
            }
            else
            {
                errorProvider1.SetError(btnGenerate, "");
            }
            // Action is is a delegate type in C# that represents a method that takes no parameters and returns no value.
            // It’s perfect for methods like PerformDataLayerGenerating and PerformBusinessLayerGenerating which don’t return anything.
            Action generateFunction = _FunctionMode == EnFunction.DataLayer ? (Action)PerformDataLayerGenerating : PerformBusinessLayerGenerating;
            generateFunction();            
        }
        private void cbFunctionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbCrudChoices.Enabled = true;
            gbColumnChoices.Enabled = true;
            btnGenerate.Enabled = true;
            btnAdding.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            rtxtbString.Clear();
            functionBody.Clear();
            dynamicArrayOfObjects.Clear();
            dataGridView1.Rows.Clear();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (rtxtbString.Text.Length > 0)
            { 
                Clipboard.SetText(rtxtbString.Text);
                MessageBox.Show("Your Function Is Copied Successfully.", "Congratulations",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your Function Is Empty. Generate A Function To Copy.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rbDataLayer_Click(object sender, EventArgs e)
        {
            _FunctionMode = EnFunction.DataLayer;
            txtTableName.Enabled = true;
            gbTableChoices.Enabled = true;
        }
    }
}