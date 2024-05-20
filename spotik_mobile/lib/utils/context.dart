class Context {
  bool _stopped = false;
  bool get stopped => _stopped;

  Context();

  void stop() {
    _stopped = true;
  }
}