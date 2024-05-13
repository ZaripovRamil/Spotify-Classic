import 'package:freezed_annotation/freezed_annotation.dart';

part 'subscription.freezed.dart';
part 'subscription.g.dart';

@freezed
class SubscriptionDto with _$SubscriptionDto {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory SubscriptionDto (
      {
        required bool ok,
        required String message
      }) = _SubscriptionDto;

  factory SubscriptionDto.fromJson(Map<String, dynamic> json) => _$SubscriptionDtoFromJson(json);
}