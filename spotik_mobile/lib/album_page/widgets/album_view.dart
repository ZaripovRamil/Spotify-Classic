import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/components/songs_list.dart';
import 'package:spotik_mobile/models/entity/album_full/album.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class AlbumView extends StatelessWidget {
  const AlbumView({super.key, required this.album});

  final Album album;

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
                          child: Image.network(Endpoints.getPreviewUrl(album.previewId)),
                        ),
                      ),
                      Expanded(
                        child: Center(
                            child: Text(
                              album.name,
                              style: Theme.of(context).textTheme.displayMedium,
                              textAlign: TextAlign.center,
                            )),
                      ),
                      Expanded(
                        child: Center(
                            child: Text(
                              album.author.name,
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
                                  if (value.currentTrackListId != album.id){
                                    value.tracklist = album.tracks;
                                    value.currentTrackListId = album.id;
                                    value.currentTrackIndex = 0;
                                  }
                                  else{
                                    value.pauseOrResume();
                                  }

                                },
                                icon: Icon(
                                  (value.isPlaying && value.currentTrackListId == album.id)?Icons.pause: CustomIcons.album_play_icon,
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
                  tracks: album.tracks,
                  playlistId: album.id,
                ),
              )),
        ]
      );
    });
  }
}