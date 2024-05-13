// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'subscription_bloc.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

/// @nodoc
mixin _$SubscriptionState {
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() submitting,
    required TResult Function() submitted,
    required TResult Function(String errorMessage) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? submitting,
    TResult? Function()? submitted,
    TResult? Function(String errorMessage)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? submitting,
    TResult Function()? submitted,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_SubscriptionInitialState value) initial,
    required TResult Function(_SubscriptionSubmittingState value) submitting,
    required TResult Function(_SubscriptionSubmittedState value) submitted,
    required TResult Function(_SubscriptionErrorlState value) error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SubscriptionInitialState value)? initial,
    TResult? Function(_SubscriptionSubmittingState value)? submitting,
    TResult? Function(_SubscriptionSubmittedState value)? submitted,
    TResult? Function(_SubscriptionErrorlState value)? error,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SubscriptionInitialState value)? initial,
    TResult Function(_SubscriptionSubmittingState value)? submitting,
    TResult Function(_SubscriptionSubmittedState value)? submitted,
    TResult Function(_SubscriptionErrorlState value)? error,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $SubscriptionStateCopyWith<$Res> {
  factory $SubscriptionStateCopyWith(
          SubscriptionState value, $Res Function(SubscriptionState) then) =
      _$SubscriptionStateCopyWithImpl<$Res, SubscriptionState>;
}

/// @nodoc
class _$SubscriptionStateCopyWithImpl<$Res, $Val extends SubscriptionState>
    implements $SubscriptionStateCopyWith<$Res> {
  _$SubscriptionStateCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;
}

/// @nodoc
abstract class _$$SubscriptionInitialStateImplCopyWith<$Res> {
  factory _$$SubscriptionInitialStateImplCopyWith(
          _$SubscriptionInitialStateImpl value,
          $Res Function(_$SubscriptionInitialStateImpl) then) =
      __$$SubscriptionInitialStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$SubscriptionInitialStateImplCopyWithImpl<$Res>
    extends _$SubscriptionStateCopyWithImpl<$Res,
        _$SubscriptionInitialStateImpl>
    implements _$$SubscriptionInitialStateImplCopyWith<$Res> {
  __$$SubscriptionInitialStateImplCopyWithImpl(
      _$SubscriptionInitialStateImpl _value,
      $Res Function(_$SubscriptionInitialStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$SubscriptionInitialStateImpl implements _SubscriptionInitialState {
  const _$SubscriptionInitialStateImpl();

  @override
  String toString() {
    return 'SubscriptionState.initial()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SubscriptionInitialStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() submitting,
    required TResult Function() submitted,
    required TResult Function(String errorMessage) error,
  }) {
    return initial();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? submitting,
    TResult? Function()? submitted,
    TResult? Function(String errorMessage)? error,
  }) {
    return initial?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? submitting,
    TResult Function()? submitted,
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
    required TResult Function(_SubscriptionInitialState value) initial,
    required TResult Function(_SubscriptionSubmittingState value) submitting,
    required TResult Function(_SubscriptionSubmittedState value) submitted,
    required TResult Function(_SubscriptionErrorlState value) error,
  }) {
    return initial(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SubscriptionInitialState value)? initial,
    TResult? Function(_SubscriptionSubmittingState value)? submitting,
    TResult? Function(_SubscriptionSubmittedState value)? submitted,
    TResult? Function(_SubscriptionErrorlState value)? error,
  }) {
    return initial?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SubscriptionInitialState value)? initial,
    TResult Function(_SubscriptionSubmittingState value)? submitting,
    TResult Function(_SubscriptionSubmittedState value)? submitted,
    TResult Function(_SubscriptionErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (initial != null) {
      return initial(this);
    }
    return orElse();
  }
}

abstract class _SubscriptionInitialState implements SubscriptionState {
  const factory _SubscriptionInitialState() = _$SubscriptionInitialStateImpl;
}

/// @nodoc
abstract class _$$SubscriptionSubmittingStateImplCopyWith<$Res> {
  factory _$$SubscriptionSubmittingStateImplCopyWith(
          _$SubscriptionSubmittingStateImpl value,
          $Res Function(_$SubscriptionSubmittingStateImpl) then) =
      __$$SubscriptionSubmittingStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$SubscriptionSubmittingStateImplCopyWithImpl<$Res>
    extends _$SubscriptionStateCopyWithImpl<$Res,
        _$SubscriptionSubmittingStateImpl>
    implements _$$SubscriptionSubmittingStateImplCopyWith<$Res> {
  __$$SubscriptionSubmittingStateImplCopyWithImpl(
      _$SubscriptionSubmittingStateImpl _value,
      $Res Function(_$SubscriptionSubmittingStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$SubscriptionSubmittingStateImpl
    implements _SubscriptionSubmittingState {
  const _$SubscriptionSubmittingStateImpl();

  @override
  String toString() {
    return 'SubscriptionState.submitting()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SubscriptionSubmittingStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() submitting,
    required TResult Function() submitted,
    required TResult Function(String errorMessage) error,
  }) {
    return submitting();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? submitting,
    TResult? Function()? submitted,
    TResult? Function(String errorMessage)? error,
  }) {
    return submitting?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? submitting,
    TResult Function()? submitted,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (submitting != null) {
      return submitting();
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_SubscriptionInitialState value) initial,
    required TResult Function(_SubscriptionSubmittingState value) submitting,
    required TResult Function(_SubscriptionSubmittedState value) submitted,
    required TResult Function(_SubscriptionErrorlState value) error,
  }) {
    return submitting(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SubscriptionInitialState value)? initial,
    TResult? Function(_SubscriptionSubmittingState value)? submitting,
    TResult? Function(_SubscriptionSubmittedState value)? submitted,
    TResult? Function(_SubscriptionErrorlState value)? error,
  }) {
    return submitting?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SubscriptionInitialState value)? initial,
    TResult Function(_SubscriptionSubmittingState value)? submitting,
    TResult Function(_SubscriptionSubmittedState value)? submitted,
    TResult Function(_SubscriptionErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (submitting != null) {
      return submitting(this);
    }
    return orElse();
  }
}

abstract class _SubscriptionSubmittingState implements SubscriptionState {
  const factory _SubscriptionSubmittingState() =
      _$SubscriptionSubmittingStateImpl;
}

/// @nodoc
abstract class _$$SubscriptionSubmittedStateImplCopyWith<$Res> {
  factory _$$SubscriptionSubmittedStateImplCopyWith(
          _$SubscriptionSubmittedStateImpl value,
          $Res Function(_$SubscriptionSubmittedStateImpl) then) =
      __$$SubscriptionSubmittedStateImplCopyWithImpl<$Res>;
}

/// @nodoc
class __$$SubscriptionSubmittedStateImplCopyWithImpl<$Res>
    extends _$SubscriptionStateCopyWithImpl<$Res,
        _$SubscriptionSubmittedStateImpl>
    implements _$$SubscriptionSubmittedStateImplCopyWith<$Res> {
  __$$SubscriptionSubmittedStateImplCopyWithImpl(
      _$SubscriptionSubmittedStateImpl _value,
      $Res Function(_$SubscriptionSubmittedStateImpl) _then)
      : super(_value, _then);
}

/// @nodoc

class _$SubscriptionSubmittedStateImpl implements _SubscriptionSubmittedState {
  const _$SubscriptionSubmittedStateImpl();

  @override
  String toString() {
    return 'SubscriptionState.submitted()';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SubscriptionSubmittedStateImpl);
  }

  @override
  int get hashCode => runtimeType.hashCode;

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() submitting,
    required TResult Function() submitted,
    required TResult Function(String errorMessage) error,
  }) {
    return submitted();
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? submitting,
    TResult? Function()? submitted,
    TResult? Function(String errorMessage)? error,
  }) {
    return submitted?.call();
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? submitting,
    TResult Function()? submitted,
    TResult Function(String errorMessage)? error,
    required TResult orElse(),
  }) {
    if (submitted != null) {
      return submitted();
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(_SubscriptionInitialState value) initial,
    required TResult Function(_SubscriptionSubmittingState value) submitting,
    required TResult Function(_SubscriptionSubmittedState value) submitted,
    required TResult Function(_SubscriptionErrorlState value) error,
  }) {
    return submitted(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SubscriptionInitialState value)? initial,
    TResult? Function(_SubscriptionSubmittingState value)? submitting,
    TResult? Function(_SubscriptionSubmittedState value)? submitted,
    TResult? Function(_SubscriptionErrorlState value)? error,
  }) {
    return submitted?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SubscriptionInitialState value)? initial,
    TResult Function(_SubscriptionSubmittingState value)? submitting,
    TResult Function(_SubscriptionSubmittedState value)? submitted,
    TResult Function(_SubscriptionErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (submitted != null) {
      return submitted(this);
    }
    return orElse();
  }
}

abstract class _SubscriptionSubmittedState implements SubscriptionState {
  const factory _SubscriptionSubmittedState() =
      _$SubscriptionSubmittedStateImpl;
}

/// @nodoc
abstract class _$$SubscriptionErrorlStateImplCopyWith<$Res> {
  factory _$$SubscriptionErrorlStateImplCopyWith(
          _$SubscriptionErrorlStateImpl value,
          $Res Function(_$SubscriptionErrorlStateImpl) then) =
      __$$SubscriptionErrorlStateImplCopyWithImpl<$Res>;
  @useResult
  $Res call({String errorMessage});
}

/// @nodoc
class __$$SubscriptionErrorlStateImplCopyWithImpl<$Res>
    extends _$SubscriptionStateCopyWithImpl<$Res, _$SubscriptionErrorlStateImpl>
    implements _$$SubscriptionErrorlStateImplCopyWith<$Res> {
  __$$SubscriptionErrorlStateImplCopyWithImpl(
      _$SubscriptionErrorlStateImpl _value,
      $Res Function(_$SubscriptionErrorlStateImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? errorMessage = null,
  }) {
    return _then(_$SubscriptionErrorlStateImpl(
      errorMessage: null == errorMessage
          ? _value.errorMessage
          : errorMessage // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

class _$SubscriptionErrorlStateImpl implements _SubscriptionErrorlState {
  const _$SubscriptionErrorlStateImpl({required this.errorMessage});

  @override
  final String errorMessage;

  @override
  String toString() {
    return 'SubscriptionState.error(errorMessage: $errorMessage)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SubscriptionErrorlStateImpl &&
            (identical(other.errorMessage, errorMessage) ||
                other.errorMessage == errorMessage));
  }

  @override
  int get hashCode => Object.hash(runtimeType, errorMessage);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$SubscriptionErrorlStateImplCopyWith<_$SubscriptionErrorlStateImpl>
      get copyWith => __$$SubscriptionErrorlStateImplCopyWithImpl<
          _$SubscriptionErrorlStateImpl>(this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function() initial,
    required TResult Function() submitting,
    required TResult Function() submitted,
    required TResult Function(String errorMessage) error,
  }) {
    return error(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function()? initial,
    TResult? Function()? submitting,
    TResult? Function()? submitted,
    TResult? Function(String errorMessage)? error,
  }) {
    return error?.call(errorMessage);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function()? initial,
    TResult Function()? submitting,
    TResult Function()? submitted,
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
    required TResult Function(_SubscriptionInitialState value) initial,
    required TResult Function(_SubscriptionSubmittingState value) submitting,
    required TResult Function(_SubscriptionSubmittedState value) submitted,
    required TResult Function(_SubscriptionErrorlState value) error,
  }) {
    return error(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(_SubscriptionInitialState value)? initial,
    TResult? Function(_SubscriptionSubmittingState value)? submitting,
    TResult? Function(_SubscriptionSubmittedState value)? submitted,
    TResult? Function(_SubscriptionErrorlState value)? error,
  }) {
    return error?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(_SubscriptionInitialState value)? initial,
    TResult Function(_SubscriptionSubmittingState value)? submitting,
    TResult Function(_SubscriptionSubmittedState value)? submitted,
    TResult Function(_SubscriptionErrorlState value)? error,
    required TResult orElse(),
  }) {
    if (error != null) {
      return error(this);
    }
    return orElse();
  }
}

abstract class _SubscriptionErrorlState implements SubscriptionState {
  const factory _SubscriptionErrorlState({required final String errorMessage}) =
      _$SubscriptionErrorlStateImpl;

  String get errorMessage;
  @JsonKey(ignore: true)
  _$$SubscriptionErrorlStateImplCopyWith<_$SubscriptionErrorlStateImpl>
      get copyWith => throw _privateConstructorUsedError;
}

/// @nodoc
mixin _$SubscriptionEvent {
  String get id => throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function(String id) subscribe,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function(String id)? subscribe,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function(String id)? subscribe,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(SubcriptionSubscribeEvent value) subscribe,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(SubcriptionSubscribeEvent value)? subscribe,
  }) =>
      throw _privateConstructorUsedError;
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(SubcriptionSubscribeEvent value)? subscribe,
    required TResult orElse(),
  }) =>
      throw _privateConstructorUsedError;

  @JsonKey(ignore: true)
  $SubscriptionEventCopyWith<SubscriptionEvent> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $SubscriptionEventCopyWith<$Res> {
  factory $SubscriptionEventCopyWith(
          SubscriptionEvent value, $Res Function(SubscriptionEvent) then) =
      _$SubscriptionEventCopyWithImpl<$Res, SubscriptionEvent>;
  @useResult
  $Res call({String id});
}

/// @nodoc
class _$SubscriptionEventCopyWithImpl<$Res, $Val extends SubscriptionEvent>
    implements $SubscriptionEventCopyWith<$Res> {
  _$SubscriptionEventCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$SubcriptionSubscribeEventImplCopyWith<$Res>
    implements $SubscriptionEventCopyWith<$Res> {
  factory _$$SubcriptionSubscribeEventImplCopyWith(
          _$SubcriptionSubscribeEventImpl value,
          $Res Function(_$SubcriptionSubscribeEventImpl) then) =
      __$$SubcriptionSubscribeEventImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String id});
}

/// @nodoc
class __$$SubcriptionSubscribeEventImplCopyWithImpl<$Res>
    extends _$SubscriptionEventCopyWithImpl<$Res,
        _$SubcriptionSubscribeEventImpl>
    implements _$$SubcriptionSubscribeEventImplCopyWith<$Res> {
  __$$SubcriptionSubscribeEventImplCopyWithImpl(
      _$SubcriptionSubscribeEventImpl _value,
      $Res Function(_$SubcriptionSubscribeEventImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
  }) {
    return _then(_$SubcriptionSubscribeEventImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

class _$SubcriptionSubscribeEventImpl implements SubcriptionSubscribeEvent {
  const _$SubcriptionSubscribeEventImpl({required this.id});

  @override
  final String id;

  @override
  String toString() {
    return 'SubscriptionEvent.subscribe(id: $id)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SubcriptionSubscribeEventImpl &&
            (identical(other.id, id) || other.id == id));
  }

  @override
  int get hashCode => Object.hash(runtimeType, id);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$SubcriptionSubscribeEventImplCopyWith<_$SubcriptionSubscribeEventImpl>
      get copyWith => __$$SubcriptionSubscribeEventImplCopyWithImpl<
          _$SubcriptionSubscribeEventImpl>(this, _$identity);

  @override
  @optionalTypeArgs
  TResult when<TResult extends Object?>({
    required TResult Function(String id) subscribe,
  }) {
    return subscribe(id);
  }

  @override
  @optionalTypeArgs
  TResult? whenOrNull<TResult extends Object?>({
    TResult? Function(String id)? subscribe,
  }) {
    return subscribe?.call(id);
  }

  @override
  @optionalTypeArgs
  TResult maybeWhen<TResult extends Object?>({
    TResult Function(String id)? subscribe,
    required TResult orElse(),
  }) {
    if (subscribe != null) {
      return subscribe(id);
    }
    return orElse();
  }

  @override
  @optionalTypeArgs
  TResult map<TResult extends Object?>({
    required TResult Function(SubcriptionSubscribeEvent value) subscribe,
  }) {
    return subscribe(this);
  }

  @override
  @optionalTypeArgs
  TResult? mapOrNull<TResult extends Object?>({
    TResult? Function(SubcriptionSubscribeEvent value)? subscribe,
  }) {
    return subscribe?.call(this);
  }

  @override
  @optionalTypeArgs
  TResult maybeMap<TResult extends Object?>({
    TResult Function(SubcriptionSubscribeEvent value)? subscribe,
    required TResult orElse(),
  }) {
    if (subscribe != null) {
      return subscribe(this);
    }
    return orElse();
  }
}

abstract class SubcriptionSubscribeEvent implements SubscriptionEvent {
  const factory SubcriptionSubscribeEvent({required final String id}) =
      _$SubcriptionSubscribeEventImpl;

  @override
  String get id;
  @override
  @JsonKey(ignore: true)
  _$$SubcriptionSubscribeEventImplCopyWith<_$SubcriptionSubscribeEventImpl>
      get copyWith => throw _privateConstructorUsedError;
}
