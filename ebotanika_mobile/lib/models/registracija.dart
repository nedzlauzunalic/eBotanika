class Registracija {
  String ime;
  String prezime;
  String email;
  String telefon;
  String datumRodjenja;
  String korisnickoIme;
  String password;
  String passwordPotvrda;

  Registracija(
      {required this.ime,
      required this.prezime,
      required this.email,
      required this.telefon,
      required this.datumRodjenja,
      required this.korisnickoIme,
      required this.password,
      required this.passwordPotvrda});

  factory Registracija.fromJson(Map<String, dynamic> json) {
    return Registracija(
        ime: json["ime"],
        prezime: json["prezime"],
        email: json["email"],
        telefon: json["telefon"],
        datumRodjenja: json["datumRodjenja"],
        korisnickoIme: json["korisnickoIme"],
        password: json["password"],
        passwordPotvrda: json["passwordPotvrda"]);
  }

  Map<String, dynamic> toJson() => {
        "ime": ime,
        "prezime": prezime,
        "email": email,
        "telefon": telefon,
        "datumRodjenja": datumRodjenja,
        "korisnickoIme": korisnickoIme,
        "password": password,
        "passwordPotvrda": passwordPotvrda
      };
}
