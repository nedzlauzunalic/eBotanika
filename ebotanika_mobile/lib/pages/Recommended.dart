import 'dart:convert';
import 'dart:io';
import 'package:http/http.dart' as http;
import 'package:ebotanika_mobile/models/Biljke.dart';
import 'package:flutter/material.dart';
import '../services/APIservice.dart';
import 'NovaRezervacija.dart';

class Recommended extends StatefulWidget {
  var biljkaID = 0;
  Recommended({Key? key, required this.biljkaID}) : super(key: key);

  @override
  State<Recommended> createState() => _RecommendedState();
}

class _RecommendedState extends State<Recommended> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Preporučeno'),
          backgroundColor: Colors.green[900],
        ),
        body: bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder<List?>(
      future: getRecommendedBiljke(widget.biljkaID),
      builder: (BuildContext context, AsyncSnapshot<List?> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: Text('Loading..'));
        } else {
          if (snapshot.hasError) {
            return Center(child: Text('Error:${snapshot.error}'));
          } else {
            return ListView(
              children:
                  snapshot.data!.map((e) => RecommendedWidget(e)).toList(),
            );
          }
        }
      },
    );
  }

  Widget RecommendedWidget(Biljke) {
    return Card(
        child: Center(
            child: Padding(
      padding: const EdgeInsets.all(40),
      child: Column(mainAxisAlignment: MainAxisAlignment.start, children: [
        SizedBox(
            height: 35,
            child: Text(Biljke.naziv,
                style: const TextStyle(
                    fontSize: 23,
                    fontWeight: FontWeight.bold,
                    color: Colors.black))),
        const SizedBox(
          height: 20,
        ),
        SizedBox(
          height: 40,
          child: Text(Biljke.opis,
              style: const TextStyle(fontSize: 15, color: Colors.black)),
        ),
        Image(
          height: 230,
          width: 230,
          image: AssetImage('assets/${Biljke.slika}'),
        ),
        const Text(
          'Cijena',
          style: TextStyle(
              fontSize: 20, fontWeight: FontWeight.bold, color: Colors.black),
        ),
        const SizedBox(
          height: 10,
        ),
        SizedBox(
          height: 35,
          child: Text('${Biljke.cijena} KM',
              style: const TextStyle(fontSize: 15, color: Colors.black)),
        ),
        Padding(
          padding: const EdgeInsets.all(5),
          child: ElevatedButton(
            onPressed: () {
              Navigator.push(
                  context,
                  MaterialPageRoute(
                      builder: (context) => NovaRezervacija(
                          biljkaID: Biljke.biljkeID, cijena: Biljke.cijena)));
            },
            style: ElevatedButton.styleFrom(
                primary: Colors.green[900],
                padding:
                    const EdgeInsets.symmetric(horizontal: 30, vertical: 15)),
            child: const Text('Naruči'),
          ),
        )
      ]),
    )));
  }

  Future<List?> getRecommendedBiljke(int biljkaID) async {
    String? username = APIService.username;
    String? password = APIService.password;
    String baseUrl = "http://10.0.2.2:44363/Biljke/$biljkaID/Recommend";

    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    final response = await http.get(Uri.parse(baseUrl),
        headers: {HttpHeaders.authorizationHeader: basicAuth});

    if (response.statusCode == 200) {
      var res = json.decode(response.body) as List;
      return res.map((i) => Biljke.fromJson(i)).toList();
    }

    return null;
  }
}
