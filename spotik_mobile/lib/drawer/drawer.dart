import 'package:flutter/material.dart';

import '../utils/pages.dart';

class MyDrawer extends StatelessWidget {
  const MyDrawer({super.key, required this.onSelectedItem});

  final Function(String route) onSelectedItem;

  @override
  Widget build(BuildContext context) {
    goToPage(String route) {
      Navigator.of(context).pop();
      onSelectedItem(route);
    }

    return Drawer(
      backgroundColor: const Color.fromRGBO(19, 19, 22, 0.8),
      child: ListView(
        children: [
          _HomeDrawerElement(
            title: 'Home',
            onClick: () => goToPage(Pages.home),
          ),
          _HomeDrawerElement(
            title: 'User',
            onClick: () => goToPage(Pages.user),
          ),
          _HomeDrawerElement(
            title: 'Album',
            onClick: () => goToPage(Pages.album),
          ),
          _HomeDrawerElement(
            title: 'Profile',
            onClick: () => goToPage(Pages.profile),
          ),
          _HomeDrawerElement(
            title: 'Subscription',
            onClick: () => goToPage(Pages.subscription)
          )
        ],
      ),
    );
  }
}

class _HomeDrawerElement extends StatelessWidget {
  const _HomeDrawerElement({required this.title, required this.onClick});

  final String title;
  final Function() onClick;

  @override
  Widget build(BuildContext context) {
    return InkWell(
        onTap: onClick,
        child: Container(
            margin: const EdgeInsets.all(10),
            child: Text(title,
                style: const TextStyle(
                    fontSize: 20, color: Color.fromRGBO(252, 252, 252, 1)))));
  }
}
