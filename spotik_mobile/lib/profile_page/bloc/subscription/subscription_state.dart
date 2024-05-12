part of 'subscription_bloc.dart';

@freezed
class SubscriptionState with _$SubscriptionState {
  const factory SubscriptionState.initial() = _SubscriptionInitialState;
  const factory SubscriptionState.submitting() = _SubscriptionSubmittingState;
  const factory SubscriptionState.submitted() = _SubscriptionSubmittedState;
  const factory SubscriptionState.error({required String errorMessage}) =
      _SubscriptionErrorlState;
}
