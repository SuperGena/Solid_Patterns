using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [SerializeField] private int _maxHealth = 100;
        [SerializeField] private int _health;
        private int waitOneSecond = 1;


        public event Action OnDie = delegate { };

        private void Awake()
        {
            _health = _maxHealth;
        }

        private void Die()
        {
            OnDie();
            Destroy(gameObject);
        }

        public void ReceiveDamage(int damage)
        {
            _health -= damage;
            if (_health <= 0)
                Die();
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
                _health -= damage;
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            var projectile = collision.collider.GetComponent<Bullet>();
            if (projectile != null)
            {
                //TakeDamage(projectile.);
            }


        }

        private void OnTriggerEnter(Collider other)
        {
            var bullet = other.GetComponent<Bullet>();
            if (bullet)
            {
                bullet.InflictDamage(this);
                //Debug.Log("HP = " + _health);
            }
        }
    }
}
