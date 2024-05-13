import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:spotik_mobile/profile_page/bloc/subscription/subscription_bloc.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class SubscriptionTab extends StatefulWidget {
  const SubscriptionTab({super.key});

  @override
  State<StatefulWidget> createState() => _SubscriptionTabState();
}

class _SubscriptionTabState extends State<SubscriptionTab> {
  @override
  Widget build(BuildContext context) {
    final state = context.watch<SubcriptionBloc>().state;
    return Scaffold(
        resizeToAvoidBottomInset: false,
        backgroundColor: Colors.transparent,
        body: SingleChildScrollView(
            child: Padding(
                padding: const EdgeInsets.all(16.0),
                child: Center(
                  child: state.when(
                      initial: () => const SubscriptionForm(),
                      submitting: () => const Center(
                            heightFactor: 1,
                            widthFactor: 1,
                            child: SizedBox(
                              height: 40,
                              width: 40,
                              child: CircularProgressIndicator(
                                strokeWidth: 1.5,
                              ),
                            ),
                          ),
                      submitted: () => const Column(
                            children: [
                              Text(
                                  "The subscription has been successfully updated"),
                              SubscriptionForm(),
                            ],
                          ),
                      error: (message) => Text(message)),
                ))));
  }
}

class SubscriptionForm extends StatefulWidget {
  const SubscriptionForm({super.key});

  @override
  State<StatefulWidget> createState() => _SubscriptionFormState();
}

class _SubscriptionFormState extends State<SubscriptionForm> {
  String? _invalidMonthMessage;
  String? _invalidYearMessage;

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        const SizedBox(height: 20.0),
        TextFormField(
          decoration: const InputDecoration(
            labelText: 'Card Number',
          ),
          maxLength: 20,
          keyboardType: TextInputType.number,
          inputFormatters: <TextInputFormatter>[
            FilteringTextInputFormatter.digitsOnly,
            LengthLimitingTextInputFormatter(20),
          ],
          onChanged: (value) {
            if (value.length == 20) {
              FocusScope.of(context).nextFocus();
            }
          },
        ),
        const SizedBox(height: 20.0),
        Row(
          children: [
            Expanded(
              child: TextFormField(
                decoration: InputDecoration(
                  labelText: 'Month',
                  errorText: _invalidMonthMessage,
                ),
                keyboardType: TextInputType.number,
                inputFormatters: <TextInputFormatter>[
                  FilteringTextInputFormatter.digitsOnly,
                  LengthLimitingTextInputFormatter(2)
                ],
                maxLength: 2,
                onChanged: (value) {
                  setState(() {
                    int? month = int.tryParse(value);
                    if (month == null || month < 1 || month > 12) {
                      _invalidMonthMessage = 'Invalid month';
                    } else {
                      _invalidMonthMessage = null;
                    }
                  });
                  if (_invalidMonthMessage == null && value.length == 2) {
                    FocusScope.of(context).nextFocus();
                  }
                },
              ),
            ),
            const SizedBox(width: 16.0),
            const Text('/'),
            const SizedBox(width: 16.0),
            Expanded(
              child: TextFormField(
                decoration: InputDecoration(
                  labelText: 'Year',
                  errorText: _invalidYearMessage,
                ),
                keyboardType: TextInputType.number,
                inputFormatters: <TextInputFormatter>[
                  FilteringTextInputFormatter.digitsOnly,
                  LengthLimitingTextInputFormatter(4)
                ],
                maxLength: 4,
                onChanged: (value) {
                  setState(() {
                    int? year = int.tryParse(value);
                    if (year == null || year < DateTime.now().year) {
                      _invalidYearMessage = 'Invalid year';
                    } else {
                      _invalidYearMessage = null;
                    }
                  });
                  if (_invalidYearMessage == null && value.length == 4) {
                    FocusScope.of(context).nextFocus();
                  }
                },
              ),
            ),
          ],
        ),
        const SizedBox(height: 20.0),
        TextFormField(
          decoration: const InputDecoration(
            labelText: 'CVV',
          ),
          keyboardType: TextInputType.number,
          inputFormatters: <TextInputFormatter>[
            FilteringTextInputFormatter.digitsOnly
          ],
          obscureText: true,
          obscuringCharacter: '•',
          maxLength: 3,
          onChanged: (value) {
            if (value.length == 3) {
              FocusScope.of(context).nextFocus();
            }
          },
        ),
        const SizedBox(height: 20.0),
        Align(
            alignment: Alignment.center,
            child: Padding(
                padding: const EdgeInsets.all(20),
                child: MaterialButton(
                  color: CustomColors.backgroundButtonGrey,
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(13.0),
                  ),
                  onPressed: () => {
                    context
                        .read<SubcriptionBloc>()
                        .add(const SubscriptionEvent.subscribe(id: "Premium"))
                  },
                  child: const Text(
                    'Subscribe',
                    style: TextStyle(
                      fontSize: TextSize.smallTextSize,
                    ),
                  ),
                )))
      ],
    );
  }
}
