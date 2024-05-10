import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/auth_page/bloc/auth_bloc.dart';
import 'package:spotik_mobile/auth_page/widgets/login_form.dart';
import 'package:spotik_mobile/utils/navigation_routes.dart';

class LoginCard extends StatefulWidget {
  LoginCard({super.key});

  @override
  State<LoginCard> createState() => _LoginCardState();
}

class _LoginCardState extends State<LoginCard> {
  get submitted => null;

  @override
  Widget build(BuildContext context) {
    final state = context.watch<AuthBloc>().state;
    return Scaffold(
      backgroundColor: Colors.transparent,
      body: Center(
        child: Card(
          color: Colors.transparent,
          margin: const EdgeInsets.all(20.0),
          child: Padding(
            padding: const EdgeInsets.all(16.0),
            child: SingleChildScrollView(
                child: state.when(
                    initial: () => const LoginForm(),
                    submitting: () => const CircularProgressIndicator(),
                    submitted: () {
                      return GestureDetector(
                        child: const Center(
                          child: Text('Перейти на главную страницу'),
                        ),
                        onTap: () {
                          Navigator.popAndPushNamed(
                              context, NavigationRoutes.main);
                        },
                      );
                    },
                    error: (message) => Text(message))),
          ),
        ),
      ),
    );
  }
}
