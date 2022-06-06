import 'package:flutter/material.dart';

class NovaRezervacija extends StatefulWidget {
  const NovaRezervacija({Key? key}) : super(key: key);

  @override
  _NovaRezervacijaState createState() => _NovaRezervacijaState();
}

class _NovaRezervacijaState extends State<NovaRezervacija> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SingleChildScrollView(
            child: Padding(
                padding: const EdgeInsets.all(40),
                child: Column(
                    mainAxisAlignment: MainAxisAlignment.start,
                    children: [
                      const SizedBox(
                        height: 35,
                      ),
                      const Text(
                        'Kreiraj rezervaciju',
                        style: TextStyle(fontSize: 30, color: Colors.green),
                      ),
                      const SizedBox(
                        height: 35,
                      ),
                      const Text(
                        'Datum rezervacije:',
                        style: TextStyle(fontSize: 15, color: Colors.black),
                      ),
                      const TextField(
                          obscureText: true,
                          decoration:
                              InputDecoration(hintText: 'Datum rezervacije')),
                      const SizedBox(
                        height: 35,
                      ),
                      const Text(
                        'Biljka:',
                        style: TextStyle(fontSize: 15, color: Colors.black),
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Biljka')),
                      const SizedBox(
                        height: 35,
                      ),
                      const Text(
                        'Svrha:',
                        style: TextStyle(fontSize: 15, color: Colors.black),
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Svrha')),
                      const SizedBox(
                        height: 35,
                      ),
                      const Text(
                        'Napomena:',
                        style: TextStyle(fontSize: 15, color: Colors.black),
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Napomena')),
                      const SizedBox(
                        height: 35,
                      ),
                      const Text(
                        'Grad:',
                        style: TextStyle(fontSize: 15, color: Colors.black),
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Grad')),
                      const SizedBox(
                        height: 35,
                      ),
                      const Text(
                        'Količina:',
                        style: TextStyle(fontSize: 15, color: Colors.black),
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'Količina')),
                      const SizedBox(
                        height: 35,
                      ),
                      Container(
                          padding: EdgeInsets.all(10),
                          height: 50,
                          width: 250,
                          decoration: BoxDecoration(
                              color: Colors.green[900],
                              borderRadius: BorderRadius.circular(8)),
                          child: const Text('Sačuvaj',
                              textAlign: TextAlign.center,
                              style:
                                  TextStyle(color: Colors.white, fontSize: 20)))
                    ]))));
  }
}
