import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/album_page/services/album_repository.dart';
import 'package:spotik_mobile/models/dto/albums/albums.dart';
import 'package:spotik_mobile/models/entity/album_full/album.dart';

part 'album_bloc.freezed.dart';

part 'album_event.dart';
part 'album_state.dart';

class AlbumBloc extends Bloc<AlbumEvent, AlbumState> {
  static const String _errorMessage = 'Something went wrong. Check the internet connection or try again later';

  final AlbumRepository albumRepository;
  AlbumBloc({required this.albumRepository}) : super(const AlbumState.initial()) {
    on<AlbumGetAlbumEvent>((event, emit) async {
      emit(const AlbumState.loading());

      var data = await albumRepository.getAlbum(event.id);
      if (data != null) {
        emit(AlbumState.loaded(album: data));
      } else {
        emit(const AlbumState.error(errorMessage: _errorMessage));
      }
    });
  }
}

class AlbumsBloc extends Bloc<AlbumEvent, AlbumsState> {
  static const String _errorMessage = 'Something went wrong. Check the internet connection or try again later';

  final AlbumRepository albumRepository;
  AlbumsBloc({required this.albumRepository}) : super(const AlbumsState.initial()) {
    on<AlbumGetAlbumsEvent>((event, emit) async {
      emit(const AlbumsState.loading());

      var data = await albumRepository.getAlbums();
      if (data.albums.isNotEmpty) {
        emit(AlbumsState.loaded(dto: data));
      } else {
        emit(const AlbumsState.error(errorMessage: _errorMessage));
      }
    });
  }
}
