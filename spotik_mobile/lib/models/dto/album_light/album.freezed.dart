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

AlbumData _$AlbumDataFromJson(Map<String, dynamic> json) {
  return _AlbumData.fromJson(json);
}

/// @nodoc
mixin _$AlbumData {
  String get id => throw _privateConstructorUsedError;
  String get previewId => throw _privateConstructorUsedError;
  String get name => throw _privateConstructorUsedError;
  Author get author => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $AlbumDataCopyWith<AlbumData> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AlbumDataCopyWith<$Res> {
  factory $AlbumDataCopyWith(AlbumData value, $Res Function(AlbumData) then) =
      _$AlbumDataCopyWithImpl<$Res, AlbumData>;
  @useResult
  $Res call({String id, String previewId, String name, Author author});

  $AuthorCopyWith<$Res> get author;
}

/// @nodoc
class _$AlbumDataCopyWithImpl<$Res, $Val extends AlbumData>
    implements $AlbumDataCopyWith<$Res> {
  _$AlbumDataCopyWithImpl(this._value, this._then);

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
              as Author,
    ) as $Val);
  }

  @override
  @pragma('vm:prefer-inline')
  $AuthorCopyWith<$Res> get author {
    return $AuthorCopyWith<$Res>(_value.author, (value) {
      return _then(_value.copyWith(author: value) as $Val);
    });
  }
}

/// @nodoc
abstract class _$$AlbumDataImplCopyWith<$Res>
    implements $AlbumDataCopyWith<$Res> {
  factory _$$AlbumDataImplCopyWith(
          _$AlbumDataImpl value, $Res Function(_$AlbumDataImpl) then) =
      __$$AlbumDataImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String id, String previewId, String name, Author author});

  @override
  $AuthorCopyWith<$Res> get author;
}

/// @nodoc
class __$$AlbumDataImplCopyWithImpl<$Res>
    extends _$AlbumDataCopyWithImpl<$Res, _$AlbumDataImpl>
    implements _$$AlbumDataImplCopyWith<$Res> {
  __$$AlbumDataImplCopyWithImpl(
      _$AlbumDataImpl _value, $Res Function(_$AlbumDataImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? previewId = null,
    Object? name = null,
    Object? author = null,
  }) {
    return _then(_$AlbumDataImpl(
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
              as Author,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$AlbumDataImpl implements _AlbumData {
  const _$AlbumDataImpl(
      {required this.id,
      required this.previewId,
      required this.name,
      required this.author});

  factory _$AlbumDataImpl.fromJson(Map<String, dynamic> json) =>
      _$$AlbumDataImplFromJson(json);

  @override
  final String id;
  @override
  final String previewId;
  @override
  final String name;
  @override
  final Author author;

  @override
  String toString() {
    return 'AlbumData(id: $id, previewId: $previewId, name: $name, author: $author)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumDataImpl &&
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
  _$$AlbumDataImplCopyWith<_$AlbumDataImpl> get copyWith =>
      __$$AlbumDataImplCopyWithImpl<_$AlbumDataImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$AlbumDataImplToJson(
      this,
    );
  }
}

abstract class _AlbumData implements AlbumData {
  const factory _AlbumData(
      {required final String id,
      required final String previewId,
      required final String name,
      required final Author author}) = _$AlbumDataImpl;

  factory _AlbumData.fromJson(Map<String, dynamic> json) =
      _$AlbumDataImpl.fromJson;

  @override
  String get id;
  @override
  String get previewId;
  @override
  String get name;
  @override
  Author get author;
  @override
  @JsonKey(ignore: true)
  _$$AlbumDataImplCopyWith<_$AlbumDataImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
