using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    /// <summary>
    /// 觸發管理器
    /// </summary>
    public class TriggerManager : MonoBehaviour
    {
        [SerializeField, Header("物件進入觸發區域事件")]
        private UnityEvent onObjectTriggerEnter;

        private void OnTriggerEnter(Collider other)
        {
            onObjectTriggerEnter?.Invoke();
        }
    }
}

