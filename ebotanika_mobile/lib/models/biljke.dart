class Biljke {
  int biljkeID;
  int kategorijaID;
  String naziv;
  String opis;
  String slika;
  double cijena;

  Biljke(
      {required this.biljkeID,
      required this.kategorijaID,
      required this.naziv,
      required this.opis,
      required this.slika,
      required this.cijena});

  factory Biljke.fromJson(Map<String, dynamic> json) {
    return Biljke(
      biljkeID: int.parse(json["biljkeID"].toString()),
      kategorijaID: json["kategorijaID"],
      naziv: json["naziv"],
      opis: json["opis"],
      slika: json["slika"],
      cijena: json["cijena"],
    );
  }

  Map<String, dynamic> toJson() => {
        "biljkeID": biljkeID,
        "kategorijaID": kategorijaID,
        "naziv": naziv,
        "opis": opis,
        "slika": slika,
        "cijena": cijena
      };
}
