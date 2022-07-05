class Placanje {
  int korisnikID;
  String brojTransakcije;
  String currency;
  double iznos;

  Placanje(
      {required this.korisnikID,
      required this.brojTransakcije,
      required this.currency,
      required this.iznos});

  factory Placanje.fromJson(Map<String, dynamic> json) {
    return Placanje(
        korisnikID: json["korisnikID"],
        brojTransakcije: json["brojTransakcije"],
        currency: json["currency"],
        iznos: json["iznos"]);
  }

  Map<String, dynamic> toJson() => {
        "korisnikID": korisnikID,
        "brojTransakcije": brojTransakcije,
        "currency": currency,
        "iznos": iznos
      };
}
