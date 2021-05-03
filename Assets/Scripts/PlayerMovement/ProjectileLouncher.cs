using UnityEngine;

namespace Tutorials
{
    public class ProjectileLouncher : MonoBehaviour
    {
        [SerializeField] private Rigidbody projectilePrefab;
        [SerializeField] private Transform weaponMountPoint;
        [SerializeField] private float fireForce = 300f;
        //private Transform _bulletCasher;

        private void Awake()
        {
            //GameObject _bulletCasher = new GameObject();
            //_bulletCasher.name = "_bulletCasher";

            GetComponent<GetPlayerInput>().OnFire += HandleFire;
        }

        private void HandleFire()
        {
            var spawnedProjectile = Instantiate(projectilePrefab, weaponMountPoint.position, weaponMountPoint.rotation);
            //var spawnedProjectile = Instantiate(projectilePrefab, weaponMountPoint.position, weaponMountPoint.rotation, _bulletCasher);

            spawnedProjectile.AddForce(spawnedProjectile.transform.forward * fireForce);
        }
    }
}
