import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  static const String routeName = "/home";

  const Home({Key? key}) : super(key: key);

  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('eBotanika'),
        backgroundColor: Colors.green[900],
      ),
      drawer: Drawer(
        backgroundColor: Colors.green[900],
        child: ListView(
          children: [
            const Padding(padding: EdgeInsets.all(10)),
            const SizedBox(
              height: 30,
            ),
            ListTile(
              title: const Text('Asortiman'),
              textColor: Colors.white,
              onTap: () {
                Navigator.of(context).pushNamed('/asortiman');
              },
            ),
            ListTile(
              title: const Text('Nova rezervacija'),
              textColor: Colors.white,
              onTap: () {
                Navigator.of(context).pushNamed('/novaRezervacija');
              },
            ),
            ListTile(
              title: const Text('Moje rezervacije'),
              textColor: Colors.white,
              onTap: () {
                Navigator.of(context).pushNamed('/mojeRezervacije');
              },
            ),
            ListTile(
              title: const Text('Plaćanje'),
              textColor: Colors.white,
              onTap: () {
                Navigator.of(context).pushNamed('/placanje');
              },
            ),
            ListTile(
              title: const Text('Dostava'),
              textColor: Colors.white,
              onTap: () {
                Navigator.of(context).pushNamed('/dostava');
              },
            ),
            ListTile(
              title: const Text('Kontakt'),
              textColor: Colors.white,
              onTap: () {
                Navigator.of(context).pushNamed('/kontakt');
              },
            )
          ],
        ),
      ),
    );
  }
}
