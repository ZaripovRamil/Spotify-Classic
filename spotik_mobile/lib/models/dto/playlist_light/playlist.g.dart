// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'playlist.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$PlaylistLightImpl _$$PlaylistLightImplFromJson(Map<String, dynamic> json) =>
    _$PlaylistLightImpl(
      id: json['id'] as String,
      previewId: json['previewId'] as String,
      name: json['name'] as String,
      owner: UserLight.fromJson(json['owner'] as Map<String, dynamic>),
      trackCount: json['trackCount'] as int,
    );

Map<String, dynamic> _$$PlaylistLightImplToJson(_$PlaylistLightImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'previewId': instance.previewId,
      'name': instance.name,
      'owner': instance.owner.toJson(),
      'trackCount': instance.trackCount,
    };
