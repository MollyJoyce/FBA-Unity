using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NavScript : MonoBehaviour
{

    public List<string> NewStuInfo = new List<string>();
    public List<List<string>> Students = new List<List<string>>();


    public List<string> YearOptions = new List<string>();

    public TMP_Dropdown DayDropdown;
    public TMP_Dropdown MonthDropdown;
    public TMP_Dropdown YearDropdown;


    private string InputName;
    private string InputGrade;
    private string InputSchool;

    public InputField NameInputField;
    public InputField GradeInputField;
    public InputField SchoolInputField;

    //https://forum.unity.com/threads/simple-drop-down-menu-script-for-gui.189139/

    public void Start()
    {
        NewStuInfo.Add("Name");
        NewStuInfo.Add("Grade");
        NewStuInfo.Add("School");
        NewStuInfo.Add("Day");
        NewStuInfo.Add("Month");
        NewStuInfo.Add("Year");

        AddDropdownOptions();

    }


    public void ReadNameInput(string Name)
    {
        InputName = Name;

        NewStuInfo.Insert(0, Name);
        NewStuInfo.RemoveAt(1);
        
    }

    public void ReadGradeInput(string Grade)
    {
        InputGrade = Grade;

        NewStuInfo.Insert(1, Grade);
        NewStuInfo.RemoveAt(2);

    }

    public void ReadSchoolInput(string School)
    {
        InputSchool = School;

        NewStuInfo.Insert(2, School);
        NewStuInfo.RemoveAt(3);

    }

    public void ReadDayInput(string Day)
    {
        Day = DayDropdown.options[DayDropdown.value].text;

        NewStuInfo.Insert(3, Day);
        NewStuInfo.RemoveAt(4);

    }

    public void ReadMonthInput(string Month)
    {
        Month = MonthDropdown.options[MonthDropdown.value].text;

        NewStuInfo.Insert(4, Month);
        NewStuInfo.RemoveAt(5);

    }

    public void ReadYearInput(string Year)
    {
        Year = YearDropdown.options[YearDropdown.value].text;

        NewStuInfo.Insert(5, Year);
        NewStuInfo.RemoveAt(6);

    }

    public void AddDropdownOptions()
    {

        YearOptions = new List<string>();

        string CurrYear = System.DateTime.Now.Year.ToString();

        int CurrYearCount;

        int.TryParse(CurrYear, out CurrYearCount);

        for (int i = 0; i < 20; i++)
        {
            int YearCount = CurrYearCount - i;

            string CurrYearString = YearCount.ToString();

            YearOptions.Add(CurrYearString);
        }

        YearDropdown.AddOptions(YearOptions);

    }
   public void AddNewStu()
    {
        NewStuInfo = new List<string>();

        Students.Add(NewStuInfo);

        Debug.Log(Students[0][0]);

    }

   

    public void NewStuNav()
    {
        SceneManager.LoadScene("New Student Page");
    }

}
