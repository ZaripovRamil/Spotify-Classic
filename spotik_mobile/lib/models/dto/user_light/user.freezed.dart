// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'user.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

UserLight _$UserLightFromJson(Map<String, dynamic> json) {
  return _UserLight.fromJson(json);
}

/// @nodoc
mixin _$UserLight {
  String get id => throw _privateConstructorUsedError;
  String get profilePicId => throw _privateConstructorUsedError;
  String get name => throw _privateConstructorUsedError;
  String? get username => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $UserLightCopyWith<UserLight> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $UserLightCopyWith<$Res> {
  factory $UserLightCopyWith(UserLight value, $Res Function(UserLight) then) =
      _$UserLightCopyWithImpl<$Res, UserLight>;
  @useResult
  $Res call({String id, String profilePicId, String name, String? username});
}

/// @nodoc
class _$UserLightCopyWithImpl<$Res, $Val extends UserLight>
    implements $UserLightCopyWith<$Res> {
  _$UserLightCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? profilePicId = null,
    Object? name = null,
    Object? username = freezed,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      profilePicId: null == profilePicId
          ? _value.profilePicId
          : profilePicId // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      username: freezed == username
          ? _value.username
          : username // ignore: cast_nullable_to_non_nullable
              as String?,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$UserLightImplCopyWith<$Res>
    implements $UserLightCopyWith<$Res> {
  factory _$$UserLightImplCopyWith(
          _$UserLightImpl value, $Res Function(_$UserLightImpl) then) =
      __$$UserLightImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String id, String profilePicId, String name, String? username});
}

/// @nodoc
class __$$UserLightImplCopyWithImpl<$Res>
    extends _$UserLightCopyWithImpl<$Res, _$UserLightImpl>
    implements _$$UserLightImplCopyWith<$Res> {
  __$$UserLightImplCopyWithImpl(
      _$UserLightImpl _value, $Res Function(_$UserLightImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? profilePicId = null,
    Object? name = null,
    Object? username = freezed,
  }) {
    return _then(_$UserLightImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      profilePicId: null == profilePicId
          ? _value.profilePicId
          : profilePicId // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      username: freezed == username
          ? _value.username
          : username // ignore: cast_nullable_to_non_nullable
              as String?,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$UserLightImpl implements _UserLight {
  const _$UserLightImpl(
      {required this.id,
      required this.profilePicId,
      required this.name,
      required this.username});

  factory _$UserLightImpl.fromJson(Map<String, dynamic> json) =>
      _$$UserLightImplFromJson(json);

  @override
  final String id;
  @override
  final String profilePicId;
  @override
  final String name;
  @override
  final String? username;

  @override
  String toString() {
    return 'UserLight(id: $id, profilePicId: $profilePicId, name: $name, username: $username)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$UserLightImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.profilePicId, profilePicId) ||
                other.profilePicId == profilePicId) &&
            (identical(other.name, name) || other.name == name) &&
            (identical(other.username, username) ||
                other.username == username));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode =>
      Object.hash(runtimeType, id, profilePicId, name, username);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$UserLightImplCopyWith<_$UserLightImpl> get copyWith =>
      __$$UserLightImplCopyWithImpl<_$UserLightImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$UserLightImplToJson(
      this,
    );
  }
}

abstract class _UserLight implements UserLight {
  const factory _UserLight(
      {required final String id,
      required final String profilePicId,
      required final String name,
      required final String? username}) = _$UserLightImpl;

  factory _UserLight.fromJson(Map<String, dynamic> json) =
      _$UserLightImpl.fromJson;

  @override
  String get id;
  @override
  String get profilePicId;
  @override
  String get name;
  @override
  String? get username;
  @override
  @JsonKey(ignore: true)
  _$$UserLightImplCopyWith<_$UserLightImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
