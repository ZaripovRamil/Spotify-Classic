import 'package:freezed_annotation/freezed_annotation.dart';

part 'message.freezed.dart';
part 'message.g.dart';

@freezed
class Message with _$Message {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory Message (
      {
        required String groupName,
        required String user,
        required DateTime timestamp,
        required String message,
        required bool isOwner,
      }) = _Message;

  factory Message.fromJson(Map<String, dynamic> json) => _$MessageFromJson(json);
}
