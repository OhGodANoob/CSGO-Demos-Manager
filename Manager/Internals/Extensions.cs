﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Manager.Internals
{
	public static class Extensions
	{
		public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> items, int maxItems)
		{
			return items.Select((item, inx) => new { item, inx })
				.GroupBy(x => x.inx / maxItems)
				.Select(g => g.Select(x => x.item));
		}

		public static bool Contains(this string source, string toCheck, StringComparison comp)
		{
			return source.IndexOf(toCheck, comp) >= 0;
		}
	}
}
