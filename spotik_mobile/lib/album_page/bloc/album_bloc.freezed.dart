// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'album_bloc.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

/// @nodoc
mixin _$AlbumEvent {
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function(String id) getAlbum,
    required TResult Function() getAlbums,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function(String id)? getAlbum,
    TResult? Function()? getAlbums,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function(String id)? getAlbum,
    TResult Function()? getAlbums,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(AlbumGetAlbumEvent value) getAlbum,
    required TResult Function(AlbumGetAlbumsEvent value) getAlbums,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(AlbumGetAlbumEvent value)? getAlbum,
    TResult? Function(AlbumGetAlbumsEvent value)? getAlbums,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(AlbumGetAlbumEvent value)? getAlbum,
    TResult Function(AlbumGetAlbumsEvent value)? getAlbums,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AlbumEventCopyWith<$Res> {
  factory $AlbumEventCopyWith(
          AlbumEvent value, $Res Function(AlbumEvent) then) =
      _$AlbumEventCopyWithImpl<$Res, AlbumEvent>;
}

/// @nodoc
class _$AlbumEventCopyWithImpl<$Res, $Val extends AlbumEvent>
    implements $AlbumEventCopyWith<$Res> {
  _$AlbumEventCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;
}

/// @nodoc
abstract class _$$AlbumGetAlbumEventImplCopyWith<$Res> {
  factory _$$AlbumGetAlbumEventImplCopyWith(_$AlbumGetAlbumEventImpl value,
          $Res Function(_$AlbumGetAlbumEventImpl) then) =
      __$$AlbumGetAlbumEventImplCopyWithImpl<$Res>;
  @useResult
  $Res call({String id});
}

/// @nodoc
class __$$AlbumGetAlbumEventImplCopyWithImpl<$Res>
    extends _$AlbumEventCopyWithImpl<$Res, _$AlbumGetAlbumEventImpl>
    implements _$$AlbumGetAlbumEventImplCopyWith<$Res> {
  __$$AlbumGetAlbumEventImplCopyWithImpl(_$AlbumGetAlbumEventImpl _value,
      $Res Function(_$AlbumGetAlbumEventImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
  }) {
    return _then(_$AlbumGetAlbumEventImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

class _$AlbumGetAlbumEventImpl implements AlbumGetAlbumEvent {
  const _$AlbumGetAlbumEventImpl({required this.id});

  @override
  final String id;

  @override
  String toString() {
    return 'AlbumEvent.getAlbum(id: $id)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumGetAlbumEventImpl &&
            (identical(other.id, id) || other.id == id));
  }

  @override
  int get hashCode => Object.hash(runtimeType, id);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$AlbumGetAlbumEventImplCopyWith<_$AlbumGetAlbumEventImpl> get copyWith =>
      __$$AlbumGetAlbumEventImplCopyWithImpl<_$AlbumGetAlbumEventImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function(String id) getAlbum,
    required TResult Function() getAlbums,
  }) {
    return getAlbum(id);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function(String id)? getAlbum,
    TResult? Function()? getAlbums,
  }) {
    return getAlbum?.call(id);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function(String id)? getAlbum,
    TResult Function()? getAlbums,
    required TResult orElse(),
  }) {
    if (getAlbum != null) {
      return getAlbum(id);
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(AlbumGetAlbumEvent value) getAlbum,
    required TResult Function(AlbumGetAlbumsEvent value) getAlbums,
  }) {
    return getAlbum(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(AlbumGetAlbumEvent value)? getAlbum,
    TResult? Function(AlbumGetAlbumsEvent value)? getAlbums,
  }) {
    return getAlbum?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(AlbumGetAlbumEvent value)? getAlbum,
    TResult Function(AlbumGetAlbumsEvent value)? getAlbums,
    required TResult orElse(),
  }) {
    if (getAlbum != null) {
      return getAlbum(this);
    }
    return orElse();
  }
}

abstract class AlbumGetAlbumEvent implements AlbumEvent {
  const factory AlbumGetAlbumEvent({required final String id}) =
      _$AlbumGetAlbumEventImpl;

  String get id;
  @JsonKey(ignore: true)
  _$$AlbumGetAlbumEventImplCopyWith<_$AlbumGetAlbumEventImpl> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class _$$AlbumGetAlbumsEventImplCopyWith<$Res> {
  factory _$$AlbumGetAlbumsEventImplCopyWith(_$AlbumGetAlbumsEventImpl value,
          $Res Function(_$AlbumGetAlbumsEventImpl) then) =
      __$$AlbumGetAlbumsEventImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$AlbumGetAlbumsEventImplCopyWithImpl<$Res>
    extends _$AlbumEventCopyWithImpl<$Res, _$AlbumGetAlbumsEventImpl>
    implements _$$AlbumGetAlbumsEventImplCopyWith<$Res> {
  __$$AlbumGetAlbumsEventImplCopyWithImpl(_$AlbumGetAlbumsEventImpl _value,
      $Res Function(_$AlbumGetAlbumsEventImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$AlbumGetAlbumsEventImpl implements AlbumGetAlbumsEvent {
  const _$AlbumGetAlbumsEventImpl();

  @override
  String toString() {
    return 'AlbumEvent.getAlbums()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumGetAlbumsEventImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function(String id) getAlbum,
    required TResult Function() getAlbums,
  }) {
    return getAlbums();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function(String id)? getAlbum,
    TResult? Function()? getAlbums,
  }) {
    return getAlbums?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function(String id)? getAlbum,
    TResult Function()? getAlbums,
    required TResult orElse(),
  }) {
    if (getAlbums != null) {
      return getAlbums();
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(AlbumGetAlbumEvent value) getAlbum,
    required TResult Function(AlbumGetAlbumsEvent value) getAlbums,
  }) {
    return getAlbums(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(AlbumGetAlbumEvent value)? getAlbum,
    TResult? Function(AlbumGetAlbumsEvent value)? getAlbums,
  }) {
    return getAlbums?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(AlbumGetAlbumEvent value)? getAlbum,
    TResult Function(AlbumGetAlbumsEvent value)? getAlbums,
    required TResult orElse(),
  }) {
    if (getAlbums != null) {
      return getAlbums(this);
    }
    return orElse();
  }
}

abstract class AlbumGetAlbumsEvent implements AlbumEvent {
  const factory AlbumGetAlbumsEvent() = _$AlbumGetAlbumsEventImpl;
}

/// @nodoc
mixin _$AlbumState {
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(Album album) loaded,
    required TResult Function(String errorMessage) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(Album album)? loaded,
    TResult? Function(String errorMessage)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(Album album)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumInitialState value) initial,
    required TResult Function(_AlbumLoadingState value) loading,
    required TResult Function(_AlbumLoadedState value) loaded,
    required TResult Function(_AlbumErrorState value) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumInitialState value)? initial,
    TResult? Function(_AlbumLoadingState value)? loading,
    TResult? Function(_AlbumLoadedState value)? loaded,
    TResult? Function(_AlbumErrorState value)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumInitialState value)? initial,
    TResult Function(_AlbumLoadingState value)? loading,
    TResult Function(_AlbumLoadedState value)? loaded,
    TResult Function(_AlbumErrorState value)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AlbumStateCopyWith<$Res> {
  factory $AlbumStateCopyWith(
          AlbumState value, $Res Function(AlbumState) then) =
      _$AlbumStateCopyWithImpl<$Res, AlbumState>;
}

/// @nodoc
class _$AlbumStateCopyWithImpl<$Res, $Val extends AlbumState>
    implements $AlbumStateCopyWith<$Res> {
  _$AlbumStateCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;
}

/// @nodoc
abstract class _$$AlbumInitialStateImplCopyWith<$Res> {
  factory _$$AlbumInitialStateImplCopyWith(_$AlbumInitialStateImpl value,
          $Res Function(_$AlbumInitialStateImpl) then) =
      __$$AlbumInitialStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$AlbumInitialStateImplCopyWithImpl<$Res>
    extends _$AlbumStateCopyWithImpl<$Res, _$AlbumInitialStateImpl>
    implements _$$AlbumInitialStateImplCopyWith<$Res> {
  __$$AlbumInitialStateImplCopyWithImpl(_$AlbumInitialStateImpl _value,
      $Res Function(_$AlbumInitialStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$AlbumInitialStateImpl implements _AlbumInitialState {
  const _$AlbumInitialStateImpl();

  @override
  String toString() {
    return 'AlbumState.initial()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType && other is _$AlbumInitialStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(Album album) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return initial();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(Album album)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return initial?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(Album album)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (initial != null) {
      return initial();
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumInitialState value) initial,
    required TResult Function(_AlbumLoadingState value) loading,
    required TResult Function(_AlbumLoadedState value) loaded,
    required TResult Function(_AlbumErrorState value) error,
  }) {
    return initial(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumInitialState value)? initial,
    TResult? Function(_AlbumLoadingState value)? loading,
    TResult? Function(_AlbumLoadedState value)? loaded,
    TResult? Function(_AlbumErrorState value)? error,
  }) {
    return initial?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumInitialState value)? initial,
    TResult Function(_AlbumLoadingState value)? loading,
    TResult Function(_AlbumLoadedState value)? loaded,
    TResult Function(_AlbumErrorState value)? error,
    required TResult orElse(),
  }) {
    if (initial != null) {
      return initial(this);
    }
    return orElse();
  }
}

abstract class _AlbumInitialState implements AlbumState {
  const factory _AlbumInitialState() = _$AlbumInitialStateImpl;
}

/// @nodoc
abstract class _$$AlbumLoadingStateImplCopyWith<$Res> {
  factory _$$AlbumLoadingStateImplCopyWith(_$AlbumLoadingStateImpl value,
          $Res Function(_$AlbumLoadingStateImpl) then) =
      __$$AlbumLoadingStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$AlbumLoadingStateImplCopyWithImpl<$Res>
    extends _$AlbumStateCopyWithImpl<$Res, _$AlbumLoadingStateImpl>
    implements _$$AlbumLoadingStateImplCopyWith<$Res> {
  __$$AlbumLoadingStateImplCopyWithImpl(_$AlbumLoadingStateImpl _value,
      $Res Function(_$AlbumLoadingStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$AlbumLoadingStateImpl implements _AlbumLoadingState {
  const _$AlbumLoadingStateImpl();

  @override
  String toString() {
    return 'AlbumState.loading()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType && other is _$AlbumLoadingStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(Album album) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return loading();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(Album album)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return loading?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(Album album)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (loading != null) {
      return loading();
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumInitialState value) initial,
    required TResult Function(_AlbumLoadingState value) loading,
    required TResult Function(_AlbumLoadedState value) loaded,
    required TResult Function(_AlbumErrorState value) error,
  }) {
    return loading(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumInitialState value)? initial,
    TResult? Function(_AlbumLoadingState value)? loading,
    TResult? Function(_AlbumLoadedState value)? loaded,
    TResult? Function(_AlbumErrorState value)? error,
  }) {
    return loading?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumInitialState value)? initial,
    TResult Function(_AlbumLoadingState value)? loading,
    TResult Function(_AlbumLoadedState value)? loaded,
    TResult Function(_AlbumErrorState value)? error,
    required TResult orElse(),
  }) {
    if (loading != null) {
      return loading(this);
    }
    return orElse();
  }
}

abstract class _AlbumLoadingState implements AlbumState {
  const factory _AlbumLoadingState() = _$AlbumLoadingStateImpl;
}

/// @nodoc
abstract class _$$AlbumLoadedStateImplCopyWith<$Res> {
  factory _$$AlbumLoadedStateImplCopyWith(_$AlbumLoadedStateImpl value,
          $Res Function(_$AlbumLoadedStateImpl) then) =
      __$$AlbumLoadedStateImplCopyWithImpl<$Res>;
  @useResult
  $Res call({Album album});

  $AlbumCopyWith<$Res> get album;
}

/// @nodoc
class __$$AlbumLoadedStateImplCopyWithImpl<$Res>
    extends _$AlbumStateCopyWithImpl<$Res, _$AlbumLoadedStateImpl>
    implements _$$AlbumLoadedStateImplCopyWith<$Res> {
  __$$AlbumLoadedStateImplCopyWithImpl(_$AlbumLoadedStateImpl _value,
      $Res Function(_$AlbumLoadedStateImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? album = null,
  }) {
    return _then(_$AlbumLoadedStateImpl(
      album: null == album
          ? _value.album
          : album // ignore: cast_nullable_to_non_nullable
              as Album,
    ));
  }

  @override
  @pragma('vm:prefer-inline')
  $AlbumCopyWith<$Res> get album {
    return $AlbumCopyWith<$Res>(_value.album, (value) {
      return _then(_value.copyWith(album: value));
    });
  }
}

/// @nodoc

class _$AlbumLoadedStateImpl implements _AlbumLoadedState {
  const _$AlbumLoadedStateImpl({required this.album});

  @override
  final Album album;

  @override
  String toString() {
    return 'AlbumState.loaded(album: $album)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumLoadedStateImpl &&
            (identical(other.album, album) || other.album == album));
  }

  @override
  int get hashCode => Object.hash(runtimeType, album);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$AlbumLoadedStateImplCopyWith<_$AlbumLoadedStateImpl> get copyWith =>
      __$$AlbumLoadedStateImplCopyWithImpl<_$AlbumLoadedStateImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(Album album) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return loaded(album);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(Album album)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return loaded?.call(album);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(Album album)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (loaded != null) {
      return loaded(album);
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumInitialState value) initial,
    required TResult Function(_AlbumLoadingState value) loading,
    required TResult Function(_AlbumLoadedState value) loaded,
    required TResult Function(_AlbumErrorState value) error,
  }) {
    return loaded(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumInitialState value)? initial,
    TResult? Function(_AlbumLoadingState value)? loading,
    TResult? Function(_AlbumLoadedState value)? loaded,
    TResult? Function(_AlbumErrorState value)? error,
  }) {
    return loaded?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumInitialState value)? initial,
    TResult Function(_AlbumLoadingState value)? loading,
    TResult Function(_AlbumLoadedState value)? loaded,
    TResult Function(_AlbumErrorState value)? error,
    required TResult orElse(),
  }) {
    if (loaded != null) {
      return loaded(this);
    }
    return orElse();
  }
}

abstract class _AlbumLoadedState implements AlbumState {
  const factory _AlbumLoadedState({required final Album album}) =
      _$AlbumLoadedStateImpl;

  Album get album;
  @JsonKey(ignore: true)
  _$$AlbumLoadedStateImplCopyWith<_$AlbumLoadedStateImpl> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class _$$AlbumErrorStateImplCopyWith<$Res> {
  factory _$$AlbumErrorStateImplCopyWith(_$AlbumErrorStateImpl value,
          $Res Function(_$AlbumErrorStateImpl) then) =
      __$$AlbumErrorStateImplCopyWithImpl<$Res>;
  @useResult
  $Res call({String errorMessage});
}

/// @nodoc
class __$$AlbumErrorStateImplCopyWithImpl<$Res>
    extends _$AlbumStateCopyWithImpl<$Res, _$AlbumErrorStateImpl>
    implements _$$AlbumErrorStateImplCopyWith<$Res> {
  __$$AlbumErrorStateImplCopyWithImpl(
      _$AlbumErrorStateImpl _value, $Res Function(_$AlbumErrorStateImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? errorMessage = null,
  }) {
    return _then(_$AlbumErrorStateImpl(
      errorMessage: null == errorMessage
          ? _value.errorMessage
          : errorMessage // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

class _$AlbumErrorStateImpl implements _AlbumErrorState {
  const _$AlbumErrorStateImpl({required this.errorMessage});

  @override
  final String errorMessage;

  @override
  String toString() {
    return 'AlbumState.error(errorMessage: $errorMessage)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumErrorStateImpl &&
            (identical(other.errorMessage, errorMessage) ||
                other.errorMessage == errorMessage));
  }

  @override
  int get hashCode => Object.hash(runtimeType, errorMessage);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$AlbumErrorStateImplCopyWith<_$AlbumErrorStateImpl> get copyWith =>
      __$$AlbumErrorStateImplCopyWithImpl<_$AlbumErrorStateImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(Album album) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return error(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(Album album)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return error?.call(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(Album album)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (error != null) {
      return error(errorMessage);
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumInitialState value) initial,
    required TResult Function(_AlbumLoadingState value) loading,
    required TResult Function(_AlbumLoadedState value) loaded,
    required TResult Function(_AlbumErrorState value) error,
  }) {
    return error(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumInitialState value)? initial,
    TResult? Function(_AlbumLoadingState value)? loading,
    TResult? Function(_AlbumLoadedState value)? loaded,
    TResult? Function(_AlbumErrorState value)? error,
  }) {
    return error?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumInitialState value)? initial,
    TResult Function(_AlbumLoadingState value)? loading,
    TResult Function(_AlbumLoadedState value)? loaded,
    TResult Function(_AlbumErrorState value)? error,
    required TResult orElse(),
  }) {
    if (error != null) {
      return error(this);
    }
    return orElse();
  }
}

abstract class _AlbumErrorState implements AlbumState {
  const factory _AlbumErrorState({required final String errorMessage}) =
      _$AlbumErrorStateImpl;

  String get errorMessage;
  @JsonKey(ignore: true)
  _$$AlbumErrorStateImplCopyWith<_$AlbumErrorStateImpl> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
mixin _$AlbumsState {
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(AlbumsDto dto) loaded,
    required TResult Function(String errorMessage) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(AlbumsDto dto)? loaded,
    TResult? Function(String errorMessage)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(AlbumsDto dto)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumsInitialState value) initial,
    required TResult Function(_AlbumsLoadingState value) loading,
    required TResult Function(_AlbumsLoadedState value) loaded,
    required TResult Function(_AlbumsErrorState value) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumsInitialState value)? initial,
    TResult? Function(_AlbumsLoadingState value)? loading,
    TResult? Function(_AlbumsLoadedState value)? loaded,
    TResult? Function(_AlbumsErrorState value)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumsInitialState value)? initial,
    TResult Function(_AlbumsLoadingState value)? loading,
    TResult Function(_AlbumsLoadedState value)? loaded,
    TResult Function(_AlbumsErrorState value)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AlbumsStateCopyWith<$Res> {
  factory $AlbumsStateCopyWith(
          AlbumsState value, $Res Function(AlbumsState) then) =
      _$AlbumsStateCopyWithImpl<$Res, AlbumsState>;
}

/// @nodoc
class _$AlbumsStateCopyWithImpl<$Res, $Val extends AlbumsState>
    implements $AlbumsStateCopyWith<$Res> {
  _$AlbumsStateCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;
}

/// @nodoc
abstract class _$$AlbumsInitialStateImplCopyWith<$Res> {
  factory _$$AlbumsInitialStateImplCopyWith(_$AlbumsInitialStateImpl value,
          $Res Function(_$AlbumsInitialStateImpl) then) =
      __$$AlbumsInitialStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$AlbumsInitialStateImplCopyWithImpl<$Res>
    extends _$AlbumsStateCopyWithImpl<$Res, _$AlbumsInitialStateImpl>
    implements _$$AlbumsInitialStateImplCopyWith<$Res> {
  __$$AlbumsInitialStateImplCopyWithImpl(_$AlbumsInitialStateImpl _value,
      $Res Function(_$AlbumsInitialStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$AlbumsInitialStateImpl implements _AlbumsInitialState {
  const _$AlbumsInitialStateImpl();

  @override
  String toString() {
    return 'AlbumsState.initial()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType && other is _$AlbumsInitialStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(AlbumsDto dto) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return initial();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(AlbumsDto dto)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return initial?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(AlbumsDto dto)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (initial != null) {
      return initial();
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumsInitialState value) initial,
    required TResult Function(_AlbumsLoadingState value) loading,
    required TResult Function(_AlbumsLoadedState value) loaded,
    required TResult Function(_AlbumsErrorState value) error,
  }) {
    return initial(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumsInitialState value)? initial,
    TResult? Function(_AlbumsLoadingState value)? loading,
    TResult? Function(_AlbumsLoadedState value)? loaded,
    TResult? Function(_AlbumsErrorState value)? error,
  }) {
    return initial?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumsInitialState value)? initial,
    TResult Function(_AlbumsLoadingState value)? loading,
    TResult Function(_AlbumsLoadedState value)? loaded,
    TResult Function(_AlbumsErrorState value)? error,
    required TResult orElse(),
  }) {
    if (initial != null) {
      return initial(this);
    }
    return orElse();
  }
}

abstract class _AlbumsInitialState implements AlbumsState {
  const factory _AlbumsInitialState() = _$AlbumsInitialStateImpl;
}

/// @nodoc
abstract class _$$AlbumsLoadingStateImplCopyWith<$Res> {
  factory _$$AlbumsLoadingStateImplCopyWith(_$AlbumsLoadingStateImpl value,
          $Res Function(_$AlbumsLoadingStateImpl) then) =
      __$$AlbumsLoadingStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$AlbumsLoadingStateImplCopyWithImpl<$Res>
    extends _$AlbumsStateCopyWithImpl<$Res, _$AlbumsLoadingStateImpl>
    implements _$$AlbumsLoadingStateImplCopyWith<$Res> {
  __$$AlbumsLoadingStateImplCopyWithImpl(_$AlbumsLoadingStateImpl _value,
      $Res Function(_$AlbumsLoadingStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$AlbumsLoadingStateImpl implements _AlbumsLoadingState {
  const _$AlbumsLoadingStateImpl();

  @override
  String toString() {
    return 'AlbumsState.loading()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType && other is _$AlbumsLoadingStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(AlbumsDto dto) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return loading();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(AlbumsDto dto)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return loading?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(AlbumsDto dto)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (loading != null) {
      return loading();
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumsInitialState value) initial,
    required TResult Function(_AlbumsLoadingState value) loading,
    required TResult Function(_AlbumsLoadedState value) loaded,
    required TResult Function(_AlbumsErrorState value) error,
  }) {
    return loading(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumsInitialState value)? initial,
    TResult? Function(_AlbumsLoadingState value)? loading,
    TResult? Function(_AlbumsLoadedState value)? loaded,
    TResult? Function(_AlbumsErrorState value)? error,
  }) {
    return loading?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumsInitialState value)? initial,
    TResult Function(_AlbumsLoadingState value)? loading,
    TResult Function(_AlbumsLoadedState value)? loaded,
    TResult Function(_AlbumsErrorState value)? error,
    required TResult orElse(),
  }) {
    if (loading != null) {
      return loading(this);
    }
    return orElse();
  }
}

abstract class _AlbumsLoadingState implements AlbumsState {
  const factory _AlbumsLoadingState() = _$AlbumsLoadingStateImpl;
}

/// @nodoc
abstract class _$$AlbumsLoadedStateImplCopyWith<$Res> {
  factory _$$AlbumsLoadedStateImplCopyWith(_$AlbumsLoadedStateImpl value,
          $Res Function(_$AlbumsLoadedStateImpl) then) =
      __$$AlbumsLoadedStateImplCopyWithImpl<$Res>;
  @useResult
  $Res call({AlbumsDto dto});

  $AlbumsDtoCopyWith<$Res> get dto;
}

/// @nodoc
class __$$AlbumsLoadedStateImplCopyWithImpl<$Res>
    extends _$AlbumsStateCopyWithImpl<$Res, _$AlbumsLoadedStateImpl>
    implements _$$AlbumsLoadedStateImplCopyWith<$Res> {
  __$$AlbumsLoadedStateImplCopyWithImpl(_$AlbumsLoadedStateImpl _value,
      $Res Function(_$AlbumsLoadedStateImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? dto = null,
  }) {
    return _then(_$AlbumsLoadedStateImpl(
      dto: null == dto
          ? _value.dto
          : dto // ignore: cast_nullable_to_non_nullable
              as AlbumsDto,
    ));
  }

  @override
  @pragma('vm:prefer-inline')
  $AlbumsDtoCopyWith<$Res> get dto {
    return $AlbumsDtoCopyWith<$Res>(_value.dto, (value) {
      return _then(_value.copyWith(dto: value));
    });
  }
}

/// @nodoc

class _$AlbumsLoadedStateImpl implements _AlbumsLoadedState {
  const _$AlbumsLoadedStateImpl({required this.dto});

  @override
  final AlbumsDto dto;

  @override
  String toString() {
    return 'AlbumsState.loaded(dto: $dto)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumsLoadedStateImpl &&
            (identical(other.dto, dto) || other.dto == dto));
  }

  @override
  int get hashCode => Object.hash(runtimeType, dto);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$AlbumsLoadedStateImplCopyWith<_$AlbumsLoadedStateImpl> get copyWith =>
      __$$AlbumsLoadedStateImplCopyWithImpl<_$AlbumsLoadedStateImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(AlbumsDto dto) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return loaded(dto);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(AlbumsDto dto)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return loaded?.call(dto);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(AlbumsDto dto)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (loaded != null) {
      return loaded(dto);
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumsInitialState value) initial,
    required TResult Function(_AlbumsLoadingState value) loading,
    required TResult Function(_AlbumsLoadedState value) loaded,
    required TResult Function(_AlbumsErrorState value) error,
  }) {
    return loaded(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumsInitialState value)? initial,
    TResult? Function(_AlbumsLoadingState value)? loading,
    TResult? Function(_AlbumsLoadedState value)? loaded,
    TResult? Function(_AlbumsErrorState value)? error,
  }) {
    return loaded?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumsInitialState value)? initial,
    TResult Function(_AlbumsLoadingState value)? loading,
    TResult Function(_AlbumsLoadedState value)? loaded,
    TResult Function(_AlbumsErrorState value)? error,
    required TResult orElse(),
  }) {
    if (loaded != null) {
      return loaded(this);
    }
    return orElse();
  }
}

abstract class _AlbumsLoadedState implements AlbumsState {
  const factory _AlbumsLoadedState({required final AlbumsDto dto}) =
      _$AlbumsLoadedStateImpl;

  AlbumsDto get dto;
  @JsonKey(ignore: true)
  _$$AlbumsLoadedStateImplCopyWith<_$AlbumsLoadedStateImpl> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class _$$AlbumsErrorStateImplCopyWith<$Res> {
  factory _$$AlbumsErrorStateImplCopyWith(_$AlbumsErrorStateImpl value,
          $Res Function(_$AlbumsErrorStateImpl) then) =
      __$$AlbumsErrorStateImplCopyWithImpl<$Res>;
  @useResult
  $Res call({String errorMessage});
}

/// @nodoc
class __$$AlbumsErrorStateImplCopyWithImpl<$Res>
    extends _$AlbumsStateCopyWithImpl<$Res, _$AlbumsErrorStateImpl>
    implements _$$AlbumsErrorStateImplCopyWith<$Res> {
  __$$AlbumsErrorStateImplCopyWithImpl(_$AlbumsErrorStateImpl _value,
      $Res Function(_$AlbumsErrorStateImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? errorMessage = null,
  }) {
    return _then(_$AlbumsErrorStateImpl(
      errorMessage: null == errorMessage
          ? _value.errorMessage
          : errorMessage // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

class _$AlbumsErrorStateImpl implements _AlbumsErrorState {
  const _$AlbumsErrorStateImpl({required this.errorMessage});

  @override
  final String errorMessage;

  @override
  String toString() {
    return 'AlbumsState.error(errorMessage: $errorMessage)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AlbumsErrorStateImpl &&
            (identical(other.errorMessage, errorMessage) ||
                other.errorMessage == errorMessage));
  }

  @override
  int get hashCode => Object.hash(runtimeType, errorMessage);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$AlbumsErrorStateImplCopyWith<_$AlbumsErrorStateImpl> get copyWith =>
      __$$AlbumsErrorStateImplCopyWithImpl<_$AlbumsErrorStateImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(AlbumsDto dto) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return error(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(AlbumsDto dto)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return error?.call(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(AlbumsDto dto)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (error != null) {
      return error(errorMessage);
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_AlbumsInitialState value) initial,
    required TResult Function(_AlbumsLoadingState value) loading,
    required TResult Function(_AlbumsLoadedState value) loaded,
    required TResult Function(_AlbumsErrorState value) error,
  }) {
    return error(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_AlbumsInitialState value)? initial,
    TResult? Function(_AlbumsLoadingState value)? loading,
    TResult? Function(_AlbumsLoadedState value)? loaded,
    TResult? Function(_AlbumsErrorState value)? error,
  }) {
    return error?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_AlbumsInitialState value)? initial,
    TResult Function(_AlbumsLoadingState value)? loading,
    TResult Function(_AlbumsLoadedState value)? loaded,
    TResult Function(_AlbumsErrorState value)? error,
    required TResult orElse(),
  }) {
    if (error != null) {
      return error(this);
    }
    return orElse();
  }
}

abstract class _AlbumsErrorState implements AlbumsState {
  const factory _AlbumsErrorState({required final String errorMessage}) =
      _$AlbumsErrorStateImpl;

  String get errorMessage;
  @JsonKey(ignore: true)
  _$$AlbumsErrorStateImplCopyWith<_$AlbumsErrorStateImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
