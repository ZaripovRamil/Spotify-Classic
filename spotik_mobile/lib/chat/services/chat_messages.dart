import 'package:flutter/material.dart';
import 'package:spotik_mobile/models/entity/chat/message.dart';

class ChatMessages extends ChangeNotifier {
  late List<Message> messages;

  ChatMessages() {
    messages = [];
  }

  void addAll(Iterable<Message> ms) {
    messages.addAll(ms);
    notifyListeners();
  }

  void add(Message message) {
    messages.add(message);
    notifyListeners();
  }
}