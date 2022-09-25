using UnityEngine;

public class HPManager : MonoBehaviour
{
    [SerializeField] private int hp;

    public void GetDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
            Death();
    }

    private void Death() =>
        Destroy(gameObject);
} 
























//                  ≈сли € не отвечаю, значит мен€ тут нет)
//                              скоро вернусь
















