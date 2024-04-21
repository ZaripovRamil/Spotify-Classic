import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/models/Album/album.dart';
import 'package:spotik_mobile/models/Author/author.dart';
import 'package:spotik_mobile/models/Playlist/playlist.dart';
import 'package:spotik_mobile/models/Track/track.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/playlist_page/widgets/songs_list.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class PlaylistPage extends StatefulWidget {
  const PlaylistPage({super.key});

  @override
  State<PlaylistPage> createState() => _PlaylistPageState();
}

class _PlaylistPageState extends State<PlaylistPage> {
  final Playlist playlist = const Playlist(
      id: "playlist1",
      prewiewId:
          "https://kartinki.pibig.info/uploads/posts/2023-04/1682442196_kartinki-pibig-info-p-kartinki-dlya-oblozhki-muzikalnogo-alboma-1.jpg",
      name: "Playlist 1",
      owner: "Person",
      tracks: [
        Track(
            id: "1",
            fileId:
                "https://dl3s2.muzofond.fm/aHR0cDovL2YubXAzcG9pc2submV0L21wMy8wMDUvMDIzLzQ0Ni81MDIzNDQ2Lm1wMw==",
            name: "Song Name 1",
            album: Album(
                id: "1",
                prewiewId:
                    "https://kartinki.pibig.info/uploads/posts/2023-04/1682442196_kartinki-pibig-info-p-kartinki-dlya-oblozhki-muzikalnogo-alboma-1.jpg",
                name: "Album Name 1",
                author: Author(id: "1", name: "Author 1"))),
        Track(
            id: "2",
            fileId:
                "https://dl3s2.muzofond.fm/aHR0cDovL2YubXAzcG9pc2submV0L21wMy8wMDUvMDIzLzQ0NS81MDIzNDQ1Lm1wMw==",
            name: "Song Name 2",
            album: Album(
                id: "1",
                prewiewId:
                    "https://kartinki.pibig.info/uploads/posts/2023-04/1682442196_kartinki-pibig-info-p-kartinki-dlya-oblozhki-muzikalnogo-alboma-1.jpg",
                name: "Album Name 1",
                author: Author(id: "1", name: "Author 1"))),
        Track(
            id: "3",
            fileId:
                "https://dl3s2.muzofond.fm/aHR0cDovL2YubXAzcG9pc2submV0L21wMy8wMDUvMDIzLzQzOC81MDIzNDM4Lm1wMw==",
            name: "Song Name 3",
            album: Album(
                id: "1",
                prewiewId:
                    "https://cs10.pikabu.ru/post_img/big/2019/03/14/0/1552511660192387395.jpg",
                name: "Album Name 1",
                author: Author(id: "1", name: "Author 1"))),
      ]);

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
                          playlist.prewiewId,
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
