part of 'history_bloc.dart';

@freezed
class HistoryEvent with _$HistoryEvent {
  const factory HistoryEvent.load() = HistoryLoadEvent;
  const factory HistoryEvent.clear() = HistoryClearEvent;
}
