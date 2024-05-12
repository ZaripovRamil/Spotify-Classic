import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/profile_page/bloc/history_bloc.dart';
import 'package:spotik_mobile/profile_page/components/history_tab.dart';
import 'package:spotik_mobile/profile_page/components/subscription_tab.dart';
import 'package:spotik_mobile/profile_page/services/history_repository.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class ProfilePage extends StatefulWidget {
  const ProfilePage({super.key});

  @override
  State<StatefulWidget> createState() => _ProfilePageState();
}

class _ProfilePageState extends State<ProfilePage> {
  @override
  Widget build(BuildContext context) {
    return MultiRepositoryProvider(
      providers: [
        RepositoryProvider<HistoryRepository>(
            create: (context) => HistoryRepository()),
      ],
      child: MultiBlocProvider(
        providers: [
          BlocProvider(
            create: (context) => HistoryBloc(
                historyRepository: context.read<HistoryRepository>())
              ..add(const HistoryEvent.load()),
          ),
        ],
        child: Scaffold(
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
                  const Expanded(
                    child: TabBarView(
                      children: [
                        HistoryTab(),
                        SubscriptionTab(),
                      ],
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
