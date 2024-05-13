import 'package:flutter/material.dart';
import 'package:spotik_mobile/chat/services/chat_service.dart';
import 'package:spotik_mobile/models/entity/chat/message.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class ChatPage extends StatelessWidget {
  ChatPage({super.key});

  final TextEditingController _messageController = TextEditingController();
  final ChatService _chatService = ChatService();

  void sendMessage() {
    if (_messageController.text.isNotEmpty) {
      _chatService.sendMessage(_messageController.text);
      _messageController.clear();
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.transparent,
      appBar: AppBar(
        backgroundColor: Colors.transparent,
        iconTheme: Theme.of(context).iconTheme,
        title: const Text('Support Chat',
            style: TextStyle(
              fontSize: TextSize.mediumTextSize,
              fontWeight: FontWeight.bold,
              color: CustomColors.goldenColor,
            )),
      ),
      body: Column(
        children: [
          Expanded(child: _buildMessageList(
            List<Message>.generate(4, (index) => Message(groupName: "group name $index", user: "user", timestamp: DateTime.now(), message: "message", isOwner: true))
          )),
          _buildMessageInput(),
        ],
      ),
    );
  }

  Widget _buildMessageItem(Message messageItem) {
    var aligment = (messageItem.isOwner)? Alignment.centerLeft: Alignment.centerRight;
    return Container(
      alignment: aligment,
      child: Column(children: [
        Text("${messageItem.user}"),
        Text("${messageItem.message}"),

      ],),
    );
  }

  Widget _buildMessageList(List<Message> messages) {
    return ListView.builder(
      
      itemCount: messages.length,
      itemBuilder: (context, i) => _buildMessageItem(messages[i]));
  }

  Widget _buildMessageInput() {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 16.0, horizontal: 8.0),
      child: TextField(
        controller: _messageController,
        decoration: InputDecoration(
            hintText: "Enter message",
            suffixIcon: IconButton(
              onPressed: sendMessage,
              icon: const Icon(Icons.send),
              iconSize: 26,
            )),
        obscureText: false,
      ),
    );
  }
}

class MessageList extends StatelessWidget {
  const MessageList({super.key});

  @override
  Widget build(BuildContext context) {
    return const Placeholder();
  }
}
