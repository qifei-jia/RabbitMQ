using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.My.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rabbit.MQTools
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            GetSkin("0.ssk");
        }
        private Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
        private void GetSkin(string skinName)
        {
            skin.SkinFile = Application.StartupPath + @"\skin\" + skinName;// @"\skin\0.ssk"; //0.ssk是皮肤文件 
            skin.Active = true;
            skin.SkinAllForm = true;
        }
        // 申明委托，与父窗体方法类型相同
        public delegate void ParentFunDelegate();
        // 用来接收父窗体方法的委托变量
        public ParentFunDelegate parentFunDelegate;
        private void btnSave_Click(object sender, EventArgs e)
        {
            string ordder_sql = string.Format("select * from mq_main where ToPic='{0}'", txt_topic.Text.Trim());
            DataTable dtc = new SQLiteBLL().SelectTable(main.SqlDBSavePath, ordder_sql);
            if (dtc.Rows.Count > 0)
            {
                MessageBox.Show(txt_topic.Text.Trim() + " 数据已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dic = new Dictionary<string, object>();
            dic["userName"] = txt_username.Text.Trim();
            dic["pwd"] = txt_pwd.Text.Trim();
            dic["IP"] = txt_ip.Text.Trim();
            dic["Port"] = txt_port.Text.Trim();
            dic["ToPic"] = txt_topic.Text.Trim();
            new SQLiteBLL().Insert(main.SqlDBSavePath, "mq_main", dic);
            parentFunDelegate();
            this.Close();
        }
    }
}
