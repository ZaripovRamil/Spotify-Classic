import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/dto/album_light/album.dart';

part 'track.freezed.dart';
part 'track.g.dart';

@freezed
class TrackLight with _$TrackLight {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory TrackLight (
      {
        required String id,
        required String fileId,
        required String name,
        required AlbumLight album,
      }) = _TrackLight;

  factory TrackLight.fromJson(Map<String, dynamic> json) => _$TrackLightFromJson(json);
}