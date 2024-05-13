import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/album_page/album_page.dart';
import 'package:spotik_mobile/auth_page/auth_page.dart';
import 'package:spotik_mobile/chat/widgets/chat_page.dart';
import 'package:spotik_mobile/home_page/home_page.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/page_builder/page_builder.dart';
import 'package:spotik_mobile/playlist_page/playlist_page.dart';
import 'package:spotik_mobile/profile_page/profile_page.dart';
import 'package:spotik_mobile/search_page/search_page.dart';
import 'package:spotik_mobile/utils/navigation_routes.dart';
import 'package:spotik_mobile/utils/storage.dart';
import 'package:spotik_mobile/utils/theme.dart';

void main() {
  runApp(ChangeNotifierProvider(
      create: (context) => PlayerProvider(), child: const MyApp()));
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Flutter Demo',
      theme: customTheme(),
      initialRoute: NavigationRoutes.init,
      onGenerateRoute: (settings) {
        switch (settings.name) {
          case NavigationRoutes.init:
            return MaterialPageRoute(builder: (context) => const PageBuilder(childWidget: AuthGuard()));
          case NavigationRoutes.main :
            return MaterialPageRoute(builder: (context) => const PageBuilder(childWidget: HomePage()));
          case NavigationRoutes.search :
            return MaterialPageRoute(builder: (context) => const PageBuilder(childWidget: SearchPage()));
          case NavigationRoutes.playlist :
            String? playlistId = settings.arguments as String?;
            return MaterialPageRoute(builder: (context) => PageBuilder(childWidget: PlaylistPage(playlistId: playlistId)));
          case NavigationRoutes.album :
            String? albumId = settings.arguments as String?;
            return MaterialPageRoute(builder: (context) => PageBuilder(childWidget: AlbumPage(albumId: albumId)));
          case NavigationRoutes.auth :
            return MaterialPageRoute(builder: (context) => const PageBuilder(childWidget: AuthPage()));
          case NavigationRoutes.profile :
            return MaterialPageRoute(builder: (context) => const PageBuilder(childWidget: ProfilePage()));
          case NavigationRoutes.chat :
            return MaterialPageRoute(builder: (context) => PageBuilder(childWidget: ChatPage()));
        }
        return MaterialPageRoute( builder: (context) => const Text("data"));
      },
    );
  }
}

class AuthGuard extends StatelessWidget {
  const AuthGuard({super.key});

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
      future: checkTokenValidity(),
      builder: (context, snapshot) {
        if (snapshot.connectionState == ConnectionState.done) {
          final bool isTokenValid = snapshot.data ?? false;
          if (isTokenValid) {
            return const HomePage();
          } else {
            return const AuthPage();
          }
        } else {
          return const CircularProgressIndicator();
        }
      },
    );
  }

  Future<bool> checkTokenValidity() async {
    return await Storage.isTokenExpired();
  }
}
