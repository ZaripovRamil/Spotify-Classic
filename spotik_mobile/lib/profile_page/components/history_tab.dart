import 'package:flutter/material.dart';
import 'package:spotik_mobile/utils/ui_constants.dart';

class History {
  final List<HistoryItem> history;
  
  History({required this.history});
}

class HistoryItem {
  final String trackName;
  final String albumName;
  final Uri previewUrl;
  final Uri trackUrl;
  final Duration trackDuration;

  HistoryItem(
      {required this.trackName,
      required this.albumName,
      required this.previewUrl,
      required this.trackUrl,
      required this.trackDuration});
}

class HistoryTab extends StatelessWidget {
  const HistoryTab({required this.data, super.key});
  final History data;

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Align(
          alignment: Alignment.centerRight,
          child: Padding(
              padding: const EdgeInsets.all(20),
              child: MaterialButton(
                  color: CustomColors.backgroundButtonGrey,
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(13.0),
                  ),
                  onPressed: () => {},
                  child: const Text('Clear',
                      style: TextStyle(fontSize: TextSize.smallTextSize)))),
        ),
        Expanded(
          child: ListView.builder(
            itemCount: data.history.length,
            itemBuilder: (context, index) {
              final item = data.history[index];
              String duration = '${item.trackDuration.inMinutes}:'
                  '${item.trackDuration.inSeconds % 60 < 10 ? '0' : ''}'
                  '${item.trackDuration.inSeconds % 60}';
              return ListTile(
                leading: Image.asset(
                  item.previewUrl.path,
                  fit: BoxFit.cover,
                ),
                title: Text(item.trackName),
                subtitle: Text(item.albumName),
                trailing: Text(duration),
              );
            },
          ),
        ),
      ],
    );
  }
}