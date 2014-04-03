//
// https://github.com/mythz/NServiceKit.Redis
// NServiceKit.Redis: ECMA CLI Binding to the Redis key-value storage system
//
// Authors:
//   Demis Bellot (demis.bellot@gmail.com)
//
// Copyright 2013 ServiceStack.
//
// Licensed under the same terms of Redis and ServiceStack: new BSD license.
//

using System.Collections.Generic;
using NServiceKit.DesignPatterns.Model;
#if WINDOWS_PHONE
using NServiceKit.Text.WP;
#endif

namespace NServiceKit.Redis
{
	public interface IRedisSet
		: ICollection<string>, IHasStringId
	{
		List<string> GetRangeFromSortedSet(int startingFrom, int endingAt);
		HashSet<string> GetAll();
		string Pop();
		void Move(string value, IRedisSet toSet);
		HashSet<string> Intersect(params IRedisSet[] withSets);
		void StoreIntersect(params IRedisSet[] withSets);
		HashSet<string> Union(params IRedisSet[] withSets);
		void StoreUnion(params IRedisSet[] withSets);
		HashSet<string> Diff(IRedisSet[] withSets);
		void StoreDiff(IRedisSet fromSet, params IRedisSet[] withSets);
		string GetRandomEntry();
	}
}