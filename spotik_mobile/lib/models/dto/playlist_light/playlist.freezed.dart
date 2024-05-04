// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'playlist.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

PlaylistLight _$PlaylistLightFromJson(Map<String, dynamic> json) {
  return _PlaylistLight.fromJson(json);
}

/// @nodoc
mixin _$PlaylistLight {
  String get id => throw _privateConstructorUsedError;
  String get previewId => throw _privateConstructorUsedError;
  String get name => throw _privateConstructorUsedError;
  UserLight get owner => throw _privateConstructorUsedError;
  int get trackCount => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $PlaylistLightCopyWith<PlaylistLight> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $PlaylistLightCopyWith<$Res> {
  factory $PlaylistLightCopyWith(
          PlaylistLight value, $Res Function(PlaylistLight) then) =
      _$PlaylistLightCopyWithImpl<$Res, PlaylistLight>;
  @useResult
  $Res call(
      {String id,
      String previewId,
      String name,
      UserLight owner,
      int trackCount});

  $UserLightCopyWith<$Res> get owner;
}

/// @nodoc
class _$PlaylistLightCopyWithImpl<$Res, $Val extends PlaylistLight>
    implements $PlaylistLightCopyWith<$Res> {
  _$PlaylistLightCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? previewId = null,
    Object? name = null,
    Object? owner = null,
    Object? trackCount = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      previewId: null == previewId
          ? _value.previewId
          : previewId // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      owner: null == owner
          ? _value.owner
          : owner // ignore: cast_nullable_to_non_nullable
              as UserLight,
      trackCount: null == trackCount
          ? _value.trackCount
          : trackCount // ignore: cast_nullable_to_non_nullable
              as int,
    ) as $Val);
  }

  @override
  @pragma('vm:prefer-inline')
  $UserLightCopyWith<$Res> get owner {
    return $UserLightCopyWith<$Res>(_value.owner, (value) {
      return _then(_value.copyWith(owner: value) as $Val);
    });
  }
}

/// @nodoc
abstract class _$$PlaylistLightImplCopyWith<$Res>
    implements $PlaylistLightCopyWith<$Res> {
  factory _$$PlaylistLightImplCopyWith(
          _$PlaylistLightImpl value, $Res Function(_$PlaylistLightImpl) then) =
      __$$PlaylistLightImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {String id,
      String previewId,
      String name,
      UserLight owner,
      int trackCount});

  @override
  $UserLightCopyWith<$Res> get owner;
}

/// @nodoc
class __$$PlaylistLightImplCopyWithImpl<$Res>
    extends _$PlaylistLightCopyWithImpl<$Res, _$PlaylistLightImpl>
    implements _$$PlaylistLightImplCopyWith<$Res> {
  __$$PlaylistLightImplCopyWithImpl(
      _$PlaylistLightImpl _value, $Res Function(_$PlaylistLightImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? previewId = null,
    Object? name = null,
    Object? owner = null,
    Object? trackCount = null,
  }) {
    return _then(_$PlaylistLightImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      previewId: null == previewId
          ? _value.previewId
          : previewId // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      owner: null == owner
          ? _value.owner
          : owner // ignore: cast_nullable_to_non_nullable
              as UserLight,
      trackCount: null == trackCount
          ? _value.trackCount
          : trackCount // ignore: cast_nullable_to_non_nullable
              as int,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$PlaylistLightImpl implements _PlaylistLight {
  const _$PlaylistLightImpl(
      {required this.id,
      required this.previewId,
      required this.name,
      required this.owner,
      required this.trackCount});

  factory _$PlaylistLightImpl.fromJson(Map<String, dynamic> json) =>
      _$$PlaylistLightImplFromJson(json);

  @override
  final String id;
  @override
  final String previewId;
  @override
  final String name;
  @override
  final UserLight owner;
  @override
  final int trackCount;

  @override
  String toString() {
    return 'PlaylistLight(id: $id, previewId: $previewId, name: $name, owner: $owner, trackCount: $trackCount)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$PlaylistLightImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.previewId, previewId) ||
                other.previewId == previewId) &&
            (identical(other.name, name) || other.name == name) &&
            (identical(other.owner, owner) || other.owner == owner) &&
            (identical(other.trackCount, trackCount) ||
                other.trackCount == trackCount));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode =>
      Object.hash(runtimeType, id, previewId, name, owner, trackCount);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$PlaylistLightImplCopyWith<_$PlaylistLightImpl> get copyWith =>
      __$$PlaylistLightImplCopyWithImpl<_$PlaylistLightImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$PlaylistLightImplToJson(
      this,
    );
  }
}

abstract class _PlaylistLight implements PlaylistLight {
  const factory _PlaylistLight(
      {required final String id,
      required final String previewId,
      required final String name,
      required final UserLight owner,
      required final int trackCount}) = _$PlaylistLightImpl;

  factory _PlaylistLight.fromJson(Map<String, dynamic> json) =
      _$PlaylistLightImpl.fromJson;

  @override
  String get id;
  @override
  String get previewId;
  @override
  String get name;
  @override
  UserLight get owner;
  @override
  int get trackCount;
  @override
  @JsonKey(ignore: true)
  _$$PlaylistLightImplCopyWith<_$PlaylistLightImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
