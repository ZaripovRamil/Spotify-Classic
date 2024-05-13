part of 'auth_bloc.dart';

@freezed
class AuthEvent with _$AuthEvent{
  const factory AuthEvent.login({required String email, required String password}) = AuthLoginEvent;
  const factory AuthEvent.signup({required String login,required String name,required String email,required String password}) = AuthSignupEvent;
}