import 'package:freezed_annotation/freezed_annotation.dart';

part 'author.freezed.dart';
part 'author.g.dart';

@freezed
class Author with _$Author {
  // ignore: invalid_annotation_target
  @JsonSerializable(explicitToJson: true)
  const factory Author({required String id, required String name}) = _Author;

  factory Author.fromJson(Map<String, dynamic> json) => _$AuthorFromJson(json);
}
