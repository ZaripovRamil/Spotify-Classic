import 'package:flutter/material.dart';
import 'package:spotik_mobile/home_page/home_page.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class AuthPage extends StatelessWidget {
  const AuthPage({super.key});

  @override
  Widget build(BuildContext context) {
    return DefaultTabController(
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
        body: TabBarView(
          children: [
            LoginCard(),
            SignupCard(),
          ],
        ),
      ),
    );
  }
}

class SignupCard extends StatelessWidget {
  SignupCard({super.key});

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
                            Navigator.of(context).pop();
                            Navigator.push(
                              context,
                              MaterialPageRoute(
                                  builder: (context) => const HomePage()),
                            );
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
        )));
  }
}

class LoginCard extends StatelessWidget {
  LoginCard({super.key});

  final _formKey = GlobalKey<FormState>();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.transparent,
      body: Center(
        child: Card(
          color: Colors.transparent,
          margin: const EdgeInsets.all(20.0),
          child: Padding(
            padding: const EdgeInsets.all(16.0),
            child: SingleChildScrollView(
              child: Form(
                key: _formKey,
                child: Column(
                  mainAxisSize: MainAxisSize.min,
                  children: <Widget>[
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
                          )),
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
                          Navigator.of(context).pop();
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) => const HomePage()),
                          );
                        }
                      },
                      child: const Text('Login',
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
      ),
    );
  }
}
