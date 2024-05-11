import 'package:spotik_mobile/models/dto/login/login.dart';
import 'package:spotik_mobile/models/dto/register/register.dart';
import 'package:spotik_mobile/services/graphql/client.dart';
import 'package:spotik_mobile/utils/constants/graphql_requests.dart';

class AuthApiProvider {
  Future<LoginDto> login(String email, String password) async {
    try {
      return LoginDto.fromJson(
          await GqlService.mutate(Mutations.login(email, password, true)));
    } catch (ex) {
      return const LoginDto(
          isSuccessful: false,
          token: "",
          resultMessage: "Something went wrong. Please try again");
    }
  }

  Future<RegisterDto> signup(String login, String name, String email, String password) async {
    try {
      return RegisterDto.fromJson(
          await GqlService.mutate(Mutations.register(login, name, email, password)));
    } catch (_) {
      return const RegisterDto(
        isSuccessful: false,
        userId: "",
        resultMessage: "Something went wrong. Try more strong password or another login"
      );
    }
  }
}
