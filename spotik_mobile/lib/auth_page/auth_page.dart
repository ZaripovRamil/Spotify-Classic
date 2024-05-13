import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/auth_page/bloc/auth_bloc.dart';
import 'package:spotik_mobile/auth_page/services/auth_repository.dart';
import 'package:spotik_mobile/auth_page/widgets/login_card.dart';
import 'package:spotik_mobile/auth_page/widgets/signup.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class AuthPage extends StatelessWidget {
  const AuthPage({super.key});

  @override
  Widget build(BuildContext context) {
    return RepositoryProvider(
      create: (context) => AuthRepository(),
      child: BlocProvider(
        create: (context) => AuthBloc(authRepository: context.read<AuthRepository>()),
        child: DefaultTabController(
          length: 2,
          child: Scaffold(
            backgroundColor: Colors.transparent,
            appBar: AppBar(
              backgroundColor: Colors.transparent,
              title: const Text('Authorization',
                  style: TextStyle(
                    fontSize: TextSize.mediumTextSize,
                    fontWeight: FontWeight.bold,
                    color: CustomColors.goldenColor,
                  )),
              iconTheme: Theme.of(context).iconTheme,
              bottom: TabBar(
                indicatorColor: CustomColors.goldenColor,
                labelStyle: Theme.of(context).textTheme.displayMedium,
                tabs: const [
                  Tab(
                    text: 'Login',
                  ),
                  Tab(
                    text: 'Signup',
                  ),
                ],
              ),
            ),
            body: const TabBarView(
              children: [
                LoginCard(),
                SignupCard(),
              ],
            ),
          ),
        ),
      ),
    );
  }
}




