import 'package:spotik_mobile/models/dto/album/albums.dart';
import 'package:spotik_mobile/services/album_services/album_api_provider.dart';

class AlbumRepository{
  final _albumProvider = AlbumApiProvider();
  Future<AlbumsDto> getAllAlbums() => _albumProvider.getAllAlbums();
}