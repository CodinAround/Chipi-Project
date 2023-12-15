using UnityEngine;

namespace HeroicArcade.CC
{
    [RequireComponent(typeof(Collider))]
    public class Target : MonoBehaviour
    {
        [SerializeField] float healthDuration;
        [SerializeField] AudioSource hitsound;
        [SerializeField] AudioClip target;

        private void Start()
        {
            hitsound = GetComponent<AudioSource>();
        }

        public void Hit(float damageSpeed)
        {
            healthDuration -= damageSpeed * Time.deltaTime;
            hitsound.clip = target;

            hitsound.PlayOneShot(target);

            if (healthDuration <= 0)
            {
                
                Die(0); //Die with no delays
            }
        }

        public void Die(float delay)
        {
            Destroy(gameObject, delay);
        }
    }
}
