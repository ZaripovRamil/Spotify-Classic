part of 'search_bloc.dart';

@freezed
class SearchState with _$SearchState {
  const factory SearchState.initial() = _SearchInitialState;
  const factory SearchState.loading() = _SearchLoadingState;
  const factory SearchState.loaded({required SearchDto? searchResult}) =
      _SearchLoadedState;
  const factory SearchState.error({required String errorMessage}) =
      _SearchErrorlState;
}
