class Korisnik {
  String ime;
  String prezime;
  String email;
  String telefon;
  String datumRodjenja;
  String korisnickoIme;
  String lozinka;
  String lozinkaPotvrda;

  Korisnik(
      {
      required this.ime,
      required this.prezime,
      required this.email,
      required this.telefon,
      required this.datumRodjenja,
      required this.korisnickoIme,
      required this.lozinka,
      required this.lozinkaPotvrda});

  factory Korisnik.fromJson(Map<String, dynamic> json) {
    return Korisnik(
        ime: json["ime"],
        prezime: json["prezime"],
        email: json["email"],
        telefon: json["telefon"],
        datumRodjenja: json["datumRodjenja"],
        korisnickoIme: json["korisnickoIme"],
        lozinka: json["lozinka"],
        lozinkaPotvrda: json["lozinkaPotvrda"]);
  }

  Map<String, dynamic> toJson() => {
        "ime": ime,
        "prezime": prezime,
        "email": email,
        "telefon": telefon,
        "datumRodjenja": datumRodjenja,
        "korisnickoIme": korisnickoIme,
        "lozinka": lozinka,
        "lozinkaPotvrda": lozinkaPotvrda
      };
}
