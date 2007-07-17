using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Xml;

namespace LogScrobbler
{
	class AudioscrobblerWebServices
	{
		/// <summary>
		/// Returns a list of the 10 most recently scrobbled tracks for this user (most recently played first).
		/// Information is retrieved from:
		/// http://ws.audioscrobbler.com/1.0/user/USERNAME/recenttracks.xml
		/// </summary>
		/// <param name="userName"></param>
		/// <returns></returns>
		public static TrackList GetRecentTracks(string userName)
		{
			if (string.IsNullOrEmpty(userName))
				throw new ArgumentException("Invalid username", userName);

			string recentTracksUrl = string.Format(@"http://ws.audioscrobbler.com/1.0/user/{0}/recenttracks.xml", userName);

			// create an XmlDocument from the url
			XmlDocument xmlDoc = new XmlDocument();
			using (XmlReader xmlReader = XmlReader.Create(recentTracksUrl))
			{
				xmlDoc.Load(xmlReader);
			}

			// xml will be of this format:
			//
			//<recenttracks user="kernelsandirs">
			//  <track streamable="false">
			//    <artist mbid="">National, The</artist>
			//    <name>Thirsty</name>
			//    <mbid/>
			//    <album mbid=""/>
			//    <url>http://www.last.fm/music/National%2C+The/_/Thirsty</url>
			//    <date uts="1184470533">15 Jul 2007, 03:35</date>
			//  </track>
			//  ...
			//</recenttracks>

			TrackList trackList = new TrackList();

			// get all the "track" nodes
			foreach (XmlNode xmlNode in xmlDoc.GetElementsByTagName("track"))
			{
				Track currentTrack = new Track();

				// parse all the child nodes to extract the Track information
				foreach (XmlNode childNode in xmlNode.ChildNodes)
				{
					string nodeName = childNode.Name.ToLower();

					switch (nodeName)
					{
						case "artist":
							currentTrack.ArtistName = childNode.InnerText;
							break;

						case "name":
							currentTrack.TrackName = childNode.InnerText;
							break;

						case "album":
							currentTrack.AlbumName = childNode.InnerText;
							break;

						case "date":
							currentTrack.Timestamp = long.Parse(childNode.Attributes["uts"].Value);
							break;
					}
				}

				trackList.Add(currentTrack);
			}

			return trackList;
		}
	}
}
