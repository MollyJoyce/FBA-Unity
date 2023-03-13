using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NewStuScript : MonoBehaviour
{

    public List<string> NewStuInfo = new List<string>();
    public List<List<string>> Students = new List<List<string>>();

    public int StuNumber = 0;
    public int Add;

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
        NewStuInfo.Add("Name");
        NewStuInfo.Add("Grade");
        NewStuInfo.Add("School");
        NewStuInfo.Add("Day");
        NewStuInfo.Add("Month");
        NewStuInfo.Add("Year");

        AddDropdownOptions();

    }

    public void Update()
    {
        Add = StuNumber * 6;
    }


    public void ReadNameInput(string Name)
    {
        InputName = Name;

        NewStuInfo.Insert(0 + Add, Name);
        NewStuInfo.RemoveAt(1 + Add);
        
    }

    public void ReadGradeInput(string Grade)
    {
        InputGrade = Grade;

        NewStuInfo.Insert(1 + Add, Grade);
        NewStuInfo.RemoveAt(2 + Add);

    }

    public void ReadSchoolInput(string School)
    {
        InputSchool = School;

        NewStuInfo.Insert(2 + Add, School);
        NewStuInfo.RemoveAt(3 + Add);

    }

    public void ReadDayInput(string Day)
    {
        Day = DayDropdown.options[DayDropdown.value].text;

        NewStuInfo.Insert(3 + Add, Day);
        NewStuInfo.RemoveAt(4 + Add);

    }

    public void ReadMonthInput(string Month)
    {
        Month = MonthDropdown.options[MonthDropdown.value].text;

        NewStuInfo.Insert(4 + Add, Month);
        NewStuInfo.RemoveAt(5 + Add);

    }

    public void ReadYearInput(string Year)
    {
        Year = YearDropdown.options[YearDropdown.value].text;

        NewStuInfo.Insert(5 + Add, Year);
        NewStuInfo.RemoveAt(6 + Add);
        
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

        

        Students.Add(NewStuInfo);
            
       // NewStuInfo.Clear();

        NewStuInfo.Add("Name");
        NewStuInfo.Add("Grade");
        NewStuInfo.Add("School");
        NewStuInfo.Add("Day");
        NewStuInfo.Add("Month");
        NewStuInfo.Add("Year");

        Debug.Log(Students[StuNumber][0 + Add]);

        StuNumber++;

    }

   

    public void NewStuNav()
    {
        SceneManager.LoadScene("New Student Page");
    }



}
