// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'album.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AlbumImpl _$$AlbumImplFromJson(Map<String, dynamic> json) => _$AlbumImpl(
      id: json['id'] as String,
      previewId: json['previewId'] as String,
      name: json['name'] as String,
      author: Author.fromJson(json['author'] as Map<String, dynamic>),
      tracks: (json['tracks'] as List<dynamic>)
          .map((e) => Track.fromJson(e as Map<String, dynamic>))
          .toList(),
      listenCounts: (json['listenCounts'] as List<dynamic>)
          .map((e) => GraphQlDictionaryItem.fromJson(e as Map<String, dynamic>))
          .toList(),
      type: json['type'] as String,
    );

Map<String, dynamic> _$$AlbumImplToJson(_$AlbumImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'previewId': instance.previewId,
      'name': instance.name,
      'author': instance.author.toJson(),
      'tracks': instance.tracks.map((e) => e.toJson()).toList(),
      'listenCounts': instance.listenCounts.map((e) => e.toJson()).toList(),
      'type': instance.type,
    };
