import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/entity/author_light/author.dart';
import 'package:spotik_mobile/models/entity/track_light/track.dart';

part 'album.freezed.dart';
part 'album.g.dart';

@freezed
class Album with _$Album {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory Album (
      {
        required String id,
        required String previewId,
        required String name,
        required Author author,
        required List<Track> tracks,
        required String type,
      }) = _Album;

  factory Album.fromJson(Map<String, dynamic> json) => _$AlbumFromJson(json);
}