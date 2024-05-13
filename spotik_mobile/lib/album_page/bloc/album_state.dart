part of 'album_bloc.dart';

@freezed
class AlbumState with _$AlbumState{
  const factory AlbumState.initial() = _AlbumInitialState;
  const factory AlbumState.loading() = _AlbumLoadingState;
  const factory AlbumState.loaded({required Album album}) = _AlbumLoadedState;
  const factory AlbumState.error({required String errorMessage}) = _AlbumErrorState;
}

@freezed
class AlbumsState with _$AlbumsState{
  const factory AlbumsState.initial() = _AlbumsInitialState;
  const factory AlbumsState.loading() = _AlbumsLoadingState;
  const factory AlbumsState.loaded({required AlbumsDto dto}) = _AlbumsLoadedState;
  const factory AlbumsState.error({required String errorMessage}) = _AlbumsErrorState;
}