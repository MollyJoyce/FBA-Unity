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
    public int InfoCounter;

    public List<string> YearOptions = new List<string>();

    public TMP_Dropdown DayDropdown;
    public TMP_Dropdown MonthDropdown;
    public TMP_Dropdown YearDropdown;
    public TMP_Dropdown GradeDropdown;


    private string InputName;
    private string InputGrade;
    private string InputSchool;

    public InputField NameInputField;
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

        if (Name != "Name")
        {
            StuInfo.Insert(0 + StuAdd, Name);
            StuInfo.RemoveAt(1 + StuAdd);

            InfoCounter++;
        }
        
    }

    public void ReadSchoolInput(string School)
    {
        InputSchool = School;
        if (School != "School")
        {
            StuInfo.Insert(2 + StuAdd, School);
            StuInfo.RemoveAt(3 + StuAdd);

            InfoCounter++;
        }

    }

    public void ReadGradeInput(string Grade)
    {
        Grade = GradeDropdown.options[GradeDropdown.value].text;

        if (GradeDropdown.value != 0)
        {
            StuInfo.Insert(1 + StuAdd, Grade);
            StuInfo.RemoveAt(2 + StuAdd);

            InfoCounter++;
        }

    }

    public void ReadDayInput(string Day)
    {
        Day = DayDropdown.options[DayDropdown.value].text;

        if (DayDropdown.value != 0)
        {
            StuInfo.Insert(3 + StuAdd, Day);
            StuInfo.RemoveAt(4 + StuAdd);

            InfoCounter++;
        }

    }

    public void ReadMonthInput(string Month)
    {
        Month = MonthDropdown.options[MonthDropdown.value].text;

        if (MonthDropdown.value != 0)
        {
            StuInfo.Insert(4 + StuAdd, Month);
            StuInfo.RemoveAt(5 + StuAdd);

            InfoCounter++;
        }

    }

    public void ReadYearInput(string Year)
    {
        Year = YearDropdown.options[YearDropdown.value].text;

        if (YearDropdown.value != 0)
        {
            StuInfo.Insert(5 + StuAdd, Year);
            StuInfo.RemoveAt(6 + StuAdd);

            InfoCounter++;
        }
        
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


        if (InfoCounter >= 6)
        {
            StuInfo.Add("Name");
            StuInfo.Add("Grade");
            StuInfo.Add("School");
            StuInfo.Add("Day");
            StuInfo.Add("Month");
            StuInfo.Add("Year");

            DayDropdown.value = 0;
            MonthDropdown.value = 0;
            YearDropdown.value = 0;
            GradeDropdown.value = 0;

            NameInputField.text = "Name";
            SchoolInputField.text = "School";


            Debug.Log(StuInfo[0 + StuAdd]);

            StuNumber++;

            InfoCounter = 0;
        }

    }

    public void UndoLastStu()
    {
        for (int i = 0; i < 6; i++)
        {

            StuInfo.RemoveAt(-1 + StuNumber);
        }

        StuNumber--;

        StuAdd = StuNumber * 6;
    }
   

    public void NewStuNav()
    {
        SceneManager.LoadScene("New Student Page");
    }



}
