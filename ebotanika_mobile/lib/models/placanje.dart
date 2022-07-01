class Placanje {
  int placanjeID;
  int korisnikID;
  int brojKartice;
  int securityCode;
  int expYear;
  int expMonth;

  Placanje(
      {required this.placanjeID,
      required this.korisnikID,
      required this.brojKartice,
      required this.securityCode,
      required this.expYear,
      required this.expMonth});

  factory Placanje.fromJson(Map<String, dynamic> json) {
    return Placanje(
        placanjeID: json["placanjeID"],
        korisnikID: json["korisnikID"],
        brojKartice: json["brojKartice"],
        securityCode: json["securityCode"],
        expYear: json["expYear"],
        expMonth: json["expMonth"]);
  }

  Map<String, dynamic> toJson() => {
        "placanjeID": placanjeID,
        "korisnikID": korisnikID,
        "brojKartice": brojKartice,
        "securityCode": securityCode,
        "expYear": expYear,
        "expMonth": expMonth
      };
}
