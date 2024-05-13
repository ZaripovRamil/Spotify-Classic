// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'search_res.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

SearchResultDto _$SearchResultDtoFromJson(Map<String, dynamic> json) {
  return _SearchResultDto.fromJson(json);
}

/// @nodoc
mixin _$SearchResultDto {
  bool get isSuccessful => throw _privateConstructorUsedError;
  SearchDto? get data => throw _privateConstructorUsedError;
  String get errorMessage => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $SearchResultDtoCopyWith<SearchResultDto> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $SearchResultDtoCopyWith<$Res> {
  factory $SearchResultDtoCopyWith(
          SearchResultDto value, $Res Function(SearchResultDto) then) =
      _$SearchResultDtoCopyWithImpl<$Res, SearchResultDto>;
  @useResult
  $Res call({bool isSuccessful, SearchDto? data, String errorMessage});

  $SearchDtoCopyWith<$Res>? get data;
}

/// @nodoc
class _$SearchResultDtoCopyWithImpl<$Res, $Val extends SearchResultDto>
    implements $SearchResultDtoCopyWith<$Res> {
  _$SearchResultDtoCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? isSuccessful = null,
    Object? data = freezed,
    Object? errorMessage = null,
  }) {
    return _then(_value.copyWith(
      isSuccessful: null == isSuccessful
          ? _value.isSuccessful
          : isSuccessful // ignore: cast_nullable_to_non_nullable
              as bool,
      data: freezed == data
          ? _value.data
          : data // ignore: cast_nullable_to_non_nullable
              as SearchDto?,
      errorMessage: null == errorMessage
          ? _value.errorMessage
          : errorMessage // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }

  @override
  @pragma('vm:prefer-inline')
  $SearchDtoCopyWith<$Res>? get data {
    if (_value.data == null) {
      return null;
    }

    return $SearchDtoCopyWith<$Res>(_value.data!, (value) {
      return _then(_value.copyWith(data: value) as $Val);
    });
  }
}

/// @nodoc
abstract class _$$SearchResultDtoImplCopyWith<$Res>
    implements $SearchResultDtoCopyWith<$Res> {
  factory _$$SearchResultDtoImplCopyWith(_$SearchResultDtoImpl value,
          $Res Function(_$SearchResultDtoImpl) then) =
      __$$SearchResultDtoImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({bool isSuccessful, SearchDto? data, String errorMessage});

  @override
  $SearchDtoCopyWith<$Res>? get data;
}

/// @nodoc
class __$$SearchResultDtoImplCopyWithImpl<$Res>
    extends _$SearchResultDtoCopyWithImpl<$Res, _$SearchResultDtoImpl>
    implements _$$SearchResultDtoImplCopyWith<$Res> {
  __$$SearchResultDtoImplCopyWithImpl(
      _$SearchResultDtoImpl _value, $Res Function(_$SearchResultDtoImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? isSuccessful = null,
    Object? data = freezed,
    Object? errorMessage = null,
  }) {
    return _then(_$SearchResultDtoImpl(
      isSuccessful: null == isSuccessful
          ? _value.isSuccessful
          : isSuccessful // ignore: cast_nullable_to_non_nullable
              as bool,
      data: freezed == data
          ? _value.data
          : data // ignore: cast_nullable_to_non_nullable
              as SearchDto?,
      errorMessage: null == errorMessage
          ? _value.errorMessage
          : errorMessage // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc

@JsonSerializable(explicitToJson: true)
class _$SearchResultDtoImpl implements _SearchResultDto {
  const _$SearchResultDtoImpl(
      {required this.isSuccessful,
      required this.data,
      required this.errorMessage});

  factory _$SearchResultDtoImpl.fromJson(Map<String, dynamic> json) =>
      _$$SearchResultDtoImplFromJson(json);

  @override
  final bool isSuccessful;
  @override
  final SearchDto? data;
  @override
  final String errorMessage;

  @override
  String toString() {
    return 'SearchResultDto(isSuccessful: $isSuccessful, data: $data, errorMessage: $errorMessage)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SearchResultDtoImpl &&
            (identical(other.isSuccessful, isSuccessful) ||
                other.isSuccessful == isSuccessful) &&
            (identical(other.data, data) || other.data == data) &&
            (identical(other.errorMessage, errorMessage) ||
                other.errorMessage == errorMessage));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode =>
      Object.hash(runtimeType, isSuccessful, data, errorMessage);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$SearchResultDtoImplCopyWith<_$SearchResultDtoImpl> get copyWith =>
      __$$SearchResultDtoImplCopyWithImpl<_$SearchResultDtoImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$SearchResultDtoImplToJson(
      this,
    );
  }
}

abstract class _SearchResultDto implements SearchResultDto {
  const factory _SearchResultDto(
      {required final bool isSuccessful,
      required final SearchDto? data,
      required final String errorMessage}) = _$SearchResultDtoImpl;

  factory _SearchResultDto.fromJson(Map<String, dynamic> json) =
      _$SearchResultDtoImpl.fromJson;

  @override
  bool get isSuccessful;
  @override
  SearchDto? get data;
  @override
  String get errorMessage;
  @override
  @JsonKey(ignore: true)
  _$$SearchResultDtoImplCopyWith<_$SearchResultDtoImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
