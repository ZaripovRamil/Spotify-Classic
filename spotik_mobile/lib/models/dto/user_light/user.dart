import 'package:freezed_annotation/freezed_annotation.dart';

part 'user.freezed.dart';
part 'user.g.dart';

@freezed
class UserLight with _$UserLight {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory UserLight (
      {
        required String id,
        required String profilePicId,
        required String name,
        required String? username,
      }) = _UserLight;

  factory UserLight.fromJson(Map<String, dynamic> json) => _$UserLightFromJson(json);
}