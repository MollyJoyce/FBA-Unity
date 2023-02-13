using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavScript : MonoBehaviour
{

    List<string> Students = new List<string>();
    List<string> NewStuInfo = new List<string>();

    private string InputName;
    //https://www.youtube.com/watch?v=guelZvubWFY

    public void ReadNameInput(string Name)
    {
        InputName = Name;
       // Debug.Log(Name);

        NewStuInfo.Add(Name);
       Debug.Log(NewStuInfo);

       // return Name;
    }

    public void NewStuNav()
    {
        SceneManager.LoadScene("New Student Page");
    }

}
