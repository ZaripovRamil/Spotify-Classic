import 'package:audioplayers/audioplayers.dart';
import 'package:flutter/material.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class BottomPlayer extends StatefulWidget {
  const BottomPlayer({super.key});

  @override
  State<BottomPlayer> createState() => _BottomPlayerState();
}

class _BottomPlayerState extends State<BottomPlayer> {
  PlayerState _playerState = PlayerState.paused;

  bool get _isPlaying => _playerState == PlayerState.playing;

  bool get _isPaused => _playerState == PlayerState.paused;

  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.symmetric(vertical: 9, horizontal: 20),
      decoration: const BoxDecoration(
          color: CustomColors.backgroundColor,
          boxShadow: [
            BoxShadow(color: CustomColors.goldenColor, blurRadius: 5.0)
          ]),
      child: Row(
        children: <Widget>[
          Expanded(
            flex: 2,
            child: Image.network(
              "https://kartinki.pibig.info/uploads/posts/2023-04/1682442196_kartinki-pibig-info-p-kartinki-dlya-oblozhki-muzikalnogo-alboma-1.jpg",
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
                        children: [
                          Text(
                            "Song Name",
                            style: Theme.of(context)
                                .textTheme
                                .displaySmall
                                ?.copyWith(fontSize: 10.0),
                          ),
                          Text(
                            "Author",
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
                            onTap: (){},
                            child: const Icon(
                              Icons.skip_previous,
                              size: 24,
                              color: CustomColors.whiteColor,
                            ),
                          ),
                          InkWell(
                            onTap: () {
                              setState(() {
                                _playerState = (_isPlaying)
                                    ? PlayerState.paused
                                    : PlayerState.playing;
                              });
                            },
                            child: Icon(
                              (_isPlaying) ? Icons.pause : Icons.play_arrow,
                              size: 24,
                              color: CustomColors.whiteColor,
                            ),
                          ),
                          InkWell(
                            onTap: (){},
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
                    height: 5,
                  ),
                  SliderTheme(
                      data: Theme.of(context).sliderTheme,
                      child: Slider(
                        value: 0.0,
                        onChanged: (double value) {},
                      ))
                ]),
          )
        ],
      ),
    );
  }
}
