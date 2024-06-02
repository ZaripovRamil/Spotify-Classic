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

  late Channel _channel;
  late Queue _queue;
  late Consumer _consumer;

  void startListening(String queueName, Function(Map<dynamic, dynamic>) callback) async {
    _channel = await _client.channel();
    _queue = await _channel.queue(queueName, durable: true, passive: true, declare: false);
    _consumer = await _queue.consume();
    _consumer.listen((event) {
      event.ack();
      final payload = event.payloadAsJson;
      callback(payload);
    });
  }

  void closeConnection() {
    _consumer.cancel();
    _channel.close();
  }
}