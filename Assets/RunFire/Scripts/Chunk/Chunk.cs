using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunFire {
    public class Chunk : MonoBehaviour
    {

        static readonly private float SCREEN_WIDTH = 20.5f;
        static readonly private Vector3 REINIT_POSITION = new Vector3(SCREEN_WIDTH*2, 0);  

        static private Vector3 s_direction = Vector3.zero;


        private ChunkGenerator m_generator;

        private void Awake()
        {
            m_generator = GetComponent<ChunkGenerator>();
        }

        private void Start()
        {
            m_generator.Regenerate();
        }

        private void Update()
        {
            s_direction.x = -PlayerStats.Singlton.Speed;
            transform.position += s_direction * Time.deltaTime;

            if (transform.position.x < -SCREEN_WIDTH) {
                transform.position = REINIT_POSITION;
                m_generator.Regenerate();
            }
        }
    }
}