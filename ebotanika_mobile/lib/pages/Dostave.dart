import 'package:flutter/material.dart';
import '../services/APIservice.dart';
import 'package:ebotanika_mobile/models/Dostava.dart';
import 'package:intl/intl.dart';

class Dostave extends StatefulWidget {
  const Dostave({Key? key}) : super(key: key);

  @override
  _DostaveState createState() => _DostaveState();
}

class _DostaveState extends State<Dostave> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
          title: const Text('Dostava'),
          backgroundColor: Colors.green[900],
        ),
        body: bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder<List<Dostava>>(
      future: getDostava(),
      builder: (BuildContext context, AsyncSnapshot<List<Dostava>> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: Text('Loading..'));
        } else {
          if (snapshot.hasError) {
            return Center(child: Text('Error:${snapshot.error}'));
          } else {
            return ListView(
              children:
                  snapshot.data!.map((e) => DostavaWidget(e)).toList(),
            );
          }
        }
      },
    );
  }

  Widget DostavaWidget(Dostava) {
    return Card(
        child: SingleChildScrollView(
            child: Padding(
      padding: const EdgeInsets.all(40),
      child: Column(mainAxisAlignment: MainAxisAlignment.start, children: [       
        const Image(
          width: 95,
          height: 100,
          image: AssetImage('assets/delivery-icon.jpg'),
        ),
        const Text(
          'Vaša dostava',
          style: TextStyle(fontSize: 30, color: Colors.green),
        ),
        const SizedBox(height: 35),
        const Text(
          'Datum i vrijeme slanja narudžbe',
          style: TextStyle(fontSize: 20, color: Colors.black),
        ),
        const SizedBox(
          height: 10,
        ),
        SizedBox(
            height: 35,
            child: Text(Dostava.datumSlanja,
                style: const TextStyle(fontSize: 15, color: Colors.black))),
        const Text(
          'Datum i vrijeme preuzimanja',
          style: TextStyle(fontSize: 20, color: Colors.black),
        ),
        const SizedBox(
          height: 10,
        ),
        SizedBox(
          height: 35,
          child: Text(Dostava.datumPreuzimanja,
              style: const TextStyle(fontSize: 15, color: Colors.black)),
        ),
        const Text(
          'Trenutna lokacija',
          style: TextStyle(fontSize: 20, color: Colors.black),
        ),
        const SizedBox(
          height: 10,
        ),
        SizedBox(
          height: 35,
          child: Text(Dostava.trenutnaLokacija,
              style: const TextStyle(fontSize: 15, color: Colors.black)),
        ),
        const Text(
          'Napomena',
          style: TextStyle(fontSize: 20, color: Colors.black),
        ),
        const SizedBox(
          height: 10,
        ),
        SizedBox(
          height: 35,
          child: Text(Dostava.napomena,
              style: const TextStyle(fontSize: 15, color: Colors.black)),
        ),
      ]),
    )));
  }

  Future<List<Dostava>> getDostava() async {
    var dostave = await APIService.getById('Dostava', APIService.korisnikId);
    return dostave!.map((i) => Dostava.fromJson(i)).toList();
  }
}
