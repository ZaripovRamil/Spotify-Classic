// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'message.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$MessageImpl _$$MessageImplFromJson(Map<String, dynamic> json) =>
    _$MessageImpl(
      groupName: json['groupName'] as String,
      user: json['user'] as String,
      timestamp: DateTime.parse(json['timestamp'] as String),
      message: json['message'] as String,
      isOwner: json['isOwner'] as bool,
    );

Map<String, dynamic> _$$MessageImplToJson(_$MessageImpl instance) =>
    <String, dynamic>{
      'groupName': instance.groupName,
      'user': instance.user,
      'timestamp': instance.timestamp.toIso8601String(),
      'message': instance.message,
      'isOwner': instance.isOwner,
    };
