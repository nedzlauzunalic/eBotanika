import 'package:flutter/material.dart';

class Placanje extends StatefulWidget {
  const Placanje({Key? key}) : super(key: key);

  @override
  _PlacanjeState createState() => _PlacanjeState();
}

void nesto() {}

class _PlacanjeState extends State<Placanje> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
          title: const Text('Način plaćanja'),
          backgroundColor: Colors.green[900],
        ),
        body: Center(
            child: Padding(
                padding: EdgeInsets.all(40),
                child: Column(children: [
                  const SizedBox(
                    height: 35,
                  ),
                  const Text(
                    'Plaćanje',
                    style: TextStyle(fontSize: 30, color: Colors.green),
                  ),
                  const SizedBox(
                    height: 35,
                  ),
                  const Text(
                    'Broj kartice:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  const TextField(
                      obscureText: true,
                      decoration: InputDecoration(hintText: 'Broj kartice')),
                  const SizedBox(
                    height: 35,
                  ),
                  const Text(
                    'SecurityCode:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  const TextField(
                      obscureText: true,
                      decoration: InputDecoration(hintText: 'SecurityCode')),
                  const SizedBox(
                    height: 35,
                  ),
                  const Text(
                    'ExpYear:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  const TextField(
                      obscureText: true,
                      decoration: InputDecoration(hintText: 'ExpYear')),
                  const SizedBox(
                    height: 35,
                  ),
                  const Text(
                    'ExpMonth:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  const TextField(
                      obscureText: true,
                      decoration: InputDecoration(hintText: 'ExpMonth')),
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
                          style: TextStyle(color: Colors.white, fontSize: 20)))
                ]))));
  }
}
