class Korisnik {
  String ime;
  String prezime;
  DateTime datumRodjenja;
  String email;
  String telefon;
  String korisnickoIme;

  Korisnik(
      {required this.ime,
      required this.prezime,
      required this.datumRodjenja,
      required this.email,
      required this.telefon,
      required this.korisnickoIme});

  factory Korisnik.fromJson(Map<String, dynamic> json) {
    return Korisnik(
        ime: json["ime"],
        prezime: json["prezime"],
        datumRodjenja: DateTime.parse(json["datumRodjenja"].toString()),
        email: json["email"],
        telefon: json["telefon"],
        korisnickoIme: json["korisnickoIme"]);
  }

  Map<String, dynamic> toJson() => {
        "ime": ime,
        "prezime": prezime,
        "datumRodjenja": datumRodjenja.toIso8601String(),
        "email": email,
        "telefon": telefon,
        "korisnickoIme": korisnickoIme
      };
}
