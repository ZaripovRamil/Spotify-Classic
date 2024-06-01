using System.Text;
using System.Text.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Utils.RabbitMq;

public interface IRabbitMqService
{
    public void CreateQueue(string queueName, Dictionary<string, object>? args = null);
    public void CreateExchange(string exchangeName, string exchangeType);
    public void BindQueueToExchange(string queueName, string exchangeName, string routingKey);
    public void PublishMessage<T>(string exchangeName, string routingKey, T message);
    public void RegisterConsumer<T>(string queueName, Action<T> action);
}

public class RabbitMqService : IRabbitMqService
{
    private readonly ConnectionFactory _connFactory;

    public RabbitMqService(ConnectionFactory connFactory)
    {
        _connFactory = connFactory;
    }

    public void CreateQueue(string queueName, Dictionary<string, object>? args = null)
    {
        using var conn = _connFactory.CreateConnection();
        using var channel = conn.CreateModel();
        channel.QueueDeclare(queue: queueName,
            durable: true,
            exclusive: false,
            autoDelete: false,
            arguments: args);
    }
    
    public void CreateExchange(string exchangeName, string exchangeType)
    {
        using var conn = _connFactory.CreateConnection();
        using var channel = conn.CreateModel();
        channel.ExchangeDeclare(exchange: exchangeName,
            type: exchangeType,
            durable: true);
    }
    
    public void BindQueueToExchange(string queueName, string exchangeName, string routingKey)
    {
        using var conn = _connFactory.CreateConnection();
        using var channel = conn.CreateModel();
        channel.QueueBind(queue: queueName,
            exchange: exchangeName,
            routingKey: routingKey);
    }
    
    public void PublishMessage<T>(string exchangeName, string routingKey, T message)
    {
        using var conn = _connFactory.CreateConnection();
        using var channel = conn.CreateModel();
        var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));
        channel.BasicPublish(exchange: exchangeName,
            routingKey: routingKey,
            basicProperties: null,
            body: body);
    }
    
    public void RegisterConsumer<T>(string queueName, Action<T> action)
    {
        using var conn = _connFactory.CreateConnection();
        using var channel = conn.CreateModel();
        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += (_, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(body));
            action(message!);
        };
        channel.BasicConsume(queue: queueName,
            autoAck: true,
            consumer: consumer);
    }
}