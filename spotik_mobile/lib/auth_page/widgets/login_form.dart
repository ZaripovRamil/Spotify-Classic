import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/auth_page/bloc/auth_bloc.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class LoginForm extends StatefulWidget {
  const LoginForm({super.key});

  @override
  State<LoginForm> createState() => _LoginFormState();
}

class _LoginFormState extends State<LoginForm> {
  final _formKey = GlobalKey<FormState>();

  final _emailController = TextEditingController();

  final _passwordController = TextEditingController();

  @override
  void dispose() {
    _emailController.dispose();
    _passwordController.dispose();
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
            style: const TextStyle(color: CustomColors.goldenColor),
            controller: _emailController,
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
            controller: _passwordController,
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
            onPressed: () async {
              if (_formKey.currentState!.validate()) {
                await _submitForm(
                    context, _emailController.text, _passwordController.text);
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
    );
  }
}

Future<void> _submitForm(BuildContext context, String email, String password) async {
    context.read<AuthBloc>().add(AuthEvent.login(email: email, password: password));
    
  }

