// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'search.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

SearchDto _$SearchDtoFromJson(Map<String, dynamic> json) {
  return _SearchDto.fromJson(json);
}

/// @nodoc
mixin _$SearchDto {
  List<Track> get tracks => throw _privateConstructorUsedError;
  List<AlbumData> get albums => throw _privateConstructorUsedError;
  List<Author> get authors => throw _privateConstructorUsedError;
  List<Playlist> get playlists => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $SearchDtoCopyWith<SearchDto> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $SearchDtoCopyWith<$Res> {
  factory $SearchDtoCopyWith(SearchDto value, $Res Function(SearchDto) then) =
      _$SearchDtoCopyWithImpl<$Res, SearchDto>;
  @useResult
  $Res call(
      {List<Track> tracks,
      List<AlbumData> albums,
      List<Author> authors,
      List<Playlist> playlists});
}

/// @nodoc
class _$SearchDtoCopyWithImpl<$Res, $Val extends SearchDto>
    implements $SearchDtoCopyWith<$Res> {
  _$SearchDtoCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? tracks = null,
    Object? albums = null,
    Object? authors = null,
    Object? playlists = null,
  }) {
    return _then(_value.copyWith(
      tracks: null == tracks
          ? _value.tracks
          : tracks // ignore: cast_nullable_to_non_nullable
              as List<Track>,
      albums: null == albums
          ? _value.albums
          : albums // ignore: cast_nullable_to_non_nullable
              as List<AlbumData>,
      authors: null == authors
          ? _value.authors
          : authors // ignore: cast_nullable_to_non_nullable
              as List<Author>,
      playlists: null == playlists
          ? _value.playlists
          : playlists // ignore: cast_nullable_to_non_nullable
              as List<Playlist>,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$SearchDtoImplCopyWith<$Res>
    implements $SearchDtoCopyWith<$Res> {
  factory _$$SearchDtoImplCopyWith(
          _$SearchDtoImpl value, $Res Function(_$SearchDtoImpl) then) =
      __$$SearchDtoImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {List<Track> tracks,
      List<AlbumData> albums,
      List<Author> authors,
      List<Playlist> playlists});
}

/// @nodoc
class __$$SearchDtoImplCopyWithImpl<$Res>
    extends _$SearchDtoCopyWithImpl<$Res, _$SearchDtoImpl>
    implements _$$SearchDtoImplCopyWith<$Res> {
  __$$SearchDtoImplCopyWithImpl(
      _$SearchDtoImpl _value, $Res Function(_$SearchDtoImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? tracks = null,
    Object? albums = null,
    Object? authors = null,
    Object? playlists = null,
  }) {
    return _then(_$SearchDtoImpl(
      tracks: null == tracks
          ? _value._tracks
          : tracks // ignore: cast_nullable_to_non_nullable
              as List<Track>,
      albums: null == albums
          ? _value._albums
          : albums // ignore: cast_nullable_to_non_nullable
              as List<AlbumData>,
      authors: null == authors
          ? _value._authors
          : authors // ignore: cast_nullable_to_non_nullable
              as List<Author>,
      playlists: null == playlists
          ? _value._playlists
          : playlists // ignore: cast_nullable_to_non_nullable
              as List<Playlist>,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$SearchDtoImpl implements _SearchDto {
  const _$SearchDtoImpl(
      {required final List<Track> tracks,
      required final List<AlbumData> albums,
      required final List<Author> authors,
      required final List<Playlist> playlists})
      : _tracks = tracks,
        _albums = albums,
        _authors = authors,
        _playlists = playlists;

  factory _$SearchDtoImpl.fromJson(Map<String, dynamic> json) =>
      _$$SearchDtoImplFromJson(json);

  final List<Track> _tracks;
  @override
  List<Track> get tracks {
    if (_tracks is EqualUnmodifiableListView) return _tracks;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_tracks);
  }

  final List<AlbumData> _albums;
  @override
  List<AlbumData> get albums {
    if (_albums is EqualUnmodifiableListView) return _albums;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_albums);
  }

  final List<Author> _authors;
  @override
  List<Author> get authors {
    if (_authors is EqualUnmodifiableListView) return _authors;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_authors);
  }

  final List<Playlist> _playlists;
  @override
  List<Playlist> get playlists {
    if (_playlists is EqualUnmodifiableListView) return _playlists;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_playlists);
  }

  @override
  String toString() {
    return 'SearchDto(tracks: $tracks, albums: $albums, authors: $authors, playlists: $playlists)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SearchDtoImpl &&
            const DeepCollectionEquality().equals(other._tracks, _tracks) &&
            const DeepCollectionEquality().equals(other._albums, _albums) &&
            const DeepCollectionEquality().equals(other._authors, _authors) &&
            const DeepCollectionEquality()
                .equals(other._playlists, _playlists));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(
      runtimeType,
      const DeepCollectionEquality().hash(_tracks),
      const DeepCollectionEquality().hash(_albums),
      const DeepCollectionEquality().hash(_authors),
      const DeepCollectionEquality().hash(_playlists));

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$SearchDtoImplCopyWith<_$SearchDtoImpl> get copyWith =>
      __$$SearchDtoImplCopyWithImpl<_$SearchDtoImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$SearchDtoImplToJson(
      this,
    );
  }
}

abstract class _SearchDto implements SearchDto {
  const factory _SearchDto(
      {required final List<Track> tracks,
      required final List<AlbumData> albums,
      required final List<Author> authors,
      required final List<Playlist> playlists}) = _$SearchDtoImpl;

  factory _SearchDto.fromJson(Map<String, dynamic> json) =
      _$SearchDtoImpl.fromJson;

  @override
  List<Track> get tracks;
  @override
  List<AlbumData> get albums;
  @override
  List<Author> get authors;
  @override
  List<Playlist> get playlists;
  @override
  @JsonKey(ignore: true)
  _$$SearchDtoImplCopyWith<_$SearchDtoImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
