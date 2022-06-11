class Rezervacije {
  int rezervacijaID;
  DateTime datumRezervacije;
  int korisnikID;
  int gradID;
  String napomena;
  int kolicina;
  int svrhaID;
  String adresaDostave;
  int biljkaID;

  Rezervacije(
      {required this.rezervacijaID,
      required this.datumRezervacije,
      required this.korisnikID,
      required this.gradID,
      required this.napomena,
      required this.kolicina,
      required this.svrhaID,
      required this.adresaDostave,
      required this.biljkaID});

  factory Rezervacije.fromJson(Map<String, dynamic> json) {
    return Rezervacije(
        rezervacijaID: int.parse(json["rezervacijaID"].toString()),
        datumRezervacije: json["datumRezervacije"],
        korisnikID: int.parse(json["korisnikID"].toString()),
        gradID: int.parse(json["gradID"].toString()),
        napomena: json["napomena"],
        kolicina: int.parse(json["kolicina"].toString()),
        svrhaID: int.parse(json["svrhaID"].toString()),
        adresaDostave: json["adresaDostave"],
        biljkaID: int.parse(json["biljkaID"].toString()));
  }

  Map<String, dynamic> toJson() => {
        "rezervacijaID": rezervacijaID,
        "datumSlanja": datumRezervacije,
        "korisnikID": korisnikID,
        "gradID": gradID,
        "napomena": napomena,
        "kolicina": kolicina,
        "svrhaID": svrhaID,
        "adresaDostave": adresaDostave,
        "biljkaID": biljkaID
      };
}
