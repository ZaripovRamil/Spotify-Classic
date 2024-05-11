import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/auth_page/bloc/auth_bloc.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class SignUpForm extends StatefulWidget {
  const SignUpForm({super.key, this.errorMessage});

  final String? errorMessage;

  @override
  State<SignUpForm> createState() => _SignUpFormState();
}

class _SignUpFormState extends State<SignUpForm> {
  final _formKey = GlobalKey<FormState>();

  String name = '', email = '', login = '', password = '';

  @override
  void dispose() {
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Form(
      key: _formKey,
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: <Widget>[
          TextFormField(
            onChanged: (value) {
              setState(() {
                name = value;
              });
            },
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
            onChanged: (value) {
              email = value;
            },
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
            onChanged: (value) {
              login = value;
            },
            style: const TextStyle(color: CustomColors.goldenColor),
            decoration: const InputDecoration(
                labelText: 'Login',
                labelStyle: TextStyle(
                  color: CustomColors.goldenColor,
                )),
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Please enter your login';
              }
              // Add more complex email validation here if needed
              return null;
            },
          ),
          const SizedBox(height: 10),
          TextFormField(
            onChanged: (value) {
              password = value;
            },
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
          Text(widget.errorMessage ?? '', style: const TextStyle(color: Colors.red)),
          ElevatedButton(
            style: ButtonStyle(
                backgroundColor: MaterialStateProperty.all<Color>(
                    CustomColors.backgroundRadialColor)),
            onPressed: () async {
              if (_formKey.currentState!.validate()) {
                await _submitForm(context, name, email, login, password);
              }
            },
            child: const Text('Signup',
                style: TextStyle(
                  fontSize: TextSize.mediumTextSize,
                  fontWeight: FontWeight.bold,
                  color: CustomColors.goldenColor,
                )),
          )
        ],
      ),
    );
  }
}

Future<void> _submitForm(BuildContext context, String name, String email, String login, String password) async {
  context.read<AuthBloc>().add(
      AuthEvent.signup(email: email, login: login, name: name, password: password));
}