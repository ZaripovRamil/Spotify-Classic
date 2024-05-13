// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'search_bloc.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

/// @nodoc
mixin _$SearchState {
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(SearchDto? searchResult) loaded,
    required TResult Function(String errorMessage) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(SearchDto? searchResult)? loaded,
    TResult? Function(String errorMessage)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(SearchDto? searchResult)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_SearchInitialState value) initial,
    required TResult Function(_SearchLoadingState value) loading,
    required TResult Function(_SearchLoadedState value) loaded,
    required TResult Function(_SearchErrorlState value) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SearchInitialState value)? initial,
    TResult? Function(_SearchLoadingState value)? loading,
    TResult? Function(_SearchLoadedState value)? loaded,
    TResult? Function(_SearchErrorlState value)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SearchInitialState value)? initial,
    TResult Function(_SearchLoadingState value)? loading,
    TResult Function(_SearchLoadedState value)? loaded,
    TResult Function(_SearchErrorlState value)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $SearchStateCopyWith<$Res> {
  factory $SearchStateCopyWith(
          SearchState value, $Res Function(SearchState) then) =
      _$SearchStateCopyWithImpl<$Res, SearchState>;
}

/// @nodoc
class _$SearchStateCopyWithImpl<$Res, $Val extends SearchState>
    implements $SearchStateCopyWith<$Res> {
  _$SearchStateCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;
}

/// @nodoc
abstract class _$$SearchInitialStateImplCopyWith<$Res> {
  factory _$$SearchInitialStateImplCopyWith(_$SearchInitialStateImpl value,
          $Res Function(_$SearchInitialStateImpl) then) =
      __$$SearchInitialStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$SearchInitialStateImplCopyWithImpl<$Res>
    extends _$SearchStateCopyWithImpl<$Res, _$SearchInitialStateImpl>
    implements _$$SearchInitialStateImplCopyWith<$Res> {
  __$$SearchInitialStateImplCopyWithImpl(_$SearchInitialStateImpl _value,
      $Res Function(_$SearchInitialStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$SearchInitialStateImpl implements _SearchInitialState {
  const _$SearchInitialStateImpl();

  @override
  String toString() {
    return 'SearchState.initial()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType && other is _$SearchInitialStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(SearchDto? searchResult) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return initial();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(SearchDto? searchResult)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return initial?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(SearchDto? searchResult)? loaded,
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
    required TResult Function(_SearchInitialState value) initial,
    required TResult Function(_SearchLoadingState value) loading,
    required TResult Function(_SearchLoadedState value) loaded,
    required TResult Function(_SearchErrorlState value) error,
  }) {
    return initial(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SearchInitialState value)? initial,
    TResult? Function(_SearchLoadingState value)? loading,
    TResult? Function(_SearchLoadedState value)? loaded,
    TResult? Function(_SearchErrorlState value)? error,
  }) {
    return initial?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SearchInitialState value)? initial,
    TResult Function(_SearchLoadingState value)? loading,
    TResult Function(_SearchLoadedState value)? loaded,
    TResult Function(_SearchErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (initial != null) {
      return initial(this);
    }
    return orElse();
  }
}

abstract class _SearchInitialState implements SearchState {
  const factory _SearchInitialState() = _$SearchInitialStateImpl;
}

/// @nodoc
abstract class _$$SearchLoadingStateImplCopyWith<$Res> {
  factory _$$SearchLoadingStateImplCopyWith(_$SearchLoadingStateImpl value,
          $Res Function(_$SearchLoadingStateImpl) then) =
      __$$SearchLoadingStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$SearchLoadingStateImplCopyWithImpl<$Res>
    extends _$SearchStateCopyWithImpl<$Res, _$SearchLoadingStateImpl>
    implements _$$SearchLoadingStateImplCopyWith<$Res> {
  __$$SearchLoadingStateImplCopyWithImpl(_$SearchLoadingStateImpl _value,
      $Res Function(_$SearchLoadingStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$SearchLoadingStateImpl implements _SearchLoadingState {
  const _$SearchLoadingStateImpl();

  @override
  String toString() {
    return 'SearchState.loading()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType && other is _$SearchLoadingStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(SearchDto? searchResult) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return loading();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(SearchDto? searchResult)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return loading?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(SearchDto? searchResult)? loaded,
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
    required TResult Function(_SearchInitialState value) initial,
    required TResult Function(_SearchLoadingState value) loading,
    required TResult Function(_SearchLoadedState value) loaded,
    required TResult Function(_SearchErrorlState value) error,
  }) {
    return loading(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SearchInitialState value)? initial,
    TResult? Function(_SearchLoadingState value)? loading,
    TResult? Function(_SearchLoadedState value)? loaded,
    TResult? Function(_SearchErrorlState value)? error,
  }) {
    return loading?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SearchInitialState value)? initial,
    TResult Function(_SearchLoadingState value)? loading,
    TResult Function(_SearchLoadedState value)? loaded,
    TResult Function(_SearchErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (loading != null) {
      return loading(this);
    }
    return orElse();
  }
}

abstract class _SearchLoadingState implements SearchState {
  const factory _SearchLoadingState() = _$SearchLoadingStateImpl;
}

/// @nodoc
abstract class _$$SearchLoadedStateImplCopyWith<$Res> {
  factory _$$SearchLoadedStateImplCopyWith(_$SearchLoadedStateImpl value,
          $Res Function(_$SearchLoadedStateImpl) then) =
      __$$SearchLoadedStateImplCopyWithImpl<$Res>;
  @useResult
  $Res call({SearchDto? searchResult});

  $SearchDtoCopyWith<$Res>? get searchResult;
}

/// @nodoc
class __$$SearchLoadedStateImplCopyWithImpl<$Res>
    extends _$SearchStateCopyWithImpl<$Res, _$SearchLoadedStateImpl>
    implements _$$SearchLoadedStateImplCopyWith<$Res> {
  __$$SearchLoadedStateImplCopyWithImpl(_$SearchLoadedStateImpl _value,
      $Res Function(_$SearchLoadedStateImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? searchResult = freezed,
  }) {
    return _then(_$SearchLoadedStateImpl(
      searchResult: freezed == searchResult
          ? _value.searchResult
          : searchResult // ignore: cast_nullable_to_non_nullable
              as SearchDto?,
    ));
  }

  @override
  @pragma('vm:prefer-inline')
  $SearchDtoCopyWith<$Res>? get searchResult {
    if (_value.searchResult == null) {
      return null;
    }

    return $SearchDtoCopyWith<$Res>(_value.searchResult!, (value) {
      return _then(_value.copyWith(searchResult: value));
    });
  }
}

/// @nodoc

class _$SearchLoadedStateImpl implements _SearchLoadedState {
  const _$SearchLoadedStateImpl({required this.searchResult});

  @override
  final SearchDto? searchResult;

  @override
  String toString() {
    return 'SearchState.loaded(searchResult: $searchResult)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SearchLoadedStateImpl &&
            (identical(other.searchResult, searchResult) ||
                other.searchResult == searchResult));
  }

  @override
  int get hashCode => Object.hash(runtimeType, searchResult);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$SearchLoadedStateImplCopyWith<_$SearchLoadedStateImpl> get copyWith =>
      __$$SearchLoadedStateImplCopyWithImpl<_$SearchLoadedStateImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(SearchDto? searchResult) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return loaded(searchResult);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(SearchDto? searchResult)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return loaded?.call(searchResult);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(SearchDto? searchResult)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (loaded != null) {
      return loaded(searchResult);
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_SearchInitialState value) initial,
    required TResult Function(_SearchLoadingState value) loading,
    required TResult Function(_SearchLoadedState value) loaded,
    required TResult Function(_SearchErrorlState value) error,
  }) {
    return loaded(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SearchInitialState value)? initial,
    TResult? Function(_SearchLoadingState value)? loading,
    TResult? Function(_SearchLoadedState value)? loaded,
    TResult? Function(_SearchErrorlState value)? error,
  }) {
    return loaded?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SearchInitialState value)? initial,
    TResult Function(_SearchLoadingState value)? loading,
    TResult Function(_SearchLoadedState value)? loaded,
    TResult Function(_SearchErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (loaded != null) {
      return loaded(this);
    }
    return orElse();
  }
}

abstract class _SearchLoadedState implements SearchState {
  const factory _SearchLoadedState({required final SearchDto? searchResult}) =
      _$SearchLoadedStateImpl;

  SearchDto? get searchResult;
  @JsonKey(ignore: true)
  _$$SearchLoadedStateImplCopyWith<_$SearchLoadedStateImpl> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class _$$SearchErrorlStateImplCopyWith<$Res> {
  factory _$$SearchErrorlStateImplCopyWith(_$SearchErrorlStateImpl value,
          $Res Function(_$SearchErrorlStateImpl) then) =
      __$$SearchErrorlStateImplCopyWithImpl<$Res>;
  @useResult
  $Res call({String errorMessage});
}

/// @nodoc
class __$$SearchErrorlStateImplCopyWithImpl<$Res>
    extends _$SearchStateCopyWithImpl<$Res, _$SearchErrorlStateImpl>
    implements _$$SearchErrorlStateImplCopyWith<$Res> {
  __$$SearchErrorlStateImplCopyWithImpl(_$SearchErrorlStateImpl _value,
      $Res Function(_$SearchErrorlStateImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? errorMessage = null,
  }) {
    return _then(_$SearchErrorlStateImpl(
      errorMessage: null == errorMessage
          ? _value.errorMessage
          : errorMessage // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

class _$SearchErrorlStateImpl implements _SearchErrorlState {
  const _$SearchErrorlStateImpl({required this.errorMessage});

  @override
  final String errorMessage;

  @override
  String toString() {
    return 'SearchState.error(errorMessage: $errorMessage)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SearchErrorlStateImpl &&
            (identical(other.errorMessage, errorMessage) ||
                other.errorMessage == errorMessage));
  }

  @override
  int get hashCode => Object.hash(runtimeType, errorMessage);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$SearchErrorlStateImplCopyWith<_$SearchErrorlStateImpl> get copyWith =>
      __$$SearchErrorlStateImplCopyWithImpl<_$SearchErrorlStateImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(SearchDto? searchResult) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return error(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(SearchDto? searchResult)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return error?.call(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(SearchDto? searchResult)? loaded,
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
    required TResult Function(_SearchInitialState value) initial,
    required TResult Function(_SearchLoadingState value) loading,
    required TResult Function(_SearchLoadedState value) loaded,
    required TResult Function(_SearchErrorlState value) error,
  }) {
    return error(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SearchInitialState value)? initial,
    TResult? Function(_SearchLoadingState value)? loading,
    TResult? Function(_SearchLoadedState value)? loaded,
    TResult? Function(_SearchErrorlState value)? error,
  }) {
    return error?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SearchInitialState value)? initial,
    TResult Function(_SearchLoadingState value)? loading,
    TResult Function(_SearchLoadedState value)? loaded,
    TResult Function(_SearchErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (error != null) {
      return error(this);
    }
    return orElse();
  }
}

abstract class _SearchErrorlState implements SearchState {
  const factory _SearchErrorlState({required final String errorMessage}) =
      _$SearchErrorlStateImpl;

  String get errorMessage;
  @JsonKey(ignore: true)
  _$$SearchErrorlStateImplCopyWith<_$SearchErrorlStateImpl> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
mixin _$SearchEvent {
  String get query => throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function(String query) search,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function(String query)? search,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function(String query)? search,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(SearchSearchEvent value) search,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(SearchSearchEvent value)? search,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(SearchSearchEvent value)? search,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;

  @JsonKey(ignore: true)
  $SearchEventCopyWith<SearchEvent> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $SearchEventCopyWith<$Res> {
  factory $SearchEventCopyWith(
          SearchEvent value, $Res Function(SearchEvent) then) =
      _$SearchEventCopyWithImpl<$Res, SearchEvent>;
  @useResult
  $Res call({String query});
}

/// @nodoc
class _$SearchEventCopyWithImpl<$Res, $Val extends SearchEvent>
    implements $SearchEventCopyWith<$Res> {
  _$SearchEventCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? query = null,
  }) {
    return _then(_value.copyWith(
      query: null == query
          ? _value.query
          : query // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$SearchSearchEventImplCopyWith<$Res>
    implements $SearchEventCopyWith<$Res> {
  factory _$$SearchSearchEventImplCopyWith(_$SearchSearchEventImpl value,
          $Res Function(_$SearchSearchEventImpl) then) =
      __$$SearchSearchEventImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String query});
}

/// @nodoc
class __$$SearchSearchEventImplCopyWithImpl<$Res>
    extends _$SearchEventCopyWithImpl<$Res, _$SearchSearchEventImpl>
    implements _$$SearchSearchEventImplCopyWith<$Res> {
  __$$SearchSearchEventImplCopyWithImpl(_$SearchSearchEventImpl _value,
      $Res Function(_$SearchSearchEventImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? query = null,
  }) {
    return _then(_$SearchSearchEventImpl(
      query: null == query
          ? _value.query
          : query // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

class _$SearchSearchEventImpl implements SearchSearchEvent {
  const _$SearchSearchEventImpl({required this.query});

  @override
  final String query;

  @override
  String toString() {
    return 'SearchEvent.search(query: $query)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SearchSearchEventImpl &&
            (identical(other.query, query) || other.query == query));
  }

  @override
  int get hashCode => Object.hash(runtimeType, query);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$SearchSearchEventImplCopyWith<_$SearchSearchEventImpl> get copyWith =>
      __$$SearchSearchEventImplCopyWithImpl<_$SearchSearchEventImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function(String query) search,
  }) {
    return search(query);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function(String query)? search,
  }) {
    return search?.call(query);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function(String query)? search,
    required TResult orElse(),
  }) {
    if (search != null) {
      return search(query);
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(SearchSearchEvent value) search,
  }) {
    return search(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(SearchSearchEvent value)? search,
  }) {
    return search?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(SearchSearchEvent value)? search,
    required TResult orElse(),
  }) {
    if (search != null) {
      return search(this);
    }
    return orElse();
  }
}

abstract class SearchSearchEvent implements SearchEvent {
  const factory SearchSearchEvent({required final String query}) =
      _$SearchSearchEventImpl;

  @override
  String get query;
  @override
  @JsonKey(ignore: true)
  _$$SearchSearchEventImplCopyWith<_$SearchSearchEventImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
