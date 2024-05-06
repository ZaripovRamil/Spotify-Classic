import 'package:shared_preferences/shared_preferences.dart';

class Storage {
  static String tokenKey = 'auth_token';

  static Future<String> getToken() async {
    final storage = await SharedPreferences.getInstance();
    final token = storage.get(tokenKey) as String?;

    if (token != null) {
      return 'Bearer $token';
    }

    return '';
  }

  static Future setToken(String token) async {
    final storage = await SharedPreferences.getInstance();
    storage.setString(tokenKey, token);
  }
}