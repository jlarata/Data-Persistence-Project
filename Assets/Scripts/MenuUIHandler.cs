using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//este me permite usar "Text"
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField]
    private string input;
    
    


    private void Start()
    {
        //InputField = GameObject.Find("NameInputField");
    
        //name = new name;
        //NamePick.Init();
        //NamePick.onColorChanged += NewColorSelected;        
    }

    public void StartNew()
    {
        
        SceneManager.LoadScene(1);
        
        
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

    public void ReadStringInput(string s)
    {
        input = s;
        GeneralMainManager.Instance.PlayerName = input;
        Debug.Log(input);
    }
}
