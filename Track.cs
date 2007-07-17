using System;
using System.Collections.Generic;
using System.Text;
using Audioscrobbler.NET;

namespace LogScrobbler
{
	public struct TrackStatusType
	{
		public const string Logged = "L";
		public const string Skipped = "S";
	}

	public class Track : AudioscrobblerTrack, IComparable<Track>
	{
		#region Private members

		private string trackNumber = "";
		private string trackStatus = TrackStatusType.Logged;
		private long timestamp = 0;
		private string timePlayed = "";

		// epoch is used to create DateTimes from timestamps (seconds since 1/1/1970)
		private static DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		#endregion

		#region Properties

		public string TimePlayed
		{
			get { return timePlayed; }
			set { timePlayed = value; }
		}

		/// <summary>
		/// Returns the track length in "m:ss" format
		/// </summary>
		public string TrackLengthAsString
		{
			get { return string.Format("{0}:{1:00}", (TrackLength / 60), (TrackLength % 60)); }
		}

		/// <summary>
		/// Returns the TrackPlayed datetime in "yyyy-MM-dd HH:mm:ss" format
		/// </summary>
		public string TrackPlayedAsString
		{
			get { return TrackPlayed.ToString("yyyy-MM-dd HH:mm:ss"); }
		}

		public long Timestamp
		{
			get { return timestamp; }
			set
			{
				timestamp = value;
				ResetTrackPlayed();
			}
		}

		public string TrackStatus
		{
			get { return trackStatus; }
			set { trackStatus = value; }
		}

		public string TrackNumber
		{
			get { return trackNumber; }
			set { trackNumber = value; }
		}

		#endregion

		/// <summary>
		/// Parses a string and returns a new Track object.
		/// </summary>
		/// <param name="trackString">
		/// Tab-delimitted string. Should be of the form:
		/// "%ARTIST% %ALBUM% %TRACKNAME% %TRACKNUMBER% %TRACKLENGTH% %STATUS% %TIMESTAMP%"
		/// (spaces are tabs)
		/// </param>
		/// <returns>Track object if successful, or null if line was a comment. Erroneous formatting causes a FormatException.</returns>
		public static Track ParseTrack(string trackString)
		{
			// if the line is a comment, return null
			if (trackString.StartsWith("#"))
				return null;

			Track t = new Track();

			// split line into fields separated by tabs
			string[] fields = trackString.Split('\t');

			// if there are too few fields, throw exception
			// (if there's too many we'll just use the first 7)
			if (fields.Length < 7)
				throw new ArgumentException(string.Format("Incorrect number of fields in log line: {0}", trackString));

			t.ArtistName = fields[0];
			t.AlbumName = fields[1];
			t.TrackName = fields[2];
			t.TrackNumber = fields[3];
			t.TrackLength = int.Parse(fields[4]);
			t.TrackStatus = fields[5];
			t.Timestamp = long.Parse(fields[6]);

			return t;
		}

		/// <summary>
		/// Resets the timestamp using a DateTime instead of just seconds
		/// </summary>
		/// <param name="d"></param>
		public void ResetTimestamp(DateTime d)
		{
			// calculate the number of seconds between 'd' and epoch
			d = d.ToUniversalTime();
			TimeSpan ts = d.Subtract(epoch);
			Timestamp = (long)ts.TotalSeconds;
		}

		private void ResetTrackPlayed()
		{
			TrackPlayed = epoch.AddSeconds(Convert.ToDouble(Timestamp)).ToUniversalTime();
		}

		/// <summary>
		/// Compares two Track objects by their Timestamp
		/// </summary>
		/// <param name="otherTrack"></param>
		/// <returns></returns>
		public int CompareTo(Track otherTrack)
		{
			return this.Timestamp.CompareTo(otherTrack.Timestamp);
		}

		
	}
}
