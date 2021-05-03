using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class Bullet : MonoBehaviour, IDamager
    {
        [SerializeField] private int _damage;
        [SerializeField] private float _velocity;
        List<BulletModifier> bulletModifiers = new List<BulletModifier>();

        public void InflictDamage(IDamageable target)
        {
            for (int i = 0; i < bulletModifiers.Count; i++)
            {
                bulletModifiers[i].InflictDamage(target);
            }
            target.ReceiveDamage(_damage);
        }

        private void Start()
        {
            //RegisterBulletModifier(new HealModifier(this, 240));
            RegisterBulletModifier(new BonusDamageModifier(this, 40));
            //RegisterBulletModifier(new PoisonModifiier(this, 5, 4));
            Destroy(gameObject, 4);
        }

        private void Update()
        {
            transform.Translate(new Vector3(0, 0, Time.deltaTime * _velocity));
        }

        public void AddDamage(int extraDamage)
        {
            _damage += extraDamage;
        }

        public void RegisterBulletModifier(BulletModifier newModifier)
        {
            bulletModifiers.Add(newModifier);
        }
    }
}
