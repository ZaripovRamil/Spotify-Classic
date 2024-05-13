// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'history.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$HistoryDtoImpl _$$HistoryDtoImplFromJson(Map<String, dynamic> json) =>
    _$HistoryDtoImpl(
      history: (json['history'] as List<dynamic>?)
          ?.map((e) => Track.fromJson(e as Map<String, dynamic>))
          .toList(),
    );

Map<String, dynamic> _$$HistoryDtoImplToJson(_$HistoryDtoImpl instance) =>
    <String, dynamic>{
      'history': instance.history?.map((e) => e.toJson()).toList(),
    };
