import 'package:flutter/material.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<StatefulWidget> createState() => _HomePageState();
}

class AlbumData {
  final String title;
  final String authorName;

  AlbumData({
    required this.title,
    required this.authorName,
  });
}

class _HomePageState extends State<HomePage> {
  final data = AlbumData(title: "Title", authorName: "Author");

  AlbumData getData() {
    return data;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.transparent,
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
                    child: _buildPlaylistCard(context, getData()),
                  );
                },
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildPlaylistCard(BuildContext context, AlbumData data) {
    return SizedBox(
      width: 170.0,
      child: GestureDetector(
        onTap: () {

        },
        child: Card(
          color: Colors.transparent,
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(10.0),
          ),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: [
              ClipRRect(
                borderRadius:
                    const BorderRadius.vertical(top: Radius.circular(10.0)),
                child: Image.asset(
                  "assets/compositor.png",
                  fit: BoxFit.cover,
                ),
              ),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      data.title,
                      style: const TextStyle(
                        fontSize: TextSize.mediumTextSize,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    Text(
                      data.authorName,
                      style: const TextStyle(
                        fontSize: TextSize.smallTextSize,
                        color: Colors.grey,
                      ),
                      maxLines: 1,
                      overflow: TextOverflow.ellipsis,
                    ),
                  ],
                ),
              ),
            ],
          ),
        )
      ),
    );
  }
}
