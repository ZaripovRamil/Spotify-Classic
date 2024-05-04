import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/dto/user_light/user.dart';

part 'playlist.freezed.dart';
part 'playlist.g.dart';

@freezed
class PlaylistLight with _$PlaylistLight {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory PlaylistLight (
      {
        required String id,
        required String previewId,
        required String name,
        required UserLight owner,
        required int trackCount,
      }) = _PlaylistLight;

  factory PlaylistLight.fromJson(Map<String, dynamic> json) => _$PlaylistLightFromJson(json);
}