import 'dart:convert';
import 'package:ebotanika_mobile/models/svrha.dart';
import 'package:ebotanika_mobile/pages/Placanja.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../models/gradovi.dart';
import '../models/rezervacije.dart';
import '../services/APIservice.dart';
// ignore: depend_on_referenced_packages


import 'Recommended.dart';

// ignore: must_be_immutable
class NovaRezervacija extends StatefulWidget {
  var biljkaID = 0;
  double cijena = 0;
  NovaRezervacija({Key? key, required this.biljkaID, required this.cijena}) : super(key: key);

  @override
  // ignore: library_private_types_in_public_api
  _NovaRezervacijaState createState() => _NovaRezervacijaState();
}

class _NovaRezervacijaState extends State<NovaRezervacija> {
  TextEditingController datumRezervacijeController = TextEditingController();
  TextEditingController napomenaController = TextEditingController();
  TextEditingController adresaDostaveController = TextEditingController();
  TextEditingController kolicinaController = TextEditingController();

  List<DropdownMenuItem> items = [];
  Svrha? _selectedSvrha;
  List<DropdownMenuItem<Gradovi>> gradovi = [];
  Gradovi? _selectedGrad;
  int? biljkeID;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Kreiraj rezervaciju'),
          backgroundColor: Colors.green[900],
        ),
        body: bodyWidget());
  }

  Widget bodyWidget() {
    return FutureBuilder<dynamic>(
        builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
      if (snapshot.connectionState == ConnectionState.waiting) {
        return const Center(child: Text('Loading..'));
      } else {
        if (snapshot.hasError) {
          return Center(child: Text('Error:${snapshot.error}'));
        } else {
          return NovaRezervacijaWidget(snapshot.data);
        }
      }
    });
  }

  Widget dropDownSvrhaWidget() {
    return FutureBuilder<List<Svrha>>(
        future: getSvrha(_selectedSvrha),
        builder: (BuildContext context, AsyncSnapshot<List<Svrha>> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(child: Text('Loading..'));
          } else {
            if (snapshot.hasError) {
              return Center(child: Text('Error:${snapshot.error}'));
            } else {
              return Padding(
                padding: const EdgeInsets.fromLTRB(0, 10, 5, 0),
                child: DropdownButton<dynamic>(
                  hint: const Text('Odaberite svrhu'),
                  isExpanded: true,
                  items: items,
                  onChanged: (newVal) {
                    setState(() {
                      _selectedSvrha = newVal;
                    });
                  },
                  value: _selectedSvrha,
                ),
              );
            }
          }
        });
  }

  Widget dropDownGradoviWidget() {
    return FutureBuilder<List<Gradovi>>(
        future: getGradovi(_selectedGrad),
        builder: (BuildContext context, AsyncSnapshot<List<Gradovi>> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(child: Text('Loading..'));
          } else {
            if (snapshot.hasError) {
              return Center(child: Text('Error:${snapshot.error}'));
            } else {
              return Padding(
                padding: const EdgeInsets.fromLTRB(0, 10, 5, 0),
                child: DropdownButton<dynamic>(
                  hint: const Text('Odaberite grad'),
                  isExpanded: true,
                  items: gradovi,
                  onChanged: (newValue) {
                    setState(() {
                      _selectedGrad = newValue;
                    });
                  },
                  value: _selectedGrad,
                ),
              );
            }
          }
        });
  }

  Widget NovaRezervacijaWidget(biljka) {
    return Scaffold(
        body: SingleChildScrollView(
            child: Padding(
                padding: const EdgeInsets.all(30),
                child: Column(
                    mainAxisAlignment: MainAxisAlignment.start,
                    children: [
                      Padding(
                        padding: const EdgeInsets.all(5),
                        child: ElevatedButton(
                          onPressed: () {
                            Navigator.push(
                                context,
                                MaterialPageRoute(
                                    builder: (context) => Recommended(
                                          biljkaID: widget.biljkaID
                                        )));
                          },
                          style: ElevatedButton.styleFrom(
                              primary: Colors.green[900],
                              padding: const EdgeInsets.symmetric(
                                  horizontal: 20, vertical: 5)),
                          child: const Text('Pogledaj preporu??eno...'),
                        ),
                      ),
                      const SizedBox(
                        height: 35,
                      ),
                      TextField(
                        controller: datumRezervacijeController,
                        decoration: const InputDecoration(
                            hintText: 'Datum rezervacije'),
                        readOnly: true,
                        onTap: () async {
                          DateTime? pickedDate = await showDatePicker(
                              context: context,
                              initialDate: DateTime.now(),
                              firstDate: DateTime.now(),
                              lastDate: DateTime(2101));

                          if (pickedDate != null) {
                            String formattedDate =
                                DateFormat('yyyy-MM-dd').format(pickedDate);

                            setState(() {
                              datumRezervacijeController.text = formattedDate;
                            });
                          }
                        },
                      ),
                      const SizedBox(
                        height: 35,
                      ),
                      Center(child: dropDownSvrhaWidget()),
                      const SizedBox(
                        height: 35,
                      ),
                      TextField(
                          controller: napomenaController,
                          decoration:
                              const InputDecoration(hintText: 'Napomena')),
                      const SizedBox(
                        height: 35,
                      ),
                      TextField(
                          controller: adresaDostaveController,
                          decoration: const InputDecoration(
                              hintText: 'Adresa dostave')),
                      const SizedBox(
                        height: 35,
                      ),
                      Center(child: dropDownGradoviWidget()),
                      const SizedBox(
                        height: 35,
                      ),
                      TextField(
                          controller: kolicinaController,
                          decoration:
                              const InputDecoration(hintText: 'Koli??ina')),
                      const SizedBox(
                        height: 35,
                      ),
                      Container(
                        padding: const EdgeInsets.all(5),
                        height: 45,
                        width: 120,
                        decoration: BoxDecoration(
                            color: Colors.green[900],
                            borderRadius: BorderRadius.circular(8)),
                        child: TextButton(
                          onPressed: () async {
                            var date = datumRezervacijeController.text;
                            DateTime formatedDate =
                                DateFormat('yyyy-MM-dd').parse(date);
                            var svrhaID = _selectedSvrha!.svrhaID;
                            var gradID = _selectedGrad!.gradID;
                            var rezervacija = Rezervacije(
                                KorisnikID: APIService.korisnikId,
                                GradID: gradID,
                                DatumRezervacije: formatedDate.toString(),
                                Napomena: napomenaController.text,
                                SvrhaID: svrhaID.toString(),
                                AdresaDostave: adresaDostaveController.text,
                                Kolicina: kolicinaController.text,
                                BiljkeID: widget.biljkaID);

                            var result = await APIService.post("Rezervacije",
                                json.encode(rezervacija.toJson()));

                            if (result != null) {
                              setState(() {
                                ScaffoldMessenger.of(context)
                                    .showSnackBar(const SnackBar(
                                  content: SizedBox(
                                      height: 20,
                                      child: Center(
                                          child: Text("Uspje??no poslano."))),
                                  backgroundColor:
                                      Color.fromARGB(255, 9, 100, 13),
                                ));
                              });
                            }
                          },
                          child: const Text('Sa??uvaj',
                              textAlign: TextAlign.center,
                              style:
                                  TextStyle(color: Colors.white, fontSize: 16)),
                        ),
                      ),
                      Padding(
                        padding: const EdgeInsets.all(5),
                        child: ElevatedButton(
                          onPressed: () {
                            Navigator.push(
                                context,
                                MaterialPageRoute(
                                    builder: (context) => Placanja(
                                          cijena: widget.cijena
                                        )));
                          },
                          style: ElevatedButton.styleFrom(
                              primary: Colors.green[900],
                              padding: const EdgeInsets.symmetric(
                                  horizontal: 20, vertical: 10)),
                          child: const Text('Defini??i pla??anje'),
                        ),
                      )
                    ]))));
  }

  Future<List<Svrha>> getSvrha(Svrha? selectedItem) async {
    var svrha = await APIService.get('Svrha', null);
    var svrhaLista = svrha?.map((i) => Svrha.fromJson(i)).toList();

    items = svrhaLista!.map((item) {
      return DropdownMenuItem<Svrha>(
        value: item,
        child: Text(item.naziv),
      );
    }).toList();

    if (selectedItem != null && selectedItem.svrhaID != 0) {
      _selectedSvrha = svrhaLista
          .where((element) => element.svrhaID == selectedItem.svrhaID)
          .first;
    }

    return svrhaLista;
  }

  Future<List<Gradovi>> getGradovi(Gradovi? selectedGrad) async {
    var grad = await APIService.get('Gradovi', null);
    var gradoviLista = grad?.map((i) => Gradovi.fromJson(i)).toList();

    gradovi = gradoviLista!.map((item) {
      return DropdownMenuItem<Gradovi>(
        value: item,
        child: Text(item.naziv),
      );
    }).toList();

    if (selectedGrad != null && selectedGrad.gradID != 0) {
      _selectedGrad = gradoviLista
          .where((element) => element.gradID == selectedGrad.gradID)
          .first;
    }

    return gradoviLista;
  }
}
