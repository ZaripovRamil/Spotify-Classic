import 'package:flutter/material.dart';
import 'package:spotik_mobile/utils/navigation_routes.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class SignupCard extends StatefulWidget {
  const SignupCard({super.key});

  @override
  State<SignupCard> createState() => _SignupCardState();
}

class _SignupCardState extends State<SignupCard> {
  final _formKey = GlobalKey<FormState>();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        backgroundColor: Colors.transparent,
        body: Center(
            child: Card(
              color: Colors.transparent,
              margin: const EdgeInsets.all(20.0),
              child: Container(
                color: Colors.transparent,
                padding: const EdgeInsets.all(16.0),
                child: SingleChildScrollView(
                  child: Form(
                    key: _formKey,
                    child: Theme(
                      data: Theme.of(context).copyWith(
                        inputDecorationTheme: const InputDecorationTheme(
                          fillColor: Colors.transparent,
                          filled: true,
                        ),
                      ),
                      child: Column(
                        mainAxisSize: MainAxisSize.min,
                        children: <Widget>[
                          TextFormField(
                            style: const TextStyle(color: CustomColors.goldenColor),
                            decoration: const InputDecoration(
                                labelText: 'Name',
                                labelStyle: TextStyle(
                                  color: CustomColors.goldenColor,
                                )),
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return 'Please enter your name';
                              }
                              return null;
                            },
                          ),
                          const SizedBox(height: 10),
                          TextFormField(
                            style: const TextStyle(color: CustomColors.goldenColor),
                            decoration: const InputDecoration(
                                labelText: 'Email',
                                labelStyle: TextStyle(
                                  color: CustomColors.goldenColor,
                                )),
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return 'Please enter your email';
                              }
                              // Add more complex email validation here if needed
                              return null;
                            },
                          ),
                          const SizedBox(height: 10),
                          TextFormField(
                            style: const TextStyle(color: CustomColors.goldenColor),
                            decoration: const InputDecoration(
                              labelText: 'Password',
                              labelStyle: TextStyle(
                                color: CustomColors.goldenColor,
                              ),
                            ),
                            obscureText: true,
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return 'Please enter your password';
                              }
                              // Add more complex password validation here if needed
                              return null;
                            },
                          ),
                          const SizedBox(height: 20),
                          ElevatedButton(
                            style: ButtonStyle(
                                backgroundColor: MaterialStateProperty.all<Color>(
                                    CustomColors.backgroundRadialColor)),
                            onPressed: () {
                              if (_formKey.currentState!.validate()) {
                                Navigator.popAndPushNamed(context, NavigationRoutes.main);
                              }
                            },
                            child: const Text('Signup',
                                style: TextStyle(
                                  fontSize: TextSize.mediumTextSize,
                                  fontWeight: FontWeight.bold,
                                  color: CustomColors.goldenColor,
                                )),
                          ),
                        ],
                      ),
                    ),
                  ),
                ),
              ),
        )
      )
    );
  }
}