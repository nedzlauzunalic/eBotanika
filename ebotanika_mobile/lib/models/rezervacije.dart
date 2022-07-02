class Rezervacije {
  DateTime datumRezervacije;
  int? korisnikID;
  int gradID;
  String? napomena;
  int? kolicina;
  int svrhaID;
  String? adresaDostave;
  int? biljkeID;

  Rezervacije(
      {
      required this.datumRezervacije,
      required this.korisnikID,
      required this.gradID,
      required this.napomena,
      required this.kolicina,
      required this.svrhaID,
      required this.adresaDostave,
      required this.biljkeID});

  factory Rezervacije.fromJson(Map<String, dynamic> json) {
    return Rezervacije(
        datumRezervacije: DateTime.parse(json["datumRezervacije"].toString()),
        korisnikID: json["korisnikID"],
        gradID: json["gradID"],
        napomena: json["napomena"],
        kolicina: json["kolicina"],
        svrhaID: json["svrhaID"],
        adresaDostave: json["adresaDostave"],
        biljkeID: json["biljkaID"]);
  }

  Map<String, dynamic> toJson() => {
        "datumRezervacije": datumRezervacije.toIso8601String(),
        "korisnikID": korisnikID,
        "gradID": gradID,
        "napomena": napomena,
        "kolicina": kolicina,
        "svrhaID": svrhaID,
        "adresaDostave": adresaDostave,
        "biljkeID": biljkeID
      };
}
