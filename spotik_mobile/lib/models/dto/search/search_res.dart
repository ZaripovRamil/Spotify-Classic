import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/dto/search/search.dart';

part 'search_res.freezed.dart';
part 'search_res.g.dart';

@freezed
class SearchResultDto with _$SearchResultDto {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory SearchResultDto(
      {required bool isSuccessful,
      required SearchDto? data,
      required String errorMessage}) = _SearchResultDto;

  factory SearchResultDto.fromJson(Map<String, dynamic> json) =>
      _$SearchResultDtoFromJson(json);
}
