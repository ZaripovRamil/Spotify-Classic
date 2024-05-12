import 'package:spotik_mobile/models/dto/history/history.dart';
import 'package:spotik_mobile/profile_page/services/history_api_provider.dart';

class HistoryRepository {
  final _historyProvider = HistoryApiProvider();
  Future<HistoryDto> getHistory() => _historyProvider.getHistory();
}
