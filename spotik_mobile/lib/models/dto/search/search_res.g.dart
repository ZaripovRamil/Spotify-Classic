// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'search_res.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$SearchResultDtoImpl _$$SearchResultDtoImplFromJson(
        Map<String, dynamic> json) =>
    _$SearchResultDtoImpl(
      isSuccessful: json['isSuccessful'] as bool,
      data: json['data'] == null
          ? null
          : SearchDto.fromJson(json['data'] as Map<String, dynamic>),
      errorMessage: json['errorMessage'] as String,
    );

Map<String, dynamic> _$$SearchResultDtoImplToJson(
        _$SearchResultDtoImpl instance) =>
    <String, dynamic>{
      'isSuccessful': instance.isSuccessful,
      'data': instance.data?.toJson(),
      'errorMessage': instance.errorMessage,
    };
