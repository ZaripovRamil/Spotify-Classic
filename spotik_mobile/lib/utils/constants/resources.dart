class Endpoints {
  static String graphQL = 'http://10.0.2.2:5245/graphql';
  static String tracks = 'http://10.0.2.2:5075/tracks';
  static String previews = 'http://10.0.2.2:5201/previews';

  static String getPreviewUrl(String previewId) =>
      'http://10.0.2.2:5201/previews/$previewId';

  static String getTrackUrl(String trackId) =>
      'http://10.0.2.2:5075/tracks/get/$trackId';
}