import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/entity/album_full/album.dart';
import 'package:spotik_mobile/models/entity/author_light/author.dart';
import 'package:spotik_mobile/models/entity/playlist_light/playlist.dart';
import 'package:spotik_mobile/models/entity/track_light/track.dart';

part 'search.freezed.dart';
part 'search.g.dart';

@freezed
class SearchDto with _$SearchDto {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory SearchDto (
      {
        required List<Track> Tracks,
        required List<Album> Albums,
        required List<Author> Authors,
        required List<Playlist> Playlists,
      }) = _SearchDto;

  factory SearchDto.fromJson(Map<String, dynamic> json) => _$SearchDtoFromJson(json);
}