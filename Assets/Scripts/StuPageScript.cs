using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StuPageScript : MonoBehaviour
{


    public TextMeshProUGUI NameTxt;

    public NewStuScript NewStuScript;

    public List<List<string>> Students = new List<List<string>>();

    public void Start()
    {
        Students = NewStuScript.Students;

        NameTxt.text = Students[0][0];
    }
}
