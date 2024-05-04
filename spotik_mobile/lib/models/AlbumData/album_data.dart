import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/Author/author.dart';

part 'album_data.freezed.dart';
part 'album_data.g.dart';

@freezed
class AlbumData with _$AlbumData{
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory AlbumData({required String id, required String prewiewId, required String name, required Author author}) = _Album;

  factory AlbumData.fromJson(Map<String, dynamic> json) => _$AlbumDataFromJson(json);
}