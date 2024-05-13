// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'search.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$SearchDtoImpl _$$SearchDtoImplFromJson(Map<String, dynamic> json) =>
    _$SearchDtoImpl(
      tracks: (json['tracks'] as List<dynamic>)
          .map((e) => Track.fromJson(e as Map<String, dynamic>))
          .toList(),
      albums: (json['albums'] as List<dynamic>)
          .map((e) => AlbumData.fromJson(e as Map<String, dynamic>))
          .toList(),
      authors: (json['authors'] as List<dynamic>)
          .map((e) => Author.fromJson(e as Map<String, dynamic>))
          .toList(),
      playlists: (json['playlists'] as List<dynamic>)
          .map((e) => Playlist.fromJson(e as Map<String, dynamic>))
          .toList(),
    );

Map<String, dynamic> _$$SearchDtoImplToJson(_$SearchDtoImpl instance) =>
    <String, dynamic>{
      'tracks': instance.tracks.map((e) => e.toJson()).toList(),
      'albums': instance.albums.map((e) => e.toJson()).toList(),
      'authors': instance.authors.map((e) => e.toJson()).toList(),
      'playlists': instance.playlists.map((e) => e.toJson()).toList(),
    };
