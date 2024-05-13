import 'package:jwt_decode/jwt_decode.dart';
import 'package:shared_preferences/shared_preferences.dart';

class Storage {
  static const String _tokenKey = 'auth_token';

  static Future<String> getToken() async {
    return await SharedPreferences.getInstance().then((storage) {
      return storage.getString(_tokenKey) ?? '';
    });
  }

  static Future setToken(String token) async {
    await SharedPreferences.getInstance().then((storage) async {
      await storage.setString(_tokenKey, token);
    });
  }

  static Future<bool> isTokenExpired() async {
    final token = await getToken();
    return token.isEmpty || Jwt.isExpired(token);
  }

  static const String _usernameKey = 'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name';

  static Future<String> getUsername() async {
    final token = await getToken();
    return token.isEmpty ? '' : Jwt.parseJwt(token)[_usernameKey];
  }
}
