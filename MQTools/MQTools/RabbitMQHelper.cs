using RabbitMQ.Client;
using System;
using System.Text;

namespace Rabbit.MQTools
{
    public class RabbitMQHelper
    {

        //queueDeclare(String queue,boolean durable,boolean exclusive, Map<String, Object> arguments);
        //durable： 是否持久化  exclusive：是否排外的  autoDelete：是否自动删除
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
                try
                {
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
                catch (Exception)
                {
                    //The AMQP operation was interrupted: AMQP close-reason, initiated by Peer, code=406, text="PRECONDITI
                    using (IConnection conn = factory.CreateConnection())
                    {
                        using (IModel channel = conn.CreateModel())
                        {
                            //在MQ上定义一个持久化队列，如果名称相同不会重复创建

                            //channel.ExchangeDeclare("World", "direct");
                            channel.QueueDeclare(model.ToPic, false, false, false, null);

                            byte[] bytes = Encoding.UTF8.GetBytes(model.content);
                            //设置消息持久化
                            IBasicProperties properties = channel.CreateBasicProperties();
                            properties.DeliveryMode = 2;
                            channel.BasicPublish("", model.ToPic, properties, bytes);

                            return string.Format("[{0}]消息已发送：{1}", model.ToPic, model.content);

                        }
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
