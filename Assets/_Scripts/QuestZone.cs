using UnityEngine;

public class QuestZone : MonoBehaviour
{
    [SerializeField] private Vector2 bounds;
    [SerializeField] private Transform botPrefab;

    public void SpawnBot(int botCount)
    {
        for(int i = 0; i < botCount; i++)
        {
            Transform newBot = Instantiate(botPrefab, transform);
            newBot.localPosition = new Vector3(Random.Range(-bounds.x, bounds.x), 0, Random.Range(-bounds.y, bounds.y));
        }
    } 
} 