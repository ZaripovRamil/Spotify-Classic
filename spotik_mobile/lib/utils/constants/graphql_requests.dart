import 'package:graphql_flutter/graphql_flutter.dart';

class Queries {
  static QueryOptions albums = QueryOptions(document: gql('''
query {
  getAlbums {
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
'''));

  static QueryOptions album(String id) {
    return QueryOptions(document: gql(r'''
query GetAlbum($albumId: String!) {
  getAlbum(albumId: $albumId) {
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
    type
  }
}
'''), variables: {
      'albumId': id
    });
  }

  static QueryOptions history = QueryOptions(document: gql('''
query {
  getHistory {
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
'''));

  static QueryOptions search(String query) {
    return QueryOptions(document: gql(r'''
query Search($query: String) {
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
        username
      },
      trackCount
    }
  }
}
'''), variables: {
      'query': query
    });
  }
}

class Mutations {
  static MutationOptions login(String username, String password, bool rememberMe) {
    return MutationOptions(document: gql(r'''
mutation Login($username: String!, $password: String!, $rememberMe: Boolean!) {
  login(username: $username, password: $password, rememberMe: $rememberMe) {
    isSuccessful
    token
    resultMessage
  }
}
'''), variables: {
      "username": username,
      "password": password,
      "rememberMe": rememberMe
    });
  }

  static MutationOptions register(String login, String name, String email, String password) {
    return MutationOptions(document: gql(r'''
mutation Register($login: String!, name: String!, $email: String!, $password: String!) {
  register(login: $login, name: $name, email: $email, password: $password) {
    isSuccessful
    userId
    resultMessage
  }
}
'''), variables: {
      "login": login,
      "name": name,
      "email": email,
      "password": password,
    });
  }

  static MutationOptions updateSubscription(String id) {
    return MutationOptions(document: gql(r'''
mutation UpdateSubscription($id: String!) {
  updateSubscription(id: $id) {
    ok
    message
  }
}
'''), variables: {
      "id": id,
    });
  }
}
