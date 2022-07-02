class Gradovi {
  int gradID;
  String naziv;

  Gradovi({
    required this.gradID,
    required this.naziv
  });

  factory Gradovi.fromJson(Map<String, dynamic> json) {
    return Gradovi(
        gradID: json["gradID"],
        naziv: json["naziv"]);
  }

  Map<String, dynamic> toJson() => {
        "gradID": gradID,
        "naziv": naziv
      };
}