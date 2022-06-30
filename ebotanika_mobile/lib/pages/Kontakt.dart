import 'package:flutter/material.dart';

class Kontakt extends StatefulWidget {
  const Kontakt({Key? key}) : super(key: key);

  @override
  _KontaktState createState() => _KontaktState();
}

class _KontaktState extends State<Kontakt> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Padding(
          padding: const EdgeInsets.all(40),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: const [
              Text(
                'Kontakt',
                style: TextStyle(
                    fontSize: 30,
                    color: Colors.green,
                    fontWeight: FontWeight.bold),
              ),
              SizedBox(
                height: 30,
              ),
              Text(
                'Halilovićka 25\n7100 Sarajevo\nBosna i Hercegovina\nTel: +387 33 849 916\nMob: +387 61 142 890\nEmail: eBotanika@gmail.com',
                style: TextStyle(fontSize: 20, color: Colors.black),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
