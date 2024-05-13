import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:spotik_mobile/models/player_provider.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class PlayerWidget extends StatefulWidget {
  const PlayerWidget({super.key});

  @override
  State<PlayerWidget> createState() => _PlayerWidgetState();
}

class _PlayerWidgetState extends State<PlayerWidget> {

  String formatTime(Duration duration){
    String twoDigitSeconds = duration.inSeconds.remainder(60).toString().padLeft(2,'0');
    return "${duration.inMinutes}:$twoDigitSeconds";
  }

  @override
  Widget build(BuildContext context) {
    return Consumer<PlayerProvider>(builder: (context, value, child) {
      final tracklist = value.trackList;
      final currentTrack = tracklist[value.currentTrackIndex!];
      return Scaffold(
        body: Container(
          padding: const EdgeInsets.symmetric(vertical: 23),
          decoration: CustomDecorations.backgroundDecoration,
          child: Column(
            children: [
              Align(
                  alignment: Alignment.centerLeft,
                  child: IconButton(
                    onPressed: () {
                      Navigator.pop(context);
                    },
                    icon: const Icon(Icons.keyboard_arrow_down),
                    iconSize: 40,
                  )),
              Expanded(
                flex: 2,
                child: Container(
                  margin:
                      const EdgeInsets.symmetric(vertical: 60, horizontal: 80),
                  child: Center(
                    child: Image.network(
                      Endpoints.getPreviewUrl(currentTrack.album.previewId),
                    ),
                  ),
                ),
              ),
              Expanded(
                child: Container(
                  margin: const EdgeInsets.symmetric(horizontal: 25),
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        mainAxisSize: MainAxisSize.max,
                        children: [
                          Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                currentTrack.name,
                                style:
                                    Theme.of(context).textTheme.displayMedium,
                              ),
                              const SizedBox(
                                height: 5,
                              ),
                              Text(
                                currentTrack.album.author.name,
                                style: Theme.of(context)
                                    .textTheme
                                    .displayMedium
                                    ?.copyWith(
                                        color: Colors.white.withOpacity(0.65)),
                              )
                            ],
                          ),
                          // const Row(
                          //   children: [
                          //     InkWell(
                          //       child: Icon(
                          //         Icons.sync,
                          //         color: CustomColors.whiteColor,
                          //         size: 25,
                          //       ),
                          //     ),
                          //     SizedBox(
                          //       width: 5,
                          //     ),
                          //     InkWell(
                          //       child: Icon(
                          //         Icons.shuffle,
                          //         color: CustomColors.whiteColor,
                          //         size: 25,
                          //       ),
                          //     ),
                          //     SizedBox(
                          //       width: 5,
                          //     ),
                          //     InkWell(
                          //       child: Icon(
                          //         Icons.favorite_border,
                          //         color: CustomColors.whiteColor,
                          //         size: 25,
                          //       ),
                          //     ),
                          //   ],
                          // )
                        ],
                      ),
                      const SizedBox(
                        height: 30,
                      ),
                      Column(
                        children: [
                          SliderTheme(
                              data: Theme.of(context).sliderTheme,
                              child: Slider(
                                min: 0,
                                max: value.totalDuration.inSeconds.toDouble(),
                                value:
                                    value.currentDuration.inSeconds.toDouble(),
                                onChanged: (double value) {},
                                onChangeEnd: (double double) {
                                  value.seek(Duration(seconds: double.toInt()));
                                },
                              )),
                          const SizedBox(
                            height: 10,
                          ),
                          Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            mainAxisSize: MainAxisSize.max,
                            children: [
                              Text(
                                formatTime(value.currentDuration),
                                style: Theme.of(context)
                                    .textTheme
                                    .displaySmall
                                    ?.copyWith(fontSize: 10),
                              ),
                              Text(
                                formatTime(value.totalDuration),
                                style: Theme.of(context)
                                    .textTheme
                                    .displaySmall
                                    ?.copyWith(fontSize: 10),
                              ),
                            ],
                          )
                        ],
                      )
                    ],
                  ),
                ),
              ),
              Expanded(
                child: Row(
                  crossAxisAlignment: CrossAxisAlignment.center,
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    InkWell(
                      onTap: () {
                        value.playPreviousSong();
                      },
                      child: const Icon(
                        Icons.skip_previous,
                        size: 55,
                        color: CustomColors.whiteColor,
                      ),
                    ),
                    InkWell(
                      onTap: () {
                        value.pauseOrResume();
                      },
                      child: Icon(
                        (value.isPlaying) ? Icons.pause : Icons.play_arrow,
                        size: 75,
                        color: CustomColors.whiteColor,
                      ),
                    ),
                    InkWell(
                      onTap: () {
                        value.playNextSong();
                      },
                      child: const Icon(
                        Icons.skip_next,
                        size: 55,
                        color: CustomColors.whiteColor,
                      ),
                    ),
                  ],
                ),
              )
            ],
          ),
        ),
      );
    });
  }
}
