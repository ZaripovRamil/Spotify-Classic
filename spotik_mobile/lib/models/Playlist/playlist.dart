import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/Track/track.dart';

part 'playlist.freezed.dart';
part 'playlist.g.dart';

@freezed
class Playlist with _$Playlist{
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory Playlist({required String id,required String prewiewId, required String name, required String owner, required List<Track> tracks }) = _Playlist;

  factory Playlist.fromJson(Map<String, dynamic> json) => _$PlaylistFromJson(json);
}