using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private Button button;
    private bool hasBeenClicked = false;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (!hasBeenClicked)
        {
            // Perform the button's action here

            // Disable the button after it's clicked
            button.interactable = false;

            // Set the flag to indicate that the button has been clicked
            hasBeenClicked = true;
        }
    }
}
