using System;
using System.Collections.Generic;
using System.Text;

namespace LogScrobbler
{
	class TrackList : List<Track>
	{
		public TrackList()
			: base()
		{
		}

		public TrackList(int capacity)
			: base(capacity)
		{
		}

		/// <summary>
		/// Updates the TrackPlayed of all tracks, so that the last track in the list
		/// finishes at endDate, and all gaps between tracks are removed
		/// </summary>
		/// <param name="endDate"></param>
		public void ShiftTimePlayedFromEnd(DateTime endDate)
		{
			endDate = endDate.ToUniversalTime();

			// go in reverse order so we can just keep subtracting the current track's length
			for (int i = this.Count - 1; i >= 0; i--)
			{
				Track currentTrack = this[i];

				endDate = endDate.AddSeconds(-1 * currentTrack.TrackLength);

				currentTrack.ResetTimestamp(endDate);
			}
		}
	}
}
