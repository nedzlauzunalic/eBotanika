import 'dart:convert';
import 'dart:io';
import 'package:http/http.dart' as http;

class APIService {
  static String? username;
  static String? password;
  static int? korisnikId;
  String route;

  APIService({required this.route});

  void setParameter(String username, String password) {
    username = username;
    password = password;
  }

  static Future<dynamic> login() async {
    String baseUrl = "http://10.0.2.2:44363/Korisnik";

    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    final response = await http.get(Uri.parse(baseUrl),
        headers: {HttpHeaders.authorizationHeader: basicAuth});

    if (response.statusCode == 200) {
      var lista = json.decode(response.body) as List;
      for(var item in lista)
      {
        if(item["korisnickoIme"] == username)
        {
         korisnikId = item["korisnikID"];
         return korisnikId;
        }       
      }
    }

    return null;
  }

  static Future<List<dynamic>?> get(String route, dynamic object) async {
    String queryString = Uri(queryParameters: object).query;
    String baseUrl = "http://10.0.2.2:44363/$route";

    if (object != null) {
      baseUrl = '$baseUrl?$queryString';
    }

    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    final response = await http.get(Uri.parse(baseUrl),
        headers: {HttpHeaders.authorizationHeader: basicAuth});

    if (response.statusCode == 200) {
      return json.decode(response.body) as List;
    }

    return null;
  }

  static Future<dynamic> getById(String route, int id) async {
    String baseUrl = "http://10.0.2.2:44363/$route/$id";

    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );

    if (response.statusCode == 200) return json.decode(response.body);

    return null;
  }

  static Future<dynamic> post(String route, String body) async {
    String baseUrl = "http://10.0.2.2:44363/$route";

    final response = await http.post(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
      },
      body: body,
    );

    if (response.statusCode == 200) { return json.decode(response.body); }

    return null;
  }
}
