using UnityEngine;

namespace RunFire {
    public class DifficultyController : MonoBehaviour
    {
        [SerializeField]
        private PlayerStats m_player;

        public float Speed() {
            var l_params = LevelManager.GetLevelParams(0);
            float speed = m_player.Speed;

            if (speed < l_params.max_speed)
                speed *= l_params.velocity;
            else 
                speed = l_params.max_speed;

            return speed;
        }
    }
}