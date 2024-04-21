import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

import '../utils/ui_constants.dart';

class SubscriptionPage extends StatefulWidget {
  const SubscriptionPage({super.key});

  @override
  State<StatefulWidget> createState() => _SubscriptionPageState();
}

class _SubscriptionPageState extends State<SubscriptionPage> {
  String? _invalidMonthMessage;
  String? _invalidYearMessage;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset : false,
      backgroundColor: Colors.transparent,
      appBar: AppBar(
        backgroundColor: Colors.transparent,
        title: const Text('Subscription'),
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.all(16.0),
          child: Column(
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
                    onPressed: () => {},
                    child: const Text(
                      'Subscribe',
                      style: TextStyle(
                        fontSize: TextSize.smallTextSize,
                      ),
                    ),
                  )
                )
              )
            ],
          )
        )
      ),
    );
  }
}
