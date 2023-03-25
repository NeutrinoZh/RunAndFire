using UnityEngine;
using System.Collections.Generic;

namespace RunFire {
    public class LevelManager : MonoBehaviour
    {
        private static LevelManager Singlton;

        private void Start()
        {
            if (Singlton) {
                Destroy(gameObject);
                return;
            }

            Singlton = this;
            DontDestroyOnLoad(gameObject);
        }

        [SerializeField]
        private List<LevelData> levels = new() {};
    
        public static LevelData GetLevelParams(int id) {
            return Singlton.levels[id];
        }
    }
}