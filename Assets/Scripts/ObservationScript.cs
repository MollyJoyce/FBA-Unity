using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObservationScript : MonoBehaviour
{

    public List<string> Behaviors = new List<string>();


    public TMP_Dropdown BehaviorDropdown;
    public TMP_Dropdown IntensityDropdown;
    public TMP_Dropdown AntecedentDropdown;
    public TMP_Dropdown ConsequenceDropdown;
    public TMP_Dropdown ReactionDropdown;

    int ObsAdd;
    int ObsNum;

    public void Start()
    {
        Behaviors.Add("Behavior");
        Behaviors.Add("Intensity");
        Behaviors.Add("Antecedent");
        Behaviors.Add("Consequence");
        Behaviors.Add("Reaction");

        
    }


    public void ReadBehaviorInput(string Behavior)
    {
        Behavior = BehaviorDropdown.options[BehaviorDropdown.value].text;

        if (BehaviorDropdown.value != 0)
        {
            Behaviors.Insert(0 + ObsAdd, Behavior);
            Behaviors.RemoveAt(1 + ObsAdd);
        }
    }

    public void ReadIntensityInput(string Intensity)
    {
        Intensity = IntensityDropdown.options[IntensityDropdown.value].text;

        if (IntensityDropdown.value != 0)
        {
            Behaviors.Insert(1 + ObsAdd, Intensity);
            Behaviors.RemoveAt(2 + ObsAdd);
        }
    }

    public void ReadAntecedentInput(string Antecedent)
    {
        Antecedent = AntecedentDropdown.options[AntecedentDropdown.value].text;

        if (AntecedentDropdown.value != 0)
        {
            Behaviors.Insert(2 + ObsAdd, Antecedent);
            Behaviors.RemoveAt(3 + ObsAdd);
        }
    }

    public void ReadConsequenceInput(string Consequence)
    {
        Consequence = ConsequenceDropdown.options[ConsequenceDropdown.value].text;

        if (ConsequenceDropdown.value != 0)
        {
            Behaviors.Insert(3 + ObsAdd, Consequence);
            Behaviors.RemoveAt(4 + ObsAdd);
        }
    }

    public void ReadReactionInput(string Reaction)
    {
        Reaction = ReactionDropdown.options[ReactionDropdown.value].text;

        if (ReactionDropdown.value != 0)
        {
            Behaviors.Insert(4 + ObsAdd, Reaction);
            Behaviors.RemoveAt(5 + ObsAdd);
        }
    }



    public void SubmitCurrBehavior()
    {
       // Behaviors = new List<string>();

        Behaviors.Add("Behavior");
        Behaviors.Add("Intensity");
        Behaviors.Add("Antecedent");
        Behaviors.Add("Consequence");
        Behaviors.Add("Reaction");

        ObsNum++;

        ObsAdd = ObsNum * 5;

    }

    public void UndoLastObs()
    {
        for(int i = 0; i < 5; i++)
        {

            Behaviors.RemoveAt(-1 + ObsNum);
        }

        ObsNum--;

        ObsAdd = ObsNum * 5;
    }


}
