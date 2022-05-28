using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    /// <summary>
    /// Ĳ�o�޲z��
    /// </summary>
    public class TriggerManager : MonoBehaviour
    {
        [SerializeField, Header("����i�JĲ�o�ϰ�ƥ�")]
        private UnityEvent onObjectTriggerEnter;

        private void OnTriggerEnter(Collider other)
        {
            onObjectTriggerEnter?.Invoke();
        }
    }
}

