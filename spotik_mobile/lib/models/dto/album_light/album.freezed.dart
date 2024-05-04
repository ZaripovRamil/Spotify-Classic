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

AlbumLight _$AlbumLightFromJson(Map<String, dynamic> json) {
  return _AlbumLight.fromJson(json);
}

/// @nodoc
mixin _$AlbumLight {
  String get id => throw _privateConstructorUsedError;
  String get previewId => throw _privateConstructorUsedError;
  String get name => throw _privateConstructorUsedError;
  AuthorLight get author => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $AlbumLightCopyWith<AlbumLight> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AlbumLightCopyWith<$Res> {
  factory $AlbumLightCopyWith(
          AlbumLight value, $Res Function(AlbumLight) then) =
      _$AlbumLightCopyWithImpl<$Res, AlbumLight>;
  @useResult
  $Res call({String id, String previewId, String name, AuthorLight author});

  $AuthorLightCopyWith<$Res> get author;
}

/// @nodoc
class _$AlbumLightCopyWithImpl<$Res, $Val extends AlbumLight>
    implements $AlbumLightCopyWith<$Res> {
  _$AlbumLightCopyWithImpl(this._value, this._then);

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
abstract class _$$AlbumLightImplCopyWith<$Res>
    implements $AlbumLightCopyWith<$Res> {
  factory _$$AlbumLightImplCopyWith(
          _$AlbumLightImpl value, $Res Function(_$AlbumLightImpl) then) =
      __$$AlbumLightImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String id, String previewId, String name, AuthorLight author});

  @override
  $AuthorLightCopyWith<$Res> get author;
}

/// @nodoc
class __$$AlbumLightImplCopyWithImpl<$Res>
    extends _$AlbumLightCopyWithImpl<$Res, _$AlbumLightImpl>
    implements _$$AlbumLightImplCopyWith<$Res> {
  __$$AlbumLightImplCopyWithImpl(
      _$AlbumLightImpl _value, $Res Function(_$AlbumLightImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? previewId = null,
    Object? name = null,
    Object? author = null,
  }) {
    return _then(_$AlbumLightImpl(
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
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$AlbumLightImpl implements _AlbumLight {
  const _$AlbumLightImpl(
      {required this.id,
      required this.previewId,
      required this.name,
      required this.author});

  factory _$AlbumLightImpl.fromJson(Map<String, dynamic> json) =>
      _$$AlbumLightImplFromJson(json);

  @override
  final String id;
  @override
  final String previewId;
  @override
  final String name;
  @override
  final AuthorLight author;

  @override
  String toString() {
    return 'AlbumLight(id: $id, previewId: $previewId, name: $name, author: $author)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumLightImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.previewId, previewId) ||
                other.previewId == previewId) &&
            (identical(other.name, name) || other.name == name) &&
            (identical(other.author, author) || other.author == author));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(runtimeType, id, previewId, name, author);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$AlbumLightImplCopyWith<_$AlbumLightImpl> get copyWith =>
      __$$AlbumLightImplCopyWithImpl<_$AlbumLightImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$AlbumLightImplToJson(
      this,
    );
  }
}

abstract class _AlbumLight implements AlbumLight {
  const factory _AlbumLight(
      {required final String id,
      required final String previewId,
      required final String name,
      required final AuthorLight author}) = _$AlbumLightImpl;

  factory _AlbumLight.fromJson(Map<String, dynamic> json) =
      _$AlbumLightImpl.fromJson;

  @override
  String get id;
  @override
  String get previewId;
  @override
  String get name;
  @override
  AuthorLight get author;
  @override
  @JsonKey(ignore: true)
  _$$AlbumLightImplCopyWith<_$AlbumLightImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
