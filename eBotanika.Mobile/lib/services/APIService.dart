import 'dart:convert';
import 'package:flutter/material.dart';
import 'dart:io';
import 'package:http/io_client.dart';
import '../models/biljke.dart';

class APIService with ChangeNotifier {
  HttpClient client = HttpClient();
  IOClient? http;

  APIService() {
    print("called APIService");
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }

  Future<List<Biljke>> get(dynamic searchObject) async {
    print("called APIService.GET METHOD");
    var url = Uri.parse("http://192.168.0.21:44363/Biljke");

    String username = "desktop";
    String password = "test";

    String basicAuth =
        "Basic ${base64Encode(utf8.encode('$username:$password'))}";

    var headers = {
      "Content-Type": "application/json",
      "Authorization": basicAuth
    };

    var response = await http!.get(url, headers: headers);

    if (response.statusCode < 400) {
      var data = jsonDecode(response.body);
      List<Biljke> list =
          data.map((x) => Biljke.fromJson(x)).cast<Biljke>().toList();
      return list;
    } else {
      throw Exception("User not allowed");
    }
  }
}
