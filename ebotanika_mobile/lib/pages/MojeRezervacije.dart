import 'dart:convert';
import 'package:ebotanika_mobile/models/ocjena.dart';
import 'package:ebotanika_mobile/models/rezervacijeList.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../services/APIservice.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';

class MojeRezervacije extends StatefulWidget {
  const MojeRezervacije({Key? key}) : super(key: key);

  @override
  State<MojeRezervacije> createState() => _MojeRezervacijeState();
}

class _MojeRezervacijeState extends State<MojeRezervacije> {
  double? rating;

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
      padding: const EdgeInsets.all(50),
      child: Column(
        mainAxisAlignment: MainAxisAlignment.start,
        children: [
          const Text(
            'Datum rezervacije',
            style: TextStyle(
                fontSize: 20, color: Colors.black, fontWeight: FontWeight.bold),
          ),
          const SizedBox(
            height: 10,
          ),
          SizedBox(
              height: 35,
              child: Text(RezervacijeList.datumRezervacije,
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
            })(), style: const TextStyle(fontSize: 15, color: Colors.black)),
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
                style: const TextStyle(fontSize: 15, color: Colors.black)),
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
            })(), style: const TextStyle(fontSize: 15, color: Colors.black)),
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
                style: const TextStyle(fontSize: 15, color: Colors.black)),
          ),
          RatingBar.builder(
              initialRating: 0,
              minRating: 1,
              direction: Axis.horizontal,
              allowHalfRating: true,
              itemCount: 5,
              itemPadding: const EdgeInsets.symmetric(horizontal: 4.0),
              itemBuilder: (context, _) => const Icon(
                    Icons.star,
                    color: Colors.amber,
                  ),
              updateOnDrag: false,
              onRatingUpdate: (value) async {
                setState(() {
                  rating = value;
                });
                var request = Ocjena(
                    ocjenaUsluge: value,
                    korisnikID: APIService.korisnikId,
                    biljkeID: RezervacijeList.biljkeID);

                var result = await APIService.put("Ocjena",
                    APIService.korisnikId, json.encode(request.toJson()));

                if (result != null) {
                  // ignore: use_build_context_synchronously
                  ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
                    content: SizedBox(
                        height: 20,
                        child: Center(
                            child:
                                Text("Uspješno ste ocijenili rezervaciju."))),
                    backgroundColor: Color.fromARGB(255, 9, 100, 13),
                  ));
                }
              }),
          const SizedBox(height: 25),
          Container(
            width: 40,
            height: 30,
            decoration: const BoxDecoration(
                color: Colors.green, shape: BoxShape.circle),
            alignment: Alignment.center,
            child: Text(
              rating == null ? "0" : rating.toString(),
              style: const TextStyle(color: Colors.white, fontSize: 20),
            ),
          ),
          const Text(
            "Ocjena",
            style: TextStyle(color: Colors.black, fontSize: 20),
          ),
        ],
      ),
    ))));
  }

  Future<List<RezervacijeList>> getRezervacije() async {
    var rez = await APIService.getById('Rezervacije/korisnik', APIService.korisnikId);

    return rez!.map((i) => RezervacijeList.fromJson(i)).toList();
  }
}
