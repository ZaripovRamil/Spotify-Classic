// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'register.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$RegisterDtoImpl _$$RegisterDtoImplFromJson(Map<String, dynamic> json) =>
    _$RegisterDtoImpl(
      isSuccessful: json['isSuccessful'] as bool,
      userId: json['userId'] as String?,
      resultMessage: json['resultMessage'] as String,
    );

Map<String, dynamic> _$$RegisterDtoImplToJson(_$RegisterDtoImpl instance) =>
    <String, dynamic>{
      'isSuccessful': instance.isSuccessful,
      'userId': instance.userId,
      'resultMessage': instance.resultMessage,
    };
