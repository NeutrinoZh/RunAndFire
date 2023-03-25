using UnityEngine;

namespace RunFire {
    [CreateAssetMenu(fileName="New LevelData", menuName="LevelData", order=51)]
    public class LevelData : ScriptableObject {
        [SerializeField]
        private float m_max_speed;
        
        [SerializeField]
        private float m_velocity;
    
        public float MaxSpeed {
            get { return m_max_speed; }  
         }

        public float Velocity {
            get { return m_velocity; }  
        }
    };
}