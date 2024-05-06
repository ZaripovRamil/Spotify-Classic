// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'register.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

RegisterDto _$RegisterDtoFromJson(Map<String, dynamic> json) {
  return _RegisterDto.fromJson(json);
}

/// @nodoc
mixin _$RegisterDto {
  bool get isSuccessful => throw _privateConstructorUsedError;
  String? get userId => throw _privateConstructorUsedError;
  String get resultMessage => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $RegisterDtoCopyWith<RegisterDto> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $RegisterDtoCopyWith<$Res> {
  factory $RegisterDtoCopyWith(
          RegisterDto value, $Res Function(RegisterDto) then) =
      _$RegisterDtoCopyWithImpl<$Res, RegisterDto>;
  @useResult
  $Res call({bool isSuccessful, String? userId, String resultMessage});
}

/// @nodoc
class _$RegisterDtoCopyWithImpl<$Res, $Val extends RegisterDto>
    implements $RegisterDtoCopyWith<$Res> {
  _$RegisterDtoCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? isSuccessful = null,
    Object? userId = freezed,
    Object? resultMessage = null,
  }) {
    return _then(_value.copyWith(
      isSuccessful: null == isSuccessful
          ? _value.isSuccessful
          : isSuccessful // ignore: cast_nullable_to_non_nullable
              as bool,
      userId: freezed == userId
          ? _value.userId
          : userId // ignore: cast_nullable_to_non_nullable
              as String?,
      resultMessage: null == resultMessage
          ? _value.resultMessage
          : resultMessage // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$RegisterDtoImplCopyWith<$Res>
    implements $RegisterDtoCopyWith<$Res> {
  factory _$$RegisterDtoImplCopyWith(
          _$RegisterDtoImpl value, $Res Function(_$RegisterDtoImpl) then) =
      __$$RegisterDtoImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({bool isSuccessful, String? userId, String resultMessage});
}

/// @nodoc
class __$$RegisterDtoImplCopyWithImpl<$Res>
    extends _$RegisterDtoCopyWithImpl<$Res, _$RegisterDtoImpl>
    implements _$$RegisterDtoImplCopyWith<$Res> {
  __$$RegisterDtoImplCopyWithImpl(
      _$RegisterDtoImpl _value, $Res Function(_$RegisterDtoImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? isSuccessful = null,
    Object? userId = freezed,
    Object? resultMessage = null,
  }) {
    return _then(_$RegisterDtoImpl(
      isSuccessful: null == isSuccessful
          ? _value.isSuccessful
          : isSuccessful // ignore: cast_nullable_to_non_nullable
              as bool,
      userId: freezed == userId
          ? _value.userId
          : userId // ignore: cast_nullable_to_non_nullable
              as String?,
      resultMessage: null == resultMessage
          ? _value.resultMessage
          : resultMessage // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$RegisterDtoImpl implements _RegisterDto {
  const _$RegisterDtoImpl(
      {required this.isSuccessful,
      required this.userId,
      required this.resultMessage});

  factory _$RegisterDtoImpl.fromJson(Map<String, dynamic> json) =>
      _$$RegisterDtoImplFromJson(json);

  @override
  final bool isSuccessful;
  @override
  final String? userId;
  @override
  final String resultMessage;

  @override
  String toString() {
    return 'RegisterDto(isSuccessful: $isSuccessful, userId: $userId, resultMessage: $resultMessage)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$RegisterDtoImpl &&
            (identical(other.isSuccessful, isSuccessful) ||
                other.isSuccessful == isSuccessful) &&
            (identical(other.userId, userId) || other.userId == userId) &&
            (identical(other.resultMessage, resultMessage) ||
                other.resultMessage == resultMessage));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode =>
      Object.hash(runtimeType, isSuccessful, userId, resultMessage);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$RegisterDtoImplCopyWith<_$RegisterDtoImpl> get copyWith =>
      __$$RegisterDtoImplCopyWithImpl<_$RegisterDtoImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$RegisterDtoImplToJson(
      this,
    );
  }
}

abstract class _RegisterDto implements RegisterDto {
  const factory _RegisterDto(
      {required final bool isSuccessful,
      required final String? userId,
      required final String resultMessage}) = _$RegisterDtoImpl;

  factory _RegisterDto.fromJson(Map<String, dynamic> json) =
      _$RegisterDtoImpl.fromJson;

  @override
  bool get isSuccessful;
  @override
  String? get userId;
  @override
  String get resultMessage;
  @override
  @JsonKey(ignore: true)
  _$$RegisterDtoImplCopyWith<_$RegisterDtoImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
