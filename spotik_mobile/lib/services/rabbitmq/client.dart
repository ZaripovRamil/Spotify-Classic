import 'package:dart_amqp/dart_amqp.dart';
import 'package:spotik_mobile/utils/config/rabbitmq_config.dart';

class RabbitMQListener {
  static final _client = Client(
      settings: ConnectionSettings(
        host: RabbitMqConfig.host,
        authProvider: PlainAuthenticator(
            RabbitMqConfig.username,
            RabbitMqConfig.password
        ),
      )
  );

  Channel? _channel;
  Consumer? _consumer;

  void startListening(String queueName, Function(Map<dynamic, dynamic>) callback) async {
    _channel = await _client.channel();
    final exchange = await _channel!.exchange(queueName, ExchangeType.FANOUT, declare: false);
    _consumer = await exchange.bindQueueConsumer(queueName, [queueName], noAck: true, durable: true, passive: true, declare: false);
    _consumer!.listen((event) {
      final payload = event.payloadAsJson;
      callback(payload);
    });
  }

  void closeConnection() {
    _consumer?.cancel();
    _channel?.close();
  }
}