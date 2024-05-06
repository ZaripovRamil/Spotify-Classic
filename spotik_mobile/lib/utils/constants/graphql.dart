class Queries {
  static String albums = '';
  static String album(String id) {
    return 'id $id';
  }
}

class Mutations {
  static String login(String login, String password) {
    return '$login, $password';
  }
}