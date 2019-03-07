using System.Collections.Generic;
using System.Data.SQLite;

namespace System.Data.My.SQLite
{
    public class SQLiteBLL
    {
        #region insert
        /// <summary>
        /// 新增数据
        /// author：jqf
        /// </summary>
        /// <param name="DataSource">db文件</param>
        /// <param name="tableName">表名</param>
        /// <param name="dic">字段值</param>
        public void Insert(string DataSource, string tableName, Dictionary<string, object> dic)
        {
            //var dic = new Dictionary<string, object>();
            //dic["name"] = txtProductName.Text;
            //dic["datepurchase"] = dateTimePicker1.Value;
            //dic["qty"] = numericUpDown_Quantity.Value;
            //dic["price"] = numericUpDown_Price.Value;
            using (SQLiteConnection conn = new SQLiteConnection(DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Insert(tableName, dic);
                    conn.Close();
                }
            }
        }
        #endregion
        #region delete
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataSource"></param>
        /// <param name="tableName"></param>
        /// <param name="Where"> a='1234'</param>
        public void DeleteTable(string DataSource, string tableName, string Where = "")
        {
            using (SQLiteConnection conn = new SQLiteConnection(DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.DeleteTable(tableName, Where);
                    conn.Close();
                }
            }
        }
        #endregion
        #region Select
        public DataTable SelectTable(string DataSource, string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    DataTable dt = sh.Select(sql);

                    conn.Close();
                    return dt;
                }
            }
        }
        #endregion
        #region Execute
        public void Execute(string DataSource, string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Execute(sql);

                    conn.Close();

                }
            }
        }
        #endregion
        #region ExecuteScalar
        public object ExecuteScalar(string DataSource, string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    var obj = sh.ExecuteScalar(sql);

                    conn.Close();
                    return obj;
                }
            }
        }
        #endregion
    }
}
