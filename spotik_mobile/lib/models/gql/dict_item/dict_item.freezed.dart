// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'dict_item.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

GraphQlDictionaryItem _$GraphQlDictionaryItemFromJson(
    Map<String, dynamic> json) {
  return _GraphQlDictionaryItem.fromJson(json);
}

/// @nodoc
mixin _$GraphQlDictionaryItem {
  String get key => throw _privateConstructorUsedError;
  int get value => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $GraphQlDictionaryItemCopyWith<GraphQlDictionaryItem> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $GraphQlDictionaryItemCopyWith<$Res> {
  factory $GraphQlDictionaryItemCopyWith(GraphQlDictionaryItem value,
          $Res Function(GraphQlDictionaryItem) then) =
      _$GraphQlDictionaryItemCopyWithImpl<$Res, GraphQlDictionaryItem>;
  @useResult
  $Res call({String key, int value});
}

/// @nodoc
class _$GraphQlDictionaryItemCopyWithImpl<$Res,
        $Val extends GraphQlDictionaryItem>
    implements $GraphQlDictionaryItemCopyWith<$Res> {
  _$GraphQlDictionaryItemCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? key = null,
    Object? value = null,
  }) {
    return _then(_value.copyWith(
      key: null == key
          ? _value.key
          : key // ignore: cast_nullable_to_non_nullable
              as String,
      value: null == value
          ? _value.value
          : value // ignore: cast_nullable_to_non_nullable
              as int,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$GraphQlDictionaryItemImplCopyWith<$Res>
    implements $GraphQlDictionaryItemCopyWith<$Res> {
  factory _$$GraphQlDictionaryItemImplCopyWith(
          _$GraphQlDictionaryItemImpl value,
          $Res Function(_$GraphQlDictionaryItemImpl) then) =
      __$$GraphQlDictionaryItemImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String key, int value});
}

/// @nodoc
class __$$GraphQlDictionaryItemImplCopyWithImpl<$Res>
    extends _$GraphQlDictionaryItemCopyWithImpl<$Res,
        _$GraphQlDictionaryItemImpl>
    implements _$$GraphQlDictionaryItemImplCopyWith<$Res> {
  __$$GraphQlDictionaryItemImplCopyWithImpl(_$GraphQlDictionaryItemImpl _value,
      $Res Function(_$GraphQlDictionaryItemImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? key = null,
    Object? value = null,
  }) {
    return _then(_$GraphQlDictionaryItemImpl(
      key: null == key
          ? _value.key
          : key // ignore: cast_nullable_to_non_nullable
              as String,
      value: null == value
          ? _value.value
          : value // ignore: cast_nullable_to_non_nullable
              as int,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$GraphQlDictionaryItemImpl implements _GraphQlDictionaryItem {
  const _$GraphQlDictionaryItemImpl({required this.key, required this.value});

  factory _$GraphQlDictionaryItemImpl.fromJson(Map<String, dynamic> json) =>
      _$$GraphQlDictionaryItemImplFromJson(json);

  @override
  final String key;
  @override
  final int value;

  @override
  String toString() {
    return 'GraphQlDictionaryItem(key: $key, value: $value)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$GraphQlDictionaryItemImpl &&
            (identical(other.key, key) || other.key == key) &&
            (identical(other.value, value) || other.value == value));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(runtimeType, key, value);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$GraphQlDictionaryItemImplCopyWith<_$GraphQlDictionaryItemImpl>
      get copyWith => __$$GraphQlDictionaryItemImplCopyWithImpl<
          _$GraphQlDictionaryItemImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$GraphQlDictionaryItemImplToJson(
      this,
    );
  }
}

abstract class _GraphQlDictionaryItem implements GraphQlDictionaryItem {
  const factory _GraphQlDictionaryItem(
      {required final String key,
      required final int value}) = _$GraphQlDictionaryItemImpl;

  factory _GraphQlDictionaryItem.fromJson(Map<String, dynamic> json) =
      _$GraphQlDictionaryItemImpl.fromJson;

  @override
  String get key;
  @override
  int get value;
  @override
  @JsonKey(ignore: true)
  _$$GraphQlDictionaryItemImplCopyWith<_$GraphQlDictionaryItemImpl>
      get copyWith => throw _privateConstructorUsedError;
}
