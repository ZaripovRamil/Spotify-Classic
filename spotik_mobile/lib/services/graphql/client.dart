import 'package:flutter/material.dart';
import 'package:graphql_flutter/graphql_flutter.dart';
import 'package:spotik_mobile/utils/constants/graphql_requests.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';
import 'package:spotik_mobile/utils/storage.dart';

class GqlService {
  static AuthLink authLink = AuthLink(getToken: () async {
    var token = await Storage.getToken();
    return 'Bearer $token';
  });

  static HttpLink httpLink = HttpLink(Endpoints.graphQL);

  static Link link = authLink.concat(httpLink);

  static ValueNotifier<GraphQLClient> client = ValueNotifier(
    GraphQLClient(
      link: link,
      cache: GraphQLCache(),
    ),
  );

  static Future<Map<String, dynamic>> query(CustomQueryOptions options) async {
    final QueryResult result = await client.value.query(options.options);

    if (result.hasException) {
      throw result.exception!;
    }

    return result.data!;
  }

  static Future<Map<String, dynamic>> mutate(CustomMutationOptions customOpts) async {
    final QueryResult result = await client.value.mutate(customOpts.options);

    if (result.hasException) {
      throw result.exception!;
    }

    return result.data![customOpts.resultParam];
  }
}
