import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/album_page/bloc/album_bloc.dart';
import 'package:spotik_mobile/home_page/components/playlist_card.dart';

class AlbumsCarousel extends StatelessWidget {
  const AlbumsCarousel({super.key});

  @override
  Widget build(BuildContext context) {
    final state = context.watch<AlbumsBloc>().state;
    return SizedBox(
      height: 310,
        child: state.when(
            initial: () {
              context
                  .read<AlbumsBloc>()
                  .add(const AlbumEvent.getAlbums());
              return const CircularProgressIndicator();
            },
            loading: () => const CircularProgressIndicator(),
            loaded: (albums) {
              return ListView.builder(
                scrollDirection: Axis.horizontal,
                itemCount: albums.albums.length,
                itemBuilder: (context, index) {
                  return Padding(
                    padding: const EdgeInsets.all(10.0),
                    child: AlbumCard(data: albums.albums[index]),
                  );
                },
              );
            },
            error: (value) => Text(value)
        )
    );
  }

}