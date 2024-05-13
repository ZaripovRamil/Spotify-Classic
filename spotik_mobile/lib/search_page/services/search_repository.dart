import 'package:spotik_mobile/models/dto/search/search_res.dart';
import 'package:spotik_mobile/search_page/services/search_api_provider.dart';

class SearchRepository {
  final _searchProvider = SearchApiProvider();
  Future<SearchResultDto> search(String query) => _searchProvider.search(query);
}
