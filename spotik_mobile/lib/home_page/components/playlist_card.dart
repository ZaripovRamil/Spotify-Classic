import 'package:flutter/material.dart';
import 'package:spotik_mobile/models/AlbumData/album_data.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class PlaylistCard extends StatelessWidget {
  const PlaylistCard({required this.data, super.key});
  final AlbumData data;

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      width: 170.0,
      child: GestureDetector(
        onTap: () {
          Navigator.pushNamed(context, '/album', arguments: data.id);
        },
        child: Card(
          color: CustomColors.backgroundColor,
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
                      data.name,
                      style: const TextStyle(
                        fontSize: TextSize.mediumTextSize,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    Text(
                      data.author.name,
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