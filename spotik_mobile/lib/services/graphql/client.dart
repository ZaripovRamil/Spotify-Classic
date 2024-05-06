import 'package:flutter/material.dart';
import 'package:graphql_flutter/graphql_flutter.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';

class GqlService {
  static AuthLink authLink = AuthLink(getToken: () async {
    final storage = await SharedPreferences.getInstance();
    final token = storage.get('auth_token') as String?;

    if (token != null) {
      return 'Bearer $token';
    } else {
      throw Exception('Authorization token not found');
    }
  });

  static HttpLink httpLink = HttpLink(Endpoints.graphQL);

  static Link link = authLink.concat(httpLink);

  static ValueNotifier<GraphQLClient> client = ValueNotifier(
    GraphQLClient(
      link: link,
      cache: GraphQLCache(),
    ),
  );

  static Future<T> query<T>(String query) async {
    final QueryOptions options = QueryOptions(
      document: gql(query),
    );

    final QueryResult result = await client.value.query(options);

    if (result.hasException) {
      throw result.exception!;
    }

    return _parseData<T>(result.data);
  }

  static Future<T> mutate<T>(MutationOptions options) async {
    final QueryResult result = await client.value.mutate(options);

    if (result.hasException) {
      throw result.exception!;
    }

    return _parseData<T>(result.data);
  }

  static T _parseData<T>(Map<String, dynamic>? data) {
    if (data == null) {
      throw Exception("No data returned from server");
    }
    try {
      return (T as dynamic).fromJson(data) as T;
    } catch (e) {
      throw Exception("Failed to parse data: $e");
    }
  }
}
