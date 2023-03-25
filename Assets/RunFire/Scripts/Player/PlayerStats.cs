using UnityEngine;

namespace RunFire {
    public class PlayerStats : MonoBehaviour
    {
        //===========================================//

        static private PlayerStats s_Singlton;
        static public PlayerStats Singlton { 
            get { return s_Singlton; }
        } 

        //===========================================//

        [SerializeField]
        private float m_speed;

        [SerializeField]
        private float m_jump_force;
        
        //===========================================//

        public float Speed { 
            get { return m_speed; } 
        }
        
        public float JumpForce {
            get { return m_jump_force; }
        }

        
        //===========================================//
        // Dependencies

        [SerializeField]
        private DifficultyController m_difficulty;

        
        //===========================================//

        private void Awake()
        {
            if (s_Singlton) {
                Debug.LogError("You try instantiate two or more player!");

                Destroy(gameObject);
                return;
            }
            
            s_Singlton = this;
        }

        private void FixedUpdate()
        {
            m_speed = m_difficulty.Speed();
        }
    }
}