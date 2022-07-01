class Kategorija {
  int kategorijaID;
  String naziv;
  String opis;

  Kategorija({
    required this.kategorijaID,
    required this.naziv,
    required this.opis,
  });

  factory Kategorija.fromJson(Map<String, dynamic> json) {
    return Kategorija(
      kategorijaID: json["kategorijaID"],
      naziv: json["naziv"],
      opis: json["opis"],
    );
  }

  Map<String, dynamic> toJson() => {
        "kategorijaID": kategorijaID,
        "naziv": naziv,
        "opis": opis,
      };
}
