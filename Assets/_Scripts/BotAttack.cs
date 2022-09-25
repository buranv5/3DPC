using UnityEngine;
using System.Collections;

public class BotAttack : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float hitDelay;

    private HPManager target;

    private void Start()
    {
        StartCoroutine(Fight());
    }

    private void SetTarget(HPManager newTarget)
    {
        target = newTarget;
    }

    public IEnumerator Fight()
    {
        while (true)
        {
            Hit();
            yield return new WaitForSeconds(hitDelay);
        }
    }

    private void Hit()
    {
        target.GetDamage(damage);
    }
}
