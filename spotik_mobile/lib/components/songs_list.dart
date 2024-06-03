import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/models/entity/track_light/track.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';

class SongsList extends StatefulWidget {
  const SongsList({required this.tracks, required this.playlistId, super.key, required this.listenCounts});
  final List<Track> tracks;
  final String playlistId;
  final Map<String, int> listenCounts;

  @override
  State<SongsList> createState() => _SongsListState();
}

class _SongsListState extends State<SongsList> {

  late final dynamic playerProvider;

  @override
  void initState() {
    super.initState();
    playerProvider = Provider.of<PlayerProvider>(context, listen: false);
  }

  @override
  Widget build(BuildContext context) {
    return Consumer<PlayerProvider>(builder: (context, value, child) {
      final List<Track> trackList = widget.tracks;
      return ListView.separated(
          itemCount: widget.tracks.length,
          padding: const EdgeInsets.only(right: 20, left: 20),
          separatorBuilder: (context, i) => const Divider(),
          itemBuilder: (context, i) {
            final Track track = trackList[i];
            return ListTile(
              leading: Image.network(Endpoints.getPreviewUrl(track.album.previewId)),
              // Text(
              //   "${i+1}",
              //   style: Theme.of(context)
              //       .textTheme
              //       .displaySmall
              //       ?.copyWith(color: CustomColors.goldenColor),
              // ),
              title: Text(track.name,
                  style: Theme.of(context).textTheme.displaySmall),
              subtitle: Text(
                track.album.author.name,
                style: const TextStyle(fontSize: 13),
              ),
              trailing:
                  Text(
                      (widget.listenCounts[track.id] ?? 0).toString(),
                      style: Theme.of(context).textTheme.displaySmall
                  ),
              onTap: () {
                if (widget.playlistId != value.currentTrackListId) {
                  playerProvider.tracklist = widget.tracks;
                  value.currentTrackListId = widget.playlistId;
                }
                playerProvider.currentTrackIndex = i;
              },
            );
          });
    });
  }
}
