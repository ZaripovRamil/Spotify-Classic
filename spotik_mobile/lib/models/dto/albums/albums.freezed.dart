// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'albums.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

AlbumsDto _$AlbumsDtoFromJson(Map<String, dynamic> json) {
  return _AlbumsDto.fromJson(json);
}

/// @nodoc
mixin _$AlbumsDto {
  List<AlbumData> get albums => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $AlbumsDtoCopyWith<AlbumsDto> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AlbumsDtoCopyWith<$Res> {
  factory $AlbumsDtoCopyWith(AlbumsDto value, $Res Function(AlbumsDto) then) =
      _$AlbumsDtoCopyWithImpl<$Res, AlbumsDto>;
  @useResult
  $Res call({List<AlbumData> albums});
}

/// @nodoc
class _$AlbumsDtoCopyWithImpl<$Res, $Val extends AlbumsDto>
    implements $AlbumsDtoCopyWith<$Res> {
  _$AlbumsDtoCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? albums = null,
  }) {
    return _then(_value.copyWith(
      albums: null == albums
          ? _value.albums
          : albums // ignore: cast_nullable_to_non_nullable
              as List<AlbumData>,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$AlbumsDtoImplCopyWith<$Res>
    implements $AlbumsDtoCopyWith<$Res> {
  factory _$$AlbumsDtoImplCopyWith(
          _$AlbumsDtoImpl value, $Res Function(_$AlbumsDtoImpl) then) =
      __$$AlbumsDtoImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({List<AlbumData> albums});
}

/// @nodoc
class __$$AlbumsDtoImplCopyWithImpl<$Res>
    extends _$AlbumsDtoCopyWithImpl<$Res, _$AlbumsDtoImpl>
    implements _$$AlbumsDtoImplCopyWith<$Res> {
  __$$AlbumsDtoImplCopyWithImpl(
      _$AlbumsDtoImpl _value, $Res Function(_$AlbumsDtoImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? albums = null,
  }) {
    return _then(_$AlbumsDtoImpl(
      albums: null == albums
          ? _value._albums
          : albums // ignore: cast_nullable_to_non_nullable
              as List<AlbumData>,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$AlbumsDtoImpl implements _AlbumsDto {
  const _$AlbumsDtoImpl({required final List<AlbumData> albums})
      : _albums = albums;

  factory _$AlbumsDtoImpl.fromJson(Map<String, dynamic> json) =>
      _$$AlbumsDtoImplFromJson(json);

  final List<AlbumData> _albums;
  @override
  List<AlbumData> get albums {
    if (_albums is EqualUnmodifiableListView) return _albums;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_albums);
  }

  @override
  String toString() {
    return 'AlbumsDto(albums: $albums)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumsDtoImpl &&
            const DeepCollectionEquality().equals(other._albums, _albums));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode =>
      Object.hash(runtimeType, const DeepCollectionEquality().hash(_albums));

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$AlbumsDtoImplCopyWith<_$AlbumsDtoImpl> get copyWith =>
      __$$AlbumsDtoImplCopyWithImpl<_$AlbumsDtoImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$AlbumsDtoImplToJson(
      this,
    );
  }
}

abstract class _AlbumsDto implements AlbumsDto {
  const factory _AlbumsDto({required final List<AlbumData> albums}) =
      _$AlbumsDtoImpl;

  factory _AlbumsDto.fromJson(Map<String, dynamic> json) =
      _$AlbumsDtoImpl.fromJson;

  @override
  List<AlbumData> get albums;
  @override
  @JsonKey(ignore: true)
  _$$AlbumsDtoImplCopyWith<_$AlbumsDtoImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
