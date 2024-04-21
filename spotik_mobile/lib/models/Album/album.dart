import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/Author/author.dart';

part 'album.freezed.dart';
part 'album.g.dart';

@freezed
class Album with _$Album{
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory Album({required String id, required String prewiewId, required String name, required Author author}) = _Album;

  factory Album.fromJson(Map<String, dynamic> json) => _$AlbumFromJson(json);
}