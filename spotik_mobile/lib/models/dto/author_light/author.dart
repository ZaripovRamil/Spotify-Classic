import 'package:freezed_annotation/freezed_annotation.dart';

part 'author.freezed.dart';
part 'author.g.dart';

@freezed
class AuthorLight with _$AuthorLight {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory AuthorLight (
      {
        required String id,
        required String name,
      }) = _AuthorLight;

  factory AuthorLight.fromJson(Map<String, dynamic> json) => _$AuthorLightFromJson(json);
}