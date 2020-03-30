using System;
using System.Collections.Generic;
using UnityEngine;

namespace FineRoadAnarchy
{
    public class PrefabUtil
    {
        //from NoPillars
        public static HashSet<NetInfo> GetAllPrefabs()
        {
            var result = new HashSet<NetInfo>();
            foreach (var prefab in Resources.FindObjectsOfTypeAll<NetInfo>())
            {
                result.Add(prefab);
            }
            return result;
        }
    }
}
