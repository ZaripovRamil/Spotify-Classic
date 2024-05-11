// import 'package:flutter_bloc/flutter_bloc.dart';
// import 'package:freezed_annotation/freezed_annotation.dart';
// import 'package:spotik_mobile/utils/storage.dart';
//
// part 'album_bloc.freezed.dart';
//
// part 'album_event.dart';
// part 'album_state.dart';
//
// class AuthBloc extends Bloc<AuthEvent, AuthState> {
//   final AuthRepository authRepository;
//   AuthBloc({required this.authRepository}) : super(const AuthState.initial()) {
//     on<AuthLoginEvent>((event, emit) async {
//       emit(const AuthState.submitting());
//
//       var data = await authRepository.login(event.email, event.password);
//       if (data.isSuccessful) {
//         await Storage.setToken(data.token);
//         emit(const AuthState.submitted());
//       } else {
//         emit(AuthState.error(errorMessage: data.resultMessage));
//       }
//     });
//
//     on<AuthSignupEvent>((event, emit) async {
//       emit(const AuthState.submitting());
//
//       var data = await authRepository.signup(event.login, event.name, event.email, event.password);
//       if (data.isSuccessful) {
//         emit(const AuthState.submitted());
//       } else {
//         emit(AuthState.error(errorMessage: data.resultMessage));
//       }
//     });
//   }
// }
