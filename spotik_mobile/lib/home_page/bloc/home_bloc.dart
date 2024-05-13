import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/entity/album_light/album.dart';
import 'package:spotik_mobile/services/album_services/album_repository.dart';

part 'home_bloc.freezed.dart';

part 'home_event.dart';
part 'home_state.dart';

class HomeBloc extends Bloc<HomeEvent, HomeState> {
  final AlbumRepository albumRepository;
  HomeBloc({required this.albumRepository}) : super(const HomeState.loading()) {
    on<HomeLoadEvent>((event, emit) async {

      emit(const HomeState.loading());
      var data = await albumRepository.getAllAlbums();
      if (data.isSuccessful){
        emit(HomeState.loaded(albums: data.albums));
      }
      else{
        emit(HomeState.error(errorMessage: data.resultMessage));
      }

      
    });
  }
}
