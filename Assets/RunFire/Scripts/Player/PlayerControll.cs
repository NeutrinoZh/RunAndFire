using UnityEngine;
using System.Collections;

namespace RunFire {
    public class PlayerControll : MonoBehaviour
    {
        [SerializeField]
        private GameObject m_gameover;

        private PlayerStats m_stats; 
        private Rigidbody2D m_rd;

        [SerializeField]
        private bool m_on_ground = true;

        private void Start()
        {
            m_stats = GetComponentInParent<PlayerStats>();
            m_rd = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {   
            m_on_ground = true;
            if (other.transform.TryGetComponent(out Tile tile)) {
                if (tile.Data.Name == "Spike") {
                    m_gameover.SetActive(true);
                    StartCoroutine(OffGameOver());
                }
            }
        }

        private IEnumerator OffGameOver() {
            yield return new WaitForSeconds(2f);
            m_gameover.SetActive(false);
        }

        private void FixedUpdate()
        {
            if (Input.GetAxis("Vertical") > 0.5f)
                Jump();
        }

        // Callbacks

        public void Jump() {
            if (!m_on_ground)
                return;

            m_rd.AddForce(new Vector2(0, m_stats.JumpForce), ForceMode2D.Impulse);
            m_on_ground = false;
        }
    }
}