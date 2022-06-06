// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************
part of 'biljke.dart';

Biljke _$BiljkeFromJson(Map<String, dynamic> json) => Biljke()
  ..biljkaId = json['biljkaId'] as int?
  ..naziv = json['naziv'] as String?
  ..opis = json['opis'] as String?
  ..slika = json['slika'] as String?
  ..cijena = json['cijena'] as int?;

Map<String, dynamic> _$BiljkeToJson(Biljke instance) => <String, dynamic>{
      'biljkaId': instance.biljkaId,
      'naziv': instance.naziv,
      'opis': instance.opis,
      'slika': instance.slika,
      'cijena': instance.cijena
    };
