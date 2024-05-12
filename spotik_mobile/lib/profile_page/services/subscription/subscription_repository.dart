import 'package:spotik_mobile/models/dto/subscription/subscription.dart';
import 'package:spotik_mobile/profile_page/services/subscription/subscription_api_provider.dart';

class SubscriptionRepository {
  final _subscriptionProvider = SubcriptionApiProvider();
  Future<SubscriptionDto> updateSubscription(String id) =>
      _subscriptionProvider.updateSubscription(id);
}
