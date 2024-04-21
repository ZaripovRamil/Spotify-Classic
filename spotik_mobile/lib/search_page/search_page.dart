import 'package:flutter/material.dart';

import '../utils/ui_constants.dart';

class SearchPage extends StatefulWidget {
  const SearchPage({super.key});

  @override
  _SearchPageState createState() {
    return _SearchPageState();
  }
}

class _SearchPageState extends State<SearchPage> {
  final TextEditingController _searchController = TextEditingController();
  List<String> _searchedTracks = [];
  List<String> _searchedAuthors = [];

  void _search() {
    setState(() {
      _searchedTracks = List.generate(5, (index) => 'Track $index');
      _searchedAuthors = List.generate(5, (index) => 'Author $index');
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Search',
            style: TextStyle(
              color: CustomColors.goldenColor,
            )),
      ),
      body: Column(
        children: <Widget>[
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: TextField(
              controller: _searchController,
              decoration: InputDecoration(
                labelText: 'Search',
                labelStyle: const TextStyle(
                  color: CustomColors.goldenColor,
                ),
                suffixIcon: IconButton(
                  icon: const Icon(Icons.search),
                  onPressed: _search,
                ),
              ),
            ),
          ),
          Expanded(
            child: ListView.builder(
              itemCount: _searchedTracks.length,
              itemBuilder: (context, index) {
                return ListTile(
                    title: Row(children: [
                  Image.asset("assets/compositor.png", height: 40,),
                  Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(_searchedTracks[index],
                            style: const TextStyle(
                                color: CustomColors.goldenColor,
                                fontSize: TextSize.smallTextSize)),
                        Text(_searchedAuthors[index],
                            style: const TextStyle(
                                color: CustomColors.goldenColor,
                                fontSize: TextSize.tinyTextSize)),
                      ])
                ]));
              },
            ),
          ),
        ],
      ),
    );
  }
}
