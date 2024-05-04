// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'album.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AlbumLightImpl _$$AlbumLightImplFromJson(Map<String, dynamic> json) =>
    _$AlbumLightImpl(
      id: json['id'] as String,
      previewId: json['previewId'] as String,
      name: json['name'] as String,
      author: AuthorLight.fromJson(json['author'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$$AlbumLightImplToJson(_$AlbumLightImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'previewId': instance.previewId,
      'name': instance.name,
      'author': instance.author.toJson(),
    };
