// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'author.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

AuthorLight _$AuthorLightFromJson(Map<String, dynamic> json) {
  return _AuthorLight.fromJson(json);
}

/// @nodoc
mixin _$AuthorLight {
  String get id => throw _privateConstructorUsedError;
  String get name => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $AuthorLightCopyWith<AuthorLight> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AuthorLightCopyWith<$Res> {
  factory $AuthorLightCopyWith(
          AuthorLight value, $Res Function(AuthorLight) then) =
      _$AuthorLightCopyWithImpl<$Res, AuthorLight>;
  @useResult
  $Res call({String id, String name});
}

/// @nodoc
class _$AuthorLightCopyWithImpl<$Res, $Val extends AuthorLight>
    implements $AuthorLightCopyWith<$Res> {
  _$AuthorLightCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? name = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$AuthorLightImplCopyWith<$Res>
    implements $AuthorLightCopyWith<$Res> {
  factory _$$AuthorLightImplCopyWith(
          _$AuthorLightImpl value, $Res Function(_$AuthorLightImpl) then) =
      __$$AuthorLightImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String id, String name});
}

/// @nodoc
class __$$AuthorLightImplCopyWithImpl<$Res>
    extends _$AuthorLightCopyWithImpl<$Res, _$AuthorLightImpl>
    implements _$$AuthorLightImplCopyWith<$Res> {
  __$$AuthorLightImplCopyWithImpl(
      _$AuthorLightImpl _value, $Res Function(_$AuthorLightImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? name = null,
  }) {
    return _then(_$AuthorLightImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$AuthorLightImpl implements _AuthorLight {
  const _$AuthorLightImpl({required this.id, required this.name});

  factory _$AuthorLightImpl.fromJson(Map<String, dynamic> json) =>
      _$$AuthorLightImplFromJson(json);

  @override
  final String id;
  @override
  final String name;

  @override
  String toString() {
    return 'AuthorLight(id: $id, name: $name)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AuthorLightImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.name, name) || other.name == name));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(runtimeType, id, name);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$AuthorLightImplCopyWith<_$AuthorLightImpl> get copyWith =>
      __$$AuthorLightImplCopyWithImpl<_$AuthorLightImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$AuthorLightImplToJson(
      this,
    );
  }
}

abstract class _AuthorLight implements AuthorLight {
  const factory _AuthorLight(
      {required final String id,
      required final String name}) = _$AuthorLightImpl;

  factory _AuthorLight.fromJson(Map<String, dynamic> json) =
      _$AuthorLightImpl.fromJson;

  @override
  String get id;
  @override
  String get name;
  @override
  @JsonKey(ignore: true)
  _$$AuthorLightImplCopyWith<_$AuthorLightImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
