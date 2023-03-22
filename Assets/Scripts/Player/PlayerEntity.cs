using UnityEngine;

namespace Player
{
    public class PlayerEntity : MonoBehaviour
    {
        [SerializeField] private float Speed = 5f;

        private Rigidbody2D _rigidbody2D;
        void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

    
        void Update()
        {
        
        }

        public void Move(Vector2 movement)
        {
            _rigidbody2D.MovePosition(_rigidbody2D.position + movement * (Speed * Time.fixedDeltaTime));
        }
    }
}
