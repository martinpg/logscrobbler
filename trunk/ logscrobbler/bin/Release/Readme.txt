LogScrobbler is a small application that is intended to sync your .scrobbler.log files from portable audio players to last.fm
it is written in C# .NET 2.0.

I wrote this for myself to sync my logs, thought some others might also find it useful, please use at your own risk, as I will not be responsible for any damage this may cause to your computer, audio player, or any other device, software, or anything.

Thanks,

kernelsandirs@gmail.com
Email with any suggestions or feedback.
============================================

Changelog:
0.12c
x fixed bug - if items are unchecked do not include them in the time shift.
+ added row colors, and unselected turn gray.

0.12
+ Settings file LogScrobbler.txt should now be in app directory(not C: Let me know if this blows up)
+ Added Save password checkbox(I will encrypt soon I swear) :-)
+ Added checkbox to display Avatar or not(Runs faster off, but funner on)


0.11 (REV 45)
  (Skipped 0.10 felt wierd about that number for a version :-))
+ Added last.fm avatar image, and made it clickable to take you to your page.
o Changed filter for file browse to allow for .scrobbler*.*log (for someone that said their file is .scrobbler-timeless.log) :-) (not sure this fixes all your issues)
  (Sorry not a lot of useful stuff in this one)


0.9 (REV 40)
+ Display track length as time format xx:xx rather than total seconds in track selection listview.
+ Added setting to exit LogScrobbler instead of minimize to tray.
+ Added Close button in "Show my last posts to Last.fm" dialog.

0.8 (REV 39)
+ Added Save Settings button, (used to have to hit Go, but couldn't if there is no log file yet)
+ Added similar Last.FM skins and save the setting when switched.(doesnt affect the about screen, don't think anyone will care) ;-)


0.7
+ Added ability to see last 10 items posted to last.fm, in another little window(double click to go to the artist page)
+ Added ability to shift the time of the tracks from the log forward to after the last track posted to Last.fm
+ Added link to your last.fm in systray menu
X minor bug fixes.
 

0.6
x I think this fixes some issue with safely removing usb device.
+ added setting for exit after processing complete
+ added progress bar.
+ added this file :-)

0.5
+ added selectable list to sync
x fixed small bugs


0.1 - 0.4 
Don't remember all the items - started this file at 0.6 :-(
+ added about window
+ Delete file after processing option
+ Save settings

