class Biljke {
  int biljkaID;
  int kategorijaID;
  String naziv;
  String opis;
  String slika;
  String cijena;

  Biljke(
      {required this.biljkaID,
      required this.kategorijaID,
      required this.naziv,
      required this.opis,
      required this.slika,
      required this.cijena});

  factory Biljke.fromJson(Map<String, dynamic> json) {
    return Biljke(
      biljkaID: int.parse(json["biljkaID"].toString()),
      kategorijaID: int.parse(json["kategorijaID"].toString()),
      naziv: json["naziv"],
      opis: json["opis"],
      slika: json["slika"],
      cijena: json["cijena"],
    );
  }

  Map<String, dynamic> toJson() => {
        "biljkaID": biljkaID,
        "kategorijaID": kategorijaID,
        "naziv": naziv,
        "opis": opis,
        "slika": slika,
        "cijena": cijena
      };
}
