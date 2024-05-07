part of 'auth_bloc.dart';

@freezed
class AuthState with _$AuthState{
  const factory AuthState.initial() = _AuthInitialState;
  const factory AuthState.submitting() = _AuthLoadingState;
  const factory AuthState.submitted() = _AuthLoadedState;
  const factory AuthState.error({required String errorMessage}) = _AuthErrorlState;
}