import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class MessageBubble extends StatelessWidget {
  final String message;
  final String sender;
  final DateTime time;
  final bool isMe;

  const MessageBubble({
    super.key,
    required this.message,
    required this.sender,
    required this.time,
    required this.isMe,
  });

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment:
      isMe ? CrossAxisAlignment.end : CrossAxisAlignment.start,
      children: [
        Text(
          isMe ? sender : "Admin",
          style: TextStyle(
            fontWeight: FontWeight.bold,
            color: Colors.grey[600],
          ),
        ),
        Container(
          decoration: BoxDecoration(
            color: isMe ? CustomColors.goldenColor : Colors.grey[300],
            borderRadius: BorderRadius.only(
              topLeft: const Radius.circular(12),
              topRight: const Radius.circular(12),
              bottomLeft: isMe ? const Radius.circular(12) : const Radius.circular(0),
              bottomRight: isMe ? const Radius.circular(0) : const Radius.circular(12),
            ),
          ),
          padding: const EdgeInsets.symmetric(vertical: 10, horizontal: 16),
          margin: const EdgeInsets.symmetric(vertical: 4, horizontal: 8),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text(
                message,
                style: const TextStyle(color: Colors.black),
              ),
              const SizedBox(height: 4),
              Text(
                DateFormat('d MMM. HH:mm').format(time),
                style: TextStyle(
                  fontSize: 10,
                  color: Colors.grey[600],
                ),
              ),
            ],
          ),
        ),
      ],
    );
  }
}