using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NewStuScript : MonoBehaviour
{

    public List<string> StuInfo = new List<string>();
    //public List<List<string>> Students = new List<List<string>>();

    public int StuNumber = 0;
    public int StuAdd;

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




    public void Start()
    {
        StuInfo.Add("Name");
        StuInfo.Add("Grade");
        StuInfo.Add("School");
        StuInfo.Add("Day");
        StuInfo.Add("Month");
        StuInfo.Add("Year");

        AddYearDropdownOptions();

    }

    public void Update()
    {
        StuAdd = StuNumber * 6;
    }


    public void ReadNameInput(string Name)
    {
        InputName = Name;

        StuInfo.Insert(0 + StuAdd, Name);
        StuInfo.RemoveAt(1 + StuAdd);
        
    }

    public void ReadGradeInput(string Grade)
    {
        InputGrade = Grade;

        StuInfo.Insert(1 + StuAdd, Grade);
        StuInfo.RemoveAt(2 + StuAdd);

    }

    public void ReadSchoolInput(string School)
    {
        InputSchool = School;

        StuInfo.Insert(2 + StuAdd, School);
        StuInfo.RemoveAt(3 + StuAdd);

    }

    public void ReadDayInput(string Day)
    {
        Day = DayDropdown.options[DayDropdown.value].text;

        StuInfo.Insert(3 + StuAdd, Day);
        StuInfo.RemoveAt(4 + StuAdd);

    }

    public void ReadMonthInput(string Month)
    {
        Month = MonthDropdown.options[MonthDropdown.value].text;

        StuInfo.Insert(4 + StuAdd, Month);
        StuInfo.RemoveAt(5 + StuAdd);

    }

    public void ReadYearInput(string Year)
    {
        Year = YearDropdown.options[YearDropdown.value].text;

        StuInfo.Insert(5 + StuAdd, Year);
        StuInfo.RemoveAt(6 + StuAdd);
        
    }

    public void AddYearDropdownOptions()
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

        

        //Students.Add(StuInfo);

        // NewStuInfo.Clear();

        StuInfo.Add("Name");
        StuInfo.Add("Grade");
        StuInfo.Add("School");
        StuInfo.Add("Day");
        StuInfo.Add("Month");
        StuInfo.Add("Year");

        Debug.Log(StuInfo[0 + StuAdd]);

        StuNumber++;

    }

   

    public void NewStuNav()
    {
        SceneManager.LoadScene("New Student Page");
    }



}
