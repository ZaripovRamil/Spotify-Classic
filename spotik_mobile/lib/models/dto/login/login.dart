import 'package:freezed_annotation/freezed_annotation.dart';

part 'login.freezed.dart';
part 'login.g.dart';

@freezed
class LoginDto with _$LoginDto {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory LoginDto (
      {
        required bool isSuccessful,
        required String token,
        required String resultMessage
      }) = _LoginDto;

  factory LoginDto.fromJson(Map<String, dynamic> json) => _$LoginDtoFromJson(json);
}