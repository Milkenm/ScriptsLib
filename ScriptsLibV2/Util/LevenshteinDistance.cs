using System;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		/// <summary>
		/// Returns the number of steps required to transform the source string into the target string.
		/// </summary>
		/// <remarks>From: <see href="https://social.technet.microsoft.com/wiki/contents/articles/26805.c-calculating-percentage-similarity-of-2-strings.aspx"/></remarks>
		public static int CalculateLevenshteinDistance(string source, string target)
		{
			NullChecker((source, target));
			if ((source.Length == 0) || (target.Length == 0)) return 0;
			if (source == target) return source.Length;

			int sourceWordCount = source.Length;
			int targetWordCount = target.Length;

			// Step 1
			if (sourceWordCount == 0)
			{
				return targetWordCount;
			}
			if (targetWordCount == 0)
			{
				return sourceWordCount;
			}

			int[,] distance = new int[sourceWordCount + 1, targetWordCount + 1];

			// Step 2
			for (int i = 0; i <= sourceWordCount; distance[i, 0] = i++) ;
			for (int j = 0; j <= targetWordCount; distance[0, j] = j++) ;

			for (int i = 1; i <= sourceWordCount; i++)
			{
				for (int j = 1; j <= targetWordCount; j++)
				{
					// Step 3
					int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

					// Step 4
					distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
				}
			}

			return distance[sourceWordCount, targetWordCount];
		}

		/// <summary>
		/// Calculate percentage similarity of two strings
		/// </summary>
		/// <param name="source">Source String to Compare with</param>
		/// <param name="target">Targeted String to Compare</param>
		/// <returns>Return Similarity between two strings from 0 to 1.0</returns>
		/// <remarks>From: <see href="https://social.technet.microsoft.com/wiki/contents/articles/26805.c-calculating-percentage-similarity-of-2-strings.aspx"/></remarks>
		public static double CalculateLevenshteinSimilarity(string source, string target)
		{
			NullChecker((source, target));
			if ((source.Length == 0) || (target.Length == 0)) return 0D;
			if (source == target) return 1D;

			int stepsToSame = CalculateLevenshteinDistance(source, target);
			return 1D - (stepsToSame / (double)Math.Max(source.Length, target.Length));
		}
	}
}
