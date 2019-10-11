using UnityEngine;
using UnityEngine.UI;
using System;
public class UILogic : MonoBehaviour
{
    public Text text;
    public string processedText;
    public InputField input1;
    public InputField input2;
    public InputField input3;
    public InputField percent1;
    public InputField percent2;
    public InputField percent3;

    public double[] grades1;
    public double[] grades2;
    public double[] grades3;

    public double weight1;
    public double weight2;
    public double weight3;

    public double answer;
    public void getInput()
    {
        grades1 = InputHandler.parseArray(input1.text);
        grades2 = InputHandler.parseArray(input2.text);
        grades3 = InputHandler.parseArray(input3.text);

        weight1 = InputHandler.getNum(percent1.text);
        weight2 = InputHandler.getNum(percent2.text);
        weight3 = InputHandler.getNum(percent3.text);

        displayOutput();
    }
    public void displayOutput()
    {
        double grade1 = InputHandler.processText(grades1, weight1);
        double grade2 = InputHandler.processText(grades2, weight2);
        double grade3 = InputHandler.processText(grades3, weight3);
        double totalPercent = weight1 + weight2 + weight3;
        answer = (grade1 + grade2 + grade3) / totalPercent;
        /*Debug.Log(processedText);
        string typeOfInput = "none";
        if (InputHandler.betterIsNum(processedText))
        {
            typeOfInput = "number";
        }
        else
        {
            typeOfInput = "string";
        }*/
        text.text = answer.ToString();
        //text.text = InputHandler.getAverageChars(processedText).ToString();
    }
    /*public static double processText(double[] values, double percent)
    {
        /*Debug.Log("Before input handler: " + inS);
        //this.processedText = inS;
        this.processedText = InputHandler.processText(inS);

        double sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        double newValue = percent * (sum / values.Length);

        return newValue;
        //displayOutput();
    }*/

}
