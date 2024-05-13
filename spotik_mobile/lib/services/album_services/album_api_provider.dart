import 'package:spotik_mobile/models/dto/album/albums.dart';
import 'package:spotik_mobile/models/entity/album_light/album.dart';
import 'package:spotik_mobile/services/graphql/client.dart';
import 'package:spotik_mobile/utils/constants/graphql_requests.dart';

class AlbumApiProvider {
  Future<AlbumsDto> getAllAlbums() async {
    try {
      var res = await GqlService.query(Queries.albums);
      final List<dynamic> jsonList = res["albums"]["albums"];
      var albums = jsonList.map((json) => AlbumData.fromJson(json)).toList();
      var albumsDto = AlbumsDto(isSuccessful: true, albums: albums, resultMessage: "");
      
      return albumsDto;
    } catch (ex) {
      return const AlbumsDto(isSuccessful: false, albums: null, resultMessage: "Произошла ошибка при получении списка альбомов");

    }


  }
}
