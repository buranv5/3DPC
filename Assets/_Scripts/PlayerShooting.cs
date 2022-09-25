using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private new Camera camera;
    [SerializeField] private QuestPanel questPanel;
    [SerializeField] private int damage;
    [SerializeField] private float distance;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            if (Physics.Raycast(camera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2)), out RaycastHit hit))
                if(hit.transform.TryGetComponent(out QuestObject questObject))
                {
                    questObject.OnDisableAction += () => questPanel.AddProgress();
                    if(Vector3.Distance(transform.position, hit.transform.position) <= distance)
                        questObject.GetComponent<HPManager>().GetDamage(damage);
                }

    }
}
