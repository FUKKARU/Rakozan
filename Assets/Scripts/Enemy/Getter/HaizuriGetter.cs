using UnityEngine;

namespace Enemy.Getter
{
    public class HaizuriGetter : MonoBehaviour
    {
        [SerializeField] GameObject self;
        public GameObject Self => self;

        [SerializeField] Transform tf;
        public Transform Tf => tf;

        [SerializeField] Collider coll;
        public Collider Coll => coll;

        [SerializeField] Rigidbody rb;
        public Rigidbody Rb => rb;

        [SerializeField] Animator anim;
        public Animator Anim => anim;

        [SerializeField] GameObject model;
        public GameObject Model => model;

        [SerializeField] GameObject smoke;
        public GameObject Smoke => smoke;
    }
}
