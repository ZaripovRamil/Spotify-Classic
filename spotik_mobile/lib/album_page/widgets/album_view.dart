import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/components/songs_list.dart';
import 'package:spotik_mobile/models/entity/album_full/album.dart';
import 'package:spotik_mobile/models/gql/dict_item/dict_item.dart';
import 'package:spotik_mobile/models/messaging_contracts/listen_event.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/services/rabbitmq/client.dart';
import 'package:spotik_mobile/utils/constants/rabbitmq_queues.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class AlbumView extends StatefulWidget {
  const AlbumView({super.key, required this.album});

  final Album album;

  @override
  State<AlbumView> createState() => _AlbumViewState();
}

class _AlbumViewState extends State<AlbumView> {
  late RabbitMQListener rabbitMQListener;
  late Map<String, int> listenCount;

  @override
  void initState() {
    super.initState();
    listenCount = _mapToDict(widget.album.listenCounts);
    rabbitMQListener = RabbitMQListener();
    rabbitMQListener.startListening(RabbitMqQueues.albumListenQueue(widget.album.id), (payload) {
      var event = ListenEvent.fromJson(payload);
      setState(() {
        if (listenCount[event.trackId] == null) {
          listenCount[event.trackId] = event.count;
        } else {
          listenCount[event.trackId] = listenCount[event.trackId]! + event.count;
        }
      });
    });
  }

  @override
  void dispose() {
    rabbitMQListener.closeConnection();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Consumer<PlayerProvider>(builder: (context, value, child) {
      return Column(children: <Widget>[
          Expanded(
              child: Container(
                  color: Colors.transparent,
                  margin: const EdgeInsets.only(top: 20, right: 20, left: 20),
                  child: Column(
                    children: [
                      Expanded(
                        flex: 10,
                        child: Container(
                          margin: const EdgeInsets.only(bottom: 15),
                          child: Image.network(Endpoints.getPreviewUrl(widget.album.previewId)),
                        ),
                      ),
                      Expanded(
                        child: Center(
                            child: Text(
                              widget.album.name,
                              style: Theme.of(context).textTheme.displayMedium,
                              textAlign: TextAlign.center,
                            )),
                      ),
                      Expanded(
                        child: Center(
                            child: Text(
                              widget.album.author.name,
                              style: Theme.of(context).textTheme.displaySmall,
                              textAlign: TextAlign.center,
                            )),
                      ),
                      Expanded(
                        flex: 3,
                        child: Row(
                            mainAxisAlignment: MainAxisAlignment.center,
                            crossAxisAlignment: CrossAxisAlignment.center,
                            children: [
                              IconButton(
                                iconSize: 40,
                                onPressed: () {
                                  if (value.currentTrackListId != widget.album.id){
                                    value.tracklist = widget.album.tracks;
                                    value.currentTrackListId = widget.album.id;
                                    value.currentTrackIndex = 0;
                                  }
                                  else{
                                    value.pauseOrResume();
                                  }

                                },
                                icon: Icon(
                                  (value.isPlaying && value.currentTrackListId == widget.album.id)?Icons.pause: CustomIcons.album_play_icon,
                                  weight: 1,
                                  color: CustomColors.goldenColor,
                                ),
                              ),
                              const IconButton(
                                iconSize: 35,
                                onPressed: null,
                                icon: Icon(
                                  CustomIcons.album_like_icon,
                                  color: CustomColors.whiteColor,
                                ),
                              )
                            ]),
                      ),
                    ],
                  ))),
          Expanded(
              child: Container(
                color: CustomColors.playerBackgroundColor,
                child: SongsList(
                  tracks: widget.album.tracks,
                  playlistId: widget.album.id,
                  listenCounts: listenCount,
                ),
              )),
        ]
      );
    });
  }

  Map<String, int> _mapToDict(List<GraphQlDictionaryItem> listens) {
    final Map<String, int> res = {};
    for (var l in listens) {
      res[l.key] = l.value;
    }

    return res;
  }
}