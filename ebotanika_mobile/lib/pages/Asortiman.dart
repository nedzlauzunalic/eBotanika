import 'package:ebotanika_mobile/models/Biljke.dart';
import 'package:flutter/material.dart';
import '../services/APIservice.dart';

class Asortiman extends StatefulWidget {
  const Asortiman({Key? key}) : super(key: key);

  @override
  State<Asortiman> createState() => _AsortimanState();
}

class _AsortimanState extends State<Asortiman> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body:
            bodyWidget() /* Center(
          child: Padding(
              padding: const EdgeInsets.all(40),
              child: Column(children: [
                const Image(
                  width: 150,
                  height: 250,
                  image: AssetImage('flower-icon.jpg')
                 */
        );
  }

  Widget bodyWidget() {
    return FutureBuilder<List<Biljke>>(
      future: GetBiljke(),
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
        const SizedBox(
          height: 35,
        ),
        const Text(
          'Naziv biljke',
          style: TextStyle(fontSize: 20, color: Colors.black),
        ),
        const SizedBox(
          height: 10,
        ),
        SizedBox(
            height: 35,
            child: Text(Biljke.naziv,
                style: const TextStyle(fontSize: 15, color: Colors.black))),
        const Text(
          'Opis',
          style: TextStyle(fontSize: 20, color: Colors.black),
        ),
        const SizedBox(
          height: 10,
        ),
        SizedBox(
          height: 35,
          child: Text(Biljke.opis,
              style: const TextStyle(fontSize: 15, color: Colors.black)),
        ),
        const Text(
          'Slika',
          style: TextStyle(fontSize: 20, color: Colors.black),
        ),
        const SizedBox(
          height: 10,
        ),
        Image(
          height: 50,
          width: 50,
          image: AssetImage(Biljke.slika),
        ),
        SizedBox(
          height: 35,
          child: Text(Biljke.slika,
              style: const TextStyle(fontSize: 15, color: Colors.black)),
        ),
        const Text(
          'Cijena',
          style: TextStyle(fontSize: 20, color: Colors.black),
        ),
        const SizedBox(
          height: 10,
        ),
        SizedBox(
          height: 35,
          child: Text(Biljke.cijena.toString(),
              style: const TextStyle(fontSize: 15, color: Colors.black)),
        ),
      ]),
    )));
  }

  Future<List<Biljke>> GetBiljke() async {
    var biljke = await APIService.Get('Biljke', null);
    return biljke!.map((i) => Biljke.fromJson(i)).toList();
  }
}
