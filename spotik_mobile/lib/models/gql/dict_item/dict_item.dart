import 'package:freezed_annotation/freezed_annotation.dart';

part 'dict_item.freezed.dart';
part 'dict_item.g.dart';

@freezed
class GraphQlDictionaryItem with _$GraphQlDictionaryItem {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory GraphQlDictionaryItem({
    required String key,
    required int value,
  }) = _GraphQlDictionaryItem;

  factory GraphQlDictionaryItem.fromJson(Map<String, dynamic> json) => _$GraphQlDictionaryItemFromJson(json);
}