import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/models/dto/search/search.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/search_page/bloc/search_bloc.dart';
import 'package:spotik_mobile/search_page/services/search_repository.dart';

import '../utils/ui_constants.dart';

class SearchPage extends StatefulWidget {
  const SearchPage({super.key});

  @override
  State<SearchPage> createState() => _SearchPageState();
}

class _SearchPageState extends State<SearchPage> {
  @override
  Widget build(BuildContext context) {
    return RepositoryProvider(
      create: (context) => SearchRepository(),
      child: BlocProvider(
        create: (context) =>
            SearchBloc(searchRepository: context.read<SearchRepository>()),
        child: Scaffold(
          appBar: AppBar(
            backgroundColor: Colors.transparent,
            title: const Text('Search',
                style: TextStyle(
                  color: CustomColors.goldenColor,
                )),
          ),
          body: Column(
            children: <Widget>[
              const SearchBar(),
              Expanded(
                child: _ResultPageMainPart(),
              )
            ],
          ),
        ),
      ),
    );
  }
}

class SearchBar extends StatefulWidget {

  const SearchBar({super.key});

  @override
  State<SearchBar> createState() => _SearchBarState();
}

class _SearchBarState extends State<SearchBar> {
  final TextEditingController _searchController = TextEditingController();

  @override
  void dispose() {
    _searchController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: TextField(
        controller: _searchController,
        decoration: InputDecoration(
          labelText: 'Search',
          labelStyle: const TextStyle(
            color: CustomColors.goldenColor,
          ),
          suffixIcon: IconButton(
              icon: const Icon(Icons.search),
              onPressed: () async {
                await _search(context, _searchController.text);
              }),
        ),
      ),
    );
  }
}

Future<void> _search(BuildContext context, String query) async {
  context.read<SearchBloc>().add(SearchEvent.search(query: query));
}

class SearchResultList extends StatelessWidget {
  const SearchResultList({required this.searchResult, super.key});
  final SearchDto searchResult;

  @override
  Widget build(BuildContext context) {
    return Consumer<PlayerProvider>(builder: (context, value, child) {
      var playerProvider = Provider.of<PlayerProvider>(context, listen: false);
      return ListView.builder(
        itemCount: searchResult.tracks.length,
        itemBuilder: (context, index) {
          return ListTile(
              onTap: () {
                playerProvider.tracklist = searchResult.tracks;
                value.currentTrackListId = searchResult.tracks[index].album.id;
                playerProvider.currentTrackIndex = index;
              },
              title: Row(children: [
                Image.asset(
                  "assets/compositor.png",
                  height: 40,
                ),
                Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
                  Text(searchResult.tracks[index].name,
                      style: const TextStyle(
                          color: CustomColors.goldenColor,
                          fontSize: TextSize.smallTextSize)),
                  Text(searchResult.tracks[index].album.author.name,
                      style: const TextStyle(
                          color: CustomColors.goldenColor,
                          fontSize: TextSize.tinyTextSize)),
                ])
              ]));
        },
      );
    });
  }
}

class _ResultPageMainPart extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    final state = context.watch<SearchBloc>().state;
    return state.when(
        initial: () => const Text(''),
        loading: () => const CircularProgressIndicator(),
        loaded: (data) => SearchResultList(searchResult: data!),
        error: (message) => Text(message));
  }
}
