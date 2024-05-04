import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/dto/author_light/author.dart';

part 'album.freezed.dart';
part 'album.g.dart';

@freezed
class AlbumLight with _$AlbumLight {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory AlbumLight (
      {
        required String id,
        required String previewId,
        required String name,
        required AuthorLight author
      }) = _AlbumLight;

  factory AlbumLight.fromJson(Map<String, dynamic> json) => _$AlbumLightFromJson(json);
}