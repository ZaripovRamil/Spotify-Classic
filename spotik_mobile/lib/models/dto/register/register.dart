import 'package:freezed_annotation/freezed_annotation.dart';

part 'register.freezed.dart';
part 'register.g.dart';

@freezed
class RegisterDto with _$RegisterDto {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory RegisterDto (
      {
        required bool isSuccessful,
        required String? userId,
        required String resultMessage
      }) = _RegisterDto;

  factory RegisterDto.fromJson(Map<String, dynamic> json) => _$RegisterDtoFromJson(json);
}