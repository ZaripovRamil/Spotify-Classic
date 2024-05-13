import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/components/player/player_widget.dart';
import 'package:spotik_mobile/components/player/slide_top_route.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class BottomPlayer extends StatefulWidget {
  const BottomPlayer({super.key});

  @override
  State<BottomPlayer> createState() => _BottomPlayerState();
}

class _BottomPlayerState extends State<BottomPlayer> {
  @override
  Widget build(BuildContext context) {
    return Consumer<PlayerProvider>(builder: (context, value, child) {
      final tracklist = value.trackList;

      final currentTrack = tracklist[value.currentTrackIndex!];

      return InkWell(
        onTap: () {
          Navigator.push(context, SlideTopRoute(page: const PlayerWidget()));
        },
        child: Container(
          padding: const EdgeInsets.symmetric(vertical: 9, horizontal: 20),
          decoration: const BoxDecoration(
              color: CustomColors.playerBackgroundColor,
              boxShadow: [
                BoxShadow(color: CustomColors.subtitleColor, blurRadius: 4.0)
              ]),
          child: Row(
            children: <Widget>[
              Expanded(
                flex: 2,
                child: Image.network(
                  Endpoints.getPreviewUrl(currentTrack.album.previewId),
                ),
              ),
              const SizedBox(
                width: 10,
              ),
              Expanded(
                flex: 13,
                child: Column(
                    mainAxisSize: MainAxisSize.min,
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Row(
                        mainAxisSize: MainAxisSize.max,
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            mainAxisAlignment: MainAxisAlignment.center,
                            children: [
                              Text(
                                currentTrack.name,
                                style: Theme.of(context)
                                    .textTheme
                                    .displaySmall
                                    ?.copyWith(fontSize: 10.0),
                              ),
                              Text(
                                currentTrack.album.author.name,
                                style: Theme.of(context)
                                    .textTheme
                                    .displaySmall
                                    ?.copyWith(
                                        fontSize: 10.0,
                                        color: Colors.white.withOpacity(0.65)),
                              )
                            ],
                          ),
                          Row(
                            children: [
                              InkWell(
                                onTap: () {
                                  value.playPreviousSong();
                                },
                                child: const Icon(
                                  Icons.skip_previous,
                                  size: 24,
                                  color: CustomColors.whiteColor,
                                ),
                              ),
                              InkWell(
                                onTap: () {
                                  value.pauseOrResume();
                                },
                                child: Icon(
                                  (value.isPlaying) ? Icons.pause : Icons.play_arrow,
                                  size: 24,
                                  color: CustomColors.whiteColor,
                                ),
                              ),
                              InkWell(
                                onTap: () {
                                  value.playNextSong();
                                },
                                child: const Icon(
                                  Icons.skip_next,
                                  size: 24,
                                  color: CustomColors.whiteColor,
                                ),
                              ),
                            ],
                          ),
                        ],
                      ),
                      const SizedBox(
                        height: 8,
                      ),
                      SliderTheme(
                          data: Theme.of(context).sliderTheme,
                          child: Slider(
                            min: 0,
                            max: value.totalDuration.inSeconds.toDouble(),
                            value: value.currentDuration.inSeconds.toDouble(),
                            onChanged: (double value) {
                              
                            },
                            onChangeEnd: (double double){
                              value.seek(Duration(seconds: double.toInt()));
                            },
                          ))
                    ]),
              )
            ],
          ),
        ),
      );
    });
  }
}
