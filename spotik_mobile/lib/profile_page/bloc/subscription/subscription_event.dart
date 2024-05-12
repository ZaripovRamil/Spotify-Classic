part of 'subscription_bloc.dart';

@freezed
class SubscriptionEvent with _$SubscriptionEvent {
  const factory SubscriptionEvent.subscribe({required String id}) =
      SubcriptionSubscribeEvent;
}
