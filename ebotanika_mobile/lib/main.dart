import 'package:ebotanika_mobile/pages/Registracija.dart';
import 'package:flutter/material.dart';
import 'package:ebotanika_mobile/pages/Login.dart';
import 'package:ebotanika_mobile/pages/Home.dart';
import 'package:ebotanika_mobile/pages/Asortiman.dart';
import 'package:ebotanika_mobile/pages/NovaRezervacija.dart';
import 'package:ebotanika_mobile/pages/MojeRezervacije.dart';
import 'package:ebotanika_mobile/pages/Placanja.dart';
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
      home: const Login(),
      routes: {
        '/home': (context) => const Home(),
        '/asortiman': (context) => const Asortiman(),
        '/novaRezervacija': (context) => NovaRezervacija(biljkaID: 0),
        '/mojeRezervacije': (context) => const MojeRezervacije(),
        '/placanje': (context) => const Placanja(),
        '/dostava': (context) => const Dostave(),
        '/kontakt': (context) => const Kontakt(),
        '/registracija': (context) => const Registracija()
      },
    );
  }
}
