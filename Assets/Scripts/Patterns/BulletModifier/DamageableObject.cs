using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class DamageableObject : MonoBehaviour, IDamageable
    {
        [SerializeField] private int _hp;
        [SerializeField] private GameObject _bullet;
        WaitForSeconds waitOneSecond = new WaitForSeconds(1);

        private void Start()
        {
            Debug.Log("HP = " + _hp);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(_bullet, new Vector3(0, 1.5f, -7), Quaternion.identity);
            }

            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
        }

        public void ReceiveDamage(int damage)
        {
            _hp -= damage;
        }

        public void ReceiveDamageOverTime(int damage, int duration)
        {
            StartCoroutine(DamageOverTime(damage, duration));
        }

        IEnumerator DamageOverTime(int damage, int duration)
        {
            for (int i = 0; i < duration; i++)
            {
                yield return waitOneSecond;
                _hp -= damage;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Bullet bullet = other.GetComponent<Bullet>();
            if (bullet)
            {
                bullet.InflictDamage(this);
                Debug.Log("HP = " + _hp);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            var bullet = collision.gameObject.GetComponent<Bullet>();
            if (bullet)
            {
                bullet.InflictDamage(this);
                Debug.Log("HP = " + _hp);
            }
        }
    }
}
