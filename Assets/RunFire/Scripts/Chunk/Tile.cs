using UnityEngine;

namespace RunFire {
    public class Tile : MonoBehaviour
    {
        private SpriteRenderer m_renderer; 
        private TileData m_data;

        private void Awake() {
            m_renderer = GetComponent<SpriteRenderer>();
        }  

        //===================API======================//

        public TileData Data {
            get { return m_data; }
            set { m_data = value; }
        }

        public void setSprite(Sprite sprite) {
            m_renderer.sprite = sprite;
        } 
    }
}