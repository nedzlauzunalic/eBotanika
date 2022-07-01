import 'package:ebotanika_mobile/models/rezervacije.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../services/APIservice.dart';

class MojeRezervacije extends StatefulWidget {
  const MojeRezervacije({Key? key}) : super(key: key);

  @override
  State<MojeRezervacije> createState() => _MojeRezervacijeState();
}

class _MojeRezervacijeState extends State<MojeRezervacije> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Moje rezervacije'),
          backgroundColor: Colors.green[900],
        ),
        body: bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder(
      future: getRezervacije(),
      builder: (BuildContext context, AsyncSnapshot<Rezervacije> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: Text('Loading..'));
        } else {
          if (snapshot.hasError) {
            return Center(child: Text('Error:${snapshot.error}'));
          } else {
            return MojeRezervacijeWidget(snapshot.data);
          }
        }
      },
    );
  }

  Widget MojeRezervacijeWidget(Rezervacije) {
    return Scaffold(
        body: Center(
            child: SingleChildScrollView(
                child: Padding(
                    padding: const EdgeInsets.all(70),
                    child: Column(
                        mainAxisAlignment: MainAxisAlignment.start,
                        children: [
                          const Text(
                            'Datum rezervacije',
                            style: TextStyle(fontSize: 20, color: Colors.black),
                          ),
                          const SizedBox(
                            height: 10,
                          ),
                          SizedBox(
                              height: 35,
                              child: Text(
                                  DateFormat('dd.MM.yyyy')
                                      .format(Rezervacije.datumRezervacije)
                                      .toString(),
                                  style: const TextStyle(
                                      fontSize: 15, color: Colors.black))),
                          const Text(
                            'Napomena',
                            style: TextStyle(fontSize: 20, color: Colors.black),
                          ),
                          const SizedBox(
                            height: 10,
                          ),
                          SizedBox(
                            height: 35,
                            child: Text(Rezervacije.napomena,
                                style: const TextStyle(
                                    fontSize: 15, color: Colors.black)),
                          ),
                          const Text(
                            'Količina',
                            style: TextStyle(fontSize: 20, color: Colors.black),
                          ),
                          const SizedBox(
                            height: 10,
                          ),
                          SizedBox(
                            height: 35,
                            child: Text(Rezervacije.kolicina.toString(),
                                style: const TextStyle(
                                    fontSize: 15, color: Colors.black)),
                          ),
                          const Text(
                            'Svrha',
                            style: TextStyle(fontSize: 20, color: Colors.black),
                          ),
                          const SizedBox(
                            height: 10,
                          ),
                          SizedBox(
                            height: 35,
                            child: Text(Rezervacije.svrhaID.toString(),
                                style: const TextStyle(
                                    fontSize: 15, color: Colors.black)),
                          ),
                          const Text(
                            'Adresa dostave',
                            style: TextStyle(fontSize: 20, color: Colors.black),
                          ),
                          const SizedBox(
                            height: 10,
                          ),
                          SizedBox(
                            height: 35,
                            child: Text(Rezervacije.adresaDostave,
                                style: const TextStyle(
                                    fontSize: 15, color: Colors.black)),
                          ),
                        ])))));
  }

  Future<Rezervacije> getRezervacije() async {
    var rezervacije = await APIService.getById('Rezervacije', 2);
    return Rezervacije.fromJson(rezervacije);
  }
}
