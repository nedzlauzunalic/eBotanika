import 'package:flutter/material.dart';

class Placanje extends StatefulWidget {
  const Placanje({Key? key, required rezervacija}) : super(key: key);

  @override
  _PlacanjeState createState() => _PlacanjeState();
}

class _PlacanjeState extends State<Placanje> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Način plaćanja'),
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
          return PlacanjeWidget(snapshot.data);
        }
      }
    });
  }

  Widget PlacanjeWidget(data) {
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
                              InputDecoration(hintText: 'Broj kartice')),
                      const SizedBox(
                        height: 35,
                      ),
                      const TextField(
                          obscureText: true,
                          decoration:
                              InputDecoration(hintText: 'SecurityCode')),
                      const SizedBox(
                        height: 35,
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'ExpYear')),
                      const SizedBox(
                        height: 35,
                      ),
                      const TextField(
                          obscureText: true,
                          decoration: InputDecoration(hintText: 'ExpMonth')),
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
                              onPressed: () async {},
                              child: const Text('Sačuvaj',
                                  textAlign: TextAlign.center,
                                  style: TextStyle(
                                      color: Colors.white, fontSize: 16)))),
                    ]))));
  }
}
