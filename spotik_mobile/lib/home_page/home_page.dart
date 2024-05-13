import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/album_page/bloc/album_bloc.dart';
import 'package:spotik_mobile/album_page/services/album_repository.dart';
import 'package:spotik_mobile/components/drawer/drawer.dart';
import 'package:spotik_mobile/home_page/components/albums_carousel.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<StatefulWidget> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  @override
  Widget build(BuildContext context) {
    return RepositoryProvider(
        create: (context) => AlbumRepository(),
        child: BlocProvider(
            create: (context) =>
                AlbumsBloc(albumRepository: context.read<AlbumRepository>()),
            child: Scaffold(
              backgroundColor: Colors.transparent,
              appBar: AppBar(
                backgroundColor: Colors.transparent,
                iconTheme: Theme.of(context).iconTheme,
              ),
              drawer: const MyDrawer(),
              body: SingleChildScrollView(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.stretch,
                  children: [
                    const Padding(
                      padding: EdgeInsets.all(20.0),
                      child: Text(
                        "Classic Music",
                        style: TextStyle(
                          fontSize: 80,
                          fontWeight: FontWeight.bold,
                          color: CustomColors.goldenColor,
                        ),
                      ),
                    ),
                    Image.asset(
                      "assets/wheel.png",
                      fit: BoxFit.cover,
                    ),
                    const SizedBox(height: 20.0),
                    const Padding(
                      padding: EdgeInsets.symmetric(horizontal: 20.0),
                      child: Text(
                        "Albums",
                        style: TextStyle(
                          fontSize: TextSize.mediumTextSize,
                          fontWeight: FontWeight.bold,
                          color: CustomColors.goldenColor,
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
                    const AlbumsCarousel(),
                  ],
                ),
              ),
            )
        )
    );
  }
}
