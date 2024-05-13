part of 'home_bloc.dart';

@freezed
class HomeState with _$HomeState{
  const factory HomeState.loading() = _HomeLoadingState;
  const factory HomeState.loaded({required List<AlbumData>? albums}) = _HomeLoadedState;
  const factory HomeState.error({required String errorMessage}) = _HomeErrorlState;
}