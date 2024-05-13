import 'package:flutter/material.dart';
import 'package:spotik_mobile/utils/navigation_routes.dart';

class MyDrawer extends StatelessWidget {
  const MyDrawer({super.key});


  @override
  Widget build(BuildContext context) {
    goToPage(String route) {
      Navigator.popAndPushNamed(context, route);
    }

    return Drawer(
      backgroundColor: const Color.fromRGBO(19, 19, 22, 0.8),
      child: ListView(
        children: [
          _HomeDrawerElement(
            title: 'Home',
            onClick: () => goToPage(NavigationRoutes.main),
          ),
          _HomeDrawerElement(
            title: 'Profile',
            onClick: () => goToPage(NavigationRoutes.profile),
          ),
          _HomeDrawerElement(
              title: 'Authorization',
              onClick: () => goToPage(NavigationRoutes.auth)
          ),
          _HomeDrawerElement(
              title: 'Search',
              onClick: () => goToPage(NavigationRoutes.search)
          ),
          _HomeDrawerElement(
              title: 'Support Chat',
              onClick: () => goToPage(NavigationRoutes.chat)
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
