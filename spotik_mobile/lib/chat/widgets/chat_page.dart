import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/chat/services/chat_messages.dart';
import 'package:spotik_mobile/chat/services/chat_service.dart';
import 'package:spotik_mobile/chat/widgets/message_bubble.dart';
import 'package:spotik_mobile/models/entity/chat/message.dart';
import 'package:spotik_mobile/utils/context.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class ChatPage extends StatelessWidget {
  const ChatPage({super.key});

  @override
  Widget build(BuildContext context) {
    return Center(
        child: Padding(
            padding: const EdgeInsets.all(20),
            child: Scaffold(
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
              body: const LoadingChat(),
            )));
  }
}

class ChatWidget extends StatefulWidget {
  const ChatWidget({super.key, required this.chatService});

  final ChatService chatService;

  @override
  State<ChatWidget> createState() => _ChatWidgetState();
}

class _ChatWidgetState extends State<ChatWidget> {
  final TextEditingController _messageController = TextEditingController();

  final ScrollController _scrollController = ScrollController();

  @override
  Widget build(BuildContext context) {
    return Column(children: [
      Consumer<ChatMessages>(builder:
          (BuildContext context, ChatMessages chatMessages, Widget? child) {
        return Expanded(child: _buildMessageList(chatMessages.messages));
      }),
      _buildMessageInput()
    ]);
  }

  @override
  void dispose() {
    _scrollController.dispose();
    _messageController.dispose();
    widget.chatService.shutdown();
    super.dispose();
  }

  @override
  void initState() {
    super.initState();
    WidgetsBinding.instance.addPostFrameCallback((_) {
      _scrollToBottom();
    });
  }

  void _scrollToBottom() {
    _scrollController.animateTo(
      _scrollController.position.maxScrollExtent,
      duration: const Duration(milliseconds: 300),
      curve: Curves.easeInOut,
    );
  }

  Widget _buildMessageItem(Message m) {
    return MessageBubble(
        message: m.message,
        sender: m.groupName,
        time: m.timestamp.toLocal(),
        isMe: m.isOwner
    );
  }

  Widget _buildMessageList(List<Message> messages) {
    WidgetsBinding.instance.addPostFrameCallback((_) {
      _scrollToBottom();
    });
    return ListView.builder(
        controller: _scrollController,
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
              onPressed: () async {
                await sendMessage(_messageController.text);
                _messageController.clear();
              },
              icon: const Icon(Icons.send),
              iconSize: 26,
            )),
        obscureText: false,
      ),
    );
  }

  Future<void> sendMessage(String content) async {
    await widget.chatService.sendChatMessage(content);
  }
}

class LoadingChat extends StatefulWidget {
  const LoadingChat({super.key});

  @override
  State<LoadingChat> createState() => _LoadingChatState();
}

class _LoadingChatState extends State<LoadingChat> {
  late ChatWidget _chatWidget;
  Context ctx = Context();

  @override
  Widget build(BuildContext context) {
    return Consumer<ChatService>(builder:
        (BuildContext context, ChatService chatService, Widget? child) {
      return FutureBuilder(
        future: _loadChat(chatService),
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.done) {
            final bool? ok = snapshot.data;
            if (ok == null) {
              return const Center(child: CircularProgressIndicator());
            }

            if (!ok) {
              return const Text(
                  'Something went wrong while connecting to the server');
            }

            return _chatWidget;
          } else {
            return const Center(child: CircularProgressIndicator());
          }
        },
      );
    });
  }

  @override
  void dispose() {
    ctx.stop();
    super.dispose();
  }

  Future<bool> _loadChat(ChatService chatService) async {
    try {
      _chatWidget = ChatWidget(chatService: chatService);
      await chatService.joinChat();
      chatService.startReceivingMessages(ctx);
      return true;
    } catch (ex) {
      await chatService.shutdown();
      return false;
    }
  }
}
