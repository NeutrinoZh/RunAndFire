using System.Collections.Generic;
using UnityEngine;

namespace RunFire {
    [CreateAssetMenu(fileName="New TileData", menuName="TileData", order=51)]
    public class TileData : ScriptableObject
    {
        [SerializeField]
        private List<Sprite> m_variants;

        [SerializeField]
        private string m_name;

        public string Name {
            get { return m_name; }
        }

        public Sprite GetRandomSprite() {
            if (m_variants.Count == 0)
                return null;

            return m_variants[Random.Range(0, m_variants.Count)];
        }
    }
}