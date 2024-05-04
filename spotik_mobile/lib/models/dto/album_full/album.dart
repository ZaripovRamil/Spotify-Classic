import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/dto/author_light/author.dart';
import 'package:spotik_mobile/models/dto/track_light/track.dart';

part 'album.freezed.dart';
part 'album.g.dart';

@freezed
class AlbumFull with _$AlbumFull {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory AlbumFull (
      {
        required String id,
        required String previewId,
        required String name,
        required AuthorLight author,
        required List<TrackLight> tracks,
        required String type,
      }) = _AlbumFull;

  factory AlbumFull.fromJson(Map<String, dynamic> json) => _$AlbumFullFromJson(json);
}