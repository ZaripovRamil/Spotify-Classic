import 'package:spotik_mobile/models/dto/albums/albums.dart';
import 'package:spotik_mobile/models/entity/album_full/album.dart';
import 'package:spotik_mobile/services/graphql/client.dart';
import 'package:spotik_mobile/utils/constants/graphql_requests.dart';

class AlbumRepository {
  Future<Album?> getAlbum(String id) async {
    try {
      var res = Album.fromJson(await GqlService.query(Queries.album(id)));
      if (res.id.isEmpty) {
        return null;
      }

      return res;
    } catch (ex) {
      return null;
    }
  }

  Future<AlbumsDto> getAlbums() async {
    try {
      return AlbumsDto.fromJson(await GqlService.query(Queries.albums));
    } catch (ex) {
      return const AlbumsDto(albums: []);
    }
  }
}