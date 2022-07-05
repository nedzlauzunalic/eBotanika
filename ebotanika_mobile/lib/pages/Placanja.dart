// ignore_for_file: deprecated_member_use

import 'dart:convert';
import 'package:http/http.dart' as http;
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import '../models/placanje.dart';
import '../services/APIservice.dart';

class Placanja extends StatefulWidget {
  double cijena = 0;
  Placanja({Key? key, required this.cijena}) : super(key: key);

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
                padding: const EdgeInsets.all(100),
                child: Column(
                    mainAxisAlignment: MainAxisAlignment.start,
                    children: [
                      const Text(
                        'Definiši plaćanje',
                        style: TextStyle(fontSize: 20, color: Colors.black),
                      ),
                      const SizedBox(
                        height: 35,
                      ),
                      const Text('Iznos',
                          style: TextStyle(fontSize: 15, color: Colors.black)),
                      const SizedBox(
                        height: 10,
                      ),
                      Text(widget.cijena.toString(),
                          style: const TextStyle(
                              fontSize: 15, color: Colors.black)),
                      const SizedBox(
                        height: 10,
                      ),
                      TextButton(
                        onPressed: () async {
                          makePayment(widget.cijena);
                        },
                        style: ElevatedButton.styleFrom(
                            primary: Colors.green[900],
                            padding: const EdgeInsets.symmetric(
                                horizontal: 40, vertical: 10)),
                        child: const Text('Plati',
                            style:
                                TextStyle(color: Colors.white, fontSize: 16)),
                      ),
                    ]))));
  }

  Future<void> makePayment(double iznos) async {
    try {
      paymentIntentData =
          await createPaymentIntent((iznos * 100).round().toString(), 'bam');
      await Stripe.instance
          .initPaymentSheet(
              paymentSheetParameters: SetupPaymentSheetParameters(
                  paymentIntentClientSecret:
                      paymentIntentData!['client_secret'],
                  applePay: true,
                  googlePay: true,
                  testEnv: true,
                  style: ThemeMode.dark,
                  merchantCountryCode: 'BIH',
                  merchantDisplayName: 'eBotanika'))
          .then((value) {});

      await insertUplata(
          iznos, paymentIntentData!['id'], paymentIntentData!['currency']);

      displayPaymentSheet();
    } catch (e, s) {
      print('exception:$e$s');
    }
  }

  createPaymentIntent(String amount, String currency) async {
    try {
      Map<String, dynamic> body = {
        'amount': amount,
        'currency': currency,
        'payment_method_types[]': 'card'
      };

      var response = await http.post(
          Uri.parse('https://api.stripe.com/v1/payment_intents'),
          body: body,
          headers: {
            'Authorization':
                'Bearer sk_test_51LHYE2K8DNVb8RyerAz8QTPpV62wQ1VfDhT8FLRojUkNjd6yC6QIVosLsfFnft3r9dLTtEvIuudZqDu881WjSIlr00YxdnV014',
            'Content-Type': 'application/x-www-form-urlencoded'
          });
      return jsonDecode(response.body);
    } catch (err) {
      print('err charging user: ${err.toString()}');
    }
  }

  insertUplata(double iznos, String brojTransakcije, String currency) async {
    var request = Placanje(
      korisnikID: APIService.korisnikId,
      brojTransakcije: brojTransakcije,
      currency: currency,
      iznos: iznos,
    );

    await APIService.post("Placanje", json.encode(request.toJson()));
  }

  displayPaymentSheet() async {
    try {
      await Stripe.instance
          .presentPaymentSheet(
              parameters: PresentPaymentSheetParameters(
        clientSecret: paymentIntentData!['client_secret'],
        confirmPayment: true,
      ))
          .onError((error, stackTrace) {
        print('Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
      });

      ScaffoldMessenger.of(context)
          .showSnackBar(const SnackBar(content: Text("Uplata uspješna.")));
    } on StripeException catch (e) {
      showDialog(
          context: context,
          builder: (_) => const AlertDialog(
                content: Text("Poništena transakcija."),
              ));
    } catch (e) {
      print('$e');
    }
  }
}
