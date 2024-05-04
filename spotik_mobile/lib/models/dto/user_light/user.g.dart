// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$UserLightImpl _$$UserLightImplFromJson(Map<String, dynamic> json) =>
    _$UserLightImpl(
      id: json['id'] as String,
      profilePicId: json['profilePicId'] as String,
      name: json['name'] as String,
      username: json['username'] as String?,
    );

Map<String, dynamic> _$$UserLightImplToJson(_$UserLightImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'profilePicId': instance.profilePicId,
      'name': instance.name,
      'username': instance.username,
    };
