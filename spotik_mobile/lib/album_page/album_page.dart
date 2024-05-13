import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/album_page/bloc/album_bloc.dart';
import 'package:spotik_mobile/album_page/services/album_repository.dart';
import 'package:spotik_mobile/album_page/widgets/album_view.dart';
import 'package:spotik_mobile/models/player_provider.dart';

class AlbumPage extends StatelessWidget {
  const AlbumPage({required this.albumId, super.key});

  final String albumId;

  @override
  Widget build(BuildContext context) {
    return RepositoryProvider(
        create: (context) => AlbumRepository(),
        child: BlocProvider(
            create: (context) =>
                AlbumBloc(albumRepository: context.read<AlbumRepository>()),
            child: Consumer<PlayerProvider>(builder: (context, value, child) {
              final state = context.watch<AlbumBloc>().state;
              return Scaffold(
                  backgroundColor: Colors.transparent,
                  appBar: AppBar(
                      backgroundColor: Colors.transparent,
                      iconTheme: Theme.of(context).iconTheme),
                  body: state.when(
                      initial: () {
                        context
                            .read<AlbumBloc>()
                            .add(AlbumEvent.getAlbum(id: albumId));
                        return const CircularProgressIndicator();
                      },
                      loading: () => const CircularProgressIndicator(),
                      loaded: (album) => AlbumView(album: album),
                      error: (value) => Text(value)));
            })
        )
    );
  }
}
