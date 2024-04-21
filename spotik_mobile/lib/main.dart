import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/utils/navigation_routes.dart';
import 'package:spotik_mobile/utils/router.dart';
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
      title: 'Flutter Demo',
      theme: customTheme(),
      initialRoute: NavigationRoutes.main,
      routes: routes,
    );
  }
}
