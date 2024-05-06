// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'track.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$TrackImpl _$$TrackImplFromJson(Map<String, dynamic> json) => _$TrackImpl(
      id: json['id'] as String,
      fileId: json['fileId'] as String,
      name: json['name'] as String,
      album: AlbumData.fromJson(json['album'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$$TrackImplToJson(_$TrackImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'fileId': instance.fileId,
      'name': instance.name,
      'album': instance.album.toJson(),
    };
