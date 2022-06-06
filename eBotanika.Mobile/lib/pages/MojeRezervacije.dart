import 'package:flutter/material.dart';

class MojeRezervacije extends StatefulWidget {
  const MojeRezervacije({Key? key}) : super(key: key);

  @override
  _MojeRezervacijeState createState() => _MojeRezervacijeState();
}

class _MojeRezervacijeState extends State<MojeRezervacije> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Center(
            child: Padding(
                padding: const EdgeInsets.all(40),
                child: Column(children: const [
                  SizedBox(
                    height: 35,
                  ),
                  Text(
                    'Moje rezervacije',
                    style: TextStyle(fontSize: 30, color: Colors.green),
                  ),
                  SizedBox(
                    height: 35,
                  ),
                  Text(
                    'Datum rezervacije:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  TextField(
                      obscureText: true,
                      decoration:
                          InputDecoration(hintText: 'Datum rezervacije')),
                  SizedBox(
                    height: 35,
                  ),
                  Text(
                    'Biljka:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  TextField(
                      obscureText: true,
                      decoration: InputDecoration(hintText: 'Biljka')),
                  SizedBox(
                    height: 35,
                  ),
                  Text(
                    'Svrha:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  TextField(
                      obscureText: true,
                      decoration: InputDecoration(hintText: 'Svrha')),
                  SizedBox(
                    height: 35,
                  ),
                  Text(
                    'Napomena:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  TextField(
                      obscureText: true,
                      decoration: InputDecoration(hintText: 'Napomena')),
                  SizedBox(
                    height: 35,
                  ),
                  Text(
                    'Grad:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  TextField(
                      obscureText: true,
                      decoration: InputDecoration(hintText: 'Grad')),
                  SizedBox(
                    height: 35,
                  ),
                  Text(
                    'Količina:',
                    style: TextStyle(fontSize: 15, color: Colors.black),
                  ),
                  TextField(
                      obscureText: true,
                      decoration: InputDecoration(hintText: 'Količina')),
                  SizedBox(
                    height: 35,
                  )
                ]))));
  }
}
