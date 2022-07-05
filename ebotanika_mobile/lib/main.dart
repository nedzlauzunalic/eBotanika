import 'package:ebotanika_mobile/pages/Kontakt.dart';
import 'package:ebotanika_mobile/pages/Profil.dart';
import 'package:ebotanika_mobile/pages/Registracije.dart';
import 'package:flutter/material.dart';
import 'package:ebotanika_mobile/pages/Login.dart';
import 'package:ebotanika_mobile/pages/Home.dart';
import 'package:ebotanika_mobile/pages/Asortiman.dart';
import 'package:ebotanika_mobile/pages/NovaRezervacija.dart';
import 'package:ebotanika_mobile/pages/MojeRezervacije.dart';
import 'package:ebotanika_mobile/pages/Placanja.dart';
import 'package:ebotanika_mobile/pages/Dostave.dart';
import 'package:flutter_stripe/flutter_stripe.dart';

void main() {
  Stripe.publishableKey =
      "pk_test_51LHYE2K8DNVb8RyeFzdBFNKMBYmTAZ9uCREIUIs4rLpc4OXMCbnm9qeTlS5kdWBXSUarwOmY11TizRVdLxV1A14W00PA3ysGF3";
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
        '/novaRezervacija': (context) => NovaRezervacija(biljkaID: 0, cijena: 0),
        '/mojeRezervacije': (context) => const MojeRezervacije(),
        '/placanje': (context) => Placanja(cijena: 0),
        '/dostava': (context) => const Dostave(),
        '/kontakt': (context) => const Kontakt(),
        '/registracija': (context) => const Registracije(),
        '/profil': (context) => const Profil()
      },
    );
  }
}
