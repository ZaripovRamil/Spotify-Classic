import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/auth_page/auth_page.dart';
import 'package:spotik_mobile/drawer/drawer.dart';
import 'package:spotik_mobile/home_page/home_page.dart';
import 'package:spotik_mobile/profile_page/profile_page.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/player/bottom_player.dart';
import 'package:spotik_mobile/search_page/search_page.dart';
import 'package:spotik_mobile/subscription_page/subscription_page.dart';
import 'package:spotik_mobile/playlist_page/playlist_page.dart';
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

  @override
  Widget build(BuildContext context) {
    var pages = {
      Pages.home: const HomePage(),
      Pages.user: const UserPage(),
      Pages.playlist: const PlaylistPage(),
      Pages.profile: const ProfilePage(),
      Pages.subscription: const SubscriptionPage(),
      Pages.auth: const AuthPage(),
      Pages.search: const SearchPage()
    };

    goToSelectedElement(String selectedItem) {
      setState(() {
        selectedElement = selectedItem;
      });
    }

    return Consumer<PlayerProvider>(builder: (context, value, child) {
      return Container(
          decoration: CustomDecorations.backgroundDecoration,
          child: Scaffold(
            // backgroundColor: Theme.of(context).scaffoldBackgroundColor,
            backgroundColor: Colors.transparent,
            appBar: AppBar(
                backgroundColor: Colors.transparent,
                title: const Text(""),
                iconTheme: Theme.of(context).iconTheme),
            body: pages[selectedElement],
             bottomNavigationBar: (value.trackList.length == 0)? Text("") : const BottomPlayer(),
            drawer: MyDrawer(
              onSelectedItem: goToSelectedElement,
            ),
          ));
    });
  }
}
