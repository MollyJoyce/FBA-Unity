using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObservationScript : MonoBehaviour
{

    public List<string> CurrBehavior = new List<string>();
    public List<List<string>> Observations = new List<List<string>>();


    public TMP_Dropdown BehaviorDropdown;
    public TMP_Dropdown IntensityDropdown;
    public TMP_Dropdown AntecedentDropdown;
    public TMP_Dropdown ConsequenceDropdown;
    public TMP_Dropdown ReactionDropdown;



    public void Start()
    {
        CurrBehavior.Add("Behavior");
        CurrBehavior.Add("Intensity");
        CurrBehavior.Add("Antecedent");
        CurrBehavior.Add("Consequence");
        CurrBehavior.Add("Reaction");
    }

    public void ReadBehaviorInput(string Behavior)
    {
        Behavior = BehaviorDropdown.options[BehaviorDropdown.value].text;


        CurrBehavior.Insert(0, Behavior);
        CurrBehavior.RemoveAt(1);
    }

    public void ReadIntensityInput(string Intensity)
    {
        Intensity = IntensityDropdown.options[IntensityDropdown.value].text;


        CurrBehavior.Insert(1, Intensity);
        CurrBehavior.RemoveAt(2);
    }

    public void ReadAntecedentInput(string Antecedent)
    {
        Antecedent = AntecedentDropdown.options[AntecedentDropdown.value].text;


        CurrBehavior.Insert(2, Antecedent);
        CurrBehavior.RemoveAt(3);
    }

    public void ReadConsequenceInput(string Consequence)
    {
        Consequence = ConsequenceDropdown.options[ConsequenceDropdown.value].text;


        CurrBehavior.Insert(3, Consequence);
        CurrBehavior.RemoveAt(4);
    }

    public void ReadReactionInput(string Reaction)
    {
        Reaction = ReactionDropdown.options[ReactionDropdown.value].text;


        CurrBehavior.Insert(4, Reaction);
        CurrBehavior.RemoveAt(5);
    }



    public void SubmitCurrBehavior()
    {
        CurrBehavior = new List<string>();

        Observations.Add(CurrBehavior);

        Debug.Log(Observations[0]);
    }


}
