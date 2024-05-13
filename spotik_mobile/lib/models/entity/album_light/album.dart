import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/entity/author_light/author.dart';

part 'album.freezed.dart';
part 'album.g.dart';

@freezed
class AlbumData with _$AlbumData {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory AlbumData (
      {
        required String id,
        required String previewId,
        required String name,
        required Author author
      }) = _AlbumData;

  factory AlbumData.fromJson(Map<String, dynamic> json) => _$AlbumDataFromJson(json);
}