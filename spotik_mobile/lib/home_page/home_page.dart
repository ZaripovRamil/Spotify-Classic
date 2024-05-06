import 'package:flutter/material.dart';
import 'package:spotik_mobile/components/drawer/drawer.dart';
import 'package:spotik_mobile/home_page/components/playlist_card.dart';
import 'package:spotik_mobile/models/dto/album_light/album.dart';
import 'package:spotik_mobile/models/dto/author_light/author.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<StatefulWidget> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  final data = const AlbumData(
      id: "1",
      name: "Title",
      previewId: "assets/compositor.png",
      author: Author(id: "1", name: "Author name"));

  AlbumData getData() {
    return data;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
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
            SizedBox(
              height: 260,
              child: ListView.builder(
                scrollDirection: Axis.horizontal,
                itemCount: 5,
                itemBuilder: (context, index) {
                  return Padding(
                    padding: const EdgeInsets.all(10.0),
                    child: PlaylistCard(data: getData()),
                  );
                },
              ),
            ),
          ],
        ),
      ),
    );
  }
}
