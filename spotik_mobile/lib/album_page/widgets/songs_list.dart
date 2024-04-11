import 'package:flutter/material.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class SongsList extends StatefulWidget {
  const SongsList({super.key});

  @override
  State<SongsList> createState() => _SongsListState();
}

class _SongsListState extends State<SongsList> {
  @override
  Widget build(BuildContext context) {
    return ListView.separated(
        itemCount: 10,
        padding: const EdgeInsets.only(right: 20, left: 20),
        separatorBuilder: (context, i) => const Divider(),
        itemBuilder: (context, i) {
          return ListTile(
            leading: Text("1", style: Theme.of(context).textTheme.displaySmall?.copyWith(color: CustomColors.goldenColor), ),
            title: Text("Song Name 1", style: Theme.of(context).textTheme.displaySmall),
            trailing: Text("3:00", style: Theme.of(context).textTheme.displaySmall),
          );
        });
  }
}