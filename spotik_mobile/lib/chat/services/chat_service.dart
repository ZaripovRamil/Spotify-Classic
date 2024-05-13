import 'package:flutter/material.dart';
import 'package:spotik_mobile/models/entity/chat/message.dart';

class ChatService extends ChangeNotifier{
  void sendMessage(String message){
    var currentUserName = "";
    var timestamp = DateTime.now();
    var newMessage = Message(
      groupName: currentUserName,
      user: currentUserName,
      timestamp: timestamp,
      message: message,
      isOwner: true);
  }
}