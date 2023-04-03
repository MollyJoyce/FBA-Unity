using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StuPageScript : MonoBehaviour
{


    public TextMeshProUGUI NameTxt;


    //public NewStuScript NewStuScript;
    public GameObject NewStuScript;


    public List<string> StuInfo = new List<string>();
    public List<string> StuNames = new List<string>();

    //public int StuAdd = NewStuScript.StuAdd;


    public TMP_Dropdown StuSelectDropdown;

    public void Start()
    {
        //StuInfo = NewStuScript.StuInfo;

        NameTxt.text = StuInfo[0];
    }


    public void Update()
    {
       // Add = NewStuScript.StuNumber * 6;
    }


    public void AddStuOptions()
    {
        //Students = NewStuScript.StuInfo;

        StuNames = new List<string>();


        for (int i = 0; i < StuInfo.Count; i++)
        {
            int StuPosition = 0 + (i * 6);

            StuNames.Add(StuInfo[StuPosition]);

        }

        StuSelectDropdown.AddOptions(StuNames);

    }
}
