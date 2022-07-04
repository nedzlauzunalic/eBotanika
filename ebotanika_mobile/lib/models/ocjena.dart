class Ocjena {
  double ocjenaUsluge;
  int korisnikID;
  int biljkeID;

  Ocjena(
      {required this.ocjenaUsluge,
      required this.korisnikID,
      required this.biljkeID});

  factory Ocjena.fromJson(Map<String, dynamic> json) {
    return Ocjena(
        ocjenaUsluge: json["ocjenaUsluge"],
        korisnikID: json["korisnikID"],
        biljkeID: json["biljkeID"]);
  }

  Map<String, dynamic> toJson() => {
        "ocjenaUsluge": ocjenaUsluge,
        "korisnikID": korisnikID,
        "biljkeID": biljkeID
      };
}
