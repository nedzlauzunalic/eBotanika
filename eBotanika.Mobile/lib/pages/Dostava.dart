import 'package:flutter/material.dart';

class Dostava extends StatefulWidget {
  const Dostava({Key? key}) : super(key: key);

  @override
  _DostavaState createState() => _DostavaState();
}

class _DostavaState extends State<Dostava> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Center(
      child: Padding(
        padding: const EdgeInsets.all(40),
        child:
            Column(mainAxisAlignment: MainAxisAlignment.start, children: const [
          SizedBox(
            height: 35,
          ),
          Image(
            width: 95,
            height: 100,
            image: AssetImage('assets/delivery-icon.jpg'),
          ),
          Text(
            'Vaša dostava',
            style: TextStyle(fontSize: 30, color: Colors.green),
          ),
          SizedBox(
            height: 35,
          ),
          Text(
            'Datum i vrijeme slanja narudžbe',
            style: TextStyle(fontSize: 20, color: Colors.black),
          ),
          Text(
            'datum',
            style: TextStyle(fontSize: 15, color: Colors.black),
          ),
          SizedBox(
            height: 20,
          ),
          Text(
            'Datum i vrijeme preuzimanja narudžbe',
            style: TextStyle(fontSize: 20, color: Colors.black),
          ),
          Text(
            'datum',
            style: TextStyle(fontSize: 15, color: Colors.black),
          ),
          SizedBox(
            height: 20,
          ),
          Text(
            'Trenutna lokacija',
            style: TextStyle(fontSize: 20, color: Colors.black),
          ),
          Text(
            'lokacija',
            style: TextStyle(fontSize: 15, color: Colors.black),
          ),
          SizedBox(
            height: 20,
          ),
          Text(
            'Napomena',
            style: TextStyle(fontSize: 20, color: Colors.black),
          ),
          Text(
            'napomena',
            style: TextStyle(fontSize: 15, color: Colors.black),
          ),
        ]),
      ),
    ));
  }
}
