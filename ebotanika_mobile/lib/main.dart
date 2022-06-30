import 'package:ebotanika_mobile/models/dostava.dart';
import 'package:flutter/material.dart';
//import 'package:ebotanika_mobile/pages/Login.dart';
import 'package:ebotanika_mobile/pages/Home.dart';
import 'package:ebotanika_mobile/pages/Asortiman.dart';
import 'package:ebotanika_mobile/pages/NovaRezervacija.dart';
import 'package:ebotanika_mobile/pages/MojeRezervacije.dart';
import 'package:ebotanika_mobile/pages/Placanje.dart';
import 'package:ebotanika_mobile/pages/Dostave.dart';
import 'package:ebotanika_mobile/pages/Kontakt.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: const Asortiman(),
      routes: {
        '/home': (context) => const Home(),
        '/asortiman': (context) => const Asortiman(),
        '/novaRezervacija': (context) => const NovaRezervacija(),
        '/mojeRezervacije': (context) => const MojeRezervacije(),
        '/placanje': (context) => const Placanje(),
        '/dostava': (context) => const Dostave(),
        '/kontakt': (context) => const Kontakt()
      },
    );
  }
}
