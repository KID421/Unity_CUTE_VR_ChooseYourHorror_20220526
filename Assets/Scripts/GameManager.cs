using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    public class GameManager : MonoBehaviour
    {

        [SerializeField, Header("遊戲通過事件")]
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

