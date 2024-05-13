import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/models/dto/search/search.dart';
import 'package:spotik_mobile/search_page/services/search_repository.dart';

part 'search_bloc.freezed.dart';

part 'search_state.dart';
part 'search_event.dart';

class SearchBloc extends Bloc<SearchEvent, SearchState> {
  final SearchRepository searchRepository;
  SearchBloc({required this.searchRepository})
      : super(const SearchState.initial()) {
    on<SearchSearchEvent>((event, emit) async {
      emit(const SearchState.loading());
      var data = await searchRepository.search(event.query);
      if (data.isSuccessful) {
        emit(SearchState.loaded(searchResult: data.data));
      } else {
        emit(SearchState.error(errorMessage: data.errorMessage));
      }
    });
  }
}
