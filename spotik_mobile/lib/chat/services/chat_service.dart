import 'package:flutter/material.dart';
import 'package:grpc/grpc.dart';
import 'package:spotik_mobile/chat/generated/chat.pbgrpc.dart';
import 'package:spotik_mobile/chat/generated/google/protobuf/empty.pb.dart';
import 'package:spotik_mobile/chat/services/chat_messages.dart';
import 'package:spotik_mobile/models/entity/chat/message.dart';
import 'package:spotik_mobile/utils/context.dart';
import 'package:spotik_mobile/utils/storage.dart';

class ChatService extends ChangeNotifier {
  late ClientChannel _channel;
  late ChatClient _stub;
  late ChatMessages _messages;
  late String _host;
  late int _port;

  ChatService(String host, int port, ChatMessages chatMessages) {
    _channel = ClientChannel(
      host,
      port: port,
      options: const ChannelOptions(
        credentials: ChannelCredentials.insecure(),
      ),
    );
    _host = host;
    _port = port;
    _stub = ChatClient(_channel);
    _messages = chatMessages;
  }

  Future<void> startReceivingMessages(Context ctx) async {
    while (!ctx.stopped) {
      try {
        await for (var message in _stub.startReceivingMessages(Empty(),
            options: CallOptions(metadata: await _getHeaders()))) {
          _messages.add(Message(
              groupName: message.user,
              user: message.user,
              timestamp: message.timestamp.toDateTime(),
              message: message.content,
              isOwner: message.isOwner));
        }
      } catch (e) {
        await shutdown();
        _channel = ClientChannel(_host, port: _port,
            options: const ChannelOptions(
                credentials: ChannelCredentials.insecure()));
        _stub = ChatClient(_channel);
      }
    }
  }

  Future<void> joinChat() async {
    try {
      var history = await _stub.joinChat(Empty(), options: CallOptions(metadata: await _getHeaders()));
      _messages.addAll(
          history.messages.map((e) => Message(
              groupName: e.user,
              user: e.user,
              timestamp: e.timestamp.toDateTime(),
              message: e.content,
              isOwner: e.isOwner)));
    } catch (e) {
      // ignored
    }
  }

  Future<void> sendChatMessage(String content) async {
    try {
      await _stub.sendChatMessage(ChatMessageRequest()..content = content,
          options: CallOptions(metadata: await _getHeaders()));
    } catch (e) {
      throw Exception("Error while sending the message");
    }
  }

  Future<void> shutdown() async {
    await _channel.shutdown();
  }

  Future<Map<String, String>> _getHeaders() async {
    var token = await Storage.getToken();
    var headers = {
      'Authorization': 'Bearer $token'
    };
    return headers;
  }
}