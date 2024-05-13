import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/models/entity/track_light/track.dart';
import 'package:spotik_mobile/profile_page/bloc/history/history_bloc.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class HistoryTab extends StatelessWidget {
  const HistoryTab({super.key});

  @override
  Widget build(BuildContext context) {
    final state = context.watch<HistoryBloc>().state;
    return Column(
      children: [
        Align(
          alignment: Alignment.centerRight,
          child: Padding(
              padding: const EdgeInsets.all(20),
              child: MaterialButton(
                  color: CustomColors.backgroundButtonGrey,
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(13.0),
                  ),
                  onPressed: () => {
                        context
                            .read<HistoryBloc>()
                            .add(const HistoryEvent.clear())
                      },
                  child: const Text('Clear',
                      style: TextStyle(fontSize: TextSize.smallTextSize)))),
        ),
        Expanded(
            child: state.when(
                initial: () => const Text("History is empty"),
                loading: () => const CircularProgressIndicator(),
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
    return ListView.builder(
      itemCount: tracks.length,
      itemBuilder: (context, index) {
        final item = tracks[index];
        return ListTile(
          leading: Image.network(
            Endpoints.getPreviewUrl(item.album.previewId),
            fit: BoxFit.cover,
          ),
          title: Text(item.name),
          subtitle: Text(item.album.name),
        );
      },
    );
  }
}
