import 'package:graphql_flutter/graphql_flutter.dart';

class Queries {
  static CustomQueryOptions albums = CustomQueryOptions(QueryOptions(document: gql('''
query {
  albums {
    albums {
      id,
      previewId,
      name,
      author {
        id,
        name
      }
    }
  }
}
''')), 'albums');

  static CustomQueryOptions album(String id) {
    return CustomQueryOptions(QueryOptions(document: gql(r'''
query GetAlbum($albumId: String!) {
  album(id: $albumId) {
    id,
    previewId,
    name,
    author {
      id,
      name
    },
    tracks {
      id,
      fileId,
      name,
      album {
        id,
        previewId,
        name,
        author {
          id,
          name
        }
      }
    },
    listenCounts {
      key,
      value
    },
    type
  }
}
'''), variables: {
      'albumId': id
    }), 'album');
  }

  static CustomQueryOptions history = CustomQueryOptions(QueryOptions(document: gql('''
query {
  history {
    history {
      id,
      fileId,
      name,
      album {
        id,
        previewId,
        name,
        author {
          id,
          name
        }
      }
    }
  }
}
''')), 'history');

  static CustomQueryOptions search(String query) {
    return CustomQueryOptions(QueryOptions(document: gql(r'''
query Search($query: String!) {
  search(query: $query) {
    tracks {
      id,
      fileId,
      name,
      album {
        id,
        previewId,
        name,
        author {
          id,
          name
        }
      }
    },
    albums {
      id,
      previewId,
      name,
      author {
        id,
        name
      }
    }
    authors {
      id,
      name
    },
    playlists {
      id,
      previewId,
      name,
      owner {
        id,
        profilePicId,
        name,
        userName
      },
      trackCount
    }
  }
}
'''), variables: {
      'query': query
    }), 'search');
  }
}

class Mutations {
  static CustomMutationOptions login(String username, String password, bool rememberMe) {
    return CustomMutationOptions(MutationOptions(document: gql(r'''
mutation Login($loginData: LoginDataInput!) {
  login(loginData: $loginData) {
    isSuccessful
    token
    resultMessage
  }
}
'''), variables: {
      "loginData": {
        "username": username,
        "password": password,
        "rememberMe": rememberMe
      }
    }), 'login');
  }

  static CustomMutationOptions register(String login, String name, String email, String password) {
    return CustomMutationOptions(MutationOptions(document: gql(r'''
mutation Register($registerData: RegistrationDataInput!) {
  register(registrationData: $registerData) {
    isSuccessful
    userId
    resultMessage
  }
}
'''), variables: {
      "registerData": {
        "login": login,
        "name": name,
        "email": email,
        "password": password,
      }
    }), 'register');
  }

  static CustomMutationOptions updateSubscription(String id) {
    return CustomMutationOptions(MutationOptions(document: gql(r'''
mutation UpdateSubscription($id: String!) {
  updateSubscription(id: $id) {
    ok
    message
  }
}
'''), variables: {
      "id": id,
    }), 'updateSubscription');
  }
}

class CustomMutationOptions {
  MutationOptions options;
  String resultParam;

  CustomMutationOptions(this.options, this.resultParam);
}

class CustomQueryOptions {
  QueryOptions options;
  String resultParam;

  CustomQueryOptions(this.options, this.resultParam);
}
