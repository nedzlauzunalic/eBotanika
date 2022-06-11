import 'package:flutter/material.dart';
import '../services/APIService.dart';
import 'package:provider/provider.dart';
import 'Asortiman.dart';
import 'Home.dart';

void main() => runApp(MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => APIService()),
      ],
      child: MaterialApp(
        debugShowCheckedModeBanner: true,
        home: const Login(),
        onGenerateRoute: (settings) {
          if (settings.name == Asortiman.routeName) {
            return MaterialPageRoute(builder: ((context) => const Asortiman()));
          }
        },
      ),
    ));

class Login extends StatefulWidget {
  const Login({Key? key}) : super(key: key);

  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  /* TextEditingController usernameController = new TextEditingController();
  TextEditingController passwordController = new TextEditingController();
  var result;

  Future<void> GetData() async {
    result = await APIService.Get('Uposlenik', null);
  } */

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.all(40),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              const Image(
                width: 100,
                height: 150,
                image: AssetImage('assets/flower-icon.jpg'),
              ),
              const Text(
                'eBotanika',
                style: TextStyle(fontSize: 30, color: Colors.green),
              ),
              const SizedBox(height: 70),
              TextField(
                  //controller: usernameController,
                  decoration: InputDecoration(
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(7)),
                      hintText: 'Korisničko ime')),
              const SizedBox(
                height: 10,
              ),
              TextField(
                  //controller: passwordController,
                  obscureText: true,
                  decoration: InputDecoration(
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(7)),
                      hintText: 'Lozinka')),
              const SizedBox(
                height: 20,
              ),
              Container(
                padding: const EdgeInsets.all(10),
                height: 60,
                width: 250,
                decoration: BoxDecoration(
                    color: Colors.green[900],
                    borderRadius: BorderRadius.circular(8)),
                child: InkWell(
                  onTap: () {
                    Navigator.pushNamed(context, Asortiman.routeName);
                  },
                  child: const Center(child: Text("Login")),
                ),
                /* child: TextButton(
                    onPressed: () async {
                      APIService.username = usernameController.text;
                      APIService.password = passwordController.text;
                      await GetData();
                      print(result);
                      if (result != null) {
                        print(result);
                        Navigator.of(context).pushReplacementNamed('/home');
                      }
                    },
                    child: const Text('Login',
                        textAlign: TextAlign.center,
                        style: TextStyle(color: Colors.white, fontSize: 20))) */
              )
            ],
          ),
        ),
      ),
    );
  }
}
