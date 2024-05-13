import 'package:spotik_mobile/models/dto/history/history.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/profile_page/services/history/history_repository.dart';

part 'history_bloc.freezed.dart';

part 'history_state.dart';
part 'history_event.dart';

class HistoryBloc extends Bloc<HistoryEvent, HistoryState> {
  final HistoryRepository historyRepository;
  HistoryBloc({required this.historyRepository})
      : super(const HistoryState.initial()) {
    on<HistoryLoadEvent>((event, emit) async {
      emit(const HistoryState.loading());
      var data = await historyRepository.getHistory();
      if (data.history != null) {
        emit(HistoryState.loaded(history: data));
      } else {
        emit(const HistoryState.error(errorMessage: 'Failed to load history'));
      }
    });
    on<HistoryClearEvent>((event, emit) async {
      emit(const HistoryState.initial());
    });
  }
}
