// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'login.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$LoginDtoImpl _$$LoginDtoImplFromJson(Map<String, dynamic> json) =>
    _$LoginDtoImpl(
      isSuccessful: json['isSuccessful'] as bool,
      token: json['token'] as String,
      resultMessage: json['resultMessage'] as String,
    );

Map<String, dynamic> _$$LoginDtoImplToJson(_$LoginDtoImpl instance) =>
    <String, dynamic>{
      'isSuccessful': instance.isSuccessful,
      'token': instance.token,
      'resultMessage': instance.resultMessage,
    };
