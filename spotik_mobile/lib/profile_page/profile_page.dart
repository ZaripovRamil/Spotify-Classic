import 'package:flutter/material.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class ProfilePage extends StatefulWidget {
  const ProfilePage({super.key});

  @override
  State<StatefulWidget> createState() => _ProfilePageState();
}

class HistoryItem {
  final String trackName;
  final String albumName;
  final Uri previewUrl;
  final Uri trackUrl;
  final Duration trackDuration;

  HistoryItem(
      {required this.trackName,
      required this.albumName,
      required this.previewUrl,
      required this.trackUrl,
      required this.trackDuration});
}

class History {
  final List<HistoryItem> history;

  History({required this.history});
}

class _ProfilePageState extends State<ProfilePage> {
  History getData() {
    return History(
      history: List.generate(10, (index) =>
        HistoryItem(
            trackName: 'Track $index',
            albumName: 'Album $index',
          previewUrl: Uri.parse('assets/history_song_40.png'),
          trackUrl: Uri.parse(''),
          trackDuration: Duration(minutes: index % 6, seconds: index % 60),
      )
    )
    );
  }

  @override
  Widget build(BuildContext context) {
    return DefaultTabController(
      length: 1,
      child: Scaffold(
        backgroundColor: Colors.transparent,
        body: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Padding(
              padding: const EdgeInsets.only(left: 20, top: 10),
              child: AppBar(
                backgroundColor: Colors.transparent,
                leading: CircleAvatar(
                  child: Image.asset(
                    'assets/avatar.png',
                  ),
                ),
                title: const Text(
                  'Username',
                  style: TextStyle(
                    fontSize: TextSize.mediumTextSize,
                    color: CustomColors.goldenColor,
                  ),
                ),
              ),
            ),
            const TabBar(
              labelStyle: TextStyle(
                color: Colors.white,
                fontFamily: Fonts.fontNameDefault,
              ),
              indicatorColor: CustomColors.goldenColor,
              tabs: [
                Tab(text: 'History'),
              ],
            ),
            Expanded(
              child: TabBarView(
                children: [
                  _buildHistoryTab(context, getData()),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildHistoryTab(BuildContext context, History data) {
    return Column(
      children: [
        Align(
          alignment: Alignment.centerRight,
          child: Padding(
              padding: const EdgeInsets.all(20),
              child: MaterialButton(
                  color: CustomColors.backgroundButtonGrey,
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(13.0),
                  ),
                  onPressed: () => {},
                  child: const Text('Clear',
                      style: TextStyle(fontSize: TextSize.smallTextSize)))),
        ),
        Expanded(
          child: ListView.builder(
            itemCount: data.history.length,
            itemBuilder: (context, index) {
              final item = data.history[index];
              String duration = '${item.trackDuration.inMinutes}:'
                  '${item.trackDuration.inSeconds % 60 < 10 ? '0' : ''}'
                  '${item.trackDuration.inSeconds % 60}';
              return ListTile(
                leading: Image.asset(
                  item.previewUrl.path,
                  fit: BoxFit.cover,
                ),
                title: Text(item.trackName),
                subtitle: Text(item.albumName),
                trailing: Text(duration),
              );
            },
          ),
        ),
      ],
    );
  }
}
