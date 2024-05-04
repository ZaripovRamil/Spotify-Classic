import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/AlbumData/album_data.dart';

part 'track.freezed.dart';
part 'track.g.dart';

@freezed
class Track with _$Track{
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory Track({required String id,required String fileId, required String name, required AlbumData album}) = _Track;

  factory Track.fromJson(Map<String, dynamic> json) => _$TrackFromJson(json);
}