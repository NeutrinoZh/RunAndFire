using UnityEngine;

namespace RunFire {
    public class World : MonoBehaviour
    {
        private const float SCREEN_WIDTH = 20.8f;

        [SerializeField]
        private PlayerStats m_player;

        private Vector3 m_direction = Vector3.zero;

        private Transform[] m_chunks = {null, null};

        private void Start()
        {
            m_chunks[0] = transform.Find("Chunk-0"); 
            m_chunks[1] = transform.Find("Chunk-1");
        }

        private void Update()
        {
            m_direction.x = -m_player.Speed;
            transform.position += m_direction * Time.deltaTime;

            if (transform.position.x < -SCREEN_WIDTH)
                transform.position = Vector3.zero;
        }
    }
}