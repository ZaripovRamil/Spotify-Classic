// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'albums.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AlbumsDtoImpl _$$AlbumsDtoImplFromJson(Map<String, dynamic> json) =>
    _$AlbumsDtoImpl(
      albums: (json['albums'] as List<dynamic>)
          .map((e) => AlbumData.fromJson(e as Map<String, dynamic>))
          .toList(),
    );

Map<String, dynamic> _$$AlbumsDtoImplToJson(_$AlbumsDtoImpl instance) =>
    <String, dynamic>{
      'albums': instance.albums.map((e) => e.toJson()).toList(),
    };
