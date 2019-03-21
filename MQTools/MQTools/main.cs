using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.My.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rabbit.MQTools
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        public static string SqlDBSavePath
        {
            get
            {
                return "Data Source=" + Path.Combine(Application.StartupPath, "MQ\\MQ.db");
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            GetSkin("0.ssk");     //换肤,0.ssk是皮肤文件
            BindTopic();
            txt_send.Text = "[-1] 发送数据，请填写发送内容！\r\n";
            //[-2] 消费数据目前是手动触发消费，每次一条数据！\n
        }
        private Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
        private void GetSkin(string skinName)
        {
            skin.SkinFile = Application.StartupPath + @"\skin\" + skinName;// @"\skin\0.ssk"; //0.ssk是皮肤文件 
            skin.Active = true;
            skin.SkinAllForm = true;
        }
        static List<mqModel> items = new List<mqModel>();
        public void BindTopic()
        {
            try
            {
                cbx_Topic.Items.Clear();
                string type_sql = string.Format("select * from mq_main order by orderNo");
                DataTable dt_type = new SQLiteBLL().SelectTable(SqlDBSavePath, type_sql);
                //cbx_Topic.Items.Add("--请选择--");
                foreach (DataRow dr in dt_type.Rows)
                {
                    cbx_Topic.Items.Add(dr["ToPic"].ToString());
                    mqModel model = new mqModel();
                    model.userName = dr["userName"].ToString();
                    model.pwd = dr["pwd"].ToString();
                    model.IP = dr["IP"].ToString();
                    model.Port = dr["Port"].ToString();
                    model.ToPic = dr["ToPic"].ToString();
                    model.orderNo = Convert.ToInt32(dr["orderNo"].ToString() != "" ? dr["orderNo"].ToString() : "0");
                    items.Add(model);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //cbx_Topic.SelectedIndex=0;
        }
        /// <summary>
        /// 选择Topic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_Topic_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string topic = cbx_Topic.SelectedItem.ToString();
                if (topic != "- 请选择 -")
                {
                    if (items.Count > 0)
                    {
                        mqModel item = items.Where(r => r.ToPic == topic).FirstOrDefault<mqModel>();
                        if (item != null)
                        {
                            SetText(item);
                        }
                        else
                        {
                            SetText(selectByTopic(topic));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public mqModel selectByTopic(string topic)
        {
            string type_sql = string.Format("select * from mq_main where ToPic='{0}'", topic);
            DataTable dt_type = new SQLiteBLL().SelectTable(SqlDBSavePath, type_sql);
            mqModel model = new mqModel();
            foreach (DataRow dr in dt_type.Rows)
            {
                model.userName = dr["userName"].ToString();
                model.pwd = dr["pwd"].ToString();
                model.IP = dr["IP"].ToString();
                model.Port = dr["Port"].ToString();
                model.ToPic = dr["ToPic"].ToString();
                model.orderNo = Convert.ToInt32(dr["orderNo"].ToString() != "" ? dr["orderNo"].ToString() : "0");

            }
            return model;
        }
        public void SetText(mqModel model)
        {
            txt_ip.Text = model.IP;
            txt_port.Text = model.Port;
            txt_username.Text = model.userName;
            txt_pwd.Text = model.pwd;
            txt_topic.Text = model.ToPic;
        }
        RabbitMQHelper rabbit = new RabbitMQHelper();
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            mqModel model = new mqModel();
            model.userName = txt_username.Text;
            model.pwd = txt_pwd.Text;
            model.IP = txt_ip.Text;
            model.Port = txt_port.Text;
            model.ToPic = txt_topic.Text;
            model.content = replactStr(txt_sendcontent.Text);
            txt_send.Text = "\r\n ==" + DateTime.Now.ToString("HH:mm:ss") + "==" + rabbit.send(model) + "\r\n" + txt_send.Text + "\r\n";
        }
        /// <summary>
        /// 随机数处理
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string replactStr(string str)
        {
            if (chb_guid.Checked)
            {
                str = str.Replace(txt_guid.Text.Trim(), Guid.NewGuid().ToString());
            }
            if (chb_random.Checked)
            {
                str = str.Replace(txt_random.Text.Trim(), new Random().Next(10000000).ToString());
            }
            if (chb_param1.Checked)
            {
                str = str.Replace(txt_param11.Text.Trim(), txt_param111.Text.Trim());
            }
            if (chb_param2.Checked)
            {
                str = str.Replace(txt_param22.Text.Trim(), txt_param222.Text.Trim());
            }
            if (chb_param3.Checked)
            {
                str = str.Replace(txt_param33.Text.Trim(), txt_param333.Text.Trim());
            }
            return str;
        }
        Thread thread;
        /// <summary>
        /// 消费MQ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsume_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            ThreadStart threadStart = new ThreadStart(Calculate);
            thread = new Thread(threadStart);
            thread.Start();

        }
        delegate void changeText(string result);
        public void Calculate()
        {
            mqModel model = new mqModel();
            model.userName = txt_username.Text;
            model.pwd = txt_pwd.Text;
            model.IP = txt_ip.Text;
            model.Port = txt_port.Text;
            model.ToPic = txt_topic.Text;
            consume(model);
        }
        public void CalcFinished(string result)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new changeText(CalcFinished), result);
            }
            else
            {
                this.txt_consume.Text = result.ToString();
            }
        }
        public void CalcFinishedLog(string result)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new changeText(CalcFinishedLog), result);
            }
            else
            {
                this.txt_send.Text = "\r\n ==" + DateTime.Now.ToString("HH:mm:ss") + "[MQ消费数据]==" + result+ "\r\n" + txt_send.Text + "\r\n";
            }
        }
        public void CalcFinishedEx(string result)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new changeText(CalcFinishedEx), result);
            }
            else
            {
                this.txt_consume.Text = result.ToString();
            }
        }
        /// <summary>
        /// MQ消费
        /// </summary>
        /// <param name="model"></param>
        public void consume(mqModel model)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();
                factory.HostName = model.IP;
                factory.Port = Convert.ToInt32(model.Port);// 5672;
                factory.UserName = model.userName;
                factory.Password = model.pwd;
                using (IConnection conn = factory.CreateConnection())
                {
                    using (IModel channel = conn.CreateModel())
                    {
                        //在MQ上定义一个持久化队列，如果名称相同不会重复创建
                        channel.QueueDeclare(model.ToPic, true, false, false, null);

                        //输入1，那如果接收一个消息，但是没有应答，则客户端不会收到下一个消息
                        channel.BasicQos(0, 1, false);

                        Console.WriteLine("Listening...");

                        //在队列上定义一个消费者
                        QueueingBasicConsumer consumer = new QueueingBasicConsumer(channel);
                        //消费队列，并设置应答模式为程序主动应答
                        channel.BasicConsume(model.ToPic, false, consumer);
                        int i = 0;
                        while (true)
                        {
                            //阻塞函数，获取队列中的消息
                            BasicDeliverEventArgs ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                            byte[] bytes = ea.Body;
                            string str = Encoding.UTF8.GetString(bytes);
                            string result = string.Format("[{0}]--{1}", i++, str) + "\r\n" + txt_consume.Text + "\r\n";
                            CalcFinishedLog(string.Format("[{0}]--{1}", i++, str));
                            CalcFinished(result);
                            //回复确认
                            channel.BasicAck(ea.DeliveryTag, false);
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                CalcFinishedEx(e1.Message);
            }
        }

        private void 参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addtype = new AddForm();
            addtype.parentFunDelegate = ParentFun;
            addtype.ShowDialog();
        }
        #region 回调父窗体事件
        // 父窗体的方法
        void ParentFun()
        {
            main_Load(null, null);
        }
        #endregion

        private void btnStop_Click(object sender, EventArgs e)
        {
            thread.Abort();
        }
    }
}
