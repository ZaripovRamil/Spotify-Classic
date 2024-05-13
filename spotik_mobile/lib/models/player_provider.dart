import 'package:flutter/material.dart';
import 'package:just_audio/just_audio.dart';
import 'package:spotik_mobile/models/entity/track_light/track.dart';
import 'package:spotik_mobile/utils/constants/resources.dart';

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

  void play() async {
    final String path = Endpoints.getTrackUrl(_trackList[_currentTrackIndex!].id);
    final audioSource = HlsAudioSource(
        Uri.parse(path)
    );
    // var headers = { 'Authorization': 'Bearer ${await Storage.getToken()}' };
    await _audioPlayer.setAudioSource(audioSource);
    await _audioPlayer.play();
    notifyListeners();
  }

  void pause() async {
    await _audioPlayer.pause();
    notifyListeners();
  }

  void resume() async {
    await _audioPlayer.play();
    notifyListeners();
  }

  void pauseOrResume() async {
    if (_audioPlayer.playing) {
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
    _audioPlayer.durationStream.listen((newDuration) {
      _totalDuration = newDuration!;
      notifyListeners();
    });

    _audioPlayer.positionStream.listen((newPosition) {
      _currentDuration = newPosition;
      notifyListeners();
    });

    _audioPlayer.processingStateStream.listen((state) {
      if (state == ProcessingState.completed) {
        playNextSong();
      }
    });
  }

  //getters

  List<Track> get trackList => _trackList;
  int? get currentTrackIndex => _currentTrackIndex;
  String? get currentTrackListId => _currentTrackListId;
  bool get isPlaying => _audioPlayer.playing;
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
