// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'history_bloc.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

/// @nodoc
mixin _$HistoryState {
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(HistoryDto history) loaded,
    required TResult Function(String errorMessage) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(HistoryDto history)? loaded,
    TResult? Function(String errorMessage)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(HistoryDto history)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_HistoryInitialState value) initial,
    required TResult Function(_HistoryLoadingState value) loading,
    required TResult Function(_HistoryLoadedState value) loaded,
    required TResult Function(_HistoryErrorlState value) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_HistoryInitialState value)? initial,
    TResult? Function(_HistoryLoadingState value)? loading,
    TResult? Function(_HistoryLoadedState value)? loaded,
    TResult? Function(_HistoryErrorlState value)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_HistoryInitialState value)? initial,
    TResult Function(_HistoryLoadingState value)? loading,
    TResult Function(_HistoryLoadedState value)? loaded,
    TResult Function(_HistoryErrorlState value)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $HistoryStateCopyWith<$Res> {
  factory $HistoryStateCopyWith(
          HistoryState value, $Res Function(HistoryState) then) =
      _$HistoryStateCopyWithImpl<$Res, HistoryState>;
}

/// @nodoc
class _$HistoryStateCopyWithImpl<$Res, $Val extends HistoryState>
    implements $HistoryStateCopyWith<$Res> {
  _$HistoryStateCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;
}

/// @nodoc
abstract class _$$HistoryInitialStateImplCopyWith<$Res> {
  factory _$$HistoryInitialStateImplCopyWith(_$HistoryInitialStateImpl value,
          $Res Function(_$HistoryInitialStateImpl) then) =
      __$$HistoryInitialStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$HistoryInitialStateImplCopyWithImpl<$Res>
    extends _$HistoryStateCopyWithImpl<$Res, _$HistoryInitialStateImpl>
    implements _$$HistoryInitialStateImplCopyWith<$Res> {
  __$$HistoryInitialStateImplCopyWithImpl(_$HistoryInitialStateImpl _value,
      $Res Function(_$HistoryInitialStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$HistoryInitialStateImpl implements _HistoryInitialState {
  const _$HistoryInitialStateImpl();

  @override
  String toString() {
    return 'HistoryState.initial()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$HistoryInitialStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(HistoryDto history) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return initial();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(HistoryDto history)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return initial?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(HistoryDto history)? loaded,
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
    required TResult Function(_HistoryInitialState value) initial,
    required TResult Function(_HistoryLoadingState value) loading,
    required TResult Function(_HistoryLoadedState value) loaded,
    required TResult Function(_HistoryErrorlState value) error,
  }) {
    return initial(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_HistoryInitialState value)? initial,
    TResult? Function(_HistoryLoadingState value)? loading,
    TResult? Function(_HistoryLoadedState value)? loaded,
    TResult? Function(_HistoryErrorlState value)? error,
  }) {
    return initial?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_HistoryInitialState value)? initial,
    TResult Function(_HistoryLoadingState value)? loading,
    TResult Function(_HistoryLoadedState value)? loaded,
    TResult Function(_HistoryErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (initial != null) {
      return initial(this);
    }
    return orElse();
  }
}

abstract class _HistoryInitialState implements HistoryState {
  const factory _HistoryInitialState() = _$HistoryInitialStateImpl;
}

/// @nodoc
abstract class _$$HistoryLoadingStateImplCopyWith<$Res> {
  factory _$$HistoryLoadingStateImplCopyWith(_$HistoryLoadingStateImpl value,
          $Res Function(_$HistoryLoadingStateImpl) then) =
      __$$HistoryLoadingStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$HistoryLoadingStateImplCopyWithImpl<$Res>
    extends _$HistoryStateCopyWithImpl<$Res, _$HistoryLoadingStateImpl>
    implements _$$HistoryLoadingStateImplCopyWith<$Res> {
  __$$HistoryLoadingStateImplCopyWithImpl(_$HistoryLoadingStateImpl _value,
      $Res Function(_$HistoryLoadingStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$HistoryLoadingStateImpl implements _HistoryLoadingState {
  const _$HistoryLoadingStateImpl();

  @override
  String toString() {
    return 'HistoryState.loading()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$HistoryLoadingStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(HistoryDto history) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return loading();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(HistoryDto history)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return loading?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(HistoryDto history)? loaded,
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
    required TResult Function(_HistoryInitialState value) initial,
    required TResult Function(_HistoryLoadingState value) loading,
    required TResult Function(_HistoryLoadedState value) loaded,
    required TResult Function(_HistoryErrorlState value) error,
  }) {
    return loading(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_HistoryInitialState value)? initial,
    TResult? Function(_HistoryLoadingState value)? loading,
    TResult? Function(_HistoryLoadedState value)? loaded,
    TResult? Function(_HistoryErrorlState value)? error,
  }) {
    return loading?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_HistoryInitialState value)? initial,
    TResult Function(_HistoryLoadingState value)? loading,
    TResult Function(_HistoryLoadedState value)? loaded,
    TResult Function(_HistoryErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (loading != null) {
      return loading(this);
    }
    return orElse();
  }
}

abstract class _HistoryLoadingState implements HistoryState {
  const factory _HistoryLoadingState() = _$HistoryLoadingStateImpl;
}

/// @nodoc
abstract class _$$HistoryLoadedStateImplCopyWith<$Res> {
  factory _$$HistoryLoadedStateImplCopyWith(_$HistoryLoadedStateImpl value,
          $Res Function(_$HistoryLoadedStateImpl) then) =
      __$$HistoryLoadedStateImplCopyWithImpl<$Res>;
  @useResult
  $Res call({HistoryDto history});

  $HistoryDtoCopyWith<$Res> get history;
}

/// @nodoc
class __$$HistoryLoadedStateImplCopyWithImpl<$Res>
    extends _$HistoryStateCopyWithImpl<$Res, _$HistoryLoadedStateImpl>
    implements _$$HistoryLoadedStateImplCopyWith<$Res> {
  __$$HistoryLoadedStateImplCopyWithImpl(_$HistoryLoadedStateImpl _value,
      $Res Function(_$HistoryLoadedStateImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? history = null,
  }) {
    return _then(_$HistoryLoadedStateImpl(
      history: null == history
          ? _value.history
          : history // ignore: cast_nullable_to_non_nullable
              as HistoryDto,
    ));
  }

  @override
  @pragma('vm:prefer-inline')
  $HistoryDtoCopyWith<$Res> get history {
    return $HistoryDtoCopyWith<$Res>(_value.history, (value) {
      return _then(_value.copyWith(history: value));
    });
  }
}

/// @nodoc

class _$HistoryLoadedStateImpl implements _HistoryLoadedState {
  const _$HistoryLoadedStateImpl({required this.history});

  @override
  final HistoryDto history;

  @override
  String toString() {
    return 'HistoryState.loaded(history: $history)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$HistoryLoadedStateImpl &&
            (identical(other.history, history) || other.history == history));
  }

  @override
  int get hashCode => Object.hash(runtimeType, history);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$HistoryLoadedStateImplCopyWith<_$HistoryLoadedStateImpl> get copyWith =>
      __$$HistoryLoadedStateImplCopyWithImpl<_$HistoryLoadedStateImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(HistoryDto history) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return loaded(history);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(HistoryDto history)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return loaded?.call(history);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(HistoryDto history)? loaded,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (loaded != null) {
      return loaded(history);
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_HistoryInitialState value) initial,
    required TResult Function(_HistoryLoadingState value) loading,
    required TResult Function(_HistoryLoadedState value) loaded,
    required TResult Function(_HistoryErrorlState value) error,
  }) {
    return loaded(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_HistoryInitialState value)? initial,
    TResult? Function(_HistoryLoadingState value)? loading,
    TResult? Function(_HistoryLoadedState value)? loaded,
    TResult? Function(_HistoryErrorlState value)? error,
  }) {
    return loaded?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_HistoryInitialState value)? initial,
    TResult Function(_HistoryLoadingState value)? loading,
    TResult Function(_HistoryLoadedState value)? loaded,
    TResult Function(_HistoryErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (loaded != null) {
      return loaded(this);
    }
    return orElse();
  }
}

abstract class _HistoryLoadedState implements HistoryState {
  const factory _HistoryLoadedState({required final HistoryDto history}) =
      _$HistoryLoadedStateImpl;

  HistoryDto get history;
  @JsonKey(ignore: true)
  _$$HistoryLoadedStateImplCopyWith<_$HistoryLoadedStateImpl> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class _$$HistoryErrorlStateImplCopyWith<$Res> {
  factory _$$HistoryErrorlStateImplCopyWith(_$HistoryErrorlStateImpl value,
          $Res Function(_$HistoryErrorlStateImpl) then) =
      __$$HistoryErrorlStateImplCopyWithImpl<$Res>;
  @useResult
  $Res call({String errorMessage});
}

/// @nodoc
class __$$HistoryErrorlStateImplCopyWithImpl<$Res>
    extends _$HistoryStateCopyWithImpl<$Res, _$HistoryErrorlStateImpl>
    implements _$$HistoryErrorlStateImplCopyWith<$Res> {
  __$$HistoryErrorlStateImplCopyWithImpl(_$HistoryErrorlStateImpl _value,
      $Res Function(_$HistoryErrorlStateImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? errorMessage = null,
  }) {
    return _then(_$HistoryErrorlStateImpl(
      errorMessage: null == errorMessage
          ? _value.errorMessage
          : errorMessage // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

class _$HistoryErrorlStateImpl implements _HistoryErrorlState {
  const _$HistoryErrorlStateImpl({required this.errorMessage});

  @override
  final String errorMessage;

  @override
  String toString() {
    return 'HistoryState.error(errorMessage: $errorMessage)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$HistoryErrorlStateImpl &&
            (identical(other.errorMessage, errorMessage) ||
                other.errorMessage == errorMessage));
  }

  @override
  int get hashCode => Object.hash(runtimeType, errorMessage);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$HistoryErrorlStateImplCopyWith<_$HistoryErrorlStateImpl> get copyWith =>
      __$$HistoryErrorlStateImplCopyWithImpl<_$HistoryErrorlStateImpl>(
          this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() loading,
    required TResult Function(HistoryDto history) loaded,
    required TResult Function(String errorMessage) error,
  }) {
    return error(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? loading,
    TResult? Function(HistoryDto history)? loaded,
    TResult? Function(String errorMessage)? error,
  }) {
    return error?.call(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? loading,
    TResult Function(HistoryDto history)? loaded,
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
    required TResult Function(_HistoryInitialState value) initial,
    required TResult Function(_HistoryLoadingState value) loading,
    required TResult Function(_HistoryLoadedState value) loaded,
    required TResult Function(_HistoryErrorlState value) error,
  }) {
    return error(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_HistoryInitialState value)? initial,
    TResult? Function(_HistoryLoadingState value)? loading,
    TResult? Function(_HistoryLoadedState value)? loaded,
    TResult? Function(_HistoryErrorlState value)? error,
  }) {
    return error?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_HistoryInitialState value)? initial,
    TResult Function(_HistoryLoadingState value)? loading,
    TResult Function(_HistoryLoadedState value)? loaded,
    TResult Function(_HistoryErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (error != null) {
      return error(this);
    }
    return orElse();
  }
}

abstract class _HistoryErrorlState implements HistoryState {
  const factory _HistoryErrorlState({required final String errorMessage}) =
      _$HistoryErrorlStateImpl;

  String get errorMessage;
  @JsonKey(ignore: true)
  _$$HistoryErrorlStateImplCopyWith<_$HistoryErrorlStateImpl> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
mixin _$HistoryEvent {
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() load,
    required TResult Function() clear,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? load,
    TResult? Function()? clear,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? load,
    TResult Function()? clear,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(HistoryLoadEvent value) load,
    required TResult Function(HistoryClearEvent value) clear,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(HistoryLoadEvent value)? load,
    TResult? Function(HistoryClearEvent value)? clear,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(HistoryLoadEvent value)? load,
    TResult Function(HistoryClearEvent value)? clear,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $HistoryEventCopyWith<$Res> {
  factory $HistoryEventCopyWith(
          HistoryEvent value, $Res Function(HistoryEvent) then) =
      _$HistoryEventCopyWithImpl<$Res, HistoryEvent>;
}

/// @nodoc
class _$HistoryEventCopyWithImpl<$Res, $Val extends HistoryEvent>
    implements $HistoryEventCopyWith<$Res> {
  _$HistoryEventCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;
}

/// @nodoc
abstract class _$$HistoryLoadEventImplCopyWith<$Res> {
  factory _$$HistoryLoadEventImplCopyWith(_$HistoryLoadEventImpl value,
          $Res Function(_$HistoryLoadEventImpl) then) =
      __$$HistoryLoadEventImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$HistoryLoadEventImplCopyWithImpl<$Res>
    extends _$HistoryEventCopyWithImpl<$Res, _$HistoryLoadEventImpl>
    implements _$$HistoryLoadEventImplCopyWith<$Res> {
  __$$HistoryLoadEventImplCopyWithImpl(_$HistoryLoadEventImpl _value,
      $Res Function(_$HistoryLoadEventImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$HistoryLoadEventImpl implements HistoryLoadEvent {
  const _$HistoryLoadEventImpl();

  @override
  String toString() {
    return 'HistoryEvent.load()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType && other is _$HistoryLoadEventImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() load,
    required TResult Function() clear,
  }) {
    return load();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? load,
    TResult? Function()? clear,
  }) {
    return load?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? load,
    TResult Function()? clear,
    required TResult orElse(),
  }) {
    if (load != null) {
      return load();
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(HistoryLoadEvent value) load,
    required TResult Function(HistoryClearEvent value) clear,
  }) {
    return load(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(HistoryLoadEvent value)? load,
    TResult? Function(HistoryClearEvent value)? clear,
  }) {
    return load?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(HistoryLoadEvent value)? load,
    TResult Function(HistoryClearEvent value)? clear,
    required TResult orElse(),
  }) {
    if (load != null) {
      return load(this);
    }
    return orElse();
  }
}

abstract class HistoryLoadEvent implements HistoryEvent {
  const factory HistoryLoadEvent() = _$HistoryLoadEventImpl;
}

/// @nodoc
abstract class _$$HistoryClearEventImplCopyWith<$Res> {
  factory _$$HistoryClearEventImplCopyWith(_$HistoryClearEventImpl value,
          $Res Function(_$HistoryClearEventImpl) then) =
      __$$HistoryClearEventImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$HistoryClearEventImplCopyWithImpl<$Res>
    extends _$HistoryEventCopyWithImpl<$Res, _$HistoryClearEventImpl>
    implements _$$HistoryClearEventImplCopyWith<$Res> {
  __$$HistoryClearEventImplCopyWithImpl(_$HistoryClearEventImpl _value,
      $Res Function(_$HistoryClearEventImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$HistoryClearEventImpl implements HistoryClearEvent {
  const _$HistoryClearEventImpl();

  @override
  String toString() {
    return 'HistoryEvent.clear()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType && other is _$HistoryClearEventImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() load,
    required TResult Function() clear,
  }) {
    return clear();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? load,
    TResult? Function()? clear,
  }) {
    return clear?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? load,
    TResult Function()? clear,
    required TResult orElse(),
  }) {
    if (clear != null) {
      return clear();
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(HistoryLoadEvent value) load,
    required TResult Function(HistoryClearEvent value) clear,
  }) {
    return clear(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(HistoryLoadEvent value)? load,
    TResult? Function(HistoryClearEvent value)? clear,
  }) {
    return clear?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(HistoryLoadEvent value)? load,
    TResult Function(HistoryClearEvent value)? clear,
    required TResult orElse(),
  }) {
    if (clear != null) {
      return clear(this);
    }
    return orElse();
  }
}

abstract class HistoryClearEvent implements HistoryEvent {
  const factory HistoryClearEvent() = _$HistoryClearEventImpl;
}
