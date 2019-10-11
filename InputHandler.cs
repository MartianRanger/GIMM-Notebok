using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public static class InputHandler
{

    public static string processText(string inS)
    {
       return inS;
    }
    public static int getAverageChars(string inS)
    {
        string[] words = inS.Split(' ');
        int sum = 0;
        foreach (var word in words)
        {
            sum += word.Length;
        }
        return sum / words.Length;
    }
    public static double[] parseArray(string doubleString)
    {
        string[] mathString = doubleString.Split(' ');
        double[] arlet = new double[mathString.Length];

        int i = 0;
        foreach (var word in mathString)
        {
            arlet[i] = getNum(mathString[i]);
            i++;
        }
        return arlet;
    }
    
    public static double processText(double[] values, double percent)
    {
        /*Debug.Log("Before input handler: " + inS);
        //this.processedText = inS;
        this.processedText = InputHandler.processText(inS);*/

        double sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        double newValue = percent * (sum / values.Length);

        return newValue;
        //displayOutput();
    }

    public static double getNum(string iS)
    {
        try
        {
            double num = Double.Parse(iS);
            return num;
        }
        catch (FormatException e)
        {
            Debug.Log(e);
            return -1;
        }
    }

    public static bool isNum(string inS)
    {
        try
        {
            double num = Double.Parse(inS);
            return true;
        }
        catch (FormatException e)
        {
            Debug.Log(e);
            return false;
        }
    }
    public static bool betterIsNum(string inS)
    {
        if (Double.TryParse(inS, out double j))
            return true;
        else
            return false;

    }
}
