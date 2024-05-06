import 'package:audioplayers/audioplayers.dart';
import 'package:flutter/material.dart';
import 'package:spotik_mobile/models/dto/track_light/track.dart';

class PlayerProvider extends ChangeNotifier {
  List<Track> _trackList = [];

  int? _currentTrackIndex;
  String? _currentTrackListId;

  //player

  final AudioPlayer _audioPlayer = AudioPlayer();

  Duration _currentDuration = Duration.zero;
  Duration _totalDuration = Duration.zero;

  PlayerProvider() {
    listenToDuration();
  }

  bool _isPlaying = false;

  void play() async {
    final String path = _trackList[_currentTrackIndex!].fileId;
    await _audioPlayer.stop();
    await _audioPlayer.play(UrlSource(path));
    _isPlaying = true;
    notifyListeners();
  }

  void pause() async {
    await _audioPlayer.pause();
    _isPlaying = false;
    notifyListeners();
  }

  void resume() async {
    await _audioPlayer.resume();
    _isPlaying = true;
    notifyListeners();
  }

  void pauseOrResume() async {
    if (_isPlaying) {
      pause();
    } else {
      resume();
    }
    notifyListeners();
  }

  void seek(Duration position) async {
    await _audioPlayer.seek(position);
  }

  void playNextSong() {
    if (_currentTrackIndex != null) {
      if (_currentTrackIndex! < _trackList.length - 1) {
        currentTrackIndex = _currentTrackIndex! + 1;
      } else {
        currentTrackIndex = 0;
      }
    }
  }

  void playPreviousSong() async {
    if (_currentDuration.inSeconds > 2) {
      seek(Duration.zero);
    } else {
      if (_currentTrackIndex! > 0) {
        currentTrackIndex = _currentTrackIndex! - 1;
      } else {
        currentTrackIndex = _trackList.length - 1;
      }
    }
  }

  void listenToDuration() {
    _audioPlayer.onDurationChanged.listen((newDuration) {
      _totalDuration = newDuration;
      notifyListeners();
    });

    _audioPlayer.onPositionChanged.listen((newPosition) {
      _currentDuration = newPosition;
      notifyListeners();
    });

    _audioPlayer.onPlayerComplete.listen((event) {playNextSong();});
  }

  //getters

  List<Track> get trackList => _trackList;
  int? get currentTrackIndex => _currentTrackIndex;
  String? get currentTrackListId => _currentTrackListId;
  bool get isPlaying => _isPlaying;
  Duration get currentDuration => _currentDuration;
  Duration get totalDuration => _totalDuration;

  // setters

  set currentTrackIndex(int? newIndex) {
    _currentTrackIndex = newIndex;

    if (newIndex != null){
      play();
    }
    notifyListeners();
  }

  set trackList(List<Track> newtrackList) {
    _trackList = newtrackList;
    notifyListeners();
  }

  set currentTrackListId(String? newtracklistId) {
    _currentTrackListId = newtracklistId;
    notifyListeners();
  }

  set tracklist(List<Track> newTracklist) {
    _trackList = newTracklist;
    notifyListeners();
  }
}
