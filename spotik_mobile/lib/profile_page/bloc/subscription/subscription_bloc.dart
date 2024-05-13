import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/profile_page/services/subscription/subscription_repository.dart';

part 'subscription_bloc.freezed.dart';

part 'subscription_state.dart';
part 'subscription_event.dart';

class SubcriptionBloc extends Bloc<SubscriptionEvent, SubscriptionState> {
  final SubscriptionRepository subcriptionRepository;
  SubcriptionBloc({required this.subcriptionRepository})
      : super(const SubscriptionState.initial()) {
    on<SubcriptionSubscribeEvent>((event, emit) async {
      emit(const SubscriptionState.submitting());
      var data = await subcriptionRepository.updateSubscription(event.id);
      if (data.ok) {
        emit(const SubscriptionState.submitted());
      } else {
        emit(SubscriptionState.error(errorMessage: data.message));
      }
    });
  }
}
