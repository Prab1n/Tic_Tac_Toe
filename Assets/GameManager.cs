using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.UI.Image;

public class GameManager : MonoBehaviour
{
    /*public Button button;
    private bool hasBeenClicked = false;
    public Button disableButton;*/
    public List<GameObject> gameObjectList; // creating a list for storing buttons
    public List<GameObject> gameList;   //creating a list for sotring buttons after clicked
    public string gameObjectName1;      //creating a string for button 1x1 to store its text 
    public string gameObjectName2;      //creating a string for button 1x2 to store its text 
    public string gameObjectName3;      //creating a string for button 1x3 to store its text 
    public string gameObjectName4;      //creating a string for button 2x1 to store its text 
    public string gameObjectName5;      //creating a string for button 2x2 to store its text 
    public string gameObjectName6;      //creating a string for button 2x3 to store its text 
    public string gameObjectName7;      //creating a string for button 3x1 to store its text 
    public string gameObjectName8;      //creating a string for button 3x2 to store its text 
    public string gameObjectName9;      //creating a string for button 3x3 to store its text 



    int click = 0;          //setting value of click count to 0
    // Start is called before the first frame update
    void Start()
    {
       /* button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick() 
    {
        /*if (!hasBeenClicked)
        {
            hasBeenClicked = true;*/
            GameObject currentlySelectedGO = EventSystem.current.currentSelectedGameObject.gameObject;      //this gives the currently selected game object

            /*string test = currentlySelectedGO.transform.GetChild(0).GetComponent<TMP_Text>().text;
            Debug.Log("check" + test);*/
            if (click % 2 != 0)     //checking condition for even 
            {
                currentlySelectedGO.transform.GetChild(0).GetComponent<TMP_Text>().text = "O";
                Debug.Log("Even");
            }
            else        //checking condition for odd
            {
                currentlySelectedGO.transform.GetChild(0).GetComponent<TMP_Text>().text = "X";
                Debug.Log("Odd");
            }
           /* disableButton = gameList[gameList.Count-1].GetComponent<Button>();
            print("is the button disabled?" + disableButton.interactable);
            disableButton.interactable = false;*/
            click++;        //increasing the count by 1

            Debug.Log("Count is" + click);
            gameList.Add(currentlySelectedGO);      //adding the clicked button to list

            for (int i = 0; i < gameList.Count; i++)   //checking the gamelist count 
            {
                Debug.Log("checking" + i);
            }

            gameObjectName1 = gameObjectList[0].transform.GetChild(0).GetComponent<TMP_Text>().text;    //storing the 1x1 button text in gameObjectName1
            gameObjectName2 = gameObjectList[1].transform.GetChild(0).GetComponent<TMP_Text>().text;    //storing the 1x2 button text in gameObjectName2    
            gameObjectName3 = gameObjectList[2].transform.GetChild(0).GetComponent<TMP_Text>().text;    //storing the 1x3 button text in gameObjectName3
            gameObjectName4 = gameObjectList[3].transform.GetChild(0).GetComponent<TMP_Text>().text;    //storing the 2x1 button text in gameObjectName4
            gameObjectName5 = gameObjectList[4].transform.GetChild(0).GetComponent<TMP_Text>().text;    //storing the 2x2 button text in gameObjectName5
            gameObjectName6 = gameObjectList[5].transform.GetChild(0).GetComponent<TMP_Text>().text;    //storing the 2x3 button text in gameObjectName6
            gameObjectName7 = gameObjectList[6].transform.GetChild(0).GetComponent<TMP_Text>().text;    //storing the 3x1 button text in gameObjectName7
            gameObjectName8 = gameObjectList[7].transform.GetChild(0).GetComponent<TMP_Text>().text;    //storing the 3x2 button text in gameObjectName8
            gameObjectName9 = gameObjectList[8].transform.GetChild(0).GetComponent<TMP_Text>().text;    //storing the 3x3 button text in gameObjectName9


            if ((gameObjectName1 == gameObjectName2) && (gameObjectName3 == gameObjectName1) && (gameObjectName1 == "X" || gameObjectName1 == "O"))     //checking condition for winning the game
            {
                Debug.Log("Condition 1 GAME OVER !!!!");
            }
            else if ((gameObjectName1 == gameObjectName4) && (gameObjectName7 == gameObjectName1) && (gameObjectName1 == "X" || gameObjectName1 == "O"))    //checking condition for winning the game   
            {
                Debug.Log("Condition 2 GAME OVER !!!!");
            }
            else if ((gameObjectName1 == gameObjectName5) && (gameObjectName9 == gameObjectName1) && (gameObjectName1 == "X" || gameObjectName1 == "O"))    //checking condition for winning the game
            {
                Debug.Log("Condition 3 GAME OVER !!!!");
            }
            else if ((gameObjectName4 == gameObjectName5) && (gameObjectName6 == gameObjectName4) && (gameObjectName4 == "X" || gameObjectName4 == "O"))    //checking condition for winning the game
            {
                Debug.Log("Condition 4 GAME OVER !!!!");
            }
            else if ((gameObjectName7 == gameObjectName8) && (gameObjectName9 == gameObjectName7) && (gameObjectName7 == "X" || gameObjectName7 == "O"))    //checking condition for winning the game
            {
                Debug.Log("Condition 5 GAME OVER !!!!");
            }
            else if ((gameObjectName7 == gameObjectName5) && (gameObjectName3 == gameObjectName7) && (gameObjectName7 == "X" || gameObjectName7 == "O"))    //checking condition for winning the game
            {
                Debug.Log("Condition 6 GAME OVER !!!!");
            }
            else if ((gameObjectName2 == gameObjectName5) && (gameObjectName8 == gameObjectName2) && (gameObjectName2 == "X" || gameObjectName2 == "O"))    //checking condition for winning the game
            {
                Debug.Log("Condition 7 GAME OVER !!!!");
            }
            else if ((gameObjectName3 == gameObjectName6) && (gameObjectName9 == gameObjectName3) && (gameObjectName3 == "X" || gameObjectName3 == "O")) //checking condition for winning the game
            {
                Debug.Log("Condition 8 GAME OVER !!!!");
            }

           

        

        
    }
}
