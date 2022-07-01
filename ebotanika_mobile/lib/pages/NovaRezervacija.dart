import 'package:flutter/material.dart';
import '../models/rezervacije.dart';
import 'Placanje.dart';

class NovaRezervacija extends StatefulWidget {
  const NovaRezervacija({Key? key, required rezervacija}) : super(key: key);

  @override
  _NovaRezervacijaState createState() => _NovaRezervacijaState();
}

class _NovaRezervacijaState extends State<NovaRezervacija> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Kreiraj rezervaciju'),
          backgroundColor: Colors.green[900],
        ),
        body:
            bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder<dynamic>(
        builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
      if (snapshot.connectionState == ConnectionState.waiting) {
        return const Center(child: Text('Loading..'));
      } else {
        if (snapshot.hasError) {
          return Center(child: Text('Error:${snapshot.error}'));
        } else {
          return NovaRezervacijaWidget(snapshot.data);
        }
      }
    });
  }

  Widget NovaRezervacijaWidget(novaRezervacija) {
    return Scaffold(
        body: SingleChildScrollView(
            child: Padding(
                padding: const EdgeInsets.all(70),
                child: Column(
                    mainAxisAlignment: MainAxisAlignment.start,
                    children: [
                      const TextField(
                          obscureText: true,
                          decoration:
                              InputDecoration(hintText: 'Datum rezervacije')),
                      const SizedBox(
                        height: 35,
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Svrha')),
                      const SizedBox(
                        height: 35,
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Napomena')),
                      const SizedBox(
                        height: 35,
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Adresa dostave')),
                      const SizedBox(
                        height: 35,
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Grad')),
                      const SizedBox(
                        height: 35,
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Količina')),
                      const SizedBox(
                        height: 35,
                      ),
                      Container(
                          padding: const EdgeInsets.all(5),
                          height: 50,
                          width: 120,
                          decoration: BoxDecoration(
                              color: Colors.green[900],
                              borderRadius: BorderRadius.circular(8)),
                          child: TextButton(
                              onPressed: () async {
                                Navigator.push(
                  context,
                  MaterialPageRoute(
                      builder: (context) => const Placanje(
                            rezervacija: Rezervacije,
                          )));
                              },
                              child: const Text('Sačuvaj',
                                  textAlign: TextAlign.center,
                                  style: TextStyle(
                                      color: Colors.white, fontSize: 16)))),
                    ]))));
  }
}
