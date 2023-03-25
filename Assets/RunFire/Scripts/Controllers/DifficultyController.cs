using UnityEngine;

namespace RunFire {
    public class DifficultyController : MonoBehaviour
    {
        public float Speed() {
            var l_params = LevelManager.GetLevelParams(0);
            float speed = PlayerStats.Singlton.Speed;

            if (speed < l_params.MaxSpeed)
                speed *= l_params.Velocity;
            else 
                speed = l_params.MaxSpeed;

            return speed;
        }
    }
}