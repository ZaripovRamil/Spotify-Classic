import 'package:spotik_mobile/models/dto/subscription/subscription.dart';
import 'package:spotik_mobile/services/graphql/client.dart';
import 'package:spotik_mobile/utils/constants/graphql_requests.dart';

class SubcriptionApiProvider {
  Future<SubscriptionDto> updateSubscription(String id) async {
    try {
      return SubscriptionDto.fromJson(
          await GqlService.mutate(Mutations.updateSubscription(id)));
    } catch (ex) {
      return const SubscriptionDto(
          ok: false, message: "Something went wrong. Please try again");
    }
  }
}
