class Dostava {
  int dostavaID;
  DateTime datumSlanja;
  DateTime datumPreuzimanja;
  String trenutnaLokacija;
  String napomena;
  int rezervacijaID;

  Dostava({
    required this.dostavaID,
    required this.datumSlanja,
    required this.datumPreuzimanja,
    required this.trenutnaLokacija,
    required this.napomena,
    required this.rezervacijaID,
  });

  factory Dostava.fromJson(Map<String, dynamic> json) {
    return Dostava(
        dostavaID: json["dostavaID"],
        datumSlanja: DateTime.parse(json["datumSlanja"].toString()),
        datumPreuzimanja: DateTime.parse(json["datumPreuzimanja"].toString()),
        trenutnaLokacija: json["trenutnaLokacija"],
        napomena: json["napomena"],
        rezervacijaID: json["rezervacijaID"]);
  }

  Map<String, dynamic> toJson() => {
        "dostavaID": dostavaID,
        "datumSlanja": datumSlanja.toIso8601String(),
        "datumPreuzimanja": datumPreuzimanja.toIso8601String(),
        "trenutnaLokacija": trenutnaLokacija,
        "napomena": napomena,
        "rezervacijaID": rezervacijaID
      };
}
