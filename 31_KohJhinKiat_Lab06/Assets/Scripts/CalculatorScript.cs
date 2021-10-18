using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalculatorScript : MonoBehaviour
{
    public InputField InputAmount;
    public InputField InputValue;
    public float value;
    public Toggle KoreanWon;
    public Toggle TaiwanDollars;
    public Toggle ToggleMalaysianRM;
    public Toggle ToggleEuropeanEUR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calculate()
    {
        if(KoreanWon.isOn)
        {
            value = float.Parse(InputAmount.text) * 878.29f;
            InputValue.text = "$" + value;
        }
        else if (TaiwanDollars.isOn)
        {
            value = float.Parse(InputAmount.text) * 20.74f;
            InputValue.text = "$" + value;
        }
        else if (ToggleMalaysianRM.isOn)
        {
            value = float.Parse(InputAmount.text) * 3.08f;
            InputValue.text = "$" + value;
        }
        else if (ToggleEuropeanEUR.isOn)
        {
            value = float.Parse(InputAmount.text) * 0.64f;
            InputValue.text = "$" + value;
        }
    }

    public void clear()
    {
        SceneManager.LoadScene("GameScene");
    }

}
