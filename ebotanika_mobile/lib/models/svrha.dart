class Svrha {
  int svrhaID;
  String naziv;

  Svrha({
    required this.svrhaID,
    required this.naziv
  });

  factory Svrha.fromJson(Map<String, dynamic> json) {
    return Svrha(
        svrhaID: json["svrhaID"],
        naziv: json["naziv"]);
  }

  Map<String, dynamic> toJson() => {
        "svrhaID": svrhaID,
        "naziv": naziv
      };
}