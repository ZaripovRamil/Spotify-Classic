import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/entity/track_light/track.dart';

part 'history.freezed.dart';
part 'history.g.dart';

@freezed
class HistoryDto with _$HistoryDto {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory HistoryDto({required List<Track>? history}) = _HistoryDto;

  factory HistoryDto.fromJson(Map<String, dynamic> json) =>
      _$HistoryDtoFromJson(json);
}
