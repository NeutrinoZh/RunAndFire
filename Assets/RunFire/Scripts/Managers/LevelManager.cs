using UnityEngine;
using System.Collections.Generic;

namespace RunFire {
    public struct LevelParams {
        public float max_speed;
        public float velocity;
    };
    
    public class LevelManager
    {
        private static List<LevelParams> levels = new() {
            new LevelParams {
                max_speed = 5f,
                velocity = 1.0002f
            }
        };

        public static LevelParams GetLevelParams(int level) {
            return levels[level];
        } 
    }
}