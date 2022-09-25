using UnityEngine;

public class QuestPanel : MonoBehaviour
{
    [SerializeField] private QuestZone questZone;
    [SerializeField] private QuestText questText;
    private int progress = 0;
    private int purpose = 3;

    public void InitQuest(int purpose)
    {
        progress = 0;
        this.purpose = purpose;
        questText.SetQuestTitle($"Kill {purpose} robots");
        questText.UpdateText(progress, purpose);
        questZone.SpawnBot(purpose);
    }

    public void AddProgress()
    {
        progress++;
        questText.UpdateText(progress, purpose);
    }
}
