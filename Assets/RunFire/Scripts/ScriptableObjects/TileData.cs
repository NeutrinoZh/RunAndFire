using System.Collections.Generic;
using UnityEngine;

namespace RunFire {
    [CreateAssetMenu(fileName="New TileData", menuName="TileData", order=51)]
    public class TileData : ScriptableObject
    {
        [SerializeField]
        private List<Sprite> m_variants;
    }
}