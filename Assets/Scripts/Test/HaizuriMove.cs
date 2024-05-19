using Enemy.Getter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public class HaizuriMove : MonoBehaviour
    {
        [SerializeField] float speed;
        HaizuriGetter haizuri;

        void Start()
        {
            haizuri = GameObject.FindGameObjectWithTag("Enemy_Haizuri").GetComponent<HaizuriGetter>();

            haizuri.Rb.useGravity = false;
        }

        void Update()
        {
            haizuri.Tf.position += speed * Time.deltaTime * Vector3.right;
        }
    }
}
