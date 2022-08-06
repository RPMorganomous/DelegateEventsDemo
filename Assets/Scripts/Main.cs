using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete;

    
    void Start()
    {
        onColorChange = UpdateColor; //onColorChange DELEGATE matches UpdateColor METHOD
        onColorChange(Color.green);
        
        onComplete = Task;
        onComplete += Task2;
        onComplete += Task3;

        onComplete -= Task2;

        if (onComplete != null)
        {
            onComplete();
        }
    }
    
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        //turn all cubes red
    }
    
    public void UpdateColor(Color newColor)
    {
        Debug.Log("Changing color to: " + newColor.ToString());
    }

    public void Task()
    {
        Debug.Log("Task Finished.");
    }

    public void Task2()
    {
        Debug.Log("Task2 Finished.");
    }

    public void Task3()
    {
        Debug.Log("Task3 Finished.");
    }
}
