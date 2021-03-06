import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../models/korisnik.dart';
import '../services/APIservice.dart';

class Profil extends StatefulWidget {
  const Profil({Key? key}) : super(key: key);

  @override
  State<Profil> createState() => _ProfilState();
}

class _ProfilState extends State<Profil> {
  TextEditingController imeController = TextEditingController();
  TextEditingController prezimeController = TextEditingController();
  TextEditingController korisnickoImeController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController telefonController = TextEditingController();
  TextEditingController datumRodjenjaController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Moj profil'),
          backgroundColor: Colors.green[900],
        ),
        body: bodyWidget());
  }

  Widget bodyWidget() {
    Widget ProfilWidget(korisnik) {
      imeController.text = korisnik.ime;
      prezimeController.text = korisnik.prezime;
      korisnickoImeController.text = korisnik.korisnickoIme;
      emailController.text = korisnik.email;
      telefonController.text = korisnik.telefon;
      datumRodjenjaController.text = korisnik.datumRodjenja.toString();
      return Card(
          child: Center(
              child: SingleChildScrollView(
                  child: Padding(
        padding: const EdgeInsets.all(50),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.start,
          children: [
            Form(
                child: Column(
              children: [
                const Text(
                  'Ime',
                  style: TextStyle(fontSize: 20, color: Colors.black),
                ),
                SizedBox(
                  height: 35,
                  child: TextFormField(
                      controller: imeController,
                      style:
                          const TextStyle(fontSize: 15, color: Colors.black)),
                ),
                const SizedBox(
                  height: 10,
                ),
                const Text(
                  'Prezime',
                  style: TextStyle(fontSize: 20, color: Colors.black),
                ),
                SizedBox(
                  height: 35,
                  child: TextFormField(
                      controller: prezimeController,
                      style:
                          const TextStyle(fontSize: 15, color: Colors.black)),
                ),
                const SizedBox(
                  height: 10,
                ),
                const Text(
                  'E-mail',
                  style: TextStyle(fontSize: 20, color: Colors.black),
                ),
                SizedBox(
                  height: 35,
                  child: TextFormField(
                      controller: emailController,
                      style:
                          const TextStyle(fontSize: 15, color: Colors.black)),
                ),
                const SizedBox(
                  height: 10,
                ),
                const Text(
                  'Telefon',
                  style: TextStyle(fontSize: 20, color: Colors.black),
                ),
                SizedBox(
                  height: 35,
                  child: TextFormField(
                      controller: telefonController,
                      style:
                          const TextStyle(fontSize: 15, color: Colors.black)),
                ),
                const SizedBox(
                  height: 10,
                ),
                const Text(
                  'Datum ro??enja',
                  style: TextStyle(fontSize: 20, color: Colors.black),
                ),
                SizedBox(
                    height: 35,
                    child: TextFormField(
                        controller: datumRodjenjaController,
                        style: const TextStyle(
                            fontSize: 15, color: Colors.black))),
                const SizedBox(
                  height: 10,
                ),
                const Text(
                  'Korisni??ko ime',
                  style: TextStyle(fontSize: 20, color: Colors.black),
                ),
                SizedBox(
                  height: 35,
                  child: TextFormField(
                      controller: korisnickoImeController,
                      style:
                          const TextStyle(fontSize: 15, color: Colors.black)),
                ),
                const SizedBox(
                  height: 10,
                ),
                Padding(
                  padding: const EdgeInsets.all(5),
                  child: ElevatedButton(
                    onPressed: () async {
                      var date = datumRodjenjaController.text;
                      DateTime formatedDate =
                          DateFormat('yyyy-MM-dd').parse(date);
                      var request = Korisnik(
                          ime: imeController.text,
                          prezime: prezimeController.text,
                          datumRodjenja: formatedDate,
                          email: emailController.text,
                          telefon: telefonController.text,
                          korisnickoIme: korisnickoImeController.text);

                      var result = await APIService.put("Korisnik",
                          APIService.korisnikId, json.encode(request.toJson()));

                      if (result != null) {
                        setState(() {
                          ScaffoldMessenger.of(context)
                              .showSnackBar(const SnackBar(
                            content: SizedBox(
                                height: 20,
                                child:
                                    Center(child: Text("Uspje??no sa??uvano."))),
                            backgroundColor: Color.fromARGB(255, 9, 100, 13),
                          ));
                        });
                      }
                    },
                    style: ElevatedButton.styleFrom(
                        primary: Colors.green[900],
                        padding: const EdgeInsets.symmetric(
                            horizontal: 20, vertical: 10)),
                    child: const Text('Sa??uvaj'),
                  ),
                )
              ],
            ))
          ],
        ),
      ))));
    }

    return FutureBuilder<Korisnik>(
      future: getPodaci(),
      builder: (BuildContext context, AsyncSnapshot<Korisnik> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: Text('Loading..'));
        } else {
          if (snapshot.hasError) {
            return Center(child: Text('Error:${snapshot.error}'));
          } else {
            return ProfilWidget(snapshot.data);
          }
        }
      },
    );
  }

  Future<Korisnik> getPodaci() async {
    var rez =
        await APIService.getByIdKorisnik('Korisnik', APIService.korisnikId);
    return Korisnik.fromJson(rez);
  }
}
