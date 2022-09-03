class RezervacijeList {
  final int rezervacijaID;
  final String datumRezervacije;
  final int korisnikID;
  final int gradID;
  final String napomena;
  final int svrhaID;
  final String adresaDostave;
  final String kolicina;
  final int biljkeID;

  RezervacijeList(
      {required this.rezervacijaID,
      required this.datumRezervacije,
      required this.korisnikID,
      required this.gradID,
      required this.napomena,
      required this.svrhaID,
      required this.adresaDostave,
      required this.kolicina,
      required this.biljkeID});

  factory RezervacijeList.fromJson(Map<String, dynamic> json) {
    return RezervacijeList(
        rezervacijaID: json["rezervacijaID"],
        datumRezervacije: json["datumRezervacije"],
        korisnikID: json["korisnikID"],
        gradID: json["gradID"],
        napomena: json["napomena"],
        svrhaID: json["svrhaID"],
        adresaDostave: json["adresaDostave"],
        kolicina: json["kolicina"],
        biljkeID: json["biljkeID"]);
  }

  Map<String, dynamic> toJson() => {
        "rezervacijaID": rezervacijaID,
        "datumRezervacije": datumRezervacije,
        "korisnikID": korisnikID,
        "gradID": gradID,
        "napomena": napomena,
        "svrhaID": svrhaID,
        "adresaDostave": adresaDostave,
        "kolicina": kolicina,
        "biljkeID": biljkeID
      };
}
