// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'album.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AlbumDataImpl _$$AlbumDataImplFromJson(Map<String, dynamic> json) =>
    _$AlbumDataImpl(
      id: json['id'] as String,
      previewId: json['previewId'] as String,
      name: json['name'] as String,
      author: Author.fromJson(json['author'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$$AlbumDataImplToJson(_$AlbumDataImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'previewId': instance.previewId,
      'name': instance.name,
      'author': instance.author.toJson(),
    };
