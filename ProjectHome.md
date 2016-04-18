**LogScrobbler** is a Windows utility written by Tim Geiges to allow users of Portable Digital Audio Players, that are running Rockbox or other firmware that generates a log file that stores which songs you have played, to later be synchronized to last.fm using my LogScrobbler Tool.


## Changelog ##

0.15 (July 2007)
  * Simplified interface
    * Track list is hidden by default unless you want to select which tracks to upload
    * Fewer options/buttons as some were redundant
  * Added status bar to track progress of log file reading/uploading
  * Customised Audioscrobbler.NET library to return a slightly more meaningful error message when an upload fails
  * Massive code cleanups

0.14c(Dec 2006)
  * Fixed exception when opening window from tray with select files left open.

0.14 (REV 57)
  * Fixed some bugs with settings path.
  * Added "Fix zero time stamps" as a one-time use button, or permanent setting(this option should help those who have players that do not time stamp the played tracks(no internal clock) this adds up the length of all the checked items, then subtracts the total from the current time and fits all the tracks up to the current time. (hope that make sense :-)).
  * widened the form as its starting to get crowded.

0.13 (REV 56)
  * Don't ask, even the version number was bad.

0.12c (REV 54)
  * fixed bug - if items are unchecked do not include them in the time shift.
  * added row colors, and unselected turn gray.

0.12 (REV 50)
  * Settings file LogScrobbler.txt should now be in app directory(not C: Let me know if this blows up)
  * Added Save password checkbox(I will encrypt soon I swear) :-)
  * Added checkbox to display Avatar or not(Runs faster off, but funner on)


0.11 (REV 45) (Skipped 0.10 felt wierd about that number for a version :-))
  * Added last.fm avatar image, and made it clickable to take you to your page.
  * Changed filter for file browse to allow for .scrobbler**.**log (for someone that said their file is .scrobbler-timeless.log) :-) (not sure this fixes all your issues)
  * (Sorry not a lot of useful stuff in this one)


0.9 (REV 40)
  * Display track length as time format xx:xx rather than total seconds in track selection listview.
  * Added setting to exit LogScrobbler instead of minimize to tray.
  * Added Close button in "Show my last posts to Last.fm" dialog.

0.8 (REV 39)
  * Added Save Settings button, (used to have to hit Go, but couldn't if there is no log file yet)
  * Added similar Last.FM skins and save the setting when switched.(doesnt affect the about screen, don't think anyone will care) ;-)


0.7
  * Added ability to see last 10 items posted to last.fm, in another little window(double click to go to the artist page)
  * Added ability to shift the time of the tracks from the log forward to after the last track posted to Last.fm
  * Added link to your last.fm in systray menu
  * minor bug fixes.


0.6
  * I think this fixes some issue with safely removing usb device.
  * added setting for exit after processing complete
  * added progress bar.
  * added this file :-)

0.5
  * added selectable list to sync
  * fixed small bugs


0.1 - 0.4
  * Don't remember all the items - started this file at 0.6 :-(
  * added about window
  * Delete file after processing option
  * Save settings


