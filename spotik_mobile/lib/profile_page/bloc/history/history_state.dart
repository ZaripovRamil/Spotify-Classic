part of 'history_bloc.dart';

@freezed
class HistoryState with _$HistoryState {
  const factory HistoryState.initial() = _HistoryInitialState;
  const factory HistoryState.loading() = _HistoryLoadingState;
  const factory HistoryState.loaded({required HistoryDto history}) =
      _HistoryLoadedState;
  const factory HistoryState.error({required String errorMessage}) =
      _HistoryErrorlState;
}
