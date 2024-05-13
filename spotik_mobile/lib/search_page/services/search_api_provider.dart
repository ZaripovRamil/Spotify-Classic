import 'package:spotik_mobile/models/dto/search/search.dart';
import 'package:spotik_mobile/models/dto/search/search_res.dart';
import 'package:spotik_mobile/services/graphql/client.dart';
import 'package:spotik_mobile/utils/constants/graphql_requests.dart';

class SearchApiProvider {
  Future<SearchResultDto> search(String query) async {
    try {
      var res = await GqlService.query(Queries.search(query));
      var data =
          SearchDto.fromJson(res);
      return SearchResultDto(isSuccessful: true, data: data, errorMessage: '');
    } catch (ex) {
      return const SearchResultDto(
          isSuccessful: false, data: null, errorMessage: 'The search failed');
    }
  }
}
