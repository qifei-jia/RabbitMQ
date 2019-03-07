using RabbitMQ.Client;
using System;
using System.Text;

namespace Rabbit.MQTools
{
    public class RabbitMQHelper
    {
        /// <summary>
        /// 向MQ发送数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string send(mqModel model)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();
                factory.HostName = model.IP;// Constants.MqHost;
                factory.Port = Convert.ToInt32(model.Port);// 5672;// Constants.MqPort;
                factory.UserName = model.userName;//Constants.MqUserName;
                factory.Password = model.pwd;// Constants.MqPwd;
                using (IConnection conn = factory.CreateConnection())
                {
                    using (IModel channel = conn.CreateModel())
                    {
                        //在MQ上定义一个持久化队列，如果名称相同不会重复创建
                        channel.QueueDeclare(model.ToPic, true, false, false, null);
                        byte[] bytes = Encoding.UTF8.GetBytes(model.content);
                        //设置消息持久化
                        IBasicProperties properties = channel.CreateBasicProperties();
                        properties.DeliveryMode = 2;
                        channel.BasicPublish("", model.ToPic, properties, bytes);

                        return string.Format("[{0}]消息已发送：{1}", model.ToPic, model.content);

                    }
                }
            }
            catch (Exception ex)
            {
                return string.Format("[{0}]消息发送异常：{1}", model.ToPic, ex.Message);
            }
        }

        
    }
}
