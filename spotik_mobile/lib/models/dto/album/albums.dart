import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/entity/album_light/album.dart';

part 'albums.freezed.dart';
part 'albums.g.dart';

@freezed
class AlbumsDto with _$AlbumsDto {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory AlbumsDto (
      {
        required bool isSuccessful,
        required List<AlbumData>? albums,
        required String resultMessage
      }) = _AlbumsDto;

  factory AlbumsDto.fromJson(Map<String, dynamic> json) => _$AlbumsDtoFromJson(json);
}