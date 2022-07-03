// ignore_for_file: deprecated_member_use

import 'package:flutter/material.dart';

class Placanja extends StatefulWidget {
  const Placanja({Key? key}) : super(key: key);

  @override
  _PlacanjaState createState() => _PlacanjaState();
}

class _PlacanjaState extends State<Placanja> {
  Map<String, dynamic>? paymentIntentData;
  TextEditingController brojKarticeController = TextEditingController();
  TextEditingController securityCodeController = TextEditingController();
  TextEditingController expYearController = TextEditingController();
  TextEditingController expMonthController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Način plaćanja'),
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
          return PlacanjeWidget(snapshot.data);
        }
      }
    });
  }

  Widget PlacanjeWidget(data) {
    return Scaffold(
        body: SingleChildScrollView(
            child: Padding(
                padding: const EdgeInsets.all(70),
                child: Column(
                    mainAxisAlignment: MainAxisAlignment.start,
                    children: [
                      TextField(
                          controller: brojKarticeController,
                          decoration:
                              const InputDecoration(hintText: 'Broj kartice')),
                      const SizedBox(
                        height: 35,
                      ),
                      TextField(
                          controller: securityCodeController,
                          decoration:
                              const InputDecoration(hintText: 'SecurityCode')),
                      const SizedBox(
                        height: 35,
                      ),
                      TextField(
                          controller: brojKarticeController,
                          decoration:
                              const InputDecoration(hintText: 'ExpYear')),
                      const SizedBox(
                        height: 35,
                      ),
                      TextField(
                          controller: expMonthController,
                          decoration:
                              const InputDecoration(hintText: 'ExpMonth')),
                      const SizedBox(
                        height: 35,
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
                                /* if (result != null) {
                                  setState(() {
                                    ScaffoldMessenger.of(context)
                                        .showSnackBar(const SnackBar(
                                      content: SizedBox(
                                          height: 20,
                                          child: Center(
                                              child:
                                                  Text("Uspješno poslano."))),
                                      backgroundColor:
                                          Color.fromARGB(255, 9, 100, 13),
                                    ));
                                  });
                                } */
                              },
                              child: const Text('Sačuvaj',
                                  textAlign: TextAlign.center,
                                  style: TextStyle(
                                      color: Colors.white, fontSize: 16)))),
                    ]))));
  }
}
