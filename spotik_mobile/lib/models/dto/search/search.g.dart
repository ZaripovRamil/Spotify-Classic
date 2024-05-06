// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'search.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$SearchDtoImpl _$$SearchDtoImplFromJson(Map<String, dynamic> json) =>
    _$SearchDtoImpl(
      Tracks: (json['Tracks'] as List<dynamic>)
          .map((e) => Track.fromJson(e as Map<String, dynamic>))
          .toList(),
      Albums: (json['Albums'] as List<dynamic>)
          .map((e) => Album.fromJson(e as Map<String, dynamic>))
          .toList(),
      Authors: (json['Authors'] as List<dynamic>)
          .map((e) => Author.fromJson(e as Map<String, dynamic>))
          .toList(),
      Playlists: (json['Playlists'] as List<dynamic>)
          .map((e) => Playlist.fromJson(e as Map<String, dynamic>))
          .toList(),
    );

Map<String, dynamic> _$$SearchDtoImplToJson(_$SearchDtoImpl instance) =>
    <String, dynamic>{
      'Tracks': instance.Tracks.map((e) => e.toJson()).toList(),
      'Albums': instance.Albums.map((e) => e.toJson()).toList(),
      'Authors': instance.Authors.map((e) => e.toJson()).toList(),
      'Playlists': instance.Playlists.map((e) => e.toJson()).toList(),
    };
