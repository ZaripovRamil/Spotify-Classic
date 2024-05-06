import 'package:flutter/material.dart';
import 'package:graphql_flutter/graphql_flutter.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';
import 'package:spotik_mobile/utils/storage.dart';

class GqlService {
  static AuthLink authLink = AuthLink(getToken: () async {
    return await Storage.getToken();
  });

  static HttpLink httpLink = HttpLink(Endpoints.graphQL);

  static Link link = authLink.concat(httpLink);

  static ValueNotifier<GraphQLClient> client = ValueNotifier(
    GraphQLClient(
      link: link,
      cache: GraphQLCache(),
    ),
  );

  static Future<Map<String, dynamic>> query<T>(QueryOptions options) async {
    final QueryResult result = await client.value.query(options);

    if (result.hasException) {
      throw result.exception!;
    }

    return result.data!;
  }

  static Future<Map<String, dynamic>> mutate<T>(MutationOptions options) async {
    final QueryResult result = await client.value.mutate(options);

    if (result.hasException) {
      throw result.exception!;
    }

    return result.data!;
  }
}
