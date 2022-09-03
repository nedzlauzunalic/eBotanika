class Ocjena {
  int ocjenaID;
  double ocjenaUsluge;
  int korisnikID;
  int biljkeID;

  Ocjena(
      {required this.ocjenaID,
      required this.ocjenaUsluge,
      required this.korisnikID,
      required this.biljkeID});

  factory Ocjena.fromJson(Map<String, dynamic> json) {
    return Ocjena(
        ocjenaID: json["ocjenaID"],
        ocjenaUsluge: json["ocjenaUsluge"],
        korisnikID: json["korisnikID"],
        biljkeID: json["biljkeID"]);
  }

  Map<String, dynamic> toJson() => {
        "ocjenaID": ocjenaID,
        "ocjenaUsluge": ocjenaUsluge,
        "korisnikID": korisnikID,
        "biljkeID": biljkeID
      };
}
