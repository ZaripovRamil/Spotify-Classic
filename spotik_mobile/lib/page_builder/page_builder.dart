import 'package:audioplayers/audioplayers.dart';
import 'package:flutter/material.dart';
import 'package:spotik_mobile/album_page/album_page.dart';
import 'package:spotik_mobile/drawer/drawer.dart';
import 'package:spotik_mobile/home_page/home_page.dart';
import 'package:spotik_mobile/player/bottom_player.dart';
import 'package:spotik_mobile/user_page/user_page.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

import '../utils/pages.dart';

class PageBuilder extends StatefulWidget {
  const PageBuilder({super.key});

  @override
  State<StatefulWidget> createState() => _PageBuilder();
}

class _PageBuilder extends State<PageBuilder> {
  var selectedElement = Pages.home;

  late AudioPlayer player = AudioPlayer();

  @override
  void initState() {
    super.initState();

    // Create the audio player.
    player = AudioPlayer();

    // Set the release mode to keep the source after playback has completed.
    player.setReleaseMode(ReleaseMode.stop);

    player.setSource(UrlSource("https://dl3s2.muzofond.fm/aHR0cDovL2YubXAzcG9pc2submV0L21wMy8wMDUvMjcwLzg1OC81MjcwODU4Lm1wMw=="));
    // Start the player as soon as the app is displayed.
    // WidgetsBinding.instance.addPostFrameCallback((_) async {
    //   await player.setSource(AssetSource('ambient_c_motion.mp3'));
    //   await player.resume();
    // });
  }

  @override
  Widget build(BuildContext context) {
    var pages = {
      Pages.home: const HomePage(),
      Pages.user: const UserPage(),
      Pages.album: const AlbumPage()
    };

    goToSelectedElement(String selectedItem) {
      setState(() {
        selectedElement = selectedItem;
      });

      @override
      void dispose() {
        // Release all sources and dispose the player.
        player.dispose();

        super.dispose();
      }
    }
    return Container(
        decoration: const BoxDecoration(
            gradient: RadialGradient(colors: [
          CustomColors.backgroundRadialColor,
          CustomColors.backgroundColor
        ], center: Alignment(-1, -1.8), radius: 2)),
        child: Scaffold(
          // backgroundColor: Theme.of(context).scaffoldBackgroundColor,
          backgroundColor: Colors.transparent,
          appBar: AppBar(
              backgroundColor: Colors.transparent,
              title: const Text(""),
              iconTheme: Theme.of(context).iconTheme),
          body: pages[selectedElement],
          bottomNavigationBar: const BottomPlayer(),
          drawer: MyDrawer(
            onSelectedItem: goToSelectedElement,
          ),
        ));
  }
}
