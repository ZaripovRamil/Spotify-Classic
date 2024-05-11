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
      var res = RegisterDto.fromJson(
          await GqlService.mutate(Mutations.register(login, name, email, password)));
      if (res.userId == null || res.userId!.isEmpty) {
        return const RegisterDto(
            isSuccessful: false,
            userId: null,
            resultMessage: "Try stronger password");
      }

      return res;
    } catch (ex) {
      return const RegisterDto(
        isSuccessful: false,
        userId: null,
        resultMessage: "Something went wrong. Try stronger password or another login"
      );
    }
  }
}
