import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/auth_page/bloc/auth_bloc.dart';
import 'package:spotik_mobile/auth_page/widgets/signup_form.dart';
import 'package:spotik_mobile/utils/navigation_routes.dart';

class SignupCard extends StatefulWidget {
  const SignupCard({super.key});

  @override
  State<SignupCard> createState() => _SignupCardState();
}

class _SignupCardState extends State<SignupCard> {
  @override
  Widget build(BuildContext context) {
    final state = context.watch<AuthBloc>().state;
    return Scaffold(
      resizeToAvoidBottomInset: false,
      backgroundColor: Colors.transparent,
      body: Center(
          child: Card(
            color: Colors.transparent,
            margin: const EdgeInsets.all(20.0),
            child: Container(
              padding: const EdgeInsets.all(16.0),
              child: SingleChildScrollView(
                child: state.when(
                    initial: () => const SignUpForm(),
                    submitting: () => const CircularProgressIndicator(),
                    submitted: () {
                      Future.delayed(Duration.zero, () {
                        Navigator.popAndPushNamed(context, NavigationRoutes.main);
                      });

                      return null;
                    },
                    error: (message) {
                      return SignUpForm(errorMessage: message);
                    }
                ),
              ),
            ),
          )
      ),
    );
  }
}