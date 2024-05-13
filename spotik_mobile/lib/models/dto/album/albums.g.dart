// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'albums.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AlbumsDtoImpl _$$AlbumsDtoImplFromJson(Map<String, dynamic> json) =>
    _$AlbumsDtoImpl(
      isSuccessful: json['isSuccessful'] as bool,
      albums: (json['albums'] as List<dynamic>?)
          ?.map((e) => AlbumData.fromJson(e as Map<String, dynamic>))
          .toList(),
      resultMessage: json['resultMessage'] as String,
    );

Map<String, dynamic> _$$AlbumsDtoImplToJson(_$AlbumsDtoImpl instance) =>
    <String, dynamic>{
      'isSuccessful': instance.isSuccessful,
      'albums': instance.albums?.map((e) => e.toJson()).toList(),
      'resultMessage': instance.resultMessage,
    };
