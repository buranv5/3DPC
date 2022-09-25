using System;
using UnityEngine;

public class QuestObject : MonoBehaviour
{
    public Action OnDisableAction;

    private void OnDisable() =>
        OnDisableAction?.Invoke();
}
