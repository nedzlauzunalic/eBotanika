class Ocjena {
  int ocjenaId;
  int ocjenaUsluge;
  int korisnikID;
  int biljkeID;

  Ocjena(
      {required this.ocjenaId,
      required this.ocjenaUsluge,
      required this.korisnikID,
      required this.biljkeID});

  factory Ocjena.fromJson(Map<String, dynamic> json) {
    return Ocjena(
        ocjenaId: int.parse(json["ocjenaId"].toString()),
        ocjenaUsluge: json["ocjenaUsluge"],
        korisnikID: int.parse(json["korisnikID"].toString()),
        biljkeID: int.parse(json["biljkeID"].toString()));
  }

  Map<String, dynamic> toJson() => {
        "ocjenaId": ocjenaId,
        "ocjenaUsluge": ocjenaUsluge,
        "korisnikID": korisnikID,
        "biljkeID": biljkeID
      };
}
