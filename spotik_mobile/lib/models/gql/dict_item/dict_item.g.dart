// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'dict_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$GraphQlDictionaryItemImpl _$$GraphQlDictionaryItemImplFromJson(
        Map<String, dynamic> json) =>
    _$GraphQlDictionaryItemImpl(
      key: json['key'] as String,
      value: (json['value'] as num).toInt(),
    );

Map<String, dynamic> _$$GraphQlDictionaryItemImplToJson(
        _$GraphQlDictionaryItemImpl instance) =>
    <String, dynamic>{
      'key': instance.key,
      'value': instance.value,
    };
