using UnityEngine;

namespace RunFire {
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField]
        private float m_speed;

        [SerializeField]
        private float m_jump_force;
        
        public float Speed { 
            get { return m_speed; } 
        }
        
        public float JumpForce {
            get { return m_jump_force; }
        }

        // Dependencies

        [SerializeField]
        private DifficultyController m_difficulty;

        //

        private void FixedUpdate()
        {
            m_speed = m_difficulty.Speed();
        }
    }
}