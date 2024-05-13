import 'package:flutter/material.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

ThemeData customTheme() => ThemeData(
    scaffoldBackgroundColor: CustomColors.backgroundColor,
    fontFamily: Fonts.fontNameTitle,
    brightness: Brightness.dark,
    textTheme: const TextTheme(
      displayLarge: TextStyle(
          fontSize: TextSize.largeTextSize, color: CustomColors.goldenColor),
      displayMedium: TextStyle(
          fontSize: TextSize.mediumTextSize, color: CustomColors.whiteColor),
      displaySmall: TextStyle(
          fontSize: TextSize.smallTextSize, color: CustomColors.whiteColor),
    ),
    iconTheme: const IconThemeData(color: CustomColors.goldenColor),
    primaryColor: CustomColors.whiteColor,
    buttonTheme: const ButtonThemeData(
        buttonColor: CustomColors.inputBgColor,
        textTheme: ButtonTextTheme.primary),
    sliderTheme: SliderThemeData(
        overlayShape: SliderComponentShape.noOverlay,
        // thumbShape: SliderComponentShape.noThumb,
        thumbShape: const RoundSliderThumbShape(enabledThumbRadius: 0),
        activeTrackColor: CustomColors.whiteColor,
        trackHeight: 5
        ));
