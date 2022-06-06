import 'package:ebotanika_mobile/services/APIService.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../models/biljke.dart';

class Asortiman extends StatefulWidget {
  static const String routeName = "/asortiman";

  const Asortiman({Key? key}) : super(key: key);

  @override
  State<Asortiman> createState() => _AsortimanState();
}

class _AsortimanState extends State<Asortiman> {
  APIService? _apiService = null;
  List<Biljke> data = [];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _apiService = context.read<APIService>();

    print("called initState");
    loadData();
  }

  Future loadData() async {
    var tmpData = await _apiService?.get(null);
    setState(() {
      data = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    print("called build $data");
    return Scaffold(
      body: Center(
          child: Padding(
              padding: const EdgeInsets.all(40),
              child: Column(children: [
                const Image(
                  width: 150,
                  height: 250,
                  image: AssetImage('flower-icon.jpg'),
                ),
                const Text(
                  'Naziv biljke',
                  style: TextStyle(fontSize: 15, fontWeight: FontWeight.normal),
                ),
                const SizedBox(
                  height: 20,
                ),
                TextField(
                    obscureText: true,
                    decoration: InputDecoration(
                        border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(3)),
                        hintText: 'Opis neki')),
              ]))),
    );
  }
}
