using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTools
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql = $@"SELECT
                  COLUMN_NAME name,
                  DATA_TYPE datatype,
                  COLUMN_COMMENT remark
                FROM
                 INFORMATION_SCHEMA.COLUMNS
                where
                table_name = '{this.cmb_tables.SelectedValue}'";
            IEnumerable<dynamic> tables = null;
            using (IDbConnection conn = GetConn())
            {
                conn.Open();
                tables = conn.Query<dynamic>(sql);
            }
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"using System;");
            builder.AppendLine($"using System.Collections.Generic;");
            builder.AppendLine($"using System.Text;");
            builder.AppendLine($"namespace {this.tb_namespace.Text}");
            builder.AppendLine("{");
            builder.AppendLine($"    public class {this.cmb_tables.SelectedValue} : AggregateRoot");
            builder.AppendLine("    {");
            foreach (var item in tables)
            {
                if (item.name != "Id")
                {
                    builder.AppendLine("        /// <summary>");
                    builder.AppendLine($"        /// {item.remark}");
                    builder.AppendLine("        /// <summary>");
                    builder.AppendLine($"        public {GetDataType(item.datatype)} {item.name} {{ get; set; }}");
                }

            }
            builder.AppendLine("    }");
            builder.AppendLine("}");
            string path = "D:\\output\\";
            string fullPath = path + this.cmb_tables.SelectedValue + ".cs";
            if (!Directory.Exists(path))//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(path);
            }

            StreamWriter sw = new StreamWriter(fullPath, false, Encoding.Default);
            sw.WriteLine(builder.ToString());
            sw.Flush();
            sw.Close();
            MessageBox.Show("生成完毕！");
        }
        private IDbConnection GetConn()
        {
            return new MySqlConnection($"Database={this.tb_lib.Text.Trim()};Data Source={this.tb_connection.Text.Trim()};User Id={this.tb_username.Text.Trim()};Password={this.tb_pwd.Text.Trim()};Connect Timeout=600");
        }
        private void btn_selecttables_Click(object sender, EventArgs e)
        {
            IEnumerable<string> tables = null;
            using (IDbConnection conn = GetConn())
            {
                conn.Open();
                tables = conn.Query<string>($"select table_name from information_schema.tables where table_schema='{this.tb_lib.Text.Trim()}'");
            }
            this.cmb_tables.DataSource = tables;
        }

        private string GetDataType(string dataType)
        {
            string typeString = "object";
            switch (dataType)
            {
                case "int":
                    typeString = "int";
                    break;
                case "text":
                    typeString = "string";
                    break;
                case "bigint":
                    typeString = "int";
                    break;
                case "binary":
                    typeString = "byte[]";
                    break;
                case "bit":
                    typeString = "bool";
                    break;
                case "char":
                    typeString = "string";
                    break;
                case "datetime":
                    typeString = "DateTime";
                    break;
                case "decimal":
                    typeString = "decimal";
                    break;
                case "float":
                    typeString = "double";
                    break;
                case "image":
                    typeString = "byte[]";
                    break;
                case "money":
                    typeString = "decimal";
                    break;
                case "nchar":
                    typeString = "string";
                    break;
                case "ntext":
                    typeString = "string";
                    break;
                case "numeric":
                    typeString = "decimal";
                    break;
                case "nvarchar":
                    typeString = "string";
                    break;
                case "real":
                    typeString = "System.Single";
                    break;
                case "smalldatetime":
                    typeString = "DateTime";
                    break;
                case "smallint":
                    typeString = "int";
                    break;
                case "smallmoney":
                    typeString = "decimal";
                    break;
                case "timestamp":
                    typeString = "DateTime";
                    break;
                case "tinyint":
                    typeString = "byte";
                    break;
                case "uniqueidentifier":
                    typeString = "System.Guid";
                    break;
                case "varbinary":
                    typeString = "byte[]";
                    break;
                case "varchar":
                    typeString = "string";
                    break;
                case "Variant":
                    typeString = "object";
                    break;
                default:
                    typeString = "object";
                    break;
            }
            return typeString;
        }
    }

}
