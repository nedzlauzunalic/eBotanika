import 'package:json_annotation/json_annotation.dart';

part 'biljke.g.dart';

@JsonSerializable()
class Biljke {
  int? biljkaId;
  String? naziv;
  String? opis;
  String? slika;
  int? cijena;

  Biljke();

  factory Biljke.fromJson(Map<String, dynamic> json) => _$BiljkeFromJson(json);

  /// Connect the generated [_$BiljkeFromJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$BiljkeToJson(this);
}
