class ListenEvent {
  final String trackId;
  final int count;

  ListenEvent({required this.trackId, required this.count});

  factory ListenEvent.fromJson(Map<dynamic, dynamic> map) {
    if (map['TrackId'] == null || map['Count'] == null) {
      throw ArgumentError('TrackId and Count for ListenEvent cannot be null');
    }
    return ListenEvent(
      trackId: map['TrackId'],
      count: map['Count'],
    );
  }
}