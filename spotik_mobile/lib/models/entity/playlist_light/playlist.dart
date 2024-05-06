import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/entity/user_light/user.dart';

part 'playlist.freezed.dart';
part 'playlist.g.dart';

@freezed
class Playlist with _$Playlist {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory Playlist (
      {
        required String id,
        required String previewId,
        required String name,
        required User owner,
        required int trackCount,
      }) = _Playlist;

  factory Playlist.fromJson(Map<String, dynamic> json) => _$PlaylistFromJson(json);
}