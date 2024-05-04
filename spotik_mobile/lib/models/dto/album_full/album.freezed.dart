// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'album.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

AlbumFull _$AlbumFullFromJson(Map<String, dynamic> json) {
  return _AlbumFull.fromJson(json);
}

/// @nodoc
mixin _$AlbumFull {
  String get id => throw _privateConstructorUsedError;
  String get previewId => throw _privateConstructorUsedError;
  String get name => throw _privateConstructorUsedError;
  AuthorLight get author => throw _privateConstructorUsedError;
  List<TrackLight> get tracks => throw _privateConstructorUsedError;
  String get type => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $AlbumFullCopyWith<AlbumFull> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AlbumFullCopyWith<$Res> {
  factory $AlbumFullCopyWith(AlbumFull value, $Res Function(AlbumFull) then) =
      _$AlbumFullCopyWithImpl<$Res, AlbumFull>;
  @useResult
  $Res call(
      {String id,
      String previewId,
      String name,
      AuthorLight author,
      List<TrackLight> tracks,
      String type});

  $AuthorLightCopyWith<$Res> get author;
}

/// @nodoc
class _$AlbumFullCopyWithImpl<$Res, $Val extends AlbumFull>
    implements $AlbumFullCopyWith<$Res> {
  _$AlbumFullCopyWithImpl(this._value, this._then);

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
    Object? author = null,
    Object? tracks = null,
    Object? type = null,
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
      author: null == author
          ? _value.author
          : author // ignore: cast_nullable_to_non_nullable
              as AuthorLight,
      tracks: null == tracks
          ? _value.tracks
          : tracks // ignore: cast_nullable_to_non_nullable
              as List<TrackLight>,
      type: null == type
          ? _value.type
          : type // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }

  @override
  @pragma('vm:prefer-inline')
  $AuthorLightCopyWith<$Res> get author {
    return $AuthorLightCopyWith<$Res>(_value.author, (value) {
      return _then(_value.copyWith(author: value) as $Val);
    });
  }
}

/// @nodoc
abstract class _$$AlbumFullImplCopyWith<$Res>
    implements $AlbumFullCopyWith<$Res> {
  factory _$$AlbumFullImplCopyWith(
          _$AlbumFullImpl value, $Res Function(_$AlbumFullImpl) then) =
      __$$AlbumFullImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {String id,
      String previewId,
      String name,
      AuthorLight author,
      List<TrackLight> tracks,
      String type});

  @override
  $AuthorLightCopyWith<$Res> get author;
}

/// @nodoc
class __$$AlbumFullImplCopyWithImpl<$Res>
    extends _$AlbumFullCopyWithImpl<$Res, _$AlbumFullImpl>
    implements _$$AlbumFullImplCopyWith<$Res> {
  __$$AlbumFullImplCopyWithImpl(
      _$AlbumFullImpl _value, $Res Function(_$AlbumFullImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? previewId = null,
    Object? name = null,
    Object? author = null,
    Object? tracks = null,
    Object? type = null,
  }) {
    return _then(_$AlbumFullImpl(
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
      author: null == author
          ? _value.author
          : author // ignore: cast_nullable_to_non_nullable
              as AuthorLight,
      tracks: null == tracks
          ? _value._tracks
          : tracks // ignore: cast_nullable_to_non_nullable
              as List<TrackLight>,
      type: null == type
          ? _value.type
          : type // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$AlbumFullImpl implements _AlbumFull {
  const _$AlbumFullImpl(
      {required this.id,
      required this.previewId,
      required this.name,
      required this.author,
      required final List<TrackLight> tracks,
      required this.type})
      : _tracks = tracks;

  factory _$AlbumFullImpl.fromJson(Map<String, dynamic> json) =>
      _$$AlbumFullImplFromJson(json);

  @override
  final String id;
  @override
  final String previewId;
  @override
  final String name;
  @override
  final AuthorLight author;
  final List<TrackLight> _tracks;
  @override
  List<TrackLight> get tracks {
    if (_tracks is EqualUnmodifiableListView) return _tracks;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_tracks);
  }

  @override
  final String type;

  @override
  String toString() {
    return 'AlbumFull(id: $id, previewId: $previewId, name: $name, author: $author, tracks: $tracks, type: $type)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumFullImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.previewId, previewId) ||
                other.previewId == previewId) &&
            (identical(other.name, name) || other.name == name) &&
            (identical(other.author, author) || other.author == author) &&
            const DeepCollectionEquality().equals(other._tracks, _tracks) &&
            (identical(other.type, type) || other.type == type));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(runtimeType, id, previewId, name, author,
      const DeepCollectionEquality().hash(_tracks), type);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$AlbumFullImplCopyWith<_$AlbumFullImpl> get copyWith =>
      __$$AlbumFullImplCopyWithImpl<_$AlbumFullImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$AlbumFullImplToJson(
      this,
    );
  }
}

abstract class _AlbumFull implements AlbumFull {
  const factory _AlbumFull(
      {required final String id,
      required final String previewId,
      required final String name,
      required final AuthorLight author,
      required final List<TrackLight> tracks,
      required final String type}) = _$AlbumFullImpl;

  factory _AlbumFull.fromJson(Map<String, dynamic> json) =
      _$AlbumFullImpl.fromJson;

  @override
  String get id;
  @override
  String get previewId;
  @override
  String get name;
  @override
  AuthorLight get author;
  @override
  List<TrackLight> get tracks;
  @override
  String get type;
  @override
  @JsonKey(ignore: true)
  _$$AlbumFullImplCopyWith<_$AlbumFullImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
