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
  List<Track> get Tracks => throw _privateConstructorUsedError;
  List<Album> get Albums => throw _privateConstructorUsedError;
  List<Author> get Authors => throw _privateConstructorUsedError;
  List<Playlist> get Playlists => throw _privateConstructorUsedError;

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
      {List<Track> Tracks,
      List<Album> Albums,
      List<Author> Authors,
      List<Playlist> Playlists});
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
    Object? Tracks = null,
    Object? Albums = null,
    Object? Authors = null,
    Object? Playlists = null,
  }) {
    return _then(_value.copyWith(
      Tracks: null == Tracks
          ? _value.Tracks
          : Tracks // ignore: cast_nullable_to_non_nullable
              as List<Track>,
      Albums: null == Albums
          ? _value.Albums
          : Albums // ignore: cast_nullable_to_non_nullable
              as List<Album>,
      Authors: null == Authors
          ? _value.Authors
          : Authors // ignore: cast_nullable_to_non_nullable
              as List<Author>,
      Playlists: null == Playlists
          ? _value.Playlists
          : Playlists // ignore: cast_nullable_to_non_nullable
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
      {List<Track> Tracks,
      List<Album> Albums,
      List<Author> Authors,
      List<Playlist> Playlists});
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
    Object? Tracks = null,
    Object? Albums = null,
    Object? Authors = null,
    Object? Playlists = null,
  }) {
    return _then(_$SearchDtoImpl(
      Tracks: null == Tracks
          ? _value._Tracks
          : Tracks // ignore: cast_nullable_to_non_nullable
              as List<Track>,
      Albums: null == Albums
          ? _value._Albums
          : Albums // ignore: cast_nullable_to_non_nullable
              as List<Album>,
      Authors: null == Authors
          ? _value._Authors
          : Authors // ignore: cast_nullable_to_non_nullable
              as List<Author>,
      Playlists: null == Playlists
          ? _value._Playlists
          : Playlists // ignore: cast_nullable_to_non_nullable
              as List<Playlist>,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$SearchDtoImpl implements _SearchDto {
  const _$SearchDtoImpl(
      {required final List<Track> Tracks,
      required final List<Album> Albums,
      required final List<Author> Authors,
      required final List<Playlist> Playlists})
      : _Tracks = Tracks,
        _Albums = Albums,
        _Authors = Authors,
        _Playlists = Playlists;

  factory _$SearchDtoImpl.fromJson(Map<String, dynamic> json) =>
      _$$SearchDtoImplFromJson(json);

  final List<Track> _Tracks;
  @override
  List<Track> get Tracks {
    if (_Tracks is EqualUnmodifiableListView) return _Tracks;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_Tracks);
  }

  final List<Album> _Albums;
  @override
  List<Album> get Albums {
    if (_Albums is EqualUnmodifiableListView) return _Albums;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_Albums);
  }

  final List<Author> _Authors;
  @override
  List<Author> get Authors {
    if (_Authors is EqualUnmodifiableListView) return _Authors;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_Authors);
  }

  final List<Playlist> _Playlists;
  @override
  List<Playlist> get Playlists {
    if (_Playlists is EqualUnmodifiableListView) return _Playlists;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_Playlists);
  }

  @override
  String toString() {
    return 'SearchDto(Tracks: $Tracks, Albums: $Albums, Authors: $Authors, Playlists: $Playlists)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SearchDtoImpl &&
            const DeepCollectionEquality().equals(other._Tracks, _Tracks) &&
            const DeepCollectionEquality().equals(other._Albums, _Albums) &&
            const DeepCollectionEquality().equals(other._Authors, _Authors) &&
            const DeepCollectionEquality()
                .equals(other._Playlists, _Playlists));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(
      runtimeType,
      const DeepCollectionEquality().hash(_Tracks),
      const DeepCollectionEquality().hash(_Albums),
      const DeepCollectionEquality().hash(_Authors),
      const DeepCollectionEquality().hash(_Playlists));

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
      {required final List<Track> Tracks,
      required final List<Album> Albums,
      required final List<Author> Authors,
      required final List<Playlist> Playlists}) = _$SearchDtoImpl;

  factory _SearchDto.fromJson(Map<String, dynamic> json) =
      _$SearchDtoImpl.fromJson;

  @override
  List<Track> get Tracks;
  @override
  List<Album> get Albums;
  @override
  List<Author> get Authors;
  @override
  List<Playlist> get Playlists;
  @override
  @JsonKey(ignore: true)
  _$$SearchDtoImplCopyWith<_$SearchDtoImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
