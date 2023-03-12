using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnterButtonPress : MonoBehaviour
{
    public Button selectedButton;

    private EventSystem eventSystem;

    private void Start()
    {
        eventSystem = EventSystem.current;
        if (selectedButton != null)
        {
            eventSystem.SetSelectedGameObject(selectedButton.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (selectedButton != null)
            {
                selectedButton.onClick.Invoke();
            }
        }
    }
}
