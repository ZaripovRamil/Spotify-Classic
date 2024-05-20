import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:spotik_mobile/auth_page/services/auth_repository.dart';
import 'package:spotik_mobile/utils/storage.dart';

part 'auth_bloc.freezed.dart';

part 'auth_event.dart';
part 'auth_state.dart';

class AuthBloc extends Bloc<AuthEvent, AuthState> {
  final AuthRepository authRepository;
  AuthBloc({required this.authRepository}) : super(const AuthState.initial()) {
    on<AuthLoginEvent>((event, emit) async {
      emit(const AuthState.submitting());

      var data = await authRepository.login(event.email, event.password);
      if (data.isSuccessful) {
        await Storage.setToken(data.token);
        emit(const AuthState.submitted());
      } else {
        emit(AuthState.error(errorMessage: data.resultMessage));
      }
    });

    on<AuthSignupEvent>((event, emit) async {
      emit(const AuthState.submitting());

      var data = await authRepository.signup(event.login, event.name, event.email, event.password);
      if (!data.isSuccessful) {
        emit(AuthState.error(errorMessage: data.resultMessage));
      }
      
      var loginRes = await authRepository.login(event.login, event.password);
      if (!loginRes.isSuccessful) {
        emit(AuthState.error(errorMessage: data.resultMessage));
      }

      await Storage.setToken(loginRes.token);
      emit(const AuthState.submitted());
    });
  }
}
