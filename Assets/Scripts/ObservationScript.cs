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
    public int ABCCounter;
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

        int CurrChosen = BehaviorDropdown.value;

        if (BehaviorDropdown.value != 0)
        {
            Behaviors.Insert(0 + ObsAdd, Behavior);
            Behaviors.RemoveAt(1 + ObsAdd);

            ABCCounter++;
        } else
        {
            BehaviorDropdown.value = CurrChosen;
        }
    }

    public void ReadIntensityInput(string Intensity)
    {
        Intensity = IntensityDropdown.options[IntensityDropdown.value].text;

        int CurrChosen = IntensityDropdown.value;

        if (IntensityDropdown.value != 0)
        {
            Behaviors.Insert(1 + ObsAdd, Intensity);
            Behaviors.RemoveAt(2 + ObsAdd);

            ABCCounter++;
        }
        else
        {
            IntensityDropdown.value = CurrChosen;
        }
    }

    public void ReadAntecedentInput(string Antecedent)
    {
        Antecedent = AntecedentDropdown.options[AntecedentDropdown.value].text;

        int CurrChosen = AntecedentDropdown.value;

        if (AntecedentDropdown.value != 0)
        {
            Behaviors.Insert(2 + ObsAdd, Antecedent);
            Behaviors.RemoveAt(3 + ObsAdd);

            ABCCounter++;
        }
        else
        {
            AntecedentDropdown.value = CurrChosen;
        }
    }

    public void ReadConsequenceInput(string Consequence)
    {
        Consequence = ConsequenceDropdown.options[ConsequenceDropdown.value].text;

        int CurrChosen = ConsequenceDropdown.value;

        if (ConsequenceDropdown.value != 0)
        {
            Behaviors.Insert(3 + ObsAdd, Consequence);
            Behaviors.RemoveAt(4 + ObsAdd);

            ABCCounter++;
        }
        else
        {
            ConsequenceDropdown.value = CurrChosen;
        }
    }

    public void ReadReactionInput(string Reaction)
    {
        Reaction = ReactionDropdown.options[ReactionDropdown.value].text;

        int CurrChosen = ReactionDropdown.value;

        if (ReactionDropdown.value != 0)
        {
            Behaviors.Insert(4 + ObsAdd, Reaction);
            Behaviors.RemoveAt(5 + ObsAdd);

            ABCCounter++;
        }
        else
        {
            ReactionDropdown.value = CurrChosen;
        }
    }



    public void SubmitCurrBehavior()
    {
        // Behaviors = new List<string>();
        if (ABCCounter >= 5)
        {
            Behaviors.Add("Behavior");
            Behaviors.Add("Intensity");
            Behaviors.Add("Antecedent");
            Behaviors.Add("Consequence");
            Behaviors.Add("Reaction");

            BehaviorDropdown.value = 0;
            IntensityDropdown.value = 0;
            AntecedentDropdown.value = 0;
            ConsequenceDropdown.value = 0;
            ReactionDropdown.value = 0;


            ObsNum++;

            ObsAdd = ObsNum * 5;

            ABCCounter = 0;
        }

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
