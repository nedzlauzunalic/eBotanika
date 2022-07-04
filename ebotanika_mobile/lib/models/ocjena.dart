class Ocjena {
  int ocjenaId;
  double ocjenaUsluge;
  int korisnikID;
  int biljkeID;

  Ocjena(
      {required this.ocjenaId,
      required this.ocjenaUsluge,
      required this.korisnikID,
      required this.biljkeID});

  factory Ocjena.fromJson(Map<String, dynamic> json) {
    return Ocjena(
        ocjenaId: json["ocjenaId"],
        ocjenaUsluge: json["ocjenaUsluge"],
        korisnikID: json["korisnikID"],
        biljkeID: json["biljkeID"]);
  }

  Map<String, dynamic> toJson() => {
        "ocjenaId": ocjenaId,
        "ocjenaUsluge": ocjenaUsluge,
        "korisnikID": korisnikID,
        "biljkeID": biljkeID
      };
}
