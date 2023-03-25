using UnityEngine;
using UnityEngine.Pool;

namespace RunFire {
    public class ChunkGenerator : MonoBehaviour
    {
        // Parent for generate objects
        private Transform m_parent;

        private void Awake()
        {
            m_parent = transform.GetChild(0);       
            
            _pool = new ObjectPool<GameObject>(
                () => Instantiate(m_tile), 
                obj => obj.SetActive(true),
                obj => obj.SetActive(false),
                obj => Destroy(obj),
                false, 10, 10
            );
        } 

        //

        [SerializeField]
        private GameObject m_tile; 

        [SerializeField]
        private TileData m_ground;

        //

        private ObjectPool<GameObject> _pool;

        public void Regenerate() {
            for (var i = 0; i < 10; ++i) {
                var tile = _pool.Get();
                tile.transform.parent = m_parent;
                tile.transform.localPosition = Vector3.zero + Vector3.left * i * 2.05f;
            }
        }
    }
}