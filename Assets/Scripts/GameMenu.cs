using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMenu : MonoBehaviour {

    public Canvas startMenu;
    public Button spinDetectionText;
    public Button exitText;
    

    //Use this for initialization
    void Start () {

        startMenu = startMenu.GetComponent<Canvas>();

        spinDetectionText = spinDetectionText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();

    }
	
	public void spinDetectionPressed()
    {
        Application.LoadLevel(1);
    }

    public void exitGame()
    {

        Application.Quit();


    }


}
