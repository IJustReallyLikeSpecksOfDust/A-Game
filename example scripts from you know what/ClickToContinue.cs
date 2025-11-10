using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //You MUST include this if you want to work with scenes / change scenes
using UnityEngine.UI; //You MUST include this to work with User Interfaces (buttons in this case)

public class ClickToContinue : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>(); //Stores a button in the 'btn' variable
		btn.onClick.AddListener(TaskOnClick); //Checks to see if the Play button is clicked.
	}

	void TaskOnClick()
	{
		//	SceneManager.LoadScene("Level_1"); //Loads Level 1 if the button is clicked
		LoadNextScene(); //Loads next scene
	}
    public void LoadNextScene() //this code is just taken from NextLevel.cs because its more versatile.
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1; //Gets the next scene

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings){ //If there is another scene
            SceneManager.LoadScene(nextSceneIndex); //Loads the next scene
        }
        else{
            SceneManager.LoadScene("SplashScreen"); //Load SplashScreen if there are no more scenes
        }
    }
}
