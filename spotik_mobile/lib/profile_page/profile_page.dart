import 'package:flutter/material.dart';
import 'package:spotik_mobile/profile_page/components/history_tab.dart';
import 'package:spotik_mobile/profile_page/components/subscription_tab.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class ProfilePage extends StatefulWidget {
  const ProfilePage({super.key});

  @override
  State<StatefulWidget> createState() => _ProfilePageState();
}

class _ProfilePageState extends State<ProfilePage> {
  History getData() {
    return History(
        history: List.generate(
            10,
            (index) => HistoryItem(
                  trackName: 'Track $index',
                  albumName: 'Album $index',
                  previewUrl: Uri.parse('assets/history_song_40.png'),
                  trackUrl: Uri.parse(''),
                  trackDuration:
                      Duration(minutes: index % 6, seconds: index % 60),
                )));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.transparent,
      appBar: AppBar(
        backgroundColor: Colors.transparent,
        iconTheme: Theme.of(context).iconTheme,
      ),
      body: DefaultTabController(
        length: 2,
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
              TabBar(
                labelStyle: Theme.of(context).textTheme.displaySmall,
                indicatorColor: CustomColors.goldenColor,
                tabs: const [
                  Tab(text: 'History'),
                  Tab(text: 'Subscription'),
                ],
              ),
              Expanded(
                child: TabBarView(
                  children: [
                    HistoryTab(data: getData()),
                    const SubscriptionTab(),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
