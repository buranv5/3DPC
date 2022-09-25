using UnityEngine;

public class QuestText : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text text;
    private string questTitle;

    public void SetQuestTitle(string newQuestTitle)
    {
        questTitle = newQuestTitle;
        Debug.Log(questTitle);
    }

    public void UpdateText(int progress, int purpose)
    {
        text.text = $"{questTitle}\n{progress}/{purpose}";
    }
}
