part of 'album_bloc.dart';

@freezed
class AlbumEvent with _$AlbumEvent{
  const factory AlbumEvent.getAlbum({required String id}) = AlbumGetAlbumEvent;
  const factory AlbumEvent.getAlbums() = AlbumGetAlbumsEvent;
}