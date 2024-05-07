import 'package:spotik_mobile/auth_page/services/auth_api_provider.dart';
import 'package:spotik_mobile/models/dto/login/login.dart';
import 'package:spotik_mobile/models/dto/register/register.dart';

class AuthRepository{
  final _authProvider = AuthApiProvider();
  Future<LoginDto> login(String email, String password) => _authProvider.login(email, password);

  Future<RegisterDto> signup(String login, String name, String email, String password) => _authProvider.signup(login, name, email, password);
}