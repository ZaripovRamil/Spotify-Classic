import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';

class TextSize {
  static const largeTextSize = 40.0;
  static const mediumTextSize = 20.0;
  static const smallTextSize = 14.0;
  static const tinyTextSize = 10.0;
}

class Fonts {
  static const String fontNameDefault = "PoiterOne";
  static const String fontNameTitle = "PPHatton";
}

class CustomColors {
  static const Color goldenColor = Color.fromRGBO(255, 197, 84, 1);
  static const Color backgroundColor = Color.fromRGBO(30, 30, 35, 1);
  static const Color backgroundRadialColor = Color.fromRGBO(246, 34, 5, 0.2);
  static const Color whiteColor = Color.fromRGBO(252, 252, 252, 1);
  static const Color subtitleColor = Color.fromRGBO(252, 252, 252, 0.65);
  static const Color errorColor = Color.fromRGBO(255, 69, 69, 0.9);
  static const Color inputBgColor = Color.fromRGBO(80, 80, 87, 0.5);
  static const Color backgroundButtonGrey = Color.fromRGBO(72, 72, 79, .95);
  static const Color playerBackgroundColor = Color.fromRGBO(19, 19, 22, 1);
}

class CustomDecorations {
  static const BoxDecoration backgroundDecoration = BoxDecoration(
            gradient: RadialGradient(colors: [
          CustomColors.backgroundRadialColor,
          CustomColors.backgroundColor
        ], center: Alignment(-1, -1.8), radius: 2));

}


class CustomIcons {
  CustomIcons._();

  static const _kFontFam = 'CustomIcons';
  static const String? _kFontPkg = null;

  static const IconData album_like_icon = IconData(0xe802, fontFamily: _kFontFam, fontPackage: _kFontPkg);
  static const IconData album_play_icon = IconData(0xf144, fontFamily: _kFontFam, fontPackage: _kFontPkg);
}
