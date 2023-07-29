using PDollarGestureRecognizer;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.VersionControl;
using UnityEngine;

public class RandomLetter : MonoBehaviour
{
    char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    public char randomChar;

    private Rect TitleArea;
    private string message;

    public MainScript mainScript;

    Result gestureResult;

    // Start is called before the first frame update
    void Start()
    {
        randomChar = alpha[Random.Range(0, 26)];
        Debug.Log(randomChar);

        TitleArea = new Rect(150, 80, 620, 80);
    }

    void OnGUI()
    {
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
        myButtonStyle.fontSize = 50;

        GUI.Box(TitleArea, "Can You Draw " + randomChar + "?", myButtonStyle);

        GUI.Label(new Rect(10, Screen.height - 30, 500, 50), message);
    }
}
