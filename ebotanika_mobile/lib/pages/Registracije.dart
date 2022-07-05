import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../models/registracija.dart';
import '../services/APIservice.dart';

class Registracije extends StatefulWidget {
  const Registracije({Key? key}) : super(key: key);

  @override
  _RegistracijeState createState() => _RegistracijeState();
}

class _RegistracijeState extends State<Registracije> {
  TextEditingController imeController = TextEditingController();
  TextEditingController prezimeController = TextEditingController();
  TextEditingController datumRodjenjaController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController telefonController = TextEditingController();
  TextEditingController korisnickoImeController = TextEditingController();
  TextEditingController lozinkaController = TextEditingController();
  TextEditingController lozinkaPotvrdaController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(body: bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder<Registracija>(
      builder: (BuildContext context, AsyncSnapshot<Registracija> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: Text('Loading..'));
        } else {
          if (snapshot.hasError) {
            return Center(child: Text('Error:${snapshot.error}'));
          } else {
            return RegistracijeWidget(snapshot.data);
          }
        }
      },
    );
  }

  Widget RegistracijeWidget(registracija) {
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
            decoration: const InputDecoration(hintText: 'Datum rođenja'),
            readOnly: true,
            onTap: () async {
              DateTime? pickedDate = await showDatePicker(
                  context: context,
                  initialDate: DateTime.now(),
                  firstDate: DateTime(1900),
                  lastDate: DateTime(2101));

              if (pickedDate != null) {
                String formattedDate =
                    DateFormat('yyyy-MM-dd').format(pickedDate);

                setState(() {
                  datumRodjenjaController.text = formattedDate;
                });
              }
            },
          ),
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
              obscureText: true,
              controller: lozinkaController,
              decoration: const InputDecoration(hintText: 'Password')),
          const SizedBox(
            height: 10,
          ),
          TextField(
              obscureText: true,
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
                    var date = datumRodjenjaController.text;
                              DateTime formatedDate =
                                  DateFormat('yyyy-MM-dd').parse(date);
                    var request = Registracija(
                        ime: imeController.text,
                        prezime: prezimeController.text,
                        email: emailController.text,
                        telefon: telefonController.text,
                        datumRodjenja: formatedDate.toString(),
                        korisnickoIme: korisnickoImeController.text,
                        password: lozinkaController.text,
                        passwordPotvrda: lozinkaPotvrdaController.text);

                    var result = await APIService.post(
                        "Korisnik", json.encode(request.toJson()));

                    if (result != null) {
                      setState(() {
                        ScaffoldMessenger.of(context)
                            .showSnackBar(const SnackBar(
                          content: SizedBox(
                              height: 20,
                              child: Center(child: Text("Uspješno poslano."))),
                          backgroundColor: Color.fromARGB(255, 9, 100, 13),
                        ));
                      });
                    }
                  },
                  child: const Text('Sačuvaj',
                      textAlign: TextAlign.center,
                      style: TextStyle(color: Colors.white, fontSize: 16)))),
        ]),
      )),
    );
  }
}
