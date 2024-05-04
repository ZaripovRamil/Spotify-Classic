// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'track.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

TrackLight _$TrackLightFromJson(Map<String, dynamic> json) {
  return _TrackLight.fromJson(json);
}

/// @nodoc
mixin _$TrackLight {
  String get id => throw _privateConstructorUsedError;
  String get fileId => throw _privateConstructorUsedError;
  String get name => throw _privateConstructorUsedError;
  AlbumLight get album => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $TrackLightCopyWith<TrackLight> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $TrackLightCopyWith<$Res> {
  factory $TrackLightCopyWith(
          TrackLight value, $Res Function(TrackLight) then) =
      _$TrackLightCopyWithImpl<$Res, TrackLight>;
  @useResult
  $Res call({String id, String fileId, String name, AlbumLight album});

  $AlbumLightCopyWith<$Res> get album;
}

/// @nodoc
class _$TrackLightCopyWithImpl<$Res, $Val extends TrackLight>
    implements $TrackLightCopyWith<$Res> {
  _$TrackLightCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? fileId = null,
    Object? name = null,
    Object? album = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      fileId: null == fileId
          ? _value.fileId
          : fileId // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      album: null == album
          ? _value.album
          : album // ignore: cast_nullable_to_non_nullable
              as AlbumLight,
    ) as $Val);
  }

  @override
  @pragma('vm:prefer-inline')
  $AlbumLightCopyWith<$Res> get album {
    return $AlbumLightCopyWith<$Res>(_value.album, (value) {
      return _then(_value.copyWith(album: value) as $Val);
    });
  }
}

/// @nodoc
abstract class _$$TrackLightImplCopyWith<$Res>
    implements $TrackLightCopyWith<$Res> {
  factory _$$TrackLightImplCopyWith(
          _$TrackLightImpl value, $Res Function(_$TrackLightImpl) then) =
      __$$TrackLightImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String id, String fileId, String name, AlbumLight album});

  @override
  $AlbumLightCopyWith<$Res> get album;
}

/// @nodoc
class __$$TrackLightImplCopyWithImpl<$Res>
    extends _$TrackLightCopyWithImpl<$Res, _$TrackLightImpl>
    implements _$$TrackLightImplCopyWith<$Res> {
  __$$TrackLightImplCopyWithImpl(
      _$TrackLightImpl _value, $Res Function(_$TrackLightImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? fileId = null,
    Object? name = null,
    Object? album = null,
  }) {
    return _then(_$TrackLightImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      fileId: null == fileId
          ? _value.fileId
          : fileId // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      album: null == album
          ? _value.album
          : album // ignore: cast_nullable_to_non_nullable
              as AlbumLight,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$TrackLightImpl implements _TrackLight {
  const _$TrackLightImpl(
      {required this.id,
      required this.fileId,
      required this.name,
      required this.album});

  factory _$TrackLightImpl.fromJson(Map<String, dynamic> json) =>
      _$$TrackLightImplFromJson(json);

  @override
  final String id;
  @override
  final String fileId;
  @override
  final String name;
  @override
  final AlbumLight album;

  @override
  String toString() {
    return 'TrackLight(id: $id, fileId: $fileId, name: $name, album: $album)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$TrackLightImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.fileId, fileId) || other.fileId == fileId) &&
            (identical(other.name, name) || other.name == name) &&
            (identical(other.album, album) || other.album == album));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(runtimeType, id, fileId, name, album);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$TrackLightImplCopyWith<_$TrackLightImpl> get copyWith =>
      __$$TrackLightImplCopyWithImpl<_$TrackLightImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$TrackLightImplToJson(
      this,
    );
  }
}

abstract class _TrackLight implements TrackLight {
  const factory _TrackLight(
      {required final String id,
      required final String fileId,
      required final String name,
      required final AlbumLight album}) = _$TrackLightImpl;

  factory _TrackLight.fromJson(Map<String, dynamic> json) =
      _$TrackLightImpl.fromJson;

  @override
  String get id;
  @override
  String get fileId;
  @override
  String get name;
  @override
  AlbumLight get album;
  @override
  @JsonKey(ignore: true)
  _$$TrackLightImplCopyWith<_$TrackLightImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
