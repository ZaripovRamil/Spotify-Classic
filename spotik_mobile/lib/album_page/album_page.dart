import 'package:flutter/material.dart';
import 'package:spotik_mobile/album_page/widgets/songs_list.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class AlbumPage extends StatefulWidget {
  const AlbumPage({super.key});

  @override
  State<AlbumPage> createState() => _AlbumPageState();
}

class _AlbumPageState extends State<AlbumPage> {
  @override
  Widget build(BuildContext context) {
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
                        "https://kartinki.pibig.info/uploads/posts/2023-04/1682442196_kartinki-pibig-info-p-kartinki-dlya-oblozhki-muzikalnogo-alboma-1.jpg",
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
                  const Expanded(
                    flex: 3,
                    child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        crossAxisAlignment: CrossAxisAlignment.center,
                        children: [
                          IconButton(
                            iconSize: 40,
                            onPressed: null,
                            icon: Icon(
                              CustomIcons.album_play_icon,
                              weight: 1,
                              color: CustomColors.goldenColor,
                            ),
                          ),
                          IconButton(
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
        color: CustomColors.backgroundColor,
        child: const SongsList(),
      )),
    ]);
  }
}
