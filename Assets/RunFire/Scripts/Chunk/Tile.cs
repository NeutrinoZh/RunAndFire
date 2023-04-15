using UnityEngine;

namespace RunFire {
    public class Tile : MonoBehaviour
    {
        private SpriteRenderer m_renderer; 

        private void Awake() {
            m_renderer = GetComponent<SpriteRenderer>();
        }  

        //===================API======================//

        public void setSprite(Sprite sprite) {
            m_renderer.sprite = sprite;
        } 
    }
}