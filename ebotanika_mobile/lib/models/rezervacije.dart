class Rezervacije {
  final int KorisnikID;
  final int GradID;
  final String DatumRezervacije;
  final String Napomena;
  final String SvrhaID;
  final String AdresaDostave;
  final String Kolicina;
  final int BiljkeID;

  Rezervacije(
      {
      required this.KorisnikID,
      required this.GradID,
      required this.DatumRezervacije,
      required this.Napomena,
      required this.SvrhaID,
      required this.AdresaDostave,
      required this.Kolicina,
      required this.BiljkeID});

  factory Rezervacije.fromJson(Map<String, dynamic> json) {
    return Rezervacije(
        KorisnikID: json["KorisnikID"],
        GradID: json["GradID"],
        DatumRezervacije: json["DatumRezervacije"],
        Napomena: json["Napomena"],
        SvrhaID: json["SvrhaID"],
        AdresaDostave: json["AdresaDostave"],
        Kolicina: json["Kolicina"],
        BiljkeID: json["BiljkeID"]);
  }

  Map<String, dynamic> toJson() => {
        "KorisnikID": KorisnikID,
        "GradID": GradID,
        "DatumRezervacije": DatumRezervacije,
        "Napomena": Napomena,
        "SvrhaID": SvrhaID,
        "AdresaDostave": AdresaDostave,
        "Kolicina": Kolicina,
        "BiljkeID": BiljkeID
      };
}
