// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'track.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$TrackLightImpl _$$TrackLightImplFromJson(Map<String, dynamic> json) =>
    _$TrackLightImpl(
      id: json['id'] as String,
      fileId: json['fileId'] as String,
      name: json['name'] as String,
      album: AlbumLight.fromJson(json['album'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$$TrackLightImplToJson(_$TrackLightImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'fileId': instance.fileId,
      'name': instance.name,
      'album': instance.album.toJson(),
    };
