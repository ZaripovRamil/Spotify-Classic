import 'package:spotik_mobile/models/dto/history/history.dart';
import 'package:spotik_mobile/services/graphql/client.dart';
import 'package:spotik_mobile/utils/constants/graphql_requests.dart';

class HistoryApiProvider {
  Future<HistoryDto> getHistory() async {
    try {
      var res = HistoryDto.fromJson(await GqlService.query(Queries.history));
      return res;
    } catch (ex) {
      return const HistoryDto(history: null);
    }
  }
}
