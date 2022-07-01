import 'dart:convert';
import 'package:flutter/material.dart';
import '../models/korisnik.dart';
import '../services/APIservice.dart';

class Registracija extends StatefulWidget {
  const Registracija({Key? key}) : super(key: key);

  @override
  _RegistracijaState createState() => _RegistracijaState();
}

class _RegistracijaState extends State<Registracija> {
  TextEditingController imeController = TextEditingController();
  TextEditingController prezimeController = TextEditingController();
  TextEditingController datumRodjenjaController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController telefonController = TextEditingController();
  TextEditingController korisnickoImeController = TextEditingController();
  TextEditingController lozinkaController = TextEditingController();
  TextEditingController lozinkaPotvrdaController = TextEditingController();

  bool visible = false;

  @override
  Widget build(BuildContext context) {
    return Scaffold(body: bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder<Korisnik>(
      builder: (BuildContext context, AsyncSnapshot<Korisnik> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: Text('Loading..'));
        } else {
          if (snapshot.hasError) {
            return Center(child: Text('Error:${snapshot.error}'));
          } else {
            return RegistracijaWidget(snapshot.data);
          }
        }
      },
    );
  }

  Widget RegistracijaWidget(korisnik) {
    return Scaffold(
      body: SingleChildScrollView(
          child: Padding(
        padding: const EdgeInsets.all(70),
        child: Column(mainAxisAlignment: MainAxisAlignment.start, children: [
          const Text(
            'Registracija',
            style: TextStyle(fontSize: 30, color: Colors.black),
          ),
          const SizedBox(height: 50),
          TextField(
              controller: imeController,
              decoration: const InputDecoration(hintText: 'Ime')),
          const SizedBox(
            height: 10,
          ),
          TextField(
              controller: prezimeController,
              decoration: const InputDecoration(hintText: 'Prezime')),
          const SizedBox(
            height: 10,
          ),
          TextField(
              controller: datumRodjenjaController,
              decoration: const InputDecoration(hintText: 'Datum rođenja')),
          const SizedBox(
            height: 10,
          ),
          TextField(
              controller: emailController,
              decoration: const InputDecoration(hintText: 'E-mail')),
          const SizedBox(
            height: 10,
          ),
          TextField(
              controller: telefonController,
              decoration: const InputDecoration(hintText: 'Telefon')),
          const SizedBox(
            height: 10,
          ),
          TextField(
              controller: korisnickoImeController,
              decoration: const InputDecoration(hintText: 'Korisničko ime')),
          const SizedBox(
            height: 10,
          ),
          TextField(
              controller: lozinkaController,
              decoration: const InputDecoration(hintText: 'Password')),
          const SizedBox(
            height: 10,
          ),
          TextField(
              controller: lozinkaPotvrdaController,
              decoration: const InputDecoration(hintText: 'Password potvrda')),
          const SizedBox(
            height: 10,
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
                    var request = korisnik(
                        Ime: imeController.text,
                        Prezime: prezimeController.text,
                        DatumRodjenja: datumRodjenjaController.text,
                        Email: emailController.text,
                        Telefon: telefonController.text,
                        KorisnickoIme: korisnickoImeController.text,
                        Lozinka: lozinkaController.text,
                        LozinkaPotvrda: lozinkaPotvrdaController.text);

                    await APIService.post(
                        "Korisnik", json.encode(request.toJson()));

                    ScaffoldMessenger.of(context).showSnackBar(
                      SnackBar(
                        behavior: SnackBarBehavior.floating,
                        backgroundColor: Colors.transparent,
                        elevation: 0,
                        content: Container(
                          padding: const EdgeInsets.all(16),
                          height: 50,
                          decoration: const BoxDecoration(
                            color: Colors.blue,
                            borderRadius: BorderRadius.all(Radius.circular(20)),
                          ),
                          child: const Text("Podaci su uspješno sačuvani."),
                        ),
                      ),
                    );
                  },
                  child: const Text('Sačuvaj',
                      textAlign: TextAlign.center,
                      style: TextStyle(color: Colors.white, fontSize: 16)))),
        ]),
      )),
    );
  }

  Future insertNoviKorisnik() async {
    setState(() {
      visible = true;
    });

    String ime = imeController.text;
    String prezime = prezimeController.text;
    String datumRodjenja = datumRodjenjaController.text;
    String email = emailController.text;
    String telefon = telefonController.text;
    String korisnickoIme = korisnickoImeController.text;
    String lozinka = lozinkaController.text;
    String lozinkaPotvrda = lozinkaPotvrdaController.text;

    //var res = await APIService.post('Korisnik', body:{}, TextEditingController: TextEditingController)
  }
}
