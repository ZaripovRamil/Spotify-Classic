import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/components/player/bottom_player.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class PageBuilder extends StatelessWidget {
  const PageBuilder({required this.childWidget, super.key});

  final Widget childWidget;

  @override
  Widget build(BuildContext context) {
    return Consumer<PlayerProvider>(builder: (context, value, child) {
      return Container(
          decoration: CustomDecorations.backgroundDecoration,
          child: Scaffold(
            // backgroundColor: Theme.of(context).scaffoldBackgroundColor,
            backgroundColor: Colors.transparent,
            body: childWidget,
            bottomNavigationBar: value.trackList.isEmpty ? null : const BottomPlayer(),
            
          ));
    });
  }
}



