// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'playlist.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$PlaylistImpl _$$PlaylistImplFromJson(Map<String, dynamic> json) =>
    _$PlaylistImpl(
      id: json['id'] as String,
      prewiewId: json['prewiewId'] as String,
      name: json['name'] as String,
      owner: json['owner'] as String,
      tracks: (json['tracks'] as List<dynamic>)
          .map((e) => Track.fromJson(e as Map<String, dynamic>))
          .toList(),
    );

Map<String, dynamic> _$$PlaylistImplToJson(_$PlaylistImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'prewiewId': instance.prewiewId,
      'name': instance.name,
      'owner': instance.owner,
      'tracks': instance.tracks.map((e) => e.toJson()).toList(),
    };
