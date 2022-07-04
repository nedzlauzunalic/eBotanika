import 'package:ebotanika_mobile/models/rezervacijeList.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../services/APIservice.dart';

class MojeRezervacije extends StatefulWidget {
  const MojeRezervacije({Key? key}) : super(key: key);

  @override
  State<MojeRezervacije> createState() => _MojeRezervacijeState();
}

class _MojeRezervacijeState extends State<MojeRezervacije> {
  var ocjena = 0.0;

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
    return FutureBuilder<List<RezervacijeList>>(
      future: getRezervacije(),
      builder: (BuildContext context,
          AsyncSnapshot<List<RezervacijeList>> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: Text('Loading..'));
        } else {
          if (snapshot.hasError) {
            return Center(child: Text('Error:${snapshot.error}'));
          } else {
            return ListView(
              children:
                  snapshot.data!.map((e) => MojeRezervacijeWidget(e)).toList(),
            );
          }
        }
      },
    );
  }

  Widget MojeRezervacijeWidget(RezervacijeList) {
    return Card(
        child: Center(
            child: SingleChildScrollView(
                child: Padding(
                    padding: const EdgeInsets.all(70),
                    child: Column(
                        mainAxisAlignment: MainAxisAlignment.start,
                        children: [
                          const Text(
                            'Datum rezervacije',
                            style: TextStyle(
                                fontSize: 20,
                                color: Colors.black,
                                fontWeight: FontWeight.bold),
                          ),
                          const SizedBox(
                            height: 10,
                          ),
                          SizedBox(
                              height: 35,
                              child: Text(
                                  DateFormat('dd.MM.yyyy')
                                      .format(RezervacijeList.datumRezervacije)
                                      .toString(),
                                  style: const TextStyle(
                                      fontSize: 15,
                                      color: Colors.black,
                                      fontWeight: FontWeight.bold))),
                          const Text(
                            'Napomena',
                            style: TextStyle(fontSize: 20, color: Colors.black),
                          ),
                          const SizedBox(
                            height: 10,
                          ),
                          SizedBox(
                            height: 35,
                            child: Text((() {
                              if (RezervacijeList.napomena == "") {
                                return "/";
                              }
                              return RezervacijeList.napomena;
                            })(),
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
                            child: Text(RezervacijeList.kolicina,
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
                            child: Text((() {
                              if (RezervacijeList.svrhaID == 1) {
                                return "Kupovina";
                              } else if (RezervacijeList.svrhaID == 2) {
                                return "Uređivanje vrtova/parkova";
                              }
                              return "Aranžman";
                            })(),
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
                            child: Text(RezervacijeList.adresaDostave,
                                style: const TextStyle(
                                    fontSize: 15, color: Colors.black)),
                          ),
                        ])))));
  }

  Future<List<RezervacijeList>> getRezervacije() async {
    var rez = await APIService.getById('Rezervacije', APIService.korisnikId);
    return rez!.map((i) => RezervacijeList.fromJson(i)).toList();
  }
}
