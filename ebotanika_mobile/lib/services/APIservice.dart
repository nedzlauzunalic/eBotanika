import 'dart:convert';
import 'dart:io';
import 'package:http/http.dart' as http;

class APIService {
  static String? username;
  static String? password;
  static int? korisnikId;
  String route;

  APIService({required this.route});

  static Future<List<dynamic>?> Get(String route, dynamic object) async {
    String queryString = Uri(queryParameters: object).query;
    String baseUrl = "http://10.0.2.2:44363/" + route;

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

  static Future<dynamic> GetById(String route, int id) async {
    String baseUrl = "http://10.0.2.2:44363/" + route + "/" + id.toString();
    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';
    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );

    if (response.statusCode == 200) return json.decode(response.body);
    return null;
  }
}
