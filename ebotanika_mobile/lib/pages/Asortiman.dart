import 'package:ebotanika_mobile/models/Biljke.dart';
import 'package:flutter/material.dart';
import '../services/APIservice.dart';
import 'NovaRezervacija.dart';

class Asortiman extends StatefulWidget {
  const Asortiman({Key? key}) : super(key: key);

  @override
  State<Asortiman> createState() => _AsortimanState();
}

class _AsortimanState extends State<Asortiman> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Asortiman biljaka'),
          backgroundColor: Colors.green[900],
        ),
        body: bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder<List<Biljke>>(
      future: getBiljke(),
      builder: (BuildContext context, AsyncSnapshot<List<Biljke>> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: Text('Loading..'));
        } else {
          if (snapshot.hasError) {
            return Center(child: Text('Error:${snapshot.error}'));
          } else {
            return ListView(
              children: snapshot.data!.map((e) => AsortimanWidget(e)).toList(),
            );
          }
        }
      },
    );
  }

  Widget AsortimanWidget(Biljke) {
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
                            rezervacija: Biljke,
                          )));
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

  Future<List<Biljke>> getBiljke() async {
    var biljke = await APIService.get('Biljke', null);
    return biljke!.map((i) => Biljke.fromJson(i)).toList();
  }
}
