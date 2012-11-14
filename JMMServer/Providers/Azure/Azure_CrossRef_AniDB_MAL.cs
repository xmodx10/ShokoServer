﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using AniDBAPI;

namespace JMMServer.Providers.Azure
{
	public class CrossRef_AniDB_MAL
	{
		public int CrossRef_AniDB_MALId { get; set; }
		public int AnimeID { get; set; }
		public int MALID { get; set; }
		public int CrossRefSource { get; set; }
		public string Username { get; set; }
		public string MALTitle { get; set; }
		public int StartEpisodeType { get; set; }
		public int StartEpisodeNumber { get; set; }

		public string Self
		{
			get
			{
				return string.Format(CultureInfo.CurrentCulture, "api/crossRef_anidb_mal/{0}", this.CrossRef_AniDB_MALId);
			}
			set
			{
			}
		}
	}
}