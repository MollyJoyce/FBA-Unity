using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavScript : MonoBehaviour
{

   public List<string> Students = new List<string>();
   public List<string> NewStuInfo = new List<string>();

    private string InputName;
    private string InputGrade;
    private string InputSchool;

    public InputField NameInputField;
    public InputField GradeInputField;
    public InputField SchoolInputField;
    //https://www.youtube.com/watch?v=guelZvubWFY

    public void Start()
    {
        GradeInputField.DeactivateInputField();
        SchoolInputField.DeactivateInputField();
    }


    public void ReadNameInput(string Name)
    {
        InputName = Name;

        NewStuInfo.Add(Name);
        Debug.Log(InputName);

        NameInputField.DeactivateInputField();
        GradeInputField.ActivateInputField();
        
    }

    public void ReadGradeInput(string Grade)
    {
        InputGrade = Grade;

        NewStuInfo.Add(Grade);

        GradeInputField.DeactivateInputField();
        SchoolInputField.ActivateInputField();

    }

    public void ReadSchoolInput(string School)
    {
        InputSchool = School;

        NewStuInfo.Add(School);

    }


    public void SubmitNewStuName(string InputName)
    {
        // InputName = Name;

        Debug.Log(InputName);
        NewStuInfo.Add(InputName);

    }

    public void SubmitNewStuGrade(string InputGrade)
    {
        // InputName = Grade;

        NewStuInfo.Add(InputGrade);

    }

    public void SubmitNewStuSchool(string InputSchool)
    {
        // InputName = School;

        NewStuInfo.Add(InputSchool);

    }

    public void NewStuNav()
    {
        SceneManager.LoadScene("New Student Page");
    }

}
