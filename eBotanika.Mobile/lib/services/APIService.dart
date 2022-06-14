import 'dart:convert';
import 'dart:io';
import 'package:ebotanika_mobile/models/korisnik.dart';
import 'package:http/http.dart' as http;

class APIService {
  static String? username;
  static String? password;
  String route;

  APIService({required this.route});

  //var url = Uri.parse("http://192.168.0.21:44363/Biljke");

  static Future<Korisnik?> login() async {
    //String queryString = Uri(queryParameters: object).query;
    String baseUrl = "http://192.168.0.21:5000/Biljke";

    /* if (object != null) {
      baseUrl = '$baseUrl?$queryString';
    } */

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );

    if (response.statusCode == 200) {
      return Korisnik.fromJson(json.decode(response.body));
    }

    return null;
  }
}
