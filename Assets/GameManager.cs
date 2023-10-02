using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.UI.Image;

public class GameManager : MonoBehaviour
{

    int click = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick() {

        GameObject currentlySelectedGO = EventSystem.current.currentSelectedGameObject.gameObject;

        /*string test = currentlySelectedGO.transform.GetChild(0).GetComponent<TMP_Text>().text;
        Debug.Log("check" + test);*/
        if (click % 2 != 0)
        {
            currentlySelectedGO.transform.GetChild(0).GetComponent<TMP_Text>().text = "O";
            Debug.Log("Even");
        }
        else
        {
            currentlySelectedGO.transform.GetChild(0).GetComponent<TMP_Text>().text = "X";
            Debug.Log("Odd");
        }
        click++;

        Debug.Log("Count is" + click);

    }
}
