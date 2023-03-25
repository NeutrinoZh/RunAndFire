using UnityEngine;

namespace RunFire {
    public class PlayerControll : MonoBehaviour
    {
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