import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/models/dto/album_full/album.dart';
import 'package:spotik_mobile/models/dto/album_light/album.dart';
import 'package:spotik_mobile/models/dto/author_light/author.dart';
import 'package:spotik_mobile/models/dto/track_light/track.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/playlist_page/widgets/songs_list.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class PlaylistPage extends StatefulWidget {
  const PlaylistPage({super.key});

  @override
  State<PlaylistPage> createState() => _PlaylistPageState();
}

class _PlaylistPageState extends State<PlaylistPage> {
  final AlbumFull playlist = const AlbumFull(
      id: "playlist1",
      previewId:
          "https://kartinki.pibig.info/uploads/posts/2023-04/1682442196_kartinki-pibig-info-p-kartinki-dlya-oblozhki-muzikalnogo-alboma-1.jpg",
      name: "Playlist 1",
      author: AuthorLight(id: "author1", name: "Some author"),
      tracks: [
        TrackLight(
            id: "1",
            fileId:
                "https://dl3s2.muzofond.fm/aHR0cDovL2YubXAzcG9pc2submV0L21wMy8wMDUvMDIzLzQ0Ni81MDIzNDQ2Lm1wMw==",
            name: "Song Name 1",
            album: AlbumLight(
                id: "1",
                previewId:
                    "https://kartinki.pibig.info/uploads/posts/2023-04/1682442196_kartinki-pibig-info-p-kartinki-dlya-oblozhki-muzikalnogo-alboma-1.jpg",
                name: "Album Name 1",
                author: AuthorLight(id: "1", name: "Author 1"))),
        TrackLight(
            id: "2",
            fileId:
                "https://dl3s2.muzofond.fm/aHR0cDovL2YubXAzcG9pc2submV0L21wMy8wMDUvMDIzLzQ0NS81MDIzNDQ1Lm1wMw==",
            name: "Song Name 2",
            album: AlbumLight(
                id: "1",
                previewId:
                    "https://kartinki.pibig.info/uploads/posts/2023-04/1682442196_kartinki-pibig-info-p-kartinki-dlya-oblozhki-muzikalnogo-alboma-1.jpg",
                name: "Album Name 1",
                author: AuthorLight(id: "1", name: "Author 1"))),
        TrackLight(
            id: "3",
            fileId:
                "https://dl3s2.muzofond.fm/aHR0cDovL2YubXAzcG9pc2submV0L21wMy8wMDUvMDIzLzQzOC81MDIzNDM4Lm1wMw==",
            name: "Song Name 3",
            album: AlbumLight(
                id: "1",
                previewId:
                    "https://cs10.pikabu.ru/post_img/big/2019/03/14/0/1552511660192387395.jpg",
                name: "Album Name 1",
                author: AuthorLight(id: "1", name: "Author 1"))),
      ],
      type: 'Album');

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
                        child: Image.network(
                          playlist.previewId,
                        ),
                      ),
                    ),
                    Expanded(
                      child: Center(
                          child: Text(
                        "Album Name",
                        style: Theme.of(context).textTheme.displayMedium,
                        textAlign: TextAlign.center,
                      )),
                    ),
                    Expanded(
                      child: Center(
                          child: Text(
                        "Author",
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
                                if (value.currentTrackListId != playlist.id){
                                  value.tracklist = playlist.tracks;
                                  value.currentTrackListId = playlist.id;
                                  value.currentTrackIndex = 0;
                                }
                                else{
                                  value.pauseOrResume();
                                }

                              },
                              icon: Icon(
                                (value.isPlaying && value.currentTrackListId == playlist.id)?Icons.pause: CustomIcons.album_play_icon,
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
            tracks: playlist.tracks,
            playlistId: playlist.id,
          ),
        )),
      ]);
    });
  }
}
