class Korisnik {
  int korisnikID;
  String ime;
  String prezime;
  DateTime datumRodjenja;
  String email;
  int telefon;
  String korisnickoIme;
  String lozinka;
  String lozinkaPotvrda;

  Korisnik(
      {required this.korisnikID,
      required this.ime,
      required this.prezime,
      required this.datumRodjenja,
      required this.email,
      required this.telefon,
      required this.korisnickoIme,
      required this.lozinka,
      required this.lozinkaPotvrda});

  factory Korisnik.fromJson(Map<String, dynamic> json) {
    return Korisnik(
        korisnikID: int.parse(json["korisnikID"].toString()),
        ime: json["ime"],
        prezime: json["prezime"],
        datumRodjenja: json["datumRodjenja"],
        email: json["email"],
        telefon: json["telefon"],
        korisnickoIme: json["korisnickoIme"],
        lozinka: json["lozinka"],
        lozinkaPotvrda: json["lozinkaPotvrda"]);
  }

  Map<String, dynamic> toJson() => {
        "korisnikID": korisnikID,
        "ime": ime,
        "prezime": prezime,
        "datumRodjenja": datumRodjenja,
        "email": email,
        "telefon": telefon,
        "korisnickoIme": korisnickoIme,
        "lozinka": lozinka,
        "lozinkaPotvrda": lozinkaPotvrda
      };
}
