using UnityEngine;

namespace NickKhalow
{
    public class Enemy : MonoBehaviour
    {
        public void TakeDamage(int amount)
        {
            Debug.Log($"Enemy took {amount} damage");
        }
    }
}