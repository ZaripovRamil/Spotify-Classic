// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'album.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AlbumFullImpl _$$AlbumFullImplFromJson(Map<String, dynamic> json) =>
    _$AlbumFullImpl(
      id: json['id'] as String,
      previewId: json['previewId'] as String,
      name: json['name'] as String,
      author: AuthorLight.fromJson(json['author'] as Map<String, dynamic>),
      tracks: (json['tracks'] as List<dynamic>)
          .map((e) => TrackLight.fromJson(e as Map<String, dynamic>))
          .toList(),
      type: json['type'] as String,
    );

Map<String, dynamic> _$$AlbumFullImplToJson(_$AlbumFullImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'previewId': instance.previewId,
      'name': instance.name,
      'author': instance.author.toJson(),
      'tracks': instance.tracks.map((e) => e.toJson()).toList(),
      'type': instance.type,
    };
