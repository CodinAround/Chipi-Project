using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.UI;

namespace HeroicArcade.CC.Core
{
    public class enemy : MonoBehaviour
    {
        [SerializeField] FloatReference avatarCurrentEnergy = null;
        [SerializeField] FloatReference hurt = null;
        // Start is called before the first frame update
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                UpdateHealth();
            }
        }

        public void UpdateHealth()
        {
           avatarCurrentEnergy.Value = avatarCurrentEnergy.Value - hurt.Value;
        }
    }
}

