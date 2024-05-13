import 'package:flutter/material.dart';

class SlideTopRoute extends PageRouteBuilder {
  final Widget page;
  SlideTopRoute({required this.page})
      : super(
          transitionDuration: const Duration(milliseconds: 500),
          pageBuilder: (
            BuildContext context,
            Animation<double> animation,
            Animation<double> secondaryAnimation,
          ) =>
              page,
          transitionsBuilder: (
            BuildContext context,
            Animation<double> animation,
            Animation<double> secondaryAnimation,
            Widget child,
          ) =>
              SlideTransition(
            position: animation.drive(Tween<Offset>(
              begin: const Offset(0, 1),
              end: Offset.zero,
            )),
            child: child,
          ),
        );
}
