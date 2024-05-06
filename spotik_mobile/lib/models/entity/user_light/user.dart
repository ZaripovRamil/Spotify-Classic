import 'package:freezed_annotation/freezed_annotation.dart';

part 'user.freezed.dart';
part 'user.g.dart';

@freezed
class User with _$User {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory User (
      {
        required String id,
        required String profilePicId,
        required String name,
        required String? username,
      }) = _User;

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);
}