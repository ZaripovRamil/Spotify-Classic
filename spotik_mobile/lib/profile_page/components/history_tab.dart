import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/models/entity/track_light/track.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/profile_page/bloc/history/history_bloc.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';

class HistoryTab extends StatelessWidget {
  const HistoryTab({super.key});

  @override
  Widget build(BuildContext context) {
    final state = context.watch<HistoryBloc>().state;
    return Column(
      children: [
        const SizedBox(height: 10),
        Expanded(
            child: state.when(
                initial: () => const Text("History is empty"),
                loading: () => const Center(
                      heightFactor: 1,
                      widthFactor: 1,
                      child: SizedBox(
                        height: 40,
                        width: 40,
                        child: CircularProgressIndicator(
                          strokeWidth: 1.5,
                        ),
                      ),
                    ),
                loaded: (data) => HistoryList(tracks: data.history!),
                error: (message) => Text(message)))
      ],
    );
  }
}

class HistoryList extends StatelessWidget {
  const HistoryList({required this.tracks, super.key});
  final List<Track> tracks;

  @override
  Widget build(BuildContext context) {
    return Consumer<PlayerProvider>(builder: (context, value, child) {
      var playerProvider = Provider.of<PlayerProvider>(context, listen: false);
      return ListView.builder(
        itemCount: tracks.length,
        itemBuilder: (context, index) {
          final item = tracks[index];
          return ListTile(
            onTap: () {
              playerProvider.tracklist = tracks;
              value.currentTrackListId = tracks[index].album.id;
              playerProvider.currentTrackIndex = index;
            },
            leading: Image.network(
              Endpoints.getPreviewUrl(item.album.previewId),
              fit: BoxFit.cover,
            ),
            title: Text(item.name),
            subtitle: Text(item.album.name),
          );
        },
      );
    });
  }
}
