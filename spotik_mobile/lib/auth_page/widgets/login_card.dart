import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/auth_page/bloc/auth_bloc.dart';
import 'package:spotik_mobile/auth_page/widgets/login_form.dart';
import 'package:spotik_mobile/utils/navigation_routes.dart';

class LoginCard extends StatefulWidget {
  const LoginCard({super.key});

  @override
  State<LoginCard> createState() => _LoginCardState();
}

class _LoginCardState extends State<LoginCard> {
  String? errorMessage = '';

  @override
  Widget build(BuildContext context) {
    final state = context.watch<AuthBloc>().state;
    return Scaffold(
      backgroundColor: Colors.transparent,
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Card(
              color: Colors.transparent,
              margin: const EdgeInsets.all(20.0),
              child: Padding(
                padding: const EdgeInsets.all(16.0),
                child: SingleChildScrollView(
                  child: state.when(
                    initial: () => const LoginForm(),
                    submitting: () => const CircularProgressIndicator(),
                    submitted: () {
                      Future.delayed(Duration.zero, () {
                        Navigator.popAndPushNamed(context, NavigationRoutes.main);
                      });

                      return null;
                    },
                    error: (message) {
                      setState(() {
                        errorMessage = message;
                      });
                      return const LoginForm();
                    }
                  ),
                ),
              ),
            ),
            Text(errorMessage ?? '', style: const TextStyle(color: Colors.red))
          ]
        )
      ),
    );
  }
}
