class Dostava {
  int dostavaID;
  String datumSlanja;
  String datumPreuzimanja;
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
        datumSlanja: json["datumSlanja"],
        datumPreuzimanja: json["datumPreuzimanja"],
        trenutnaLokacija: json["trenutnaLokacija"],
        napomena: json["napomena"],
        rezervacijaID: json["rezervacijaID"]);
  }

  Map<String, dynamic> toJson() => {
        "dostavaID": dostavaID,
        "datumSlanja": datumSlanja,
        "datumPreuzimanja": datumPreuzimanja,
        "trenutnaLokacija": trenutnaLokacija,
        "napomena": napomena,
        "rezervacijaID": rezervacijaID
      };
}
