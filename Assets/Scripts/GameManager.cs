using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    public class GameManager : MonoBehaviour
    {

        [SerializeField, Header("�C���q�L�ƥ�")]
        private UnityEvent onGamePass;

        private bool getKey;

        public void GetKey(GameObject key)
        {
            if (!getKey)
            {
                getKey = true;

                Destroy(key);
            }
        }

        public void GameOver()
        {
            if (getKey)
            {
                onGamePass?.Invoke();
            }
        }
    }
}

