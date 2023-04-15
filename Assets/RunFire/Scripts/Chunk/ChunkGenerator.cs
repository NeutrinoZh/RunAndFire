using UnityEngine;
using UnityEngine.Pool;
using System.Collections.Generic;

namespace RunFire {
    public class ChunkGenerator : MonoBehaviour
    {
        private void Awake()
        {       
            _pool = new ObjectPool<Tile>(
                () => Instantiate(m_tile_prefab).GetComponent<Tile>(), 
                obj => obj.gameObject.SetActive(true),
                obj => obj.gameObject.SetActive(false),
                obj => Destroy(obj.gameObject),
                false, 10, 10
            );
        } 

        //

        [SerializeField]
        private GameObject m_tile_prefab; 

        [SerializeField]
        private TileData m_ground;

        //

        private ObjectPool<Tile> _pool;

        public void Regenerate(Transform parent, List<Tile> tiles) {
            foreach (Tile tile in tiles)
                _pool.Release(tile);

            tiles.Clear();
            for (var i = 0; i < 10; ++i) {
                var tile = _pool.Get();

                tile.transform.parent = parent;
                tile.transform.localPosition = Vector3.zero + Vector3.left * i * 2.05f;
                tile.setSprite(m_ground.GetRandomSprite());

                tiles.Add(tile);
            }
        }
    }
}