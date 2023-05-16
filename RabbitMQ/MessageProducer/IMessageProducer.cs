﻿namespace RabbitMQ.MessageProducer
{
    public interface IMessageProducer
    {
        void SendMessage<T>(T message, string queueName);
    }
}