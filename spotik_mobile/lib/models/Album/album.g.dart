// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'album.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AlbumImpl _$$AlbumImplFromJson(Map<String, dynamic> json) => _$AlbumImpl(
      id: json['id'] as String,
      prewiewId: json['prewiewId'] as String,
      name: json['name'] as String,
      author: Author.fromJson(json['author'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$$AlbumImplToJson(_$AlbumImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'prewiewId': instance.prewiewId,
      'name': instance.name,
      'author': instance.author.toJson(),
    };
